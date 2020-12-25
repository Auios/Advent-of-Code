using System;
using System.Collections.Generic;
using System.IO;

namespace _1_Report_Repair
{
    class Program
    {
        static void Main()
        {
            bool partTwo = true;

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
                    if(partTwo)
                    {
                        for(int k = 0; k < values.Count && !found; k++)
                        {
                            if(i == j || j == k || k == i) continue;

                            if(values[i] + values[j] + values[k] == 2020)
                            {
                                found = true;
                                Console.WriteLine(values[i] * values[j] * values[k]);
                            }
                        }
                    }
                    else
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
}
