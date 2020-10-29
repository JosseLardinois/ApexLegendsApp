using System;
using System.Collections.Generic;
using System.Text;
using ApexLogic.Models;

namespace ApexLogic
{
    public class CalculatorLogic
    {
        public CalculatorModel Calculate(CalculatorModel calculator)
        {
            if (calculator.CurrentLevel < 21)
            {
                calculator.CurrentPack = calculator.CurrentPack + (calculator.CurrentLevel - 1);
                int seizoenPacks = calculator.PlayedSeasons * 5;
                int BattlepassPacks = calculator.Battlepass * 12;
                calculator.CurrentPack = calculator.CurrentPack + seizoenPacks + BattlepassPacks + calculator.BoughtPacks;
                
            }

            else if (calculator.CurrentLevel > 21 && calculator.CurrentLevel < 301)
            {
                int CurrentLevelPack = calculator.CurrentLevel - 20;
                int PackCalculator2 = (calculator.CurrentLevel / 2);
                int CurrentLevelPack2 = PackCalculator2 + 19;
                int seizoenPacks = calculator.PlayedSeasons * 5;
                int BattlepassPacks = calculator.Battlepass * 12;
                calculator.CurrentPack = calculator.CurrentPack + seizoenPacks + BattlepassPacks + calculator.BoughtPacks + CurrentLevelPack2;


            }

            else if (calculator.CurrentLevel > 300 && calculator.CurrentLevel <= 500)
            {
                int CurrentLevelPack = calculator.CurrentLevel - 300;
                int PackCalculator2 = (CurrentLevelPack / 5);
                int CurrentLevelPack2 = PackCalculator2 + 159;
                int seizoenPacks = calculator.PlayedSeasons * 5;
                int BattlepassPacks = calculator.Battlepass * 12;
                calculator.CurrentPack = calculator.CurrentPack + seizoenPacks + BattlepassPacks + calculator.BoughtPacks + CurrentLevelPack2;

            }

            return calculator;
        }
        }
    }

