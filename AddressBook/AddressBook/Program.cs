using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        public static Dictionary<string,Contacts> addressBook = new Dictionary<string,Contacts>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem Statement!\n");

            Contacts contacts = new Contacts();

            AddressBookMain address = new AddressBookMain();
            int a = 0;
            do
            {
                Console.WriteLine("Please, select valid number from below for the action: \n1. Add \n2. Delete \n3. EditContact \n4. Show All Contact \n5. Search User \n6. View Person By City Or State \n7. Count Of ContactPersons By City and State \n8. Sort the Entries by CityState Or Zipcode  \nOtherwise press any key to terminate ");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1: 
                        address.CreateContact();
                        break;
                    case 2:
                        address.DeleteContact();
                        break;
                    case 3:
                        address.EditContact();
                        break;
                    case 4: 
                        address.ShowAllContact();
                        break;
                    case 5:
                        address.CityOrState();
                        break;
                    case 6:
                        address.ViewPersonInTheCityOrState();
                        break;
                    case 7:
                        address.CountOfContactPersons();
                        break;
                    case 8:
                        address.SortByCityStateOrZipCode();
                        break;
                }
            }
            while(a > 0 && a < 5);

            Console.ReadLine();
         
        }
    }
}
