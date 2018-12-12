using System;
using System.Collections.Generic;

namespace DayOne
{
    class Program
    {
        static int frequency = 0;
        static int[] vals = new Input().Values;
        static List<int> frequencies = new List<int>();
        static void Main(string[] args)
        {
            int totalFrequency = 0;
            bool totalFrequencyFound = false;
            int duplicateFrequency = 0;
            bool duplicateFrequencyFound = false;
            int count = 0;
            while (!duplicateFrequencyFound)
            {
                if (count > 0)
                {
                    totalFrequencyFound = true;
                }

                for (int i = 0; i < vals.Length; i++)
                {
                    frequency += vals[i];
                    if (!totalFrequencyFound)
                        totalFrequency = frequency;
                    if (!frequencies.Exists(f => f == frequency))
                    {
                        frequencies.Add(frequency);
                    }
                    else
                    {
                        duplicateFrequencyFound = true;
                        duplicateFrequency = frequency;
                        break;
                    }
                }
                count++;
            }
            Console.WriteLine($"Total frequency is : {totalFrequency}");
            Console.WriteLine($"Duplicate frequency is : {duplicateFrequency}");
        }
    }
}
