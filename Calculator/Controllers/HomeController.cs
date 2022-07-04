using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OperationViewModel model)
        {
            switch(model.Type)
            {
                case OperationType.Addition:
                    model.Result = model.Number1 + model.Number2;
                    break;
                case OperationType.Subtraction:
                    model.Result = model.Number1 - model.Number2;
                    break;
                case OperationType.Multiplication:
                    model.Result = model.Number1 * model.Number2;
                    break;
                case OperationType.Division:
                    if (model.Number2 == 0)
                    {
                        ModelState.AddModelError("Error", "Division by zero is not possible.");
                        return View(model);
                    }

                    model.Result = (double) model.Number1 / model.Number2;
                    break;
                default: return View(model);
            }

            return View(model);
        }
    }
}