﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    class SavingsAccount : Account
    {
        private static int autoIncmnt = 0;
        public String id;
        public String Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal SavingsAccount(String id, string name) : base("AZ4041", name)
        {

        }

        public override bool Deposit(double amount)
        {
            bool found = false;
            if (0 < amount)
            {
                Balance = Balance + amount;
                found = true;
                Console.WriteLine("\nCongratulation! {0} balance sucessefully added to your account!", amount);
            }
            else
            {
                Console.WriteLine("Amount must  be greater than 0!");
            }
            return found;
        }

        public override bool Withdraw(double amount)
        {
            bool found = false;
            if (Balance >= amount && Balance > 0)
            {
                if (amount <= amount * 0.8 && amount > 0)
                {
                    Balance = Balance - amount; found = true;
                }
                else Console.WriteLine("Sorry! You can't withdraw amount!");
            }

            else Console.WriteLine("Balance nt available! ");
            return found;
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("Show The Savings Account info...");
            Console.Write("ID: {0}", this.Id);
            base.ShowInfo();
        }
    }
}
