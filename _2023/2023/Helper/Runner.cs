namespace _2023.Helper
{
    public class Runner
    {
        public static void PuzzleSelector(int day, int part)
        {
            string result;
            
            string path = $"../../../Inputs/day{day:00}.txt";

            switch (day)
            {
                case 01:
                    result = part == 1
                        ? Solutions.Day01.PartOne(File.ReadAllLines(path))
                        : Solutions.Day01.PartTwo(File.ReadAllLines(path));
                    break;
                case 02:
                    result = part == 1
                        ? Solutions.Day02.PartOne(File.ReadAllLines(path))
                        : Solutions.Day02.PartTwo(File.ReadAllLines(path));
                    break;
                default:
                    result = "not yet implemented";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}