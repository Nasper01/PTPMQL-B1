using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc096.Models;

namespace DemoMvc096.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // ViewResult - hiển thị View bình thường
    public IActionResult Index()
    {
        return View();
    }

    // RedirectResult - chuyển hướng đến một URL khác
    public IActionResult RedirectExample()
    {
        return Redirect("https://learn.microsoft.com/");
    }

    // RedirectToActionResult - chuyển hướng đến một Action khác trong cùng Controller
    public IActionResult RedirectToActionExample()
    {
        return RedirectToAction("Index");
    }

    // JsonResult - trả về dữ liệu JSON
    public IActionResult JsonExample()
    {
        var data = new { Name = "MVC Demo", Version = "1.0", Author = "the niem" };
        return Json(data);
    }

    // FileResult - trả về file ví dụ
    public IActionResult FileExample()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "example.txt");

        if (!System.IO.File.Exists(filePath))
        {
            System.IO.File.WriteAllText(filePath, "Đây là nội dung file ví dụ.");
        }

        var bytes = System.IO.File.ReadAllBytes(filePath);
        return File(bytes, "text/plain", "example.txt");
    }

    // StatusCodeResult - trả về mã trạng thái HTTP
    public IActionResult StatusCodeExample()
    {
        return StatusCode(404, "Trang không tồn tại (404 Not Found)");
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
