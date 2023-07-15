using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n 1.Fibonacci Series\n 2.Perfect Number\n" +
                    " 3.Prime Number\n 4.Reverse Number\n 5.Stop Watch\n 6.Exit\n");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.CheckNumIsFibo();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.CheckPerfectNumber();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.CheckNumberIsPrime();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.PrintReverseNumber();
                        break;
                    case 5:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Run();
                        break;
                    case 6:
                        Coupon coupon = new Coupon();
                        coupon.GetCoupon();
                    case 7:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.PrintDayOfWeek();
                    case 6:
                        flag = false;
                        break;

                }
            }
        }
    }

}
    
