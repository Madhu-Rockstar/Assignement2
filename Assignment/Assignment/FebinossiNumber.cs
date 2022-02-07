using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FebinossiNumber
    {
        static void Main()
        {
            febinossi(1000);
        }
        
        public static void febinossi(int num)
        {
            
            int a = 0;
            int b = 1;
            int res = a + b;
            Console.Write(" "+a);
            Console.Write(" "+b);
            while (res<num)
            {
                
                Console.Write(" " + res);
                a = b;
                b = res;
                res = a + b;
            }
        }
    }
}
