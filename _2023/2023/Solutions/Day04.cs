namespace _2023.Solutions;

public class Day04
{
    public static string PartOne(string[] input)
    {
        var totalScore = 0;
        
        foreach (var row in input)
        {
            var titleAndGameSplit = row.Split(": ");
            var game = titleAndGameSplit[1].Split("| ");
            
            int[] myNumbers = game[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] drawnNumbers = game[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int[] matches = myNumbers.Intersect(drawnNumbers).ToArray();
            
            totalScore += (int)Math.Pow(2, matches.Length - 1);
        }
        
        return totalScore.ToString();
    }

    public static string PartTwo(string[] input)
    {
        var counter = 1;
        
        Dictionary<int, int[]> tickets = new Dictionary<int, int[]>();

        foreach (var row in input)
        {
            var titleAndGameSplit = row.Split(": ");
            var game = titleAndGameSplit[1].Split("| ");
            
            int[] myNumbers = game[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] drawnNumbers = game[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int[] newTickets = myNumbers.Intersect(drawnNumbers).ToArray();
            
            tickets.Add(counter, newTickets);
            
            counter++;
        }

        var totalCards = 0;
        Dictionary<int, int> ticketsRemaining = new Dictionary<int, int> {{1, 1}}; // Key, Amount

        while (ticketsRemaining.Count > 0)
        {
            foreach (var currentTicket in ticketsRemaining.ToList())
            {
                for (int i = 0; i <  currentTicket.Value; i++)
                {
                    foreach (var number in tickets[currentTicket.Key])
                    {
                        if (ticketsRemaining.TryGetValue(number, out var value))
                        {
                            ticketsRemaining[number] = value + 1;
                        }
                        else
                        {
                            ticketsRemaining.Add(number, 1);
                        }
                    }
                    
                    ticketsRemaining[currentTicket.Key]--;
                    totalCards++;
                }

                Console.WriteLine("Key: " + currentTicket.Key);
                ticketsRemaining.Remove(currentTicket.Key);
            }
        }
        
        return totalCards.ToString();
    }
}