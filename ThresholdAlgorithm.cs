using System;
using GranPrix;
using Distance;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ThresholdAlgorithm
{
    public class Threshold
    {
        public StageList stageList;
        public GranPrixSchedule currentSchedule;
        private int count;

        public Threshold(StageList stageList)
        {
            this.stageList = stageList;
        }

        public void CalculateCost(GranPrixSchedule schedule)
        {
            float cost = 0;
            for (int i = 1; i < schedule.Schedule.Length; i++)
            {
                cost += stageList.GetDistanceToStage(schedule.Schedule[i - 1], schedule.Schedule[i]);
            }
            schedule.Cost = cost;
        }

        public GranPrixSchedule GenerateInitialSolution()
        {
            // Create a new GranPrixSchedule object.
            GranPrixSchedule schedule = new GranPrixSchedule(stageList.StageListCount());

            // Create a list of all the stages.
            List<Stage> stages = stageList.GetListOfStages();

            // Shuffle the list of stages.
            stages = stages.OrderBy(x => Random.Shared.Next()).ToList();

            // Add the stages to the schedule in the shuffled order.
            for (int i = 0; i < schedule.NumberOfGranPrix; i++)
            {
                schedule.Schedule[i] = stages[i];
            }

            return schedule;
        }

        public GranPrixSchedule Optimize(StageList stageList, float threshold)
        {
            // Initialize the current schedule.
            currentSchedule = GenerateInitialSolution();
            count = currentSchedule.NumberOfGranPrix;
            // Initialize the best schedule.
            GranPrixSchedule bestSchedule = (GranPrixSchedule)currentSchedule.Clone();
            CalculateCost(bestSchedule);

            int iterations = (int)Math.Pow(count, 3);
            int best = -1;
            for (int i = 0; i < iterations; i++)
            {
                var listOfStages = stageList.GetListOfStages().OrderBy(x => Random.Shared.Next(i)).ToList();
                int granPrixCount = 0;
                var firstStage = listOfStages.First();
                if (!firstStage.Visited)
                {
                    firstStage.Visited = true;
                    currentSchedule.Schedule[granPrixCount] = firstStage;
                    granPrixCount++;
                }
                // While there are still unvisited stages.
                while (listOfStages.Any(stage => !stage.Visited) && granPrixCount < count)
                {
                    // Get the current stage.
                    Stage currentStage = listOfStages.Where(x => !x.Visited).FirstOrDefault();
                    currentStage.Visited = true;
                    currentSchedule.Cost += stageList.GetDistanceToStage(currentSchedule.Schedule[granPrixCount - 1], currentStage);
                    currentSchedule.Schedule[granPrixCount] = currentStage;
                    granPrixCount++;
                }

                if (currentSchedule.Cost < bestSchedule.Cost)
                {
                    bestSchedule = (GranPrixSchedule)currentSchedule.Clone();
                    best = i;
                }
            }
            Console.WriteLine("Best iteration {0} from {1}", best, iterations);
            // Return the best schedule.
            return bestSchedule;
        }
    }
}