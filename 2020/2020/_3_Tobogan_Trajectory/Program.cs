using System;
using System.IO;

namespace _3_Tobogan_Trajectory
{
    class Program
    {
        static string[] map;
        static int x;
        static int y;

        static void Main(string[] args)
        {
            bool partTwo = true;

            map = File.ReadAllLines("input.txt");

            int result = 0;

            if(partTwo)
            {
                x = y = 0;
                int result1 = 0;
                while(Step(1, 1))
                {
                    result1 += IsTree() ? 1 : 0;
                }

                x = y = 0;
                int result2 = 0;
                while(Step(3, 1))
                {
                    result2 += IsTree() ? 1 : 0;
                }

                x = y = 0;
                int result3 = 0;
                while(Step(5, 1))
                {
                    result3 += IsTree() ? 1 : 0;
                }

                x = y = 0;
                int result4 = 0;
                while(Step(7, 1))
                {
                    result4 += IsTree() ? 1 : 0;
                }

                x = y = 0;
                int result5 = 0;
                while(Step(1, 2))
                {
                    result5 += IsTree() ? 1 : 0;
                }

                result = result1 * result2 * result3 * result4 * result5;
            }
            else
            {
                x = y = 0;
                while(Step(3, 1))
                {
                    result += IsTree() ? 1 : 0;
                }
            }
            
            Console.WriteLine(result);
        }

        static bool IsTree()
        {
            bool result = false;

            if(x < map[y].Length && y < map.Length)
            {
                result = map[y][x] == '#';
            }

            return result;
        }

        static bool Step(int stepX, int stepY)
        {
            x += stepX;
            y += stepY;

            bool result = y < map.Length;
            if(result)
            {
                if(x >= map[y].Length) x -= map[y].Length;
            }

            return result;
        }
    }
}
