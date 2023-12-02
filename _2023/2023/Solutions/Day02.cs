namespace _2023.Solutions;

public class Day02
{
    public static string PartOne(string[] input)
    {
        var sumOfGameId = 0;
        int maxBlue = 14, maxGreen = 13, maxRed = 12;
        
        foreach (var game in input)
        {
            var splitLine = game.Split(": ");
            var draws = splitLine[1].Split("; ");
            bool acceptedDraw = true;
            
            foreach (var pull in draws)
            {
                var colors = pull.Split(", ");
                
                foreach (var colorSet in colors)
                {
                    string[] parts = colorSet.Split(' ');
                    int amount = int.Parse(parts[0]);
                    string color = parts[1];
                    
                    if (color == "blue" && amount > maxBlue)
                    {
                        acceptedDraw = false;
                        continue;
                    }
                    if (color == "green" && amount > maxGreen)
                    {
                        acceptedDraw = false;
                        continue;
                    }
                    if (color == "red" && amount > maxRed)
                    {
                        acceptedDraw = false;
                        continue;
                    }
                }
            }
            
            if (acceptedDraw)
            {
                var gameId = splitLine[0].Split(' ');
                Console.WriteLine(gameId[1]);
                sumOfGameId += Int32.Parse(gameId[1]);
            }
        }
        
        return sumOfGameId.ToString();
    }

    public static string PartTwo(string[] input)
    {
        var sum = 0;
        foreach (var game in input)
        {
            var splitLine = game.Split(": ");
            var draws = splitLine[1].Split("; ");

            var needBlue = 0;
            var needGreen = 0;
            var needRed = 0;
            
            foreach (var pull in draws)
            {
                var colors = pull.Split(", ");

                foreach (var colorSet in colors)
                {
                    string[] parts = colorSet.Split(' ');
                    int amount = int.Parse(parts[0]);
                    string color = parts[1];

                    if (color == "blue" && amount > needBlue)
                    {
                        needBlue = amount;
                        continue;
                    }

                    if (color == "green" && amount > needGreen)
                    {
                        needGreen = amount;
                        continue;
                    }

                    if (color == "red" && amount > needRed)
                    {
                        needRed = amount;
                        continue;
                    }

                }
            }
            sum += needBlue * needGreen * needRed;
        }
        
        return sum.ToString();
    }
}