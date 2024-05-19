namespace Listlenghtstuff
{
    internal class Program
    {
        public static Func<List<string>, int, List<string>> filterNamesByLength = (names, length) =>
        {
            return names.Where(n => n.Length <= length).ToList();
        };

        private static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(" ").ToList();

            var names1 = filterNamesByLength(names, length);

            Console.WriteLine(string.Join(" ", names1));
        }
    }
}