using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.day3
{
    public class Code
    {
        public static void PowerConsumption()
        {
            var path = "../../../day3/data.txt";
            var data = File.ReadLines(path);

            var test = new List<KeyValuePair<int, string>>();
            KeyValuePair<int,string> = new KeyValuePair<string,string>(dialedno, line);

            foreach (var lines in data)
            {
                for (int i = 0; i < lines.ToCharArray().Length; i++)
                {
                    test.Add(i, lines[i].ToString());
                }
            }
            
            Console.Write(test.Keys);
            
            /*
            // var firstRow = "";
            var secondRow = "";
            var thirdRow = "";
            var fourthRow = "";
            var fifthRow = "";            
            var sixthRow = "";
            var seventhRow = "";
            var eightRow = "";
            var ninethRow = "";
            var tenthRow = "";
            var elevnthRow = "";
            
            foreach (var eachRow in data)
            {
                firstRow += eachRow.Substring(0, 1);
                secondRow += eachRow.Substring(1, 1);
                thirdRow += eachRow.Substring(2, 1);
                fourthRow += eachRow.Substring(3, 1);
                fifthRow += eachRow.Substring(4, 1);
                sixthRow += eachRow.Substring(5, 1);
                seventhRow += eachRow.Substring(6, 1);
                eightRow += eachRow.Substring(7, 1);
                ninethRow += eachRow.Substring(8, 1);
                tenthRow += eachRow.Substring(9, 1);
                elevnthRow += eachRow.Substring(10, 1);
            }
            
            Console.WriteLine("First row: " + firstRow);
            Console.WriteLine("Second row: " + secondRow);
            Console.WriteLine("Third row: " + thirdRow);
            Console.WriteLine("Fourth row: " + fourthRow);
            Console.WriteLine("Fifth row: " + fifthRow);
            Console.WriteLine("Sixth row: " + sixthRow);
            Console.WriteLine("Seventh row: " + seventhRow);
            Console.WriteLine("Eighth row: " + eightRow);
            Console.WriteLine("Nineth row: " + ninethRow);
            Console.WriteLine("Tenth row: " + tenthRow);
            Console.WriteLine("Elevent row: " + elevnthRow);
            
            */
            /*
            var query = File.ReadLines(path).GroupBy(line => line.FirstOrDefault());
            var gamma = 0;
            var epsilon = 0;
            
            if (!String.IsNullOrEmpty(path))
            {
                foreach (var character in query)
                {
                    if (character.Key.ToString() == "1")
                    {
                        gamma = character.Count();
                    }
                    else
                    {
                        epsilon = character.Count();
                    }
                }
            }
            */
            
            // Console.Write($"Power consumption: " + gamma * epsilon);   
        }
    }
}