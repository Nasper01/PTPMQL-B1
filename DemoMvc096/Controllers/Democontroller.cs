using Microsoft.AspNetCore.Mvc;

namespace DemoMvc096.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            // Gửi dữ liệu qua ViewData và ViewBag
            ViewData["Message1"] = "Đây là dữ liệu từ ViewData";
            ViewBag.Message2 = "Đây là dữ liệu từ ViewBag";

            // Gửi dữ liệu bằng TempData để dùng sau Redirect
            TempData["Message3"] = "Đây là dữ liệu từ TempData (sẽ còn sau Redirect)";

            return View();
        }

        public IActionResult ShowTempData()
        {
            // Nhận lại dữ liệu từ TempData
            string? message = TempData["Message3"] as string;
            ViewBag.TempMessage = message;

            return View();
        }

        // Action để test Redirect
        public IActionResult RedirectToTemp()
        {
            TempData["Message3"] = "TempData vẫn giữ được qua Redirect!";
            return RedirectToAction("ShowTempData");
        }
    }
}
