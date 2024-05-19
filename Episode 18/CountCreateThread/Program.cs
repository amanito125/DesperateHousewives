namespace CountCreateThread
{
    internal class Program
    {
        static void Count(int n)
        {

            for (int i = n; i >= 0; i--)
            {

                Console.WriteLine(i);

            }

        }
        static void Main(string[] args)
        {
            Thread t = new Thread(() => Count(10));
            t.Start();
        }
    }
}
