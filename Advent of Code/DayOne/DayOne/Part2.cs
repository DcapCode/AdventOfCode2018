using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DayOne
{
    class Part2
    {
        public static void Run()
        {
            string[] changes = File.ReadAllLines("C:/Development/Advent of Code/DayOne/DayOne/input.txt");
            int result = 0;
            bool duplicate = false;
            HashSet<int> frequencies = new HashSet<int>();
            frequencies.Add(result);

            while (!duplicate)
            {
                foreach (var change in changes)
                {
                    result += Int32.Parse(change);
                    if (frequencies.Contains(result))
                    {
                        duplicate = true;
                        break;
                    }
                    frequencies.Add(result);
                }
            }
            Console.WriteLine(result);
        }
        
    }
}
