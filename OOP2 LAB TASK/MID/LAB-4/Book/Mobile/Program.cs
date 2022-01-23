using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class mobile
    {
        private string mobileOwnerName;
        private string mobileNumber;
        private string mobileBalance;
        private string mobileOSName;
        bool Lock;

        public string MOBILEOWNERNAME { set; get; }
        public string MOBILENUMBER { set; get; }
        public string MOBILEBALANCE { set; get; }
        public string MOBILEOSNAME { set; get; }
        public bool LOCK { set; get; }

        public mobile()
        {
            Console.WriteLine("empty");
        }

        public mobile(string mobileOwnerName, string mobileNumber, string mobileBalance, string mobileOSName, bool Lock)
        {
            this.mobileOwnerName = mobileOwnerName;
            this.mobileNumber = mobileNumber;
            this.MOBILEBALANCE = mobileBalance;
            this.mobileOSName = mobileOSName;
            this.Lock = Lock;
        }
        public void showInfo()
        {
            Console.WriteLine("Mobile_owner_name:{0} \n Mobile_Number:{1} \n Mobile_Balance:{2} \n Mobile_OS_Name:{3}", mobileOwnerName, mobileNumber, mobileBalance, mobileOSName);
        }

        public void recharge(int amount)
        {
            if (Lock == true)
            {
                Console.WriteLine("can't recharge");
            }
            else
            {
                Console.WriteLine("mobile can recharge");
                mobileBalance = mobileBalance + amount;
                Console.WriteLine("mobile balance=" + amount);
            }
        }



        public void CallSomeone(int timeduration)
        {
            if (timeduration >= 1)
            {
                mobileBalance = mobileBalance + timeduration;
                Console.WriteLine("time" + timeduration + "min");
                Console.WriteLine("balance" + mobileBalance);
            }
            else
            {
                Console.WriteLine("time is less then 1 min");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mobile m1 = new mobile("ASHRAF", "01859486522", "100", "Android", false);
            m1.showInfo();
           

            Console.ReadKey();
        }
    }
}