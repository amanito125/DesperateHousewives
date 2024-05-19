var collection = Console.ReadLine().Split().Select(int.Parse).ToList();
for (int index = 0; index < collection.Count; index++)
{
    int min = index;
    for (int curr = index + 1; curr < collection.Count; curr++)
    {
        if (collection[curr] < collection[min])
        {
            min = curr;
        }
    }
    int temp = collection[min];
    collection[min] = collection[index];
    collection[index] = temp;
}
Console.WriteLine(string.Join(" ", collection));