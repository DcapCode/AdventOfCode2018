using System;
using System.IO;
using System.Linq;

namespace DayTwo
{
    class Part1
    {
        public static void Run()
        {
            string[] ids = File.ReadAllLines("C:/Development/Advent of Code/DayTwo/DayTwo/DayTwo/input.txt");

            var doubleChar = 0;
            var trippleChar = 0;

            foreach (string id in ids)
            {
                var doubleCharCheck = CheckSequence(id, 2);
                var trippleCharCheck = CheckSequence(id, 3);

                if (doubleCharCheck)
                    doubleChar++;
                if (trippleCharCheck)
                    trippleChar++;
            }
            var checksum = doubleChar * trippleChar;
            Console.WriteLine("Checksum = " + doubleChar + " * " + trippleChar + " = " + checksum);
        }
        public static bool CheckSequence(string id, int seq)
        {
            return (from chars in id
                    group chars by chars into c
                    select c.Count()).Any(x => x == seq);
        }
    }
}
