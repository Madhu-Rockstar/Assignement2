using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Sumofprimes
    {
        static void Main()
        {
            
            sumofprimes(5, 1000);
        }
        public static void sumofprimes(int from, int to)
        {
            bool isPrime = true;
            for (int i = from; i <= to; i++)
            {
                for (int j = from; j <= to; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                
                if (isPrime)
                {
                    Console.WriteLine("  "+i);
                }
                isPrime = true;
            }
            
        }
    }
}

