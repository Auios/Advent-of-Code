using System;
using System.Collections.Generic;
using System.IO;

namespace _1_Report_Repair
{
    class Program
    {
        static void Main()
        {
            List<int> values = new List<int>();

            foreach(string line in File.ReadAllLines("input.txt"))
            {
                values.Add(int.Parse(line));
            }

            bool found = false;
            for(int i = 0; i < values.Count && !found; i++)
            {
                for(int j = 0; j < values.Count && !found; j++)
                {
                    if(i == j) continue;

                    if(values[i] + values[j] == 2020)
                    {
                        found = true;
                        Console.WriteLine(values[i] * values[j]);
                    }
                }
            }
        }
    }
}
