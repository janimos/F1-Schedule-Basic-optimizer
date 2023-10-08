using System;
using System.Collections.Generic;
using GranPrix;

namespace Distance
{
    public class StageList
    {
        private Dictionary<Stage, List<Tuple<Stage, float>>> adjacencyList;

        public StageList()
        {
            adjacencyList = new Dictionary<Stage, List<Tuple<Stage, float>>>();
        }

        public void AddStage(Stage stage)
        {
            if (!adjacencyList.ContainsKey(stage))
            {
                adjacencyList[stage] = new List<Tuple<Stage, float>>();
            }
        }

        public void AddDistance(Stage stage1, Stage stage2, float distance)
        {
            adjacencyList[stage1].Add(new Tuple<Stage, float>(stage2, distance));
            adjacencyList[stage2].Add(new Tuple<Stage, float>(stage1, distance));
        }

        public List<Tuple<Stage, float>> GetDistancesForStage(Stage stage)
        {
            return adjacencyList[stage];
        }
    }
}