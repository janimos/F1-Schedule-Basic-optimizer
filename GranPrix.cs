using System;
using System.Collections.Generic;

namespace GranPrix
{

    public class Schedule
    {
        public int NumberGranPrix { get; set; }
        public float Income { get; set; }
        public float Cost { get; set; }

        float Profit { get; set; }

        void CalculateProfit()
        {
            Profit = Income - Cost;
        }

        public float GetProfit()
        {
            CalculateProfit();
            return Profit;
        }
    }
    public class Stage
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public bool Visited { get; set; }

        public float[] StageIncome { get; set; }

        public Stage(string name, string location, float[] income)
        {
            Name = name;
            Location = location;
            StageIncome = income;
            Visited = false;
        }
    }

}