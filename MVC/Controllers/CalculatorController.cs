using Microsoft.AspNetCore.Mvc;
using myMvcApp.Models;

namespace myMvcApp.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            switch (model.Operation)
            {
                case "+":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "-":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "*":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "/":
                    model.Result = model.Number2 != 0 ? model.Number1 / model.Number2 : null;
                    break;
            }

            return View(model);
        }
    }
}
