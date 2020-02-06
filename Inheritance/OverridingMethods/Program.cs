using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverridingMethods
{
    class Account
    {
        private string id;
        private decimal balance;

        public Account()
        {
            this.id = "";
            this.balance = 0.0m;
        }

        public Account(string id, decimal balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public void Deposit(decimal amt)
        {
            this.balance += amt;
        }

        public virtual void Withdraw(decimal amt)
        {
            this.balance -= amt;
        }

        public override string ToString()
        {
            return this.id + ":" + this.balance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                this.balance = value;
            }
        }
    }

    class CheckingAccount : Account
    {
        public decimal overdraft = -400;
        public CheckingAccount(string id, decimal balance)
            : base(id, balance)
        {
        }

        public override void Withdraw(decimal amt)
        {
            if ((base.Balance - amt) >= overdraft)
                base.Balance -= amt;
            else
                Console.WriteLine("Insufficient funds.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Account acct = new Account("1", 100);
            //Console.WriteLine(acct.ToString());
            //acct.Withdraw(20);
            //Console.WriteLine(acct.ToString());
            //acct.Deposit(10);
            //Console.WriteLine(acct.ToString());
            //Console.WriteLine("-------------");
            //CheckingAccount cacct = new CheckingAccount("2", 5000);
            //Console.WriteLine(cacct.ToString());
            //cacct.Withdraw(20);
            //Console.WriteLine(cacct.ToString());
            //cacct.Deposit(1000);
            //Console.WriteLine(cacct.ToString());

            CheckingAccount acct = new CheckingAccount("1", 1000);
            acct.Withdraw(1500);
            Console.WriteLine(acct.ToString());


            Console.ReadKey();
        }
    }
}
