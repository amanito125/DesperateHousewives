using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStuff
{
    internal class BankAccount
    {
        private int id;


        public int Id

        {

            get { return id; }

            set { id = value; }

        }

        private decimal balance;


        public decimal Balance

        {

            get { return balance; }

            set { balance = value; }

        }


        public BankAccount(int id, decimal balance)

        {

            Id = id;

            Balance = balance;


        }

        public void Deposit(decimal amount)

        {

            if (amount < 0)

            {

                Console.WriteLine("Amount must be positive number!");


            }

            else

            {

                Balance += amount;

            }

        }

        public void Withdraw(decimal amount)

        {

            if (Balance - amount >= 0)

            {

                Balance -= amount;

            }

            else

            {

                Console.WriteLine("Insufficient balance");

            }

        }

        public override string ToString()

        {

            return $"Account {Id}, balance {Balance}";

        }
    }
}
