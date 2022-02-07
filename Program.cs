using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter the celsious:");
            double celsious = double.Parse(Console.ReadLine());

            double kelvin = celsious + 273;
            double farenheit = (celsious * 18) / 10 + 32;

            Console.WriteLine($"the kevin degrees is {kelvin} and farrenheat is {farenheit}");
            
        }
    }
}
