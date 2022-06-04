using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblems
{
    internal class PrimeNumber
    {
        public void PrimeNo()
        {
            int num, i, m = 0;
            bool flag = true;
            Console.WriteLine("Enter the Number to check Prime:\n ");
            Console.WriteLine("------------------------------------");
            num = Convert.ToInt32(Console.ReadLine());
            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.Write("Number is Prime Number.\n");
            else
                Console.Write("Number is Not Prime Number.\n");
        }
    }
}
