using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public static class Generator
    {
        public static string PhoneNumber()
        {
            Random random = new Random();
            return "+" + random.Next(10000, 99999).ToString() + random.Next(100000, 999999).ToString();
        }

        public static string FullName()
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

        public static string Email()
        {
            // Array of common email providers
            string[] emailProviders = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com", "aol.com", "icloud.com" };

            // Array of possible characters for the username
            string[] usernameChars = { "abcdefghijklmnopqrstuvwxyz", "0123456789", "_-." };

            Random random = new Random();

            string username = "";
            for (int i = 0; i < 8; i++)
            {
                string charSet = usernameChars[random.Next(usernameChars.Length)];
                username += charSet[random.Next(charSet.Length)];
            }

            // Randomly select an email provider
            string emailProvider = emailProviders[random.Next(emailProviders.Length)];

            // Combine the username and email provider to create the email address
            string email = $"{username}@{emailProvider}";

            return email;
        }

        public static DateTime TimeStamp()
        {
            // Set the range of years you want to generate a DateTime within
            int minYear = 1900;
            int maxYear = 2023;

            Random random = new Random();

            // Generate a random year, month, and day
            int year = random.Next(minYear, maxYear);
            int month = random.Next(1, 13);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int day = random.Next(1, daysInMonth + 1);

            // Create the DateTime object using the randomly generated values
            DateTime randomDateTime = new DateTime(year, month, day);

            return randomDateTime;
        }

        public static string VkId()
        {
            Random random = new Random();
            return "https://vk.com/id" + random.Next(10000, 99999);
        }
    }
}
