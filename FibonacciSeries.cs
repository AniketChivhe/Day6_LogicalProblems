using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblems
{
    internal class FibonacciSeries
    {
        /// <summary>
        /// Fibonacci Series 0 and 1 are constant numbers
        /// </summary>
        public void Fibonacci()
        {
            int n1 = 0, n2 = 1;
            int n3, i, number;
            Console.WriteLine("---------***Fibonacci Series***-------------");

            Console.Write("Enter the number of elements: ");
            Console.WriteLine("-------------------------------");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
