namespace TypesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray(); //2Т

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            List<int> sum5 = new List<int>();

            for (int i = 0; i < nums.Length; i++) //1Т
            {
                if (nums[i] % 2 == 0) //2Т
                {
                    evens.Add(nums[i]);
                }
                else
                {//1Т
                    odds.Add(nums[i]);
                }
                if (SumDigits(nums[i]) % 10 == 5)//2Т
                {
                    sum5.Add(nums[i]);
                }
            }
            Console.WriteLine(String.Join(", ", evens));
            Console.WriteLine(String.Join(", ", odds));
            Console.WriteLine(String.Join(", ", sum5));
        }
        public static int SumDigits(int number)
        {
            int sum = 0;

            while (number != 0) //2Т
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
