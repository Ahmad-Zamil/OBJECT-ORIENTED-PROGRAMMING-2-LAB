
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContactAdressBook
{
    class AddressBook
    {
        private string ownerName;
        private string info;
        private Contact[] listOfContact = new Contact[1000];
        public string OwnerName
        {
            set { ownerName = value; }
            get { return ownerName; }
        }
        public string Info
        {
            set { info = value; }
            get { return info; }
        }

        public AddressBook()
        {
        }
        public AddressBook(string name, string info)
        {
            this.ownerName = name;
            this.info = info;
        }
        public void ShowAllContactInfo()
        {
            Console.WriteLine("[-------------Contact Address Book---------------]");
            Console.WriteLine("Owner's Name : " + OwnerName);
            Console.WriteLine("Info : " + Info);
            Console.WriteLine("The Contact List showing bellow:\n");
            for (int i = 0; listOfContact[i] != null; i++)
            {
                Console.WriteLine("Contact " + (i + 1) + ":");
                listOfContact[i].ShowPersonInfo();
                Console.WriteLine();
            }
        }

        public void AddContact(Contact con)
        {
            if (listOfContact[0] == null)
            {
                listOfContact[0] = con;

            }
            else
            {
                for (int i = 0; listOfContact[i] != null; i++)
                {
                    if (listOfContact[i + 1] == null)
                    {
                        listOfContact[i + 1] = con;

                        break;
                    }
                }
            }
        }
        public void DeleteContact(Contact con)
        {
            for (int i = 0; listOfContact[i] != null; i++)
            {
                if (listOfContact[i].Equals(con))
                {
                    for (int j = i; listOfContact[j] != null; j++)
                    {
                        listOfContact[j] = listOfContact[j + 1];
                    }
                }
            }
        }
    }
}