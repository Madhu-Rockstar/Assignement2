using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Primenumber
    {
        static void Main()
        {
            isprime(2);
            isprime(5);
            isprime(9);
        }
        public static void isprime(int num)
        { 
        bool prime = true;
        for(int i = 2; i <num; i++)
        {
            if (num %i  == 0)
            {
                prime = false;   
            }
        }
        if (prime == true)
        {
            Console.WriteLine(num + " is a prime number");
        }
        else
        {
            Console.WriteLine(num +" is not a prime number");
        }
        }
    }
}
