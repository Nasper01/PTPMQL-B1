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
            else
            {
                double delta = model.B * model.B - 4 * model.A * model.C;

                if (delta < 0)
                {
                    model.Result = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    double x = -model.B / (2 * model.A);
                    model.Result = $"Phương trình có nghiệm kép: x₁ = x₂ = {x}";
                }
                else
                {
                    double x1 = (-model.B + Math.Sqrt(delta)) / (2 * model.A);
                    double x2 = (-model.B - Math.Sqrt(delta)) / (2 * model.A);
                    model.Result = $"Phương trình có 2 nghiệm phân biệt: x₁ = {x1}, x₂ = {x2}";
                }
            }

            return View(model);
        }
    }
}
