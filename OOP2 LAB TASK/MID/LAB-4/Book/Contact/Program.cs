using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;

        public string PERSONNAME { set; get; }
        public string PERSONID { set; get; }
        public int AGE { set; get; }
        public string MOBILENUMBER { set; get; }
        public char GENDER { set; get; }

        public contact()
        {

        }
        public contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;

        }

        public void showInfo()
        {
            Console.WriteLine("Person_Name:{0} \n Person_Id:{1} \n Age:{2} \n Mobile_Number:{3} \n Gender:{4}", personName, personId, age, mobileNumber, gender);
        }

        public void checkGender()
        {
            if (gender == 'm' || gender == 'M')
            {
                Console.WriteLine("gender: male");
            }

            else if (gender == 'f' || gender == 'F')
            {
                Console.WriteLine(" gernder: female");
            }
            else
                Console.WriteLine(" gender: make sure you give the right input");
        }

        public void DetectMobileOperator()
        {
            if (mobileNumber.Contains("017"))
            {
                Console.WriteLine("the number is Grameen Phone");
            }
            else if (mobileNumber.Contains("018"))
            {
                Console.WriteLine("the number is Robi");
            }
            else
                Console.WriteLine("Others Operator");

        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            contact c1 = new contact("ASHRAF", "12-221", 20, "01859486255", 'M');
            c1.showInfo();
            c1.DetectMobileOperator();
            c1.checkGender();

            contact c2 = new contact("ASHIK", "12-222", 21, "01787881595", 'F');
            c2.showInfo();
            c2.DetectMobileOperator();
            c2.checkGender();

            contact c3 = new contact("TARIK", "12-223", 22, "01517037326", 'X');
            c3.showInfo();
            c3.DetectMobileOperator();
            c3.checkGender();

            Console.ReadKey();
        }
    }
}