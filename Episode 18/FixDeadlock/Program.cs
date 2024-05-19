namespace FixDeadlock
{
    internal class Program
    {
        private static object brush = new object();
        private static object canvas = new object();

        public static void Artist1(int n)
        {
            lock (brush)
            {
                Thread.Sleep(1000);

                lock (canvas)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(new string('*', i));
                    }
                }
            }
        }
        public static void Artist2(int n)
        {
            lock (brush)
            {
                Thread.Sleep(1000);

                lock (canvas)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(new string('$', i));
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => Artist1(10));
            Thread t2 = new Thread(() => Artist2(10));
            t1.Start();
            t2.Start();
        }
    }
}
