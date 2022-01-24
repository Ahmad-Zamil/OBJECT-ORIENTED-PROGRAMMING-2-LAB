using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ac1 = new CurrentAccount("AZ4041", "Zamil");
            ac1.Deposit(15000);
            ac1.Withdraw(200);
            ac1.ShowInfo();
            Account ac2 = new CurrentAccount("AZ32565", "Zamil");
            ac2.Deposit(25000);
            ac2.Withdraw(500);
            ac2.ShowInfo();
            CurrentAccount.AddAccount(new OverdraftAccount("AZ4041", "Zamil"));
            CurrentAccount.AddAccount(new SavingsAccount("AZ4041", "Zamil"));
            CurrentAccount.ShowAccountInfo();

            SavingsAccount sa1 = new SavingsAccount("AZ4041", "Zamil");
            sa1.Deposit(5000);
            sa1.Withdraw(420);
            sa1.ShowInfo();
            CurrentAccount ca1 = new CurrentAccount("AZ4041", "Sabbir");
            ca1.Deposit(5000);
            ca1.Withdraw(860);
            ca1.ShowInfo();
            OverdraftAccount oc1 = new OverdraftAccount("AZ32565", "Sabbir");
            oc1.Deposit(12520);
            oc1.Withdraw(2100);
            oc1.ShowInfo();

            Console.ReadKey();

        }
    }
}
