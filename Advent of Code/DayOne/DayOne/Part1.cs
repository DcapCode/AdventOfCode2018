using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DayOne
{
    class Part1
    {
        public static void Run()
        {
            Console.WriteLine("Part 1");
            string[] changes = File.ReadAllLines("C:/Development/Advent of Code/DayOne/DayOne/input.txt");
            List<int> frequencies = new List<int>();
            foreach (string change in changes)
            {
                var numbers = Int32.Parse(change);
                frequencies.Add(numbers);
            }
            int result = frequencies.Sum();
            Console.WriteLine(result);
        }
    }
}
