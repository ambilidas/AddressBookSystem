using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class FileIO
    {
        string path = @"D:\bridgelabz1\AddressBookSystem\TextFile1.txt";
        string csvpath = @"D:\bridgelabz1\AddressBookSystem\addbookcsv.csv";
        string jsonpath = @"D:\bridgelabz1\AddressBookSystem\addbookjson.json";
        public void WriteTextfileStreamWriter(Dictionary<string, List<Contact>> AddBookDictObj)
        {
            int count = 1;
            foreach (KeyValuePair<string, List<Contact>> user in AddBookDictObj)
            {
                using (StreamWriter stream = File.AppendText(path))
                {
                    stream.WriteLine("Name of AddressBook: " + user.Key);
                    foreach (Contact contact in user.Value)
                    {
                        stream.Write(" FirstName: " + contact.firstName);
                        stream.Write(" LastName: " + contact.lastName);
                        stream.Write(" City: " + contact.city);
                        stream.Write(" State: " + contact.state);
                        stream.Write(" Address: " + contact.address);
                        stream.Write(" zipCode: " + contact.zipcode);
                        stream.Write(" PhoneNo: " + contact.phoneNumber);
                        stream.Write(" Email: " + contact.email);
                        count++;
                    }
                }
            }
            Console.WriteLine("File Written Successfully");
        }
        public void ReadTextFile()
        {
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            Console.WriteLine("File Read Successfully");
        }
        public void WriteInCsvFile(Dictionary<string, List<Contact>> AddBookDictObj)
        {
            using (StreamWriter stream = new StreamWriter(csvpath))
            using (CsvWriter csvWriter = new CsvWriter(stream, CultureInfo.InvariantCulture))
                foreach (KeyValuePair<string, List<Contact>> user in AddBookDictObj)
                {
                    csvWriter.WriteRecords(user.Value.ToList());
                }
            Console.WriteLine("File Written Successfully");
        }
        public void ReadCsvFile()
        {
            using (StreamReader streamreader = new StreamReader(csvpath))
            using (CsvReader csvReader = new CsvReader(streamreader, CultureInfo.InvariantCulture))
            {
                List<Contact> records = csvReader.GetRecords<Contact>().ToList();
                foreach (var contact in records)
                {
                    Console.WriteLine(contact);
                }
            }
            Console.WriteLine("File Read Successfully");
        }
        public void WriteInJsonFile(Dictionary<string, List<Contact>> AddBookDictObj)
        {
            string serialize = JsonConvert.SerializeObject(AddBookDictObj);
            File.WriteAllText(jsonpath, serialize);
            Console.WriteLine("File Written Successfully");
        }
        public void ReadJsonFile()
        {
            string jsondata = File.ReadAllText(jsonpath);
            Dictionary<string, List<Contact>> addbookjson = JsonConvert.DeserializeObject<Dictionary<string, List<Contact>>>(jsondata);
            foreach (KeyValuePair<string, List<Contact>> user in addbookjson)
            {
                Console.WriteLine("\nName of Address Book: " + user.Key);
                foreach (Contact contact in user.Value)
                {
                    Console.WriteLine(contact);
                }
            }
            Console.WriteLine("File Read Successfully");
        }
    }
}
