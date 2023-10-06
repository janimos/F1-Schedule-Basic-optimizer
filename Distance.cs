using System;
using System.Collections.Generic;
using GranPrix;

namespace Distance
{
    public class StageAdjacencyList
    {
        LinkedList<Tuple<Stage, float>>[] StageList;

        public StageAdjacencyList(int AmountOfStages){
            StageList = new LinkedList<Tuple<Stage, float>>[AmountOfStages];

        }

        public void addDistance(int startStage, Stage endStage, float distance){
            StageList[startStage].AddLast(new Tuple<Stage, float>(endStage, distance));
        }
    }
}