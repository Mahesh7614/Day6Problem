using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problem
{
    public class StopWatchProgram
    {
        public int s;

        public StopWatchProgram(int S)
        {
            s = S;
        }
        public static StopWatchProgram UserInputForStopWatch()
        {
            Console.WriteLine("Enter the Number for how many times to print the statement to get time elapsed for it : ");
            int st = Convert.ToInt32(Console.ReadLine());

            return new StopWatchProgram(st)
            {
                s = st
            };
        }
        public void CalculateStopWatchTime()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for ( int i = 0; i < s; i++)
            {
                Console.WriteLine("Hello Mahesh Waghmare");
            }
            stopWatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopWatch.Elapsed);
        }
    }
}
// StopWatch Program