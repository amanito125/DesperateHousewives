namespace BankStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount(1, 15);
            acc.Deposit(100);
            Console.WriteLine(acc);

            acc.Withdraw(200);
            Console.WriteLine(acc);
        }
    }
}
