using ApexLegendsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult PackCalculator(CalculatorModel calculator, string calculate)
        {
            if (calculate == "add")
            {
                if (calculator.CurrentLevel < 21)
                {
                    calculator.CurrentPack = calculator.CurrentPack + (calculator.CurrentLevel - 1);
                    int seizoenPacks = calculator.PlayedSeasons * 5;
                    int BattlepassPacks = calculator.Battlepass * 12;
                    calculator.CurrentPack = calculator.CurrentPack + seizoenPacks + BattlepassPacks + calculator.BoughtPacks;
                    return View(calculator);
                }

                else if (calculator.CurrentLevel > 21 && calculator.CurrentLevel < 301)
                {
                    int CurrentLevelPack = calculator.CurrentLevel - 20;
                    int PackCalculator2 = (calculator.CurrentLevel / 2);
                    int CurrentLevelPack2 = PackCalculator2 + 19;
                    int seizoenPacks = calculator.PlayedSeasons * 5;
                    int BattlepassPacks = calculator.Battlepass * 12;
                    calculator.CurrentPack = calculator.CurrentPack + seizoenPacks + BattlepassPacks + calculator.BoughtPacks + CurrentLevelPack2;
                    return View(calculator);


                }

                else if (calculator.CurrentLevel > 300 && calculator.CurrentLevel <= 500)
                {
                    int CurrentLevelPack = calculator.CurrentLevel - 300;
                    int PackCalculator2 = (CurrentLevelPack / 5);
                    int CurrentLevelPack2 = PackCalculator2 + 159;
                    int seizoenPacks = calculator.PlayedSeasons * 5;
                    int BattlepassPacks = calculator.Battlepass * 12;
                    calculator.CurrentPack = calculator.CurrentPack + seizoenPacks + BattlepassPacks + calculator.BoughtPacks + CurrentLevelPack2;
                    return View(calculator);

                }
            }
            else
            {
                return View(calculator);
            }
            return View(calculator);
        }
    }
}
