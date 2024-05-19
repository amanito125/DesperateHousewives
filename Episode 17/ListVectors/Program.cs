using System.Numerics;

List<double> l = new List<double>();
for (int i = 0; i < 3; i++)
{
    var input = Console.ReadLine().Split(' ').Select(float.Parse).ToList();
    Vector3 v = new Vector3(input[0], input[1], input[2]);
    l.Add(v.Length());
}

Console.WriteLine(l.Min());
