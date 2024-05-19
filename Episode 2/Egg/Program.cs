namespace EggStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int eggs = int.Parse(Console.ReadLine());
            for (int i = 0; i < eggs; i++)
            {
                string color = Console.ReadLine();
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, 0);
                }
                dict[color]++;
            }

            Console.WriteLine($"Red eggs: {(dict.ContainsKey("red") ? dict["red"] : 0)}");
            Console.WriteLine($"Orange eggs: {(dict.ContainsKey("orange") ? dict["orange"] : 0)}");
            Console.WriteLine($"Blue eggs: {(dict.ContainsKey("blue") ? dict["blue"] : 0)}");
            Console.WriteLine($"Green eggs: {(dict.ContainsKey("green") ? dict["green"] : 0)}");
            Console.WriteLine($"Max eggs: {dict.Values.Max()} -> {dict.OrderByDescending(x => x.Value).FirstOrDefault().Key}");
        }
    }
}
