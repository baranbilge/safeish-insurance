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
}
