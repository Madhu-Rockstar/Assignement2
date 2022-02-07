using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Pattrenprogramme
    {
        static void Main()
        {
            pyramid(6);
        }
        public static void pyramid(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*"," ");
                }
                Console.WriteLine();
            }
        }
    }
}
