using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblems
{
    internal class PerfectNumber
    {
        public void PerfectNum()
        {
            int  sum = 0, n;
            ///enter a Number 
            Console.Write("Enter the Number:\n");
            Console.WriteLine("-----------------------------------------------");
            int number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");

            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");

            }
        }
    }
}
