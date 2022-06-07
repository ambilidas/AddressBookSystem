﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
  public class AddressBook
  {
        public List<PersonDetails> contactList = new List<PersonDetails>();
       
        public class PersonDetails
        {
            public string FirstName;
            public string LastName;
            public string Address;
            public string City;
            public string State;
            public int Zip;
            public long PhoneNumber;
            public string Email;  
        }
        public  void Contact()
        {
            Console.WriteLine("\nDo you want to add a new contact(Y/N) ");
            char choice=Convert.ToChar(Console.ReadLine());
            while(choice == 'y' || choice == 'Y')
            {
                bool exist = false;
                //object creation
                 PersonDetails personDetails = new PersonDetails();
                //input contact details
                 Console.Write("Enter the first name:");
                personDetails.FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                personDetails.LastName = Console.ReadLine();
                Console.Write("Enter the Address: ");
                personDetails.Address = Console.ReadLine();
                Console.Write("Enter the City: ");
                personDetails.City = Console.ReadLine();
                Console.Write("Enter the State: ");
                personDetails.State = Console.ReadLine();
                Console.Write("Enter Zip code: ");
                personDetails.Zip = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                personDetails.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.Write("Enter Email: ");
                personDetails.Email = Console.ReadLine();

                foreach(var elements in contactList.ToList())
                {
                    //UC7
                    if (elements.FirstName == personDetails.FirstName && elements.LastName == personDetails.LastName)
                    {
                        exist = true;
                        Console.WriteLine("\nContact is already exist");
                    }

                }
                if(exist == false)
                {
                    contactList.Add(personDetails);
                }
                Console.WriteLine("Do you want to add a new contact(Y/N) ");
                choice = Convert.ToChar(Console.ReadLine());
            }
           
        }
        public  void DisplayContact(PersonDetails personDetails)
        {
            Console.WriteLine("\nFirst Name: " + personDetails.FirstName);
            Console.WriteLine("Last Name: " + personDetails.LastName);
            Console.WriteLine("Address: " + personDetails.Address);
            Console.WriteLine("City: " + personDetails.City);
            Console.WriteLine("State: " + personDetails.State);
            Console.WriteLine("Zip Code: " + personDetails.Zip);
            Console.WriteLine("Phone Number: " + personDetails.PhoneNumber);
            Console.WriteLine("Email ID: " + personDetails.Email);
            Console.WriteLine("------------------------------------------------");

        }
        public  void Modify()
        {
            if(contactList.Count != 0)
            {
                Console.WriteLine("\n Do you want to modify?(Y/N) ");
                char modify=Convert.ToChar(Console.ReadLine());
                while(modify == 'Y' || modify == 'y')
                {
                    Console.WriteLine("Enter first name of contact to modify ");
                    string key_modify = Console.ReadLine();
                    bool exist = false;
                    foreach(var element in contactList)
                    {
                        if(element.FirstName.ToUpper() == key_modify.ToUpper())
                        {
                            exist = true;
                            Console.WriteLine("Choose the field to modify: ");
                            Console.WriteLine("Enter 1 to change First name");
                            Console.WriteLine("Enter 2 to change Last name");
                            Console.WriteLine("Enter 3 to change Address");
                            Console.WriteLine("Enter 4 to change city");
                            Console.WriteLine("Enter 5 to change State");
                            Console.WriteLine("Enter 6 to cahnge zip code");
                            Console.WriteLine("Enter 7 to change Phone number");
                            Console.WriteLine("Enter 8 to change email");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.Write("Enter the new First name: ");
                                    element.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Write("Enter new Last name: ");
                                    element.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Enter new Address: ");
                                    element.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write("Enter new City: ");
                                    element.City = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.Write("Enter new State: ");
                                    element.State = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.Write("Enter new zip code: ");
                                    element.Zip = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.Write("Enter new Phone number: ");
                                    element.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                                    break;
                                case 8:
                                    Console.Write("Enter new email ID: ");
                                    element.Email = Console.ReadLine();
                                    break;
                                default:
                                    Console.Write("Enter valid input");
                                    break;

                            }
                        }
                        else if (exist == false)
                        {
                            Console.WriteLine("Enter a valid name");
                        }
                    }
                    Console.WriteLine("\n Do you want to modify?(Y/N) ");
                    modify = Convert.ToChar(Console.ReadLine());
                }
            }
        }
        public void Delete()
        {
            if(contactList.Count != 0)
            {
                Console.WriteLine("\n Do you want to delete an existing contact? (Y/N)  ");
                char choice = Convert.ToChar(Console.ReadLine());
                while (choice == 'y' || choice == 'Y')
                {
                    
                    Console.WriteLine("\n Enter the first name of contact you want to delete: ");
                    string delete = Console.ReadLine();
                    bool exist = false;
                    foreach (var elements in contactList.ToList())
                    {
                        if (elements.FirstName.ToUpper() == delete.ToUpper())
                        {
                            exist = true;
                            contactList.Remove(elements);
                            Console.WriteLine("\n Contact deleted!! ");
                        }
                    }
                    if (exist == false)
                    {
                        Console.WriteLine("\nContact doesn't exist ");
                    }
                    Console.WriteLine("\n Do you want to delete an existing contact? (Y/N)  ");
                    choice = Convert.ToChar(Console.ReadLine());
                }
            }
           
        }
        public void ContactList()
        {
            if(contactList.Count == 0)
            {
                Console.WriteLine("\n Address Book is Empty!!");
                Console.WriteLine("To exit press any key ");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\n-----------ADDRESS BOOK------------\n");
            foreach (var element in contactList)
            {
                DisplayContact(element);
            }
            Console.WriteLine("To exit press any key ");
            Console.ReadKey();
        }
        public void Search()
        {
            Console.WriteLine("Enter the city or state for searching");
            string search = Console.ReadLine();
            foreach (var elements in contactList.ToList())
            {
                if((elements.City.ToUpper() == search.ToUpper()) || (elements.State.ToUpper() == search.ToUpper() ))
                {
                    Console.WriteLine(elements.FirstName);
                }
            }
        }
  }
}
