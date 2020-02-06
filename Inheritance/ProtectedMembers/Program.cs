using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProtectedMembers
{
    class Account
    {
        protected string id;
        protected decimal balance;

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
            if ((this.balance - amt) >= overdraft)
                this.balance -= amt;
            else
                Console.WriteLine("Insufficient funds.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            CheckingAccount act = new CheckingAccount("1", 1000);
            act.Withdraw(2000);
            Console.WriteLine(act.ToString());
            Console.ReadKey();
        }
    }
}
