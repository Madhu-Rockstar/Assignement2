using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Average
    {
        static void Main()
        {
            int i = 1;
            double ptotal = 0;
            double ntotal = 0;
            int pcount = 0;
            int ncount = 0;
            double ptavg = 0;
            double ntavg = 0;
            while (i <= 10)
            {
                Console.WriteLine($"Enter the {i} number:");
                double num = double.Parse(Console.ReadLine());
                
                if (num >= 0)
                {
                    pcount = pcount + 1;
                    ptotal = ptotal + num;
                    ptavg = ptotal / pcount;
                }
                else
                {
                    ncount = ncount + 1;
                    ntotal =  ntotal + num;
                    ntavg = ntotal / ncount;
                }
                     
                i++;
            }
            Console.WriteLine($"the positive average is {ptavg} and negative average in {ntavg}:");
        }
    }
}
