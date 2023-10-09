using System;
using GranPrix;
using Distance;
using System.Collections.Generic;
using System.Linq;

namespace ThresholdAlgorithm
{
    public class Threshold
    {
        public StageList stageList;
        public GranPrixSchedule currentSchedule;
        private int count;
        private int indexOfWeek;

        public Threshold(StageList stageList)
        {
            this.stageList = stageList;
            indexOfWeek = -1;
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

        public (float, int) CalculateIncome(Stage stage)
        {
            float income = 0;
            for (int i = 0; i < stage.StageIncome.Length; i++)
            {
                if (stage.StageIncome[i] > income && indexOfWeek < i)
                {
                    income = stage.StageIncome[i];
                    indexOfWeek = i;
                }
            }
            return (income, indexOfWeek);
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
                schedule.Income += stages[i].StageIncome[i];
                schedule.GranPrixWeek.Add(i);
            }

            CalculateCost(schedule);

            return schedule;
        }

        public GranPrixSchedule Optimize(StageList stageList, float threshold)
        {
            // Initialize the best schedule.
            GranPrixSchedule bestSchedule = GenerateInitialSolution();
            count = bestSchedule.NumberOfGranPrix;

            int iterations = (int)Math.Pow(count, 3);
            int best = -1;
            bool toBreak = false;
            for (int i = 0; i < iterations; i++)
            {
                currentSchedule = new GranPrixSchedule(stageList.StageListCount());
                indexOfWeek = -1;
                var listOfStages = stageList.GetListOfStages().OrderBy(x => Random.Shared.Next(i)).ToList();
                foreach (var s in listOfStages) s.Visited = false;
                int granPrixCount = 0;
                var firstStage = listOfStages.First();
                if (!firstStage.Visited)
                {
                    firstStage.Visited = true;
                    currentSchedule.Schedule[granPrixCount] = firstStage;
                    granPrixCount++;
                    var stageIncome = CalculateIncome(firstStage);
                    currentSchedule.GranPrixWeek.Add(stageIncome.Item2);
                    currentSchedule.Income += stageIncome.Item1;
                }
                // While there are still unvisited stages.
                while (listOfStages.Any(stage => !stage.Visited) && granPrixCount < count)
                {
                    // Get the current stage.
                    Stage currentStage = listOfStages.Where(x => !x.Visited).FirstOrDefault();
                    currentStage.Visited = true;

                    var stageIncome = CalculateIncome(currentStage);
                    if (((int)Constants.NumberOfWeeks - stageIncome.Item2) < (count - granPrixCount))
                    {
                        toBreak = true;
                        break;
                    }
                    else
                    {
                        currentSchedule.GranPrixWeek.Add(stageIncome.Item2);
                        currentSchedule.Income += stageIncome.Item1;
                    }

                    currentSchedule.Cost += stageList.GetDistanceToStage(currentSchedule.Schedule[granPrixCount - 1], currentStage);
                    currentSchedule.Schedule[granPrixCount] = currentStage;
                    granPrixCount++;
                }

                if (!toBreak)
                {
                    CalculateCost(currentSchedule);
                    if (currentSchedule.GetProfit() < bestSchedule.GetProfit())
                    {
                        bestSchedule = (GranPrixSchedule)currentSchedule.Clone();
                        best = i;
                    }
                }
            }
            Console.WriteLine("Best iteration {0} from {1}", best, iterations);
            // Return the best schedule.
            return bestSchedule;
        }
    }
}