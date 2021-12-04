using System;
using System.IO;

namespace AdventOfCode._2021.Helper
{
    public class Runner
    {
        public static void PuzzleSelector(int day, int part)
        {
            string result;
            
            string path = $"../../../2021/Inputs/{day:00}.txt";

            switch (day)
            {
                case 01:
                    result = part == 1
                        ? Solutions.Day01.PartOne(File.ReadAllLines(path))
                        : Solutions.Day01.PartTwo(File.ReadAllLines(path));
                    break;
                case 02:
                    result = part == 1
                        ? Solutions.Day02.PartOne(File.ReadAllLines(path))
                        : Solutions.Day02.PartTwo(File.ReadAllLines(path));
                    break;
                case 03:
                    result = part == 1
                        ? Solutions.Day03.PartOne(File.ReadAllLines(path))
                        : Solutions.Day03.PartTwo(File.ReadAllLines(path));
                    break;
                default:
                    result = "not yet implemented";
                    break;
            }
                    
            Console.WriteLine(result);
        }
    }
}