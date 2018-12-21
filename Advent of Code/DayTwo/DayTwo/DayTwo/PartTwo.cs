using System.IO;
using System.Linq;
namespace DayTwo
{
    class PartTwo
    {
        public static void Run()
        {
            string[] ids = File.ReadAllLines("C:/Development/Advent of Code/DayTwo/DayTwo/DayTwo/input.txt");
            var lines = ids;
            var test =
            (from i in Enumerable.Range(0, lines.Length)
                    from j in Enumerable.Range(i + 1, lines.Length - i - 1)
                    let line1 = lines[i]
                    let line2 = lines[j]
                    where Diff(line1, line2) == 1
                    select Common(line1, line2)
            ).Single();

            System.Console.WriteLine(test);
        }

        public static int Diff(string line1, string line2)
        {
            return line1.Zip(line2,
                (chA, chB) => chA == chB
            ).Count(x => x == false);
        }

        public static string Common(string line1, string line2)
        {
            return string.Join("", line1.Zip(line2, (chA, chB) => chA == chB ? chA.ToString() : ""));
        }
    }
}

