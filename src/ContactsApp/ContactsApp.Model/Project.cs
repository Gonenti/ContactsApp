using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Project
    {
        private List<Contact> _contacts;

        public Project()
        {
            _contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
        }

        public List<Contact> GetAllContacts()
        {
            // return a copy of the list to prevent modification of the original list
            return new List<Contact>(_contacts);
        }

        public List<Contact> GetContactsByFullName()
        {
            // sort contacts by full name using LINQ and return a new list
            return _contacts.OrderBy(c => c.FullName).ToList();
        }

        public List<Contact> GetContactsByInitials(string initials)
        {
            // search for contacts whose full name starts with the specified initials and return a new list
            return _contacts.Where(c => c.FullName.StartsWith(initials)).ToList();
        }

        public List<Contact> GetContactsBySubstring(string substring)
        {
            // search for contacts whose full name contains the specified substring and return a new list
            return _contacts.Where(c => c.FullName.Contains(substring)).ToList();
        }
    }

}
