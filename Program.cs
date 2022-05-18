using System;
namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t Welcome to Address Book Program");

            //create object for class

            Console.WriteLine("\nEnter 1 for adding contact ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Contact.createContact();
                    break;
                default:
                    Console.WriteLine("Invalid key");
                    Program.Main(args);
                    break;
            }
        }
    }
}