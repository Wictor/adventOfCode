namespace _2023.Solutions;

public class Day03
{
    public static string PartOne(string[] input)
    {
        Console.WriteLine(input.Length);
        Console.WriteLine(input[0].Length);
        var grid = new char[input.Length, input[0].Length];
        
        for (int i = 0; i < input.Length - 1; i++)
        {
            for (int j = 0; i < input[i].Length - 1; j++)
            {
                
                Console.WriteLine(i);
                Console.WriteLine(j);
                grid[i, j] = input[i][j];
            }
        }

        return grid[1, 2].ToString();
    }

    public static string PartTwo(string[] input)
    {
        
        return "hej";
    }
}