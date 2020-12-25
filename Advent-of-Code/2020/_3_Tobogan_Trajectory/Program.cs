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
            map = File.ReadAllLines("input.txt");
            x = y = 0;

            int count = 0;

            while(Step())
            {
                count += IsTree() ? 1 : 0;
            }

            Console.WriteLine(count);
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

        static bool Step()
        {
            x += 3;
            y += 1;

            bool result = y < map.Length;
            if(result)
            {
                if(x >= map[y].Length) x -= map[y].Length;
            }

            return result;
        }
    }
}
