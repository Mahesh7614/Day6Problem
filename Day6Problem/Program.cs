namespace Day6Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci Series
            var fb = UserInputForFibonacciSeries();
            FibonacciSeries series = new FibonacciSeries(fb.Number);
            series.CalculateFibonacciSeries();

            // Perfect Number
            var pf = UserInputForPerfectNumber();
            PerfectNumber perfect = new PerfectNumber(pf.pNumber);
            perfect.CheckPerfectNumber();

            // Prime Number
            var p = UserInputForPrimeNumber();
            PrimeNumber prime = new PrimeNumber(p.No);
            prime.CheckPrimeNumber();

            // Reverse Number
            var rev = UserInputForReverseNumber();
            ReverseNumber reverse = new ReverseNumber(rev.RN);
            reverse.CalculateReverseNumber();

            // StopWatch Problem
            StopWatchProgram watch = new StopWatchProgram();
            watch.CalculateStopWatchTime();


        }
        //Fibonacci Series
        public static FibonacciSeries UserInputForFibonacciSeries()
        {
            Console.WriteLine("Enter the Number of Elements : ");
            int num = Convert.ToInt32(Console.ReadLine());

            return new FibonacciSeries(num)
            {
                Number = num
            };
        }
        // Perfect NUmber
        public static PerfectNumber UserInputForPerfectNumber()
        {
            Console.WriteLine("Enter the Number to Check Number is Perfect or Not : ");
            int n = Convert.ToInt32(Console.ReadLine());

            return new PerfectNumber(n)
            {
                pNumber = n
            };
        }
        // Prime Number
        public static PrimeNumber UserInputForPrimeNumber()
        {
            Console.WriteLine("Enter the Number to Check Number is Prime or Not : ");
            int pn = Convert.ToInt32(Console.ReadLine());

            return new PrimeNumber(pn)
            {
                No = pn
            };
        }
        // Reverse Number
        public static ReverseNumber UserInputForReverseNumber()
        {
            Console.WriteLine("Enter the Number to Check Number is Prime or Not : ");
            int r = Convert.ToInt32(Console.ReadLine());

            return new ReverseNumber(r)
            {
                RN = r
            };
        }
    }
}