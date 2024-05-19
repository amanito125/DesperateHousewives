var list = Console.ReadLine().Split().Select(int.Parse).ToList();
for (int j = 0; j <= list.Count - 2; j++)
{
    for (int i = 0; i <= list.Count - 2; i++)
    {
        if (list[i] > list[i + 1])
        {
            int temp = list[i];
            list[i] = list[i + 1];
            list[i + 1] = temp;
        }
    }
}
Console.WriteLine(string.Join(" ", list));