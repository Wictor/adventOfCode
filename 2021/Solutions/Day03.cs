using System;
using System.Linq;

namespace AdventOfCode._2021.Solutions
{
    public class Day03
    {
        public static string PartOne(string[] data)
        {
            int gamma = 0;
            int epsilon = 0;
            
            for (var i = 0; i < data[0].Length; i++)
            {
                var ones = data.Count(s => s.Substring(i,1) == "1");
                var zeros = data.Count(s => s.Substring(i, 1) == "0");

                gamma = gamma * 2 + (ones > zeros ? 1 : 0);
                epsilon = epsilon * 2 + (ones < zeros ? 1 : 0);
            }
            
            return (gamma * epsilon).ToString();
        }

        public static string PartTwo(string[] data)
        {
            var o2Rating = IterateData(data, "1", "0");
            var co2Rating = IterateData(data, "0", "1");

            return (o2Rating * co2Rating).ToString();
        }
        
        private static int IterateData(string[] data, string primary, string secondary)
        {
            string[] rating = data;
            for (var i = 0; i < data[0].Length; i++)
            {
                var ones = rating.Count(s => s.Substring(i, 1) == "1");
                var zeros = rating.Count(s => s.Substring(i, 1) == "0");
                string mostCommonCharacter = ones >= zeros ? primary : secondary;
                
                rating = rating.Where(s => s.Substring(i, 1) == mostCommonCharacter).ToArray();

                if (rating.Length == 1)
                {
                    break;
                }
                
            }

            return Convert.ToInt32(rating[0], 2);
        }
    }
}