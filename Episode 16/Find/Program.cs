var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
var mode = list.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
Console.WriteLine(mode);