using System;
using System.IO;
using System.Collections.Generic;

namespace _2_Password_Philosophy
{
    class Entry
    {
        int min;
        int max;
        char character;
        string password;

        public Entry(string data)
        {
            string[] tokens = data.Split('-', ' ', ':');
            min = int.Parse(tokens[0]);
            max = int.Parse(tokens[1]);
            character = char.Parse(tokens[2]);
            password = tokens[4];
        }

        public bool IsValid()
        {
            int count = password.Split(character).Length;
            return count >= min && count <= max;
        }
    }

    class Program
    {
        static void Main()
        {
            int validCount = 0;
            foreach(string line in File.ReadAllLines("input.txt"))
            {
                validCount += new Entry(line).IsValid() ? 1 : 0;
            }

            Console.WriteLine(validCount);
        }
    }
}
