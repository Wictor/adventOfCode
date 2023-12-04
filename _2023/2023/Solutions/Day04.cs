namespace _2023.Solutions;

public class Day04
{
    public static string PartOne(string[] input)
    {
        var score = 0;
        
        foreach (var row in input)
        {
            var titleAndGameSplit = row.Split(": ");
            var game = titleAndGameSplit[1].Split("| ");
            
            int[] myNumbers = game[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] drawnNumbers = game[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int[] matches = myNumbers.Intersect(drawnNumbers).ToArray();

            // Scorring
            switch (matches.Length)
            {
                case 1:
                    score++;
                    break;
                case > 1:
                    score += matches.Length * 2;
                    break;
                default:
                    break;
            }
        }
        
        return score.ToString();
    }

    public static string PartTwo(string[] input)
    {
        
        return "hej";
    }
}