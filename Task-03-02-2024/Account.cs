﻿
namespace Task_03_02_2024
{
    internal class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string Name = "Unnamed Account", double Balance = 0.0)
        {
            this.Name = Name;
            this.Balance = Balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Balance: {Balance}";
        }

        public static Account operator +(Account lhs, Account rhs)
        {
            return new Account(lhs.Name + " " + rhs.Name, lhs.Balance + rhs.Balance);
        }
    }
}
