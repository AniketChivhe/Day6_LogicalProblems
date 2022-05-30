using System;

namespace Day6_LogicalProblems
{
    class Program
    {        
        public static void Main(string[] args)
        {
            FibonacciSeries series = new FibonacciSeries();
            series.Fibonacci();


            PerfectNumber perfectNumber = new PerfectNumber();
            perfectNumber.PerfectNum();

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.PrimeNo();

            ReverseNumber reverseNumber = new ReverseNumber();
            reverseNumber.ReverseNum();

            CouponNumbers couponNumbers = new CouponNumbers();
            couponNumbers.CalcCoupon();

            StopWatch stopWatch = new StopWatch();
            stopWatch.Stopwatch();

            DaysOfWeek daysOfWeek = new DaysOfWeek();
            daysOfWeek.ReadInput();
        }
    }
}