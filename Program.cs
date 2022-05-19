using System;
namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t Welcome to Address Book Program");
            
            AddressBook.Contact();
            AddressBook.Modify();
            AddressBook.ContactList();
            AddressBook.Delete();
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