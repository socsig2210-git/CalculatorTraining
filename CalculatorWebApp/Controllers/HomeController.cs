using CalculatorWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculatorWebApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            switch (model.OperationType)
            {
                case OperationType.Addition:
                    model.Add();
                    break;
                case OperationType.Subtraction:
                    model.Subtract();
                    break;
                case OperationType.Multiplication:
                    model.Multiply();
                    break;
                case OperationType.Division:
                    model.Divide();
                    break;
            }

            return View(model);
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