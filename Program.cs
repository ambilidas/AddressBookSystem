using System;
using System.Collections;
namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t WELCOME TO ADDRESS BOOK PROGRAM");

            AddressBook addressBook = new AddressBook();
            // AddressBook addressBook2 = new AddressBook();
            while (true)
            {


                Console.WriteLine("\nPlease choose an option:");

                Console.WriteLine("1: View Contact \n2: Add New Contact \n3: Modify the Contact \n4: Delete the  \n5: Add Multiple Addressbook\n6: Search person in city/state\n7: View person in city/state\n8: Count by city/state\n9: Sort Contact List\n10: Add new book and save into file\n11: Add new book and save into csv file\n12: Add new book and save into json file");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.DisplayContact();
                        break;
                    case 2:
                        addressBook.Contact();
                        break;
                    case 3:
                        Console.WriteLine("Enter the first name of contact that you want to modify");
                        string input = Console.ReadLine();
                        addressBook.Modify(input);
                        break;
                    case 4:
                        Console.WriteLine("Enter the first name of contact");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Enter the last name of contact");
                        string lname = Console.ReadLine();
                        addressBook.Delete(fname, lname);
                        addressBook.DisplayContact();
                        break;
                    case 5:
                        addressBook.AddNewAddressBook();
                        addressBook.ViewAddressBook();
                        break;
                    case 6:
                        addressBook.SearchPersonInCityOrState();
                        break;
                    case 7:
                        addressBook.ViewPersonInCityOrState();
                        break;
                    case 8:
                        addressBook.CountByCityOrState();
                        break;
                    case 9:
                        //Console.WriteLine("Contacts in sorted order by person's name");
                        addressBook.SortAddressBook();
                        break;
                    case 10:
                        addressBook.WriteTextFile();
                        break;
                    case 11:
                        addressBook.WriteCsvFile();
                        break;
                    case 12:
                        addressBook.WriteJsonFile();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }
    }
}