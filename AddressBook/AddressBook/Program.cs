using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem Statement!");

            Contacts contacts = new Contacts();

            AddressBookMain address = new AddressBookMain();
            address.CreateContact();
            //address.EditContact("Ram");
            
            address.DeleteContact("Ram");
            Console.ReadLine();
         
        }
    }
}
