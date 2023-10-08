using System;
using GranPrix;
using Distance;
using System.Collections.Generic;

namespace TestData
{
    public class Test
    {

        public void TestProgram()
        {
            StageList stages = new StageList();

            float[] incomeStage1 = { 1000, 750, 500 };
            Stage firstStage = new Stage("Sakhir", "Bahrein", incomeStage1);
            stages.AddStage(firstStage);

            float[] incomeStage2 = { 900, 1500, 1000 };
            Stage secondStage = new Stage("Jeddah", "Saudi Arabia", incomeStage2);
            stages.AddStage(secondStage);

            float[] incomeStage3 = { 500, 840, 900 };
            Stage thirdStage = new Stage("Melbourne", "Australia", incomeStage3);
            stages.AddStage(thirdStage);

            stages.AddDistance(firstStage, secondStage, 200);
            stages.AddDistance(firstStage, thirdStage, 1000);
            stages.AddDistance(secondStage, thirdStage, 900);

            var adjacent = stages.GetDistancesForStage(firstStage);
            foreach (var st in adjacent){
                Console.WriteLine("{0}, {1}, {2}", st.Item1.Name, st.Item1.Visited.ToString(), st.Item2);
            }
            firstStage.Visited = true;
            Console.WriteLine("");
            adjacent = stages.GetDistancesForStage(secondStage);
            foreach (var st in adjacent){
                Console.WriteLine("{0}, {1}, {2}", st.Item1.Name, st.Item1.Visited.ToString(), st.Item2);
            }
        }

    }
}