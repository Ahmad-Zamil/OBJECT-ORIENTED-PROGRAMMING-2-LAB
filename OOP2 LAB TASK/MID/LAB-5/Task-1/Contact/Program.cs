using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContactAdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact obj1 = new Contact("Ashik", "015247822", 21, "01916467735", 'F');
            // obj1.ShowPersonInfo();
            // obj1.DetectMobileOperator();
            Contact obj2 = new Contact("Tarik", "1945678922", 25, "017258746", 'M');
            // obj2.ShowPersonInfo();
            // obj2.DetectMobileOperator();
            Contact obj3 = new Contact("Ashraf", "19403431", 30, "012588456", 'M');
            // obj3.ShowPersonInfo();
            // obj3.DetectMobileOperator();
            Contact obj4 = new Contact("Sabbir", "19235865", 28, "0142589562", 'O');
            // obj4.ShowPersonInfo();
            // obj4.DetectMobileOperator();
            AddressBook A1 = new AddressBook("XXXXXXX", "Personal Contact Info");
            A1.AddContact(obj1);
            A1.AddContact(obj2);
            A1.AddContact(obj3);
            A1.AddContact(obj4);
            A1.ShowAllContactInfo();
            Console.WriteLine("[-------------After Deletion of a Contact-Info------------ -- -]\n");
        A1.DeleteContact(obj2);
            A1.ShowAllContactInfo();
        }
    }
}