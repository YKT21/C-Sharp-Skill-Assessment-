using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Task 5 Assessment 3 of 3           
            for (int i = 50; i > 24; i--)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}[3 & 5]");
                }
                else if (i % 3 == 00)
                {
                    Console.WriteLine($"{i} [3]");
                }
                else if (i % 5 == 00)
                {
                    Console.WriteLine($"{i} [5]");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
