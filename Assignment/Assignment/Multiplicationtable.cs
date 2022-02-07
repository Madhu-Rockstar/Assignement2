using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Multiplicationtable
    {
        static void Main()
        {
            Console.WriteLine("Enter the table number:");
            int tableno = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(tableno+" X "+i+" = "+tableno*i);
                i++;
            }
        }
    }
}
