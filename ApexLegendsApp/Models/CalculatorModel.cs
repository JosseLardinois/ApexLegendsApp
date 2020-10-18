using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexLegendsApp.Models
{
    public class CalculatorModel
    {
        public int CurrentLevel { get; set; }
        public int Battlepass { get; set; }
        public int BoughtPacks { get; set; }
        public int PlayedSeasons { get; set; }
        public int CurrentPack { get; set; }
    }
}