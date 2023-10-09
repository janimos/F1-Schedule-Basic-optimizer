using System;
using System.Collections.Generic;

namespace GranPrix
{
    public class Stage: ICloneable
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
        public object Clone(){
            return MemberwiseClone();
        }
    }

    public class GranPrixSchedule: ICloneable
    {
        public int NumberOfGranPrix { get; set; }
        public Stage[] Schedule { get; set; }
        public float Income { get; set; }
        public float Cost { get; set; }
        float Profit { get; set; }

        public GranPrixSchedule(int granPrixCount)
        {
            NumberOfGranPrix = granPrixCount;
            Schedule = new Stage[NumberOfGranPrix];
            Income = 0;
            Cost = 0;
            Profit = 0;
        }

        void CalculateProfit()
        {
            Profit = Income - Cost;
        }

        public float GetProfit()
        {
            CalculateProfit();
            return Profit;
        }

        public object Clone(){
            var schedule = (GranPrixSchedule)MemberwiseClone();
            return schedule;
        }
    }
}