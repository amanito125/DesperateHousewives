namespace ArrayListImplement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Pesho");

            list.Add("Gosho");

            list.Add("Tosho");

            Console.WriteLine(list.Length);

            Console.WriteLine(list.Capacity);

            Console.WriteLine(list.Get(2));

            list.Set(2, "Geri");

            Console.WriteLine(list.Get(2));

            list.RemoveAt(1);

            foreach (var item in list)

            {
                Console.WriteLine(item);
            }
        }
    }
}