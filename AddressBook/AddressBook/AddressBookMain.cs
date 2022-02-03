using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> addressBook=new List<Contacts>();
        public void CreateContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter FirstName: \n");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Lastline: \n");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber: \n");
            contacts.PhoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email ID: \n");
            contacts.EmailId = Console.ReadLine();

            Console.WriteLine("Enter Address: \n");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City: \n");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State: \n");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter ZipCode: \n");
            contacts.ZipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Create Contact:- \n" + contacts.FirstName + "\n" + contacts.LastName +
                "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId + "\n" + contacts.Address + "\n"
                + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode);
           
            addressBook.Add(contacts);
        }
    }
}
