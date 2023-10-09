using System;
using System.Collections.Generic;
using System.Linq;
using GranPrix;

namespace Distance
{
    public class StageList
    {
        public Dictionary<Stage, List<Tuple<Stage, float>>> adjacencyList;

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
        public int StageListCount(){
            return adjacencyList.Count;
        }

        public List<Stage> GetListOfStages(){
            return adjacencyList.Keys.ToList();
        }

        public float GetDistanceToStage(Stage start, Stage end){
            return adjacencyList[start].Where(x => x.Item1.Equals(end)).ToList().Select(x => x.Item2).FirstOrDefault();
        }
    }
}