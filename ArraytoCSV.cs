using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Arraycsv
    {
        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "Hello";
            files[0, 1] = "hiii";
            files[0, 2] = "This ";
            files[0, 3] = "is";
            files[0, 4] = "Madhu";

            files[1, 0] = "Rockstar";
            files[1, 1] = "and";
            files[1, 2] = "1234";
            files[1, 3] = "Bangalore";
            files[1, 4] = "7675933139";

            StreamWriter sw = File.CreateText("OutputText.csv");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");
                }
                sw.Write("\n");
            }
            sw.Flush();
            sw.Close();
            Console.WriteLine("success the programme!");
        }
    }
}



