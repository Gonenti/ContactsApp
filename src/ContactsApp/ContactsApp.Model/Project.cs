﻿namespace ContactsApp.Model
{
    /// <summary>
    /// Represents a collection of contacts and provides methods for adding, removing, and querying contacts.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// A list of contacts managed by the Project class.
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Returns a copy of the list of contacts.
        /// </summary>
        /// <returns>A new list of contacts containing the same contacts as the original list.</returns>
        public List<Contact> AllContacts
        {
            get { return _contacts; }
            //return new List<Contact>(_contacts);
        }

        /// <summary>
        /// Initializes a new instance of the Project class and creates a new empty list of contacts.
        /// </summary>
        public Project()
        {
            _contacts = new List<Contact>();
        }

        /// <summary>
        /// Search Birthday Contacts
        /// </summary>
        /// <returns></returns>
        public List<Contact> FindContactsBirthday()
        {
            List<Contact> сontactsBirthdays = new List<Contact>();
            for (int i = 0; i < _contacts.Count; i++)
            {
                if (_contacts[i].DateOfBirth.Month == DateTime.Today.Month &&
                    _contacts[i].DateOfBirth.Day == DateTime.Today.Day)
                {
                    сontactsBirthdays.Add(_contacts[i]);
                }

            }
            return сontactsBirthdays;
        }

        /// <summary>
        /// Adds a new contact to the list of contacts.
        /// </summary>
        /// <param name="contact">The contact to add to the list.</param>
        public void AddContact(Contact contact)
        {
            if (_contacts.Any(c => c.FullName.Equals(contact.FullName)))
            { 
                throw new ArgumentException("This contact already exist"); 
            }
            _contacts.Add(contact);
        }

        /// <summary>
        /// Adds a new contact to the list of contacts.
        /// </summary>
        /// <param name="contact">The contact to add to the list.</param>
        public void ReplaceContactByIndex(Contact contact, int index)
        {
            if (index < 0) return;
            _contacts[index] = contact;
        }

        /// <summary>
        /// Removes a contact from the list of contacts.
        /// </summary>
        /// <param name="contact">The contact to remove from the list.</param>
        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
        }

        /// <summary>
        /// Returns a sorted list of contacts ordered by their full name.
        /// </summary>
        /// <returns>A new list of contacts sorted by full name.</returns>
        public List<Contact> SortContactsByFullName()
        {
            return _contacts.OrderBy(c => c.FullName).ToList();
        }

        /// <summary>
        /// Returns a list of contacts whose  contains the specified substring.
        /// </summary>
        /// <param name="substring">The substring to match.</param>
        /// <returns>A new list of contacts whose contains the specified substring.</returns>
        public List<Contact> GetContactsBySubstring(string substring)
        {
            return _contacts.Where(c => c.FullName.Contains(substring) ||
                                        c.Email.Contains(substring) ||
                                        c.PhoneNumber.Contains(substring) ||
                                        c.DateOfBirth.ToString().Contains(substring) ||
                                        c.VkontakteId.Contains(substring)
                                        ).ToList();
        }

        /// <summary>
        /// Search for the contact index
        /// </summary>
        /// <param name="contact">the contact whose index you need to find.</param>
        /// <returns>Contact index.</returns>
        public int FindContact(Contact contact)
        {
            return _contacts.IndexOf(contact);
        }
    }
}