using ApexLegendsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using ApexLogic;
using LogicInterface;
using LogicLayerApex.Models;


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
            CalculatorLogic calculatorLogic = new CalculatorLogic();
            CalculatorDTO calculatorDto = new CalculatorDTO();
            calculatorDto.CurrentLevel = calculator.CurrentLevel;
            calculatorDto.Battlepass = calculator.Battlepass;
            calculatorDto.BoughtPacks = calculator.BoughtPacks;
            calculatorDto.PlayedSeasons = calculator.PlayedSeasons;
            calculatorDto.CurrentPack = calculator.CurrentPack;
            calculatorLogic.Calculate(calculator);

            return View(calculator);
        }

        
    }
}