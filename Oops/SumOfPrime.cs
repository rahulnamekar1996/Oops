using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class SumOfPrime
    {
       static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for(int i = 2; i*i  < num; i++)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
       /* static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumOfPrimes = 0;
            foreach (int i in arr)
            {
                if (!IsPrime(i))
                {
                    sumOfPrimes = sumOfPrimes + i;
                }
            }
            Console.WriteLine("Sum of prime in an array = " + sumOfPrimes);

        }*/
    }
}
