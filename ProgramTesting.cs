using System;
using Distance;
using ThresholdAlgorithm;

namespace ProgramTesting
{
    public class Testing
    {
        public void StartTesting(StageList stages){
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Threshold alg = new Threshold(stages);
            var sch = alg.Optimize(stages, 3);

            watch.Stop();

            foreach(var st in sch.Schedule){
                Console.WriteLine("{0}, {1}, {2}", st.Name, st.Visited.ToString(), st.Location);
            }
            foreach(var w in sch.GranPrixWeek){
                Console.WriteLine("Weeks: {0}", w.ToString());
            }
            Console.WriteLine("Profit: {0}", sch.GetProfit());
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

    }
}