namespace Delegatstuff
{
    internal class Program
    {
        private delegate void SumDelegate(double num1, double num2);

        public static void Sum(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine(result);
        }

        private static void Main(string[] args)
        {
            SumDelegate sumDel = new SumDelegate(Sum);
            sumDel(10, 5);
        }
    }
}