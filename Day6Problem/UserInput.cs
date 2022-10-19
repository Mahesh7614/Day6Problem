using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Problem
{
    public class UserInput
    {
        //Fibonacci Series
        public void fibonacciSeriesProblem()
        {
            var fb = FibonacciSeries.UserInputForFibonacciSeries();
            FibonacciSeries series = new FibonacciSeries(fb.Number);
            series.CalculateFibonacciSeries();
        }
        // Perfect Number
        public void perfectNumberProblem()
        {
            var pf = PerfectNumber.UserInputForPerfectNumber();
            PerfectNumber perfect = new PerfectNumber(pf.pNumber);
            perfect.CheckPerfectNumber();
        }
        // Prime Number
        public void primeNumberProblem()
        {
            var p = PrimeNumber.UserInputForPrimeNumber();
            PrimeNumber prime = new PrimeNumber(p.No);
            prime.CheckPrimeNumber();
        }
        // Reverse Number
        public void reverseNumberProblem()
        {
            var rev = ReverseNumber.UserInputForReverseNumber();
            ReverseNumber reverse = new ReverseNumber(rev.RN);
            reverse.CalculateReverseNumber();
        }
        // Coupon Number
        public void couponNumberProblem()
        {
            CouponNumbers couponNumbers = new CouponNumbers();
            couponNumbers.CouponNumberBuilder();
        }
        // StopWatch Problem
        public void stopWatchProblem()
        {
            var stop = StopWatchProgram.UserInputForStopWatch();
            StopWatchProgram watch = new StopWatchProgram(stop.s);
            watch.CalculateStopWatchTime();
        }
    }
}
