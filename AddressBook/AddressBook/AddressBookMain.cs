using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        //creating contacts  
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

            Console.WriteLine("=======================================\n");

            if (Validate(contacts.FirstName, contacts.LastName))
            {
                Console.WriteLine("Contacts Already Exit!\n");
            }
            else
            {
                display(contacts);

                try
                {
                    Program.addressBook.Add(contacts.FirstName, contacts);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        //lambda Expression
        public bool Validate(string firstname, string lastname)
        {
         return   Program.addressBook.Values.Any(x => x.FirstName == firstname && x.LastName == lastname);
           
        }
       
        public void CityOrState()
        {
            Console.WriteLine("Please, Enter City or State .");    
            string State = Console.ReadLine();
            List<Contacts> contacts = Program.addressBook.Values.ToList().FindAll(e => (e.State == State) || (e.City == State)).ToList();
            foreach (Contacts person in contacts)
            {
                Console.WriteLine("FirstName : "+ person.FirstName + "\tLastName: " + person.LastName + "\tPhoneNo: " + person.PhoneNumber + "\tEmailId: " + person.EmailId + "\tZipCode: " + person.ZipCode);
            }
           
        }

        //print all the Contact in the AddressBook
        public void ShowAllContact()
        {
            foreach (var item in Program.addressBook)
            {
                if (item.Key != null)
                {
                    Console.WriteLine("First Name : " + item.Value.FirstName);
                    Console.WriteLine("Last Name : " + item.Value.LastName);
                    Console.WriteLine("Phone Number : " + item.Value.PhoneNumber);
                    Console.WriteLine("Email Id : " + item.Value.EmailId);
                    Console.WriteLine("Address : " + item.Value.Address);
                    Console.WriteLine("City : " + item.Value.City);
                    Console.WriteLine("State : " + item.Value.State);
                    Console.WriteLine("ZipCode : " + item.Value.ZipCode);
                    Console.WriteLine("===================================================\n");
                }
            }
        }

        //printing Edit Contact
        public void EditContact()
        {
            Console.WriteLine("Please Enter First Name to Edit \n");
            string FirstName=Console.ReadLine();
            Contacts contacts = new Contacts();

            foreach (var item in Program.addressBook)
            {
                if (item.Value.FirstName == FirstName)
                {
                    contacts = item.Value;
                    //return;
                    break;
                }
            }
            Program.addressBook.Remove(contacts.FirstName);

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
        //print Delete Contact 
        public void DeleteContact()
        {
            Console.WriteLine("Please Enter First Name to Delete");
            string FirstName=Console.ReadLine();
            Contacts contacts = new Contacts();
            int i = 0;

            foreach (var item in Program.addressBook)
            {

                if (item.Value.FirstName == FirstName)
                {
                    //contacts = item;
                    //return;

                    break;
                }
                i++;
            }
            if (Program.addressBook.Count > i)
            {
                Program.addressBook.Remove(FirstName);
            }


            foreach (var item in Program.addressBook)
            {
                if (item.Value == null)
                {
                    Console.WriteLine("Deleted Successfully !!!");
                }
            }
          

        }

        //Display
        public static void display(Contacts contacts)
        {
            Console.WriteLine("Create Contact:- \n" + contacts.FirstName + "\n" + contacts.LastName +
                "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId + "\n" + contacts.Address + "\n"
                + contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode + "\n");
            
        }
        
    }
}
