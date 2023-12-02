namespace _2023.Solutions
{
    class Day01
    {
        public static string PartOne(string[] input)
        {
            var sumValue = 0;
            
            foreach (var line in input)
            {
                var intLine = new string(line.Where(c => char.IsDigit(c)).ToArray());
                
                if (intLine.Length == 1)
                {
                    var value = intLine + intLine;
                    sumValue += int.Parse(value);
                }
                else
                {
                    var value = intLine[0].ToString() + intLine[intLine.Length -1].ToString();
                    sumValue += int.Parse(value);
                }
            }
            

            return sumValue.ToString();
        }

        public static string PartTwo(string[] input)
        {
            var index = 0;
            int sumValue = 0;
            
            foreach (var line in input)
            {

                var changedLine = LineReplacer(line);
                var intLine = new string(changedLine.Where(c => char.IsDigit(c)).ToArray());
                
                Console.WriteLine(intLine);
                if (intLine.Length == 1)
                {
                    var value = intLine + intLine;
                    sumValue += int.Parse(value);
                }
                else
                {
                    var value = intLine[0].ToString() + intLine[intLine.Length -1].ToString();
                    sumValue += int.Parse(value);
                }
            }
            
            return sumValue.ToString();
        }

        private static string LineReplacer(string line)
        {
            var numberWords = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
            };

            for (int i = 0; i < numberWords.Count; i++)
            {
                string word = numberWords.ElementAt(i).Key;
                int number = numberWords.ElementAt(i).Value;

                if (line.Contains(word))
                {
                    line = line.Insert(line.IndexOf(word, StringComparison.Ordinal) + word.Length - 1, word[word.Length - 1].ToString());
                    line = line.Insert(line.IndexOf(word, StringComparison.Ordinal), word[0].ToString());
                    line = line.Replace(word, number.ToString());
                }
            }

            return line;
        }
    }
}