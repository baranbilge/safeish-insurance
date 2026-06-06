using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Safeish.Data;
using Safeish.Models;

namespace Safeish.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly SafeishDbContext _context;

        public AdminController(SafeishDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var totalUsers = await _context.Users.CountAsync();
            var totalPackages = await _context.InsurancePackages.CountAsync();
            var pendingPolicies = await _context.UserPolicies.CountAsync(p => p.Status == "Görüşme bekleniyor");

            var activePoliciesCount = await _context.UserPolicies.CountAsync(p => p.Status == "Aktif");

            ViewBag.TotalUsers = totalUsers;
            ViewBag.TotalPackages = totalPackages;
            ViewBag.PendingPolicies = pendingPolicies;
            ViewBag.ActivePoliciesCount = activePoliciesCount;

            return View();
        }

        public async Task<IActionResult> Packages(string search, int? typeId)
        {
            var query = _context.InsurancePackages.Include(p => p.InsuranceType).AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Name.ToLower().Contains(search.ToLower()));
            }

            if (typeId.HasValue && typeId.Value > 0)
            {
                query = query.Where(p => p.InsuranceTypeId == typeId.Value);
            }

            var packages = await query.ToListAsync();
            ViewBag.InsuranceTypes = await _context.InsuranceTypes.ToListAsync();
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentTypeId = typeId;

            return View(packages);
        }

        public async Task<IActionResult> CreatePackage()
        {
            ViewBag.InsuranceTypeId = new SelectList(await _context.InsuranceTypes.ToListAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePackage(InsurancePackage package)
        {
            ModelState.Remove("InsuranceType");
            ModelState.Remove("Policies");
            if (ModelState.IsValid)
            {
                _context.Add(package);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Packages), new { typeId = package.InsuranceTypeId });
            }
            ViewBag.InsuranceTypeId = new SelectList(await _context.InsuranceTypes.ToListAsync(), "Id", "Name", package.InsuranceTypeId);
            return View(package);
        }

        public async Task<IActionResult> EditPackage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.InsurancePackages.FindAsync(id);
            if (package == null)
            {
                return NotFound();
            }
            ViewBag.InsuranceTypeId = new SelectList(await _context.InsuranceTypes.ToListAsync(), "Id", "Name", package.InsuranceTypeId);
            return View(package);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPackage(int id, InsurancePackage package)
        {
            if (id != package.Id)
            {
                return NotFound();
            }

            ModelState.Remove("InsuranceType");
            ModelState.Remove("Policies");
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(package);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsurancePackageExists(package.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Packages), new { typeId = package.InsuranceTypeId });
            }
            ViewBag.InsuranceTypeId = new SelectList(await _context.InsuranceTypes.ToListAsync(), "Id", "Name", package.InsuranceTypeId);
            return View(package);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePackage(int id)
        {
            var package = await _context.InsurancePackages.FindAsync(id);
            if (package != null)
            {
                _context.InsurancePackages.Remove(package);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Packages));
        }

        private bool InsurancePackageExists(int id)
        {
            return _context.InsurancePackages.Any(e => e.Id == id);
        }

        // 6. TEKLİF TALEPLERİ (POLICIES) LİSTELEME
        public async Task<IActionResult> Policies()
        {
            var policies = await _context.UserPolicies
                .Include(p => p.User)
                .Include(p => p.InsurancePackage)
                .Where(p => p.Status == "Görüşme bekleniyor")
                .OrderByDescending(p => p.Id)
                .ToListAsync();
            return View(policies);
        }

        [HttpPost]
        public async Task<IActionResult> ApprovePolicy(int id)
        {
            var policy = await _context.UserPolicies.FindAsync(id);
            if (policy != null && policy.Status == "Görüşme bekleniyor")
            {
                policy.Status = "Aktif";
                policy.IsActive = true;
                policy.StartDate = DateTime.UtcNow;
                policy.EndDate = new DateTime(2028, DateTime.UtcNow.Month, DateTime.UtcNow.Day, 0, 0, 0, DateTimeKind.Utc);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Policies));
        }

        [HttpPost]
        public async Task<IActionResult> RejectPolicy(int id)
        {
            var policy = await _context.UserPolicies.FindAsync(id);
            if (policy != null && policy.Status == "Görüşme bekleniyor")
            {
                policy.Status = "Reddedildi";
                policy.IsActive = false;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Policies));
        }

        // AKTİF SİGORTALAR LİSTELEME
        public async Task<IActionResult> ActivePolicies()
        {
            var policies = await _context.UserPolicies
                .Include(p => p.User)
                .Include(p => p.InsurancePackage)
                .Where(p => p.Status == "Aktif")
                .OrderByDescending(p => p.StartDate)
                .ToListAsync();
            return View(policies);
        }

        // 7. KULLANICILAR LİSTELEME
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.OrderByDescending(u => u.Id).ToListAsync();
            return View(users);
        }
    }
}
