using ApexLegendsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using ApexLogic;
using ApexLogic.Models;

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
            calculator = x.Calculate(calculator);
            return View(calculator);
        }
    }
}