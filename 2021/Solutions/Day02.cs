using System;
using System.Linq;

namespace AdventOfCode._2021.Solutions
{
    public class Day02
    {
        public static string PartOne(string[] data)
        {
            var x = 0;
            var y = 0;

            for (int i = 0; i < data.Count(); i++)
            {
                var direction = data[i].Split(" ")[0];
                var speed = int.Parse(data[i].Split(" ")[1]);

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

            return (x * y).ToString();
        }

        public static string PartTwo(string[] data)
        {
            var horizontal = 0;
            var depth = 0;
            var aim = 0;

            for (int i = 0; i < data.Count(); i++)
            {
                var direction = data[i].Split(" ")[0];
                var speed = int.Parse(data[i].Split(" ")[1]);

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

            return (horizontal * depth).ToString();
        }
    }
}