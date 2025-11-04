using Microsoft.AspNetCore.Mvc;
using DemoMvc096.Models;

namespace DemoMvc096.Controllers
{
    public class DataController : Controller
    {
        // GET: /Data/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person model)
        {
            ViewBag.Message = $"Xin chào {model.Name}, bạn {model.Age} tuổi!";
            return View();
        }
    }
}
