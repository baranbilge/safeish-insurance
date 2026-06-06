using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
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

    [Authorize]
    public IActionResult ChatBot()
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

    [HttpPost]
    public async Task<IActionResult> AskChatbot([FromBody] ChatRequest request)
    {
        if (string.IsNullOrWhiteSpace(request?.Message)) return BadRequest();

        var packages = await _context.InsurancePackages.Include(p => p.InsuranceType).ToListAsync();
        
        var packagesInfo = "Sitemizde sunulan güncel sigorta paketleri ve içerikleri şunlardır:\n";
        foreach (var pack in packages)
        {
            var typeName = pack.InsuranceType?.Name ?? "Bilinmeyen Tür";
            packagesInfo += $"- Paket: {pack.Name} ({typeName}). Teminat: {pack.CoverageAmount} TL. Özellikler: {pack.Features}\n";
        }
        packagesInfo += "\nMüşteriyle konuşurken ihtiyaçlarını analiz et ve yukarıdaki listelenen paketlerden müşteriye en uygun olanını önererek yönlendir.";

        var systemPrompt = "Sen Safeish sigorta platformunun resmi yapay zeka asistanısın. Senin görevin kullanıcılara kasko, trafik sigortası, DASK, sağlık sigortası ve poliçe detayları hakkında profesyonel bilgi vermektir. Sigortacılık, finans veya platformun kullanımı dışındaki hiçbir soruya yanıt vermeyeceksin. Farklı bir konu sorulduğunda nazikçe 'Ben bir sigorta asistanıyım, size sadece sigortacılık konularında yardımcı olabilirim' diyerek reddetmelisin.\n" +
            "ÖNEMLİ FORMAT KURALLARI: Yanıtlarını verirken mutlaka okunaklı ve özenli bir imla kullan. Uzun metinleri tek bir satıra sıkıştırma, paragraflara böl. Sigorta paketlerini veya özellikleri sayarken mutlaka alt alta maddeler halinde (tire veya madde işareti kullanarak) listele. Yazılar görsel açıdan düzenli, ferah ve profesyonel olmalı.\n\n" + packagesInfo;

        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? "YOUR_API_KEY_HERE";
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "system", content = systemPrompt },
                new { role = "user", content = request.Message }
            }
        };

        var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(requestBody), System.Text.Encoding.UTF8, "application/json");
        var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

        if (response.IsSuccessStatusCode)
        {
            var resultString = await response.Content.ReadAsStringAsync();
            using var document = System.Text.Json.JsonDocument.Parse(resultString);
            var reply = document.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
            return Json(new { reply = reply });
        }
        else
        {
            // If gpt-5 nano doesn't exist, we fallback to something safe or just return error message so UI knows.
            return Json(new { reply = "Üzgünüm, sistemsel bir hata oluştu veya bu model desteklenmiyor. (OpenAI yanıtı başarısız)" });
        }
    }
}

public class ChatRequest
{
    public string Message { get; set; }
}
