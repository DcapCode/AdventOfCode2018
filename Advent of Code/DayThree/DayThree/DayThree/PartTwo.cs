using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DayThree
{
    class PartTwo
    {
        public static void Run()
        {
            var plots = File.ReadAllLines("C:/Development/Advent of Code/DayThree/DayThree/DayThree/input.txt");

            var grid = new Dictionary<int, Dictionary<int, int>>();
            int overlaps = 0;

            foreach (var plot in plots)
            {
                var area = plot.Split(" ");

                var areaCoords = area[2].Remove(area[2].Length - 1, 1).Split(',');
                var areaXCoords = int.Parse(areaCoords[0]);
                var areaYCoords = int.Parse(areaCoords[1]);

                var areaSize = area[3].Split("x");
                var areaXSize = int.Parse(areaSize[0]);
                var areaYSize = int.Parse(areaSize[1]);

                for (int x = areaXCoords; x < areaXCoords + areaXSize; x++)
                {
                    for (int y = areaYCoords; y < areaYCoords + areaYSize; ++y)
                    {
                        if (grid.TryGetValue(x, out var gridDictY))
                        {
                            if (gridDictY.TryGetValue(y, out var gridAtLocation))
                            {
                                if (gridAtLocation > 1)
                                {
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
