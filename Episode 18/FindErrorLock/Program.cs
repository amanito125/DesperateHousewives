namespace FindErrorLock
{
    internal class Program
    {
        private static object _lock1 = new object();
        private static object _lock2 = new object();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                lock (_lock1)
                {
                    Thread.Sleep(1000);
                    lock (_lock2)
                    {
                        Console.WriteLine("Finished thread 1");
                    }
                }
            });

            Thread t2 = new Thread(() =>
            {
                lock (_lock1)
                {
                    Thread.Sleep(1000);
                    lock (_lock2)
                    {
                        Console.WriteLine("Finished thread 2");
                    }
                }
            });

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
