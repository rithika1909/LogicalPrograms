using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void CheckNumberIsPrime()
        {
            int count = 0;
            Console.WriteLine("Enter number");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (input % 1 == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a prime Number");
            }
        }
    }
}
