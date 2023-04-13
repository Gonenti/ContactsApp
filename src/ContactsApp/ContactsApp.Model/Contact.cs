using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Contact : ICloneable
    {
        private string _fullName;
        private string _email;
        private string _phoneNumber;
        private DateTime _dateOfBirth;
        private string _vkontakteId;

        // constructor
        public Contact(string fullName, string email, string phoneNumber, DateTime dateOfBirth, string vkontakteId)
        {
            _fullName = fullName;
            _email = email;
            _phoneNumber = phoneNumber;
            _dateOfBirth = dateOfBirth;
            _vkontakteId = vkontakteId;
        }

        // properties
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = ValidateFullName(value); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = ValidateEmail(value); }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = ValidatePhoneNumber(value); }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = ValidateDateOfBirth(value); }
        }

        public string VkontakteId
        {
            get { return _vkontakteId; }
            set { _vkontakteId = ValidateVkontakteId(value); }
        }

        // validation methods
        private string ValidateFullName(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Full name cannot be null or empty.");

            if (value.Length > 100)
                throw new ArgumentException("Full name cannot exceed 100 characters.");

            // convert first letter of each word to upper case
            string[] names = value.Split(' ');
            for (int i = 0; i < names.Length; i++)
            {
                if (!string.IsNullOrEmpty(names[i]))
                {
                    char[] nameChars = names[i].ToCharArray();
                    nameChars[0] = char.ToUpper(nameChars[0]);
                    names[i] = new string(nameChars);
                }
            }
            return string.Join(" ", names);
        }

        private string ValidateEmail(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Email cannot be null or empty.");

            if (value.Length > 100)
                throw new ArgumentException("Email cannot exceed 100 characters.");

            return value;
        }

        private string ValidatePhoneNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            if (!Regex.IsMatch(value, @"^[0-9+()\- ]+$"))
                throw new ArgumentException("Phone number can only contain digits and the characters '+', '(', ')', '-', and ' '.");

            return value;
        }

        private DateTime ValidateDateOfBirth(DateTime value)
        {
            if (value.Year < 1900 || value > DateTime.Now)
                throw new ArgumentException("Date of birth must be between 1900 and the current date.");

            return value;
        }

        private string ValidateVkontakteId(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            if (value.Length > 50)
                throw new ArgumentException("VKontakte ID cannot exceed 50 characters.");

            return value;
        }

        // ICloneable implementation
        public object Clone()
        {
            return new Contact(_fullName, _email, _phoneNumber, _dateOfBirth, _vkontakteId);
        }
    }

}
