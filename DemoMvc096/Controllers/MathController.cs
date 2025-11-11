using Microsoft.AspNetCore.Mvc;
using DemoMvc096.Models;

namespace DemoMvc096.Controllers
{
    public class MathController : Controller
    {
        // GET: hiển thị form nhập
        [HttpGet]
        public IActionResult GiaiPTB2()
        {
            return View();
        }

        // POST: xử lý khi người dùng nhập xong
        [HttpPost]
        public IActionResult GiaiPTB2(QuadraticEquation model)
        {
            if (model.A == 0)
            {
                if (model.B == 0)
                {
                    model.Result = model.C == 0 ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -model.C / model.B;
                    model.Result = $"Phương trình có 1 nghiệm: x = {x}";
                }
            }


            return View(model);
        }
    }
}
