using System;
using System.Collections.Generic;

namespace DayOne
{
    class Program
    {
        static int[] vals = new Input().Values;
        static void Main(string[] args)
        {
            int frequency = 0;
            
            foreach (int v in vals)
            {
                frequency += v;
            }

            Console.WriteLine($"The resulting frequency is : { frequency }");
        }
    }
}
