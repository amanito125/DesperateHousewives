namespace Basketballstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            string[] input = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            while (!input[0].Equals("END"))
            {
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], 0);
                }
                dict[input[0]] += int.Parse(input[1]);
                input = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
