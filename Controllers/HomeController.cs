using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Safeish.Data;
using Safeish.Models;

namespace Safeish.Controllers;

public class HomeController : Controller
{
    private readonly SafeishDbContext _context;

    public HomeController(SafeishDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var packages = await _context.InsurancePackages.Include(p => p.InsuranceType).ToListAsync();
        return View(packages);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IActionResult GetQuote(int packageId)
    {
        var viewModel = new Safeish.Models.ViewModels.GetQuoteViewModel { PackageId = packageId };
        // If user is logged in, prepopulate their info
        if (User.Identity.IsAuthenticated)
        {
            var userIdStr = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (int.TryParse(userIdStr, out int userId))
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    viewModel.FirstName = user.FirstName;
                    viewModel.LastName = user.LastName;
                    viewModel.Email = user.Email;
                }
            }
        }
        return View(viewModel);
    }

    [HttpPost]
    public IActionResult GetQuote(Safeish.Models.ViewModels.GetQuoteViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("GetQuoteConfirmation");
        }
        return View(model);
    }

    [HttpPost]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public async Task<IActionResult> RequestQuote([FromBody] Safeish.Models.ViewModels.QuoteRequestDto dto)
    {
        var userIdStr = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (int.TryParse(userIdStr, out int userId))
        {
            var policy = new UserPolicy
            {
                UserId = userId,
                PackageName = dto.PackageName,
                Status = "Görüşme bekleniyor",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddYears(1),
                IsActive = false
            };
            
            _context.UserPolicies.Add(policy);
            await _context.SaveChangesAsync();
            
            return Json(new { success = true, message = "Teklif talebiniz başarıyla alındı. Sigortalarım sekmesinden takip edebilirsiniz." });
        }
        return Json(new { success = false, message = "Lütfen giriş yapın." });
    }

    [HttpGet]
    public IActionResult GetQuoteConfirmation()
    {
        return View();
    }

    /*
    // -------------------------------------------------------------------------
    // YAPAY ZEKA (AI) FİNANSAL DANIŞMANLIK ENTEGRASYONU İÇİN ÖRNEK METOT
    // -------------------------------------------------------------------------
    // Bu metot, appsettings.json içerisine eklediğiniz "OpenAI:ApiKey" değerini 
    // kullanarak OpenAI API (veya benzeri) ile iletişim kurmanız için taslak 
    // olarak hazırlanmıştır. Gerekli kütüphaneleri (örn: OpenAI-DotNet veya HttpClient) 
    // projenize dahil ettikten sonra bu metodu aktif hale getirebilirsiniz.
    
    [HttpPost]
    public async Task<IActionResult> AskFinancialAdvisor([FromBody] string userMessage)
    {
        // 1. API Key'i Configuration üzerinden oku
        // (Bunun için HomeController constructor'ına IConfiguration inject etmeniz gerekir)
        // string apiKey = _configuration["OpenAI:ApiKey"];

        // 2. HTTP İsteği veya Kütüphane Ayarı
        // var client = new HttpClient();
        // client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        // 3. API'ye gönderilecek JSON Payload'ı hazırla
        // var requestBody = new {
        //     model = "gpt-4",
        //     messages = new[] {
        //         new { role = "system", content = "Sen profesyonel bir sigorta ve finans danışmanısın." },
        //         new { role = "user", content = userMessage }
        //     }
        // };

        // 4. API'den gelen yanıtı döndür
        // return Json(new { response = "Yapay Zeka Yanıtı Burada Olacak" });
        
        return Ok();
    }
    */
}
