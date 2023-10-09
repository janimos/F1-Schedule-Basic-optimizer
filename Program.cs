using System;
using TestData;
using ProgramTesting;
using System.Linq.Expressions;

namespace F1_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F1 Schedule optimization!\n");
            Testing x = new Testing();
            TestingData t = new TestingData();
            string c = "";
            while (c != "e")
            {
                Console.WriteLine("Select test example 1, 2, 3, 4 or e to exit: ");
                c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        x.StartTesting(t.Test1());
                        break;
                    case "2":
                        x.StartTesting(t.Test2());
                        break;
                    case "3":
                        x.StartTesting(t.Test3());
                        break;
                    case "4":
                        x.StartTesting(t.Test4());
                        break;
                    default:
                        break;
                }

            }


            //x.StartTesting();

            Console.WriteLine("\nProgram stopped!");
        }
    }
}
