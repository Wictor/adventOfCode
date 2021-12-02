using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.day2
{
    public class Code
    {
        public static void Part1Counter()
        {
            var lines = File.ReadAllLines("../../../day2/data.txt");

            var x = 0;
            var y = 0;

            for (int i = 0; i < lines.Count(); i++)
            {
                var direction = lines[i].Split(" ")[0];
                var speed = int.Parse(lines[i].Split(" ")[1]);

                switch (direction)
                {
                    case "forward":
                        x += speed;
                        break;
                    case "down":
                        y += speed;
                        break;
                    case "up":
                        y -= speed;
                        break;
                }
            }
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");
            Console.WriteLine("Position:" + x * y);
        }
        
        public static void Part2Counter()
        {
            var lines = File.ReadAllLines("../../../day2/data.txt");

            var horizontal = 0;
            var depth = 0;
            var aim = 0;

            for (int i = 0; i < lines.Count(); i++)
            {
                var direction = lines[i].Split(" ")[0];
                var speed = int.Parse(lines[i].Split(" ")[1]);

                switch (direction)
                {
                    case "forward":
                        horizontal += speed;
                        
                        depth += aim == 0 ? 0 : speed * aim; 
                        break;
                    case "down":
                        aim += speed;
                        break;
                    case "up":
                        aim -= speed;
                        break;
                }
            }
            Console.WriteLine($"horizontal: {horizontal}");
            Console.WriteLine($"depth: {depth}");
            Console.WriteLine($"aim: {aim}");

            Console.WriteLine("Position:" + horizontal * depth);
        }
    }
}