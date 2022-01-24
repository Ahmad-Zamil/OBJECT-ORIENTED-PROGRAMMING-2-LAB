﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    class OverdraftAccount : Account
    {
        private static int autoIncmnt = 0;
        public String id;
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal OverdraftAccount(string id, string name) : base("AZ4041", name)
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
            else Console.WriteLine("Amount must  be greater than 0!");
            return found;
        }

        public override bool Withdraw(double amount)
        {
            bool found = false;
            if (Balance - amount > Balance)
            {
                Balance = Balance - amount;
                found = true;
                Console.WriteLine("Withdraw Sucessfully! ");
            }
            else Console.WriteLine("Sorry! Your account is overdraft!");

            return found;
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("Showing Overdraft Account info...");
            Console.Write("ID: {0}", this.Id);
            base.ShowInfo();

            
        }
    }
}
