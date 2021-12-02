using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.day1
{
    public static class Code
    {
        public static void Part1Counter()
        {
            var lines = Array.ConvertAll(File.ReadAllLines("../../../day1/data.txt"), int.Parse);

            var increments = 0;
            
            for (var i = 1; i < lines.Count(); i++)
            {
                if (lines[i] > lines[i - 1])
                {
                    increments += 1;
                } 
            }

            Console.WriteLine(increments);
        }
        
        public static void threeDataCounter()
        {
            var lines = Array.ConvertAll(File.ReadAllLines("../../../day1/data.txt"), int.Parse);
            var increments = 0;
            
            for (var i = 0; i < lines.Count() - 3; i++)
            {
                var firstSum = lines[i] + lines[i + 1] + lines[i + 2];
                var secondSum = lines[i + 1] + lines[i + 2] + lines[i + 3];
                if (firstSum < secondSum)
                {
                    increments += 1;
                }
            }

            Console.WriteLine(increments);
        }
    }
}