using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//collections : https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-9.0

namespace InterfaceExample
{
    public class  MyContacts
    {
        //bemærk bemærk - brug af Interfacet ICollection her!!!
        private ICollection<Contact> contacts;
        public MyContacts(ICollection<Contact> contacts)
        {
            this.contacts = contacts;
        }

        public void AddContact(Contact contact)
        {
            this.contacts.Add(contact);
        }

        public int CountContacts { 
            get { return contacts.Count(); }
        }

    }
}
