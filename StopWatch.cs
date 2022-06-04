using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblems
{
    internal class StopWatch
    {
        /// <summary>
        /// simulate stopwatch program
        /// </summary>
        public void Stopwatch()
        {

            //// start holds the stating time and stop holding ending time
            ///
            Console.WriteLine("Present Time :" + DateTime.Now.ToString("HH:mm:ss tt"));
            Console.WriteLine("----------------------------------");
            int start, stop;
            start = DateTime.Now.Second;
            Console.WriteLine("Timer started: please press enter to stop ");
            Console.ReadLine();
            stop = DateTime.Now.Second;
            Console.WriteLine("Elapsed time in seconds {0} ", stop - start);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("After Elapsed " + DateTime.Now.ToString("HH:mm:ss tt"));
        }
    }
}
