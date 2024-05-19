List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

int bestStart = 0;
int bestLength = 1;
int currentLength = 1;
int index = 0;
int first = nums[index];

for (int i = 1; i < nums.Count; i++)
{
    if (first == nums[i])
    {
        currentLength++;
        if (currentLength > bestLength)
        {
            bestLength = currentLength;
            bestStart = index;
        }
    }
    else
    {
        currentLength = 1;
        first = nums[i];
        index = i;
    }
}

for (int i = bestStart; i < bestStart + bestLength; i++)
{
    Console.Write($"{nums[i]} ");
}