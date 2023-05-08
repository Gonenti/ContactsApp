namespace ContactsApp.Model
{
    public class Contact : ICloneable
    {
        /// <summary>
        /// Full name of user
        /// </summary>
        private string _fullName;

        /// <summary>
        /// user email
        /// </summary>
        private string _email;

        /// <summary>
        /// user phone number
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// user date of birth
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// user vk id
        /// </summary>
        private string _vkontakteId;

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="fullName">The full name of the contact.</param>
        /// <param name="email">The email address of the contact.</param>
        /// <param name="phoneNumber">The phone number of the contact.</param>
        /// <param name="dateOfBirth">The date of birth of the contact.</param>
        /// <param name="vkontakteId">The VKontakte ID of the contact.</param>
        public Contact(string fullName, 
            string email, 
            string phoneNumber, 
            DateTime dateOfBirth, 
            string vkontakteId)
        {
            _fullName = fullName;
            _email = email;
            _phoneNumber = phoneNumber;
            _dateOfBirth = dateOfBirth;
            _vkontakteId = vkontakteId;
        }

        /// <summary>
        /// Gets or sets the full name of the contact.
        /// </summary>

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = Validator.ValidateFullName(value); }
        }

        /// <summary>
        /// Gets or sets the email address of the contact.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = Validator.ValidateEmail(value); }
        }

        /// <summary>
        /// Gets or sets the phone number of the contact.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = Validator.ValidatePhoneNumber(value); }
        }

        /// <summary>
        /// Gets or sets the date of birth of the contact.
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = Validator.ValidateDateOfBirth(value); }
        }

        /// <summary>
        /// Gets or sets the VKontakte ID of the contact.
        /// </summary>
        public string VkontakteId
        {
            get { return _vkontakteId; }
            set { _vkontakteId = Validator.ValidateVkontakteId(value); }
        }

        /// <summary>
        /// ICloneable implementation
        /// </summary>
        public object Clone()
        {
            return new Contact(_fullName, _email, _phoneNumber, _dateOfBirth, _vkontakteId);
        }
    }

}
