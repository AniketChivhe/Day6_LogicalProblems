using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblems
{
    internal class ReverseNumber
    {
        public void ReverseNum()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter A Number To Check Reverse: ");
            Console.WriteLine("-----------------------------------------------");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number Is: " + reverse);
        }
    }
}
