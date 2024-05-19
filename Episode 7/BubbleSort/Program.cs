List<int> list = new List<int>() { 12, 8, 10, 2, 9, 6, 1 };
BubbleSort(list.ToArray());
void BubbleSort(int[] arr)
{
    int temp;
    for (int j = 0; j <= arr.Length - 2; j++)
    {
        for (int i = 0; i <= arr.Length - 2; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
    }
    Console.WriteLine(string.Join(' ', arr));
}