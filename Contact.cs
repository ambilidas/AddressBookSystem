using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        //declaration of variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;
        //public Contact[] contactArray; //declaration of array for storing class instances
        public int contact = 0;
        //constructor
        public Contact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }
        //contact creation
        public static void createContact()
        {
            Console.Write("Enter the first name:");
            string firstname = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter the Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter the City: ");
            string city = Console.ReadLine();
            Console.Write("Enter the State: ");
            string state = Console.ReadLine();
            Console.Write("Enter Zip code: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Contact contactobj = new Contact(firstname, lastname, address, city, state, zip, phonenumber, email);
            ArrayList contactArray = new ArrayList();
            contactArray.Add(contactobj.firstName);
            contactArray.Add(contactobj.lastName);
            contactArray.Add(contactobj.address);
            contactArray.Add(contactobj.city);
            contactArray.Add(contactobj.state);
            contactArray.Add(contactobj.zip);
            contactArray.Add(contactobj.phoneNumber);
            contactArray.Add(contactobj.email);
            Console.WriteLine("Contact has been created");
            //displaying contact details
            Console.WriteLine("-----------ADDRESS BOOK------------");
            foreach (var element in contactArray)
            {
                Console.WriteLine(element);

            }
        }
    }
}
