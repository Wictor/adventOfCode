using System;
using System.Linq;

namespace AdventOfCode._2021.Solutions
{
    class Day01
    {
        public static void PartOne(string[] input)
        {
            var intInput = Array.ConvertAll(input, int.Parse);
            var increments = 0;
            
            for (var i = 1; i < intInput.Count(); i++)
            {
                increments = intInput[i] > intInput[i - 1] ? increments + 1 : increments;
            }

            Console.WriteLine(increments);
        }

        public static void PartTwo(string[] input)
        {
            var intInput = Array.ConvertAll(input, int.Parse);
            var increments = 0;
            
            for (var i = 0; i < intInput.Count() - 3; i++)
            {
                var firstSum = intInput[i] + intInput[i + 1] + intInput[i + 2];
                var secondSum = intInput[i + 1] + intInput[i + 2] + intInput[i + 3];
                
                increments = firstSum < secondSum ? increments + 1 : increments;
            }

            Console.WriteLine(increments);
        }
    }
}