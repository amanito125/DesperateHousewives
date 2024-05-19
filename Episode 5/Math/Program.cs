namespace mathstuff
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()

    .Split()

    .Select(int.Parse)

    .ToList();

            string cmd = Console.ReadLine();

            while (!cmd.Equals("end"))

            {
                switch (cmd)

                {
                    case "add":

                        numbers = numbers.Select(n => n + 1).ToList();

                        break;

                    case "multiply":

                        numbers = numbers.Select(n => n * 2).ToList();

                        break;

                    case "subtract":

                        numbers = numbers.Select(n => n - 1).ToList();

                        break;

                    case "print":

                        Console.WriteLine(string.Join(" ", numbers));

                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}