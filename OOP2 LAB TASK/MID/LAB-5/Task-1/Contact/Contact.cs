using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContactAdressBook
{
    class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;
        public string PERSONNAME
        {
            set { personName = value; }
            get { return personName; }
        }
        public string PERSONID
        {
            set { personId = value; }
            get { return personId; }
        }
        public int AGE
        {
            set { age = value; }
            get { return age; }
        }
        public string MOBILENUMBER
        {
            set { mobileNumber = value; }
            get { return mobileNumber; }
        }
        public char GENDER
        {
            set { gender = value; }
            get { return gender; }
        }
        public Contact()
        {
            Console.WriteLine("Empty Constructor");
        }
        public Contact(string personName, string personId, int age, string
        mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("Person Name : " + personName);
            Console.WriteLine("Person Id : " + personId);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Mobile Number : " + mobileNumber);
            Console.WriteLine("Gender : " + gender);
        }
        public void DetectMobileOperator()
        {
            if (mobileNumber.Contains("017"))
            {
                Console.WriteLine("GRAMEENPHONE OPERATOR");
            }
            else if (mobileNumber.Contains("019"))
            {
                Console.WriteLine("BANGLALINK OPERATOR");
            }
            else if (mobileNumber.Contains("018"))
            {
                Console.WriteLine("ROBI OPERATOR");
            }
            else
                Console.WriteLine("OTHER OPERATOR");
        }
    }
}
