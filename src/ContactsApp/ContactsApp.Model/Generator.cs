namespace ContactsApp.Model
{
    /// <summary>
    /// Generates random contact information.
    /// </summary>
    public static class Generator
    {
        /// <summary>
        /// Generates a random phone number in the format of +xxxxxxxxxx.
        /// </summary>
        /// <returns>A string containing the generated phone number.</returns>
        private static string PhoneNumber()
        {
            Random random = new Random();
            return "+" + random.Next(10000, 99999).ToString() + random.Next(100000, 999999).ToString();
        }

        /// <summary>
        /// Generates a random full name.
        /// </summary>
        /// <returns>A string containing the generated full name.</returns>
        private static string FullName()
        {
            string[] popularNames = {
                "Emma", "Liam", "Olivia", "Noah", "Ava", "Ethan", "Isabella", "Sophia", "Mason", "Mia",
                "Lucas", "Harper", "Logan", "Aria", "Jackson", "Evelyn", "Elijah", "Abigail", "Caden", "Emily",
                "Grayson", "Charlotte", "Michael", "Amelia", "Benjamin", "Chloe", "Carter", "Avery", "William", "Ella",
                "Luke", "Mila", "Daniel", "Lily", "Alexander", "Scarlett", "Owen", "Aubrey", "Jack", "Hazel",
                "Gabriel", "Nora", "Matthew", "Addison", "Henry", "Hannah", "Isaac", "Aaliyah", "Wyatt", "Ellie",
                "Jayden", "Natalie", "Levi", "Sofia", "Oliver", "Camila", "Sebastian", "Ariana", "David", "Eva",
                "Joseph", "Luna", "Caleb", "Emilia", "Samuel", "Aria", "Lincoln", "Makayla", "Anthony", "Peyton",
                "Leo", "Leah", "Jaxon", "Skylar", "Jonathan", "Elizabeth", "Christopher", "Lila", "Joshua", "Brooklyn",
                "Andrew", "Madison", "Grayson", "Eleanor", "Dylan", "Victoria", "Isabelle", "Aurora", "Julian", "Penelope",
                "Nicholas", "Grace", "Dominic", "Stella"
            };
            string[] popularSurnames = {
                "Smith", "Johnson", "Brown", "Taylor", "Miller", "Jones", "Clark", "Allen", "Hall", "Adams",
                "Baker", "Lewis", "Lee", "Walker", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner",
                "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers",
                "Reed", "Cook", "Morgan", "Bell", "Cooper", "Flores", "Gonzalez", "Cruz", "Hughes", "Foster",
                "Gray", "Ward", "Coleman", "Watson", "Sullivan", "Woods", "West", "Jordan", "Owens", "Reynolds",
                "Fisher", "Ellis", "Harrison", "Gibson", "Mcdonald", "Cruz", "Marshall", "Gomez", "Murray", "Freeman",
                "Wells", "Webb", "Simpson", "Porter", "Hunter", "Hicks", "Crawford", "Henry", "Boyd", "Mason",
                "Morales", "Kennedy", "Warren", "Dixon", "Ramos", "Reyes", "Burns", "Gordon", "Shaw", "Holmes",
                "Rice", "Robertson", "Hunt", "Black", "Daniels", "Palmer", "Mills", "Nichols", "Grant", "Knight",
                "Ferguson", "Rose", "Stone", "Hawkins", "Dunn", "Perkins", "Hudson", "Spencer", "Gardner", "Payne"
            };

            Random random = new Random();
            return popularNames[random.Next(popularNames.Length)] + " " + popularSurnames[random.Next(popularSurnames.Length)];
        }

        /// <summary>
        /// Generates a random email address.
        /// </summary>
        /// <returns>A string that represents the email address.</returns>
        private static string Email()
        {
            string[] emailProviders = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com", "aol.com", "icloud.com" };

            string[] usernameChars = { "abcdefghijklmnopqrstuvwxyz", "0123456789", "_-" };

            Random random = new Random();

            string username = "";
            for (int i = 0; i < 8; i++)
            {
                string charSet = usernameChars[random.Next(usernameChars.Length)];
                username += charSet[random.Next(charSet.Length)];
            }

            string emailProvider = emailProviders[random.Next(emailProviders.Length)];

            string email = $"{username}@{emailProvider}";

            return email;
        }

        /// <summary>
        /// Generates a random date and time between January 1, 1900, and December 31, 2023.
        /// </summary>
        /// <returns>A DateTime object that represents the generated date and time.</returns>
        private static DateTime TimeStamp()
        {
            int minYear = 1900;
            int maxYear = 2023;

            Random random = new Random();

            int year = random.Next(minYear, maxYear);
            int month = random.Next(1, 13);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int day = random.Next(1, daysInMonth + 1);

            DateTime randomDateTime = new DateTime(year, month, day);

            return randomDateTime;
        }

        /// <summary>
        /// Generates a random VK ID.
        /// </summary>
        /// <returns>A string that represents the VK ID.</returns>
        private static string VkId()
        {
            Random random = new Random();
            return "id" + random.Next(10000, 99999);
        }

        /// <summary>
        /// Generates a new Contact object with randomly generated values.
        /// </summary>
        /// <returns>A Contact object with randomly generated values.</returns>
        public static Contact getContact()
        {
            return new Contact(FullName(),
            Email(), PhoneNumber(),
            TimeStamp(), VkId());
        }

        public static Contact getEmtyContact()
        {
            return new Contact("",
            "", "",
            TimeStamp(), "");
        }
    }
}
