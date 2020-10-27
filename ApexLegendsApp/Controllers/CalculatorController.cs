using ApexLegendsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApexLogic;

namespace ApexLegendsApp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult PackCalculator()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult PackCalculator(CalculatorModel calculator)
        {
            CalculatorLogic x = new CalculatorLogic();
            int Y = x.calculator(calculator);
            return View(calculator);

        }
    }
}
