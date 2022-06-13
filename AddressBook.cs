using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AddressBookSystem
{
  public class AddressBook : IContact
  {
        List<Contact> contactList;
        Dictionary<string, List<Contact>> addressBookDict;
        //public List<PersonDetails> contactList = new List<PersonDetails>();
        public AddressBook()
        {
            contactList = new List<Contact>();
            addressBookDict = new Dictionary<string, List<Contact>>();
        }

        //public class PersonDetails
        //{
        //    public string FirstName;
        //    public string LastName;
        //    public string Address;
        //    public string City;
        //    public string State;
        //    public int Zip;
        //    public long PhoneNumber;
        //    public string Email;

            
        //}
        public  List<Contact> Contact()
        {
            Console.WriteLine("\nEnter the number of contacts you want to add");
            int numOfContacts=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numOfContacts; i++)
            {


                //input contact details
                Console.WriteLine("\nEnter your First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter your State: ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter your Zipcode: ");
                int zipcode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Phone Number: ");
                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Email-ID: ");
                string email = Console.ReadLine();

                if (CheckIfAlreadyPresent(firstName, lastName))
                    Console.WriteLine("Already exist");
                else
                {
                    contactList.Add(new Contact()
                    {
                        firstName = firstName,
                        lastName = lastName,
                        address = address,
                        city = city,
                        state = state,
                        zipcode = zipcode,
                        email = email,
                        phoneNumber = phoneNumber
                    });
                }
            }
            return contactList;
        }
        public bool CheckIfAlreadyPresent(string firstName, string lastName) //using lambda for no duplicate entry
        {
            return contactList.Any(x => x.firstName == firstName && x.lastName == lastName);
        }

        public void DisplayContact()
        {
            int count = 1;
            foreach (var contact in contactList)
            {
                Console.WriteLine("Person {0} Details: ", count);
                Console.WriteLine("First Name: " + contact.firstName);
                Console.WriteLine("Last Name: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zipcode);
                Console.WriteLine("Phone Number: " + contact.phoneNumber);
                Console.WriteLine("Email ID: " + contact.email);
                count++;
            }

        }
        public  void Modify(string input)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                
                 if (contactList[i].firstName == input)
                 {
                            //exist = true;
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
                                    contactList[i].firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Write("Enter new Last name: ");
                                    contactList[i].lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Write("Enter new Address: ");
                                    contactList[i].address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Write("Enter new City: ");
                                    contactList[i].city = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.Write("Enter new State: ");
                                    contactList[i].state = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.Write("Enter new zip code: ");
                                    contactList[i].zipcode = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.Write("Enter new Phone number: ");
                                    contactList[i].phoneNumber = Convert.ToInt64(Console.ReadLine());
                                    break;
                                case 8:
                                    Console.Write("Enter new email ID: ");
                                    contactList[i].email = Console.ReadLine();
                                    break;
                                default:
                                    Console.Write("Enter valid input");
                                    break;

                            }
                 }
                 
                
            }
        }
        public void Delete(string fname,string lname)
        {
            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].firstName == fname && contactList[i].lastName == lname)
                {
                    Console.WriteLine("Contact {0} {1} Deleted Successfully from Address Book.", contactList[i].firstName, contactList[i].lastName);
                    contactList.RemoveAt(i);
                }
            }

        }
        public void AddNewAddressBook()
        {
            Console.WriteLine("Howmany number of address books you want to add? ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());
            while (numberOfBooks > 0)
            {
                Console.WriteLine("Enter name of the address book:");
                string addBookName = Console.ReadLine();
                if (addressBookDict.ContainsKey(addBookName))
                {
                    Console.WriteLine("Address Book Name Already Exists");
                }
                else
                {
                    AddressBook books = new AddressBook();
                    List<Contact> list = books.Contact();
                    addressBookDict.Add(addBookName, list);
                }
                foreach (KeyValuePair<string, List<Contact>> item in addressBookDict)
                {
                    Console.WriteLine($"key:{item.Key} value:{item.Value}");
                }
                numberOfBooks--;
            }
        }
        public void ViewAddressBook()
        {
            int count = 1;
            foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                Console.WriteLine("\nName of Address Book: " + user.Key);
                foreach (Contact contact in user.Value)
                {
                    Console.Write("\nPerson " + count + " Details:\n");
                    Console.Write(" FirstName: " + contact.firstName);
                    Console.Write(" LastName: " + contact.lastName);
                    Console.Write(" City: " + contact.city);
                    Console.Write(" State: " + contact.state);
                    Console.Write(" Address: " + contact.address);
                    Console.Write(" zipCode: " + contact.zipcode);
                    Console.Write(" PhoneNo: " + contact.phoneNumber);
                    Console.Write(" Email: " + contact.email);
                    count++;
                }
            }
        }
        public void SearchPersonInCityOrState()
        {
            Console.WriteLine("enter the city or state name");
            string city = Console.ReadLine();
            int found = 0;
            foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                foreach (Contact contact in user.Value)
                {
                    if (contact.city == city || contact.state == city)
                    {
                        Console.WriteLine(contact.firstName);
                        found = 1;
                    }
                }
            }
            if (found == 0)
                Console.WriteLine("No record found");
        }
        public void ViewPersonInCityOrState()
        {
            Console.WriteLine("enter the city or state name");
            string city = Console.ReadLine();
            foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                foreach (Contact contact in user.Value)
                {
                    if (contact.city == city || contact.state == city)
                    {
                        Console.WriteLine("FirstName: " + contact.firstName);
                        Console.WriteLine("LastName: " + contact.lastName);
                        Console.WriteLine("City: " + contact.city);
                        Console.WriteLine("State: " + contact.state);
                        Console.WriteLine("Address: " + contact.address);
                        Console.WriteLine("zipCode: " + contact.zipcode);
                        Console.WriteLine("Email: " + contact.email);
                        Console.WriteLine("PhoneNo: " + contact.phoneNumber);
                    }
                }
            }
        }
        public void CountByCityOrState()
        {
            int count = 0;
            Console.WriteLine("Enter city or state name");
            string city= Console.ReadLine();
            foreach(KeyValuePair<string, List<Contact>> user in addressBookDict)
            {
                count += user.Value.Count(x => x.city == city || x.state == city);
            }
            Console.WriteLine("No of persons in city " + city + " is " + count);
        }
        public void SortAddressBook()
        {
            Console.WriteLine("Choose an option 1-4\n 1.Sort by name\n 2.Sort by city\n 3.Sort by state\n 4.Sort by Zip code\n");
            int choice =Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
                    {
                        user.Value.Sort((emp1, emp2) => emp1.firstName.CompareTo(emp2.firstName));
                    }
                    break;
                case 2:
                    foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
                    {
                        user.Value.Sort((emp1, emp2) => emp1.city.CompareTo(emp2.city));
                    }
                    break;
                case 3:
                    foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
                    {
                        user.Value.Sort((emp1, emp2) => emp1.state.CompareTo(emp2.state));
                    }
                    break;
                case 4:
                    foreach (KeyValuePair<string, List<Contact>> user in addressBookDict)
                    {
                        user.Value.Sort((emp1, emp2) => emp1.zipcode.CompareTo(emp2.zipcode));
                    }
                    break;
                default:
                    Console.WriteLine("Choose between 1-4");
                    break;
            }
            ViewAddressBook();
        }
        public void WriteFile()
        {
            FileIO file = new FileIO();
            file.WriteUsingStreamWriter(addressBookDict);
        }

        //public void ContactList()
        //{
        //    if(contactList.Count == 0)
        //    {
        //        Console.WriteLine("\n Address Book is Empty!!");
        //        Console.WriteLine("To exit press any key ");
        //        Console.ReadKey();
        //        return;
        //    }
        //    Console.WriteLine("\n-----------ADDRESS BOOK------------\n");
        //    foreach (var element in contactList)
        //    {
        //        DisplayContact(element);
        //    }
        //    Console.WriteLine("To exit press any key ");
        //    Console.ReadKey();
        //}
        //public void Search()
        //{
        //    Console.WriteLine("Enter the city or state for searching");
        //    string search = Console.ReadLine();
        //    foreach (var elements in contactList.ToList())
        //    {
        //        if((elements.City.ToUpper() == search.ToUpper()) || (elements.State.ToUpper() == search.ToUpper() ))
        //        {
        //            Console.WriteLine(elements.FirstName);
        //        }
        //    }
        //}
    }
}
