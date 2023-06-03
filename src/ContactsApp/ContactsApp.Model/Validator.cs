namespace ContactsApp.Model
{
    using System.Net.Mail;
    using System.Text.RegularExpressions;
    /// <summary>
    ///the class is intended for validating values    
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validates a full name, converting the first letter of each word to upper case.
        /// </summary>
        /// <param name="value">The full name to validate.</param>
        /// <returns>The validated full name.</returns>
        /// <exception cref="ArgumentException">Thrown when the full name is null, empty or exceeds 100 characters.</exception>
        public static string ValidateFullName(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("NameError: Full name cannot be null or empty.");

            if (value.Length > 100)
                throw new ArgumentException("NameError: Full name cannot exceed 100 characters.");

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

        /// <summary>
        /// Validates an email address. example: example2000@gmail.com
        /// </summary>
        /// <param name="value">The email address to validate.</param>
        /// <returns>The validated email address.</returns>
        /// <exception cref="ArgumentException">Thrown when the email address is null, empty or exceeds 100 characters.</exception>
        public static string ValidateEmail(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("EmailError: Email cannot be null or empty.");

            if (value.Length > 100)
                throw new ArgumentException("EmailError: Email cannot exceed 100 characters.");

            try
            {
                var emailAddress = new MailAddress(value);
            }
            catch
            {
                throw new ArgumentException("EmailError: Incorrect email. An example of proper email: example2000@gmail.com");
            }

            return value;
        }

        /// <summary>
        /// Validates a phone number.
        /// </summary>
        /// <param name="value">The phone number to validate.</param>
        /// <returns>The validated phone number or null if the input is null or empty.</returns>
        /// <exception cref="ArgumentException">Thrown when the phone number contains invalid characters.</exception>
        public static string ValidatePhoneNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("PhoneNumberError: Phone Number can not be emty");

            if (!value.StartsWith("+"))
                throw new ArgumentException("PhoneNumberError: Phone Number must starts with '+'");

            if (Regex.Replace(value, @"[^\d]", "").Length != 11)
                throw new ArgumentException("PhoneNumberError: There should be 11 digits");

            if (!Regex.IsMatch(value, @"^[0-9+()\- ]+$"))
                throw new ArgumentException("PhoneNumberError: Phone number can only contain digits and the characters" +
                                            "'+', '(', ')', '-', and ' '.");

                return value;
        }

        /// <summary>
        /// Validates a date of birth.
        /// </summary>
        /// <param name="value">The date of birth to validate.</param>
        /// <returns>The validated date of birth.</returns>
        /// <exception cref="ArgumentException">Thrown when the date of birth is before 1900 or after the current date.</exception>
        public static DateTime ValidateDateOfBirth(DateTime value)
        {
            if (value.Year < 1900 || value > DateTime.Now)
                throw new ArgumentException("Date of birth must be between 1900 and the current date.");

            return value;
        }

        /// <summary>
        /// Validates a VKontakte ID.
        /// </summary>
        /// <param name="value">The VKontakte ID to validate.</param>
        /// <returns>The validated VKontakte ID or null if the input is null or empty.</returns>
        /// <exception cref="ArgumentException">Thrown when the VKontakte ID exceeds 50 characters.</exception>
        public static string ValidateVkontakteId(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("VKError: VK id can not be emty");

            if (value.Length > 50)
                throw new ArgumentException("VKError: VKontakte ID cannot exceed 50 characters.");
            return value;
        }
    }

}
