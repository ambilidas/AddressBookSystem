using System;
using System.Collections;
namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t WELCOME TO ADDRESS BOOK PROGRAM");
            AddressBook addressBook1 = new AddressBook();
            AddressBook addressBook2 = new AddressBook();
            Console.WriteLine("Address Book 1");
            addressBook1.Contact();
            addressBook1.Modify();
            addressBook1.ContactList();
            addressBook1.Delete();
            Console.WriteLine("Address Book 2");
            addressBook2.Contact();
            addressBook2.Modify();
            addressBook2.ContactList();
            addressBook2.Delete();
            Dictionary<int,AddressBook> list = new Dictionary<int,AddressBook>();
            list.Add(1,addressBook1);
            list.Add(2,addressBook2);
            //UC8
            Console.WriteLine("Do you want to search on address book 1?(Y/N)");
            char choice=Convert.ToChar(Console.ReadLine());
            if(choice == 'Y')
             addressBook1.Search();
             Console.WriteLine("Do you want to search on address book 2?(Y/N)");
            char choice2=Convert.ToChar(Console.ReadLine());
            if(choice2 == 'Y')
                addressBook2.Search();  

            //foreach(var address in list)
            //{
            //    Console.WriteLine("Key: "+address.Key+"Value: "+address.Value);
            //    list.Contains()
            //}

            // AddressBook.PersonDetails personDetails = new AddressBook.PersonDetails();
            //AddressBook.DisplayContact(AddressBook.personDetails);


            //Console.WriteLine("\nEnter 1 for adding contact ");
            //int key = Convert.ToInt32(Console.ReadLine());
            //switch (key)
            //{
            //    case 1:
            //        Contact.createContact();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid key");
            //        Program.Main(args);
            //        break;
            //}
            //Console.WriteLine("Do you want to modify contact?(Y/N)");
            //string modify = Console.ReadLine();
            //if (modify == "Y" || modify == "y")
            //{
            //    Contact.Modify();
            //}

        }
    }
}