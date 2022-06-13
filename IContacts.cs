using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    interface IContact
    {
        List<Contact> Contact();
        void DisplayContact();
        void Modify(string input);
        void Delete(string fName, string lName);
        void AddNewAddressBook();
    }
}
