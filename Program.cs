using System;

namespace Day6_LogicalProblems
{
    class Program
    {        
        public static void Main(string[] args)
        {
            Console.WriteLine("\n----Logical Pgrogramming Problems----");
            Console.WriteLine("\n1.Fibonacci Series \n2.Perfect Number \n3.Prime Number \n4.Reverse Number \n5.Coupon Number\n6.Stopwatch\n7.Exit\n");
            Console.WriteLine("\nEnter Your Option:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.Fibonacci();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.PerfectNum();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.PrimeNo();
                    break;
                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.ReverseNum();
                    break;
                case 5:
                    CouponNumbers couponNumbers = new CouponNumbers();
                    couponNumbers.CalcCoupon();
                    break;
                case 6:
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.Stopwatch();
                    break;
                case 7:
                    DaysOfWeek daysOfWeek = new DaysOfWeek();
                    daysOfWeek.ReadInput();
                    break;


            }
            


            

            

            

            

            

            
        }
    }
}