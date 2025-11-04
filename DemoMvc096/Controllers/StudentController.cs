using Microsoft.AspNetCore.Mvc;
using DemoMvc096.Models;

namespace DemoMvc096.Controllers
{
    public class StudentController : Controller
    {
        // GET: /Student/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Student/Index
        [HttpPost]
        public IActionResult Index(Student std)
        {
            // Gửi dữ liệu lại View để hiển thị
            ViewBag.Name = std.Name;
            ViewBag.Age = std.Age;
            ViewBag.ClassName = std.ClassName;

            return View();
        }
    }
}
