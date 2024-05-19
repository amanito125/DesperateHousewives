Console.WriteLine("Please enter 3x3 matrix");


double[,] m = new double[3, 3];

for (int i = 0; i < 3; i++)
{
    var j = 0;
    var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
    foreach (var n in numbers)
    {
        m[i, j] = n;
        j++;
    }
}

Console.WriteLine("Please enter a number");
var num = int.Parse(Console.ReadLine());
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        m[i, j] *= num;
        Console.Write(m[i, j] + " ");
    }
    Console.WriteLine();
}