using System;
using System.Linq;

namespace AdventOfCode._2021.Solutions
{
    class Day01
    {
        public static string PartOne(string[] input)
        {
            console.log(input.Where(c => char.IsDigit(c)).ToArray()));
            
            foreach (var line in input)
            {
                var intLine = line.Where(c => char.IsDigit(c)).ToArray());
                console.log(intLine);
            }
            

            return "hello";
        }

        public static string PartTwo(string[] input)
        {
            var intInput = Array.ConvertAll(input, int.Parse);
            var increments = 0;
            
            for (var i = 0; i < intInput.Count() - 3; i++)
            {
                var firstSum = intInput[i] + intInput[i + 1] + intInput[i + 2];
                var secondSum = intInput[i + 1] + intInput[i + 2] + intInput[i + 3];
                
                increments = firstSum < secondSum ? increments + 1 : increments;
            }

            return increments.ToString();
        }
    }
}