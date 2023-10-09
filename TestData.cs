using System;
using GranPrix;
using Distance;
using System.Collections.Generic;
using ThresholdAlgorithm;

namespace TestData
{
    public class Test
    {

        public void TestProgram()
        {
            StageList stages = new StageList();

            float[] incomeStage1 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f  };
            Stage firstStage = new Stage("Sakhir", "Bahrein", incomeStage1);
            stages.AddStage(firstStage);

            float[] incomeStage2 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage secondStage = new Stage("Jeddah", "Saudi Arabia", incomeStage2);
            stages.AddStage(secondStage);

            float[] incomeStage3 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage thirdStage = new Stage("Melbourne", "Australia", incomeStage3);
            stages.AddStage(thirdStage);

            stages.AddDistance(firstStage, secondStage, 200);
            stages.AddDistance(firstStage, thirdStage, 1000);
            stages.AddDistance(secondStage, thirdStage, 900);

            var adjacent = stages.GetDistancesForStage(firstStage);
            /*foreach (var st in adjacent){
                Console.WriteLine("{0}, {1}, {2}", st.Item1.Name, st.Item1.Visited.ToString(), st.Item2);
            }
            Console.WriteLine("");
            adjacent = stages.GetDistancesForStage(secondStage);
            foreach (var st in adjacent){
                Console.WriteLine("{0}, {1}, {2}", st.Item1.Name, st.Item1.Visited.ToString(), st.Item2);
            }*/

            Threshold alg = new Threshold(stages);
            var sch = alg.Optimize(stages, 1.0f);

            foreach(var st in sch.Schedule){
                Console.WriteLine("{0}, {1}, {2}", st.Name, st.Visited.ToString(), st.Location);
            }
            foreach(var w in sch.GranPrixWeek){
                Console.WriteLine("Weeks: {0}", w.ToString());
            }
            Console.WriteLine("Profit: {0}", sch.GetProfit());
        }

    }
}