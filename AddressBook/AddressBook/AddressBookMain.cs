using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> addressBook = new List<Contacts>();

        public void CreateContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter FirstName:");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName:");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber:");
            contacts.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email ID:");
            contacts.EmailId = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter ZipCode:");
            contacts.ZipCode = Convert.ToInt32(Console.ReadLine());

            display(contacts);

            addressBook.Add(contacts);
        }
        public void EditContact(string FirstName)
        {
            Contacts contacts = new Contacts();

            foreach (var item in addressBook)
            {
                if (item.FirstName == FirstName)
                {
                    contacts = item;
                    //return;
                    break;
                }
            }
            addressBook.Remove(contacts);

            Console.WriteLine("1.LastName \n2.PhoneNumber \n3.EmailID \n4.Address \n5.City \n6.State \n7.ZipCode ");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        contacts.LastName = Console.ReadLine();
                        break;

                    case 2:
                        contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        contacts.EmailId = Console.ReadLine();
                        break;

                    case 4:
                        contacts.Address = Console.ReadLine();
                        break;

                    case 5:
                        contacts.City = Console.ReadLine();
                        break;

                    case 6:
                        contacts.State = Console.ReadLine();
                        break;

                    case 7:
                        contacts.ZipCode = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        flag = false;
                        break;

                }
                display(contacts);
            }



        }
        public void DeleteContact(string FirstName)
        {
            Contacts contacts = new Contacts();
            int i = 0;

            foreach (var item in addressBook)
            {

                if (item.FirstName == FirstName)
                {
                    //contacts = item;
                    //return;

                    break;
                }
                i++;
            }
            if (addressBook.Count > i)
            {
                addressBook[i] = null;
            }


            foreach (var item in addressBook)
            {
                if (item == null)
                {
                    Console.WriteLine("Deleted Successfully");
                }
            }
            



        }


        public static void display(Contacts contacts)
        {
            Console.WriteLine("Create Contact:- \n" + contacts.FirstName + "\n" + contacts.LastName +
                "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId + "\n" + contacts.Address + "\n"
                + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode + "\n");
        }
    }
}
