using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_IEnumerable 
{
    internal class PhoneBook : IEnumerable<Contact>
    {
        public List<Contact> Contacts;

        public PhoneBook()
        {
            Contacts = new List<Contact>()
            {
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }

        // Explicit implementation of IEnumerable.GetEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }

        // Explicit implementation of IEnumerable<Contact>.GetEnumerator
        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }
    }
}
