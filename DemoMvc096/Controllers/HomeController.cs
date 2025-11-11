using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc096.Models;

namespace DemoMvc096.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName, int yearOfBirth)
        {
            if (string.IsNullOrEmpty(userName))
            {
                ViewBag.Message = "Vui lòng nhập tên của bạn!";
                return View();
            }

            int currentYear = DateTime.Now.Year;
            int age = 0;

            if (yearOfBirth > 1900 && yearOfBirth <= currentYear)
            {
                age = currentYear - yearOfBirth;
                ViewBag.Message = $"Xin chào {userName}, bạn năm nay {age} tuổi.";
            }
            else
            {
                ViewBag.Message = "Năm sinh không hợp lệ!";
            }

            return View();
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
}
