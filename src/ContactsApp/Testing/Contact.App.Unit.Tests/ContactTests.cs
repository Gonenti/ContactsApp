using ContactsApp.Model;

namespace ContactsApp.Tests
{
    [TestFixture]
    public class ContactTests
    {

        [Test(Description ="Test Contact default constructor")]
        public void ContactConstructorByDefault_WithValidParameters_CreatesContactObject()
        {
            // Act
            Contact contact = new Contact();

            // Assert
            Assert.IsNotNull(contact);
            Assert.AreEqual(null, contact.FullName);
            Assert.AreEqual(null, contact.Email);
            Assert.AreEqual(null, contact.PhoneNumber);
            Assert.Less(contact.DateOfBirth, DateTime.Now);
            Assert.AreEqual(null, contact.VkontakteId);
        }

        [Test(Description = "Test Contact constructor with parametrs")]
        public void ContactConstructor_WithValidParameters_CreatesContactObject()
        {
            // Arrange
            string fullName = "Bekzod Olimov";
            string email = "Olimov.bekzod.2002@gmail.com";
            string phoneNumber = "+1123-456-7890";
            DateTime dateOfBirth = new DateTime(1990, 1, 1);
            string vkontakteId = "1234567890";

            // Act
            Contact contact = new Contact(fullName, email, phoneNumber, dateOfBirth, vkontakteId);

            // Assert
            Assert.IsNotNull(contact);
            Assert.AreEqual(fullName, contact.FullName);
            Assert.AreEqual(email, contact.Email);
            Assert.AreEqual(phoneNumber, contact.PhoneNumber);
            Assert.AreEqual(dateOfBirth, contact.DateOfBirth);
            Assert.AreEqual(vkontakteId, contact.VkontakteId);
        }

        [Test(Description = "Test getter for full name field")]
        public void FullName_Getter_ReturnsFullName()
        {
            // Arrange
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                        "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");

            // Assert
            Assert.AreEqual("Bekzod Olimov", contact.FullName);
        }

        [Test(Description = "Test getter for email field")]
        public void Email_Getter_ReturnsEmail()
        {
            // Arrange
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                        "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            // Assert
            Assert.AreEqual("Olimov.bekzod.2002@gmail.com", contact.Email);
        }

        [Test(Description = "Test getter for Phone number field")]
        public void PhoneNumber_Getter_ReturnsPhoneNumber()
        {
            // Arrange
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                        "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            
            // Assert
            Assert.AreEqual("+1123-456-7890", contact.PhoneNumber);
        }

        [Test(Description = "Test getter for fate of birth field")]
        public void DateOfBirth_Getter_ReturnsDateOfBirth()
        {
            // Arange
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                        "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            // Assert
            Assert.AreEqual(new DateTime(1980, 1, 1), contact.DateOfBirth);
        }

        [Test(Description = "Test getter for Vk id field")]
        public void VkontakteId_Getter_ReturnsVkontakteId()
        {
            // Arange
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                        "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod123");
            // Assert
            Assert.AreEqual("Bekzod123", contact.VkontakteId);
        }

        [Test(Description = "Test clone function")]
        public void Clone_SetValidParameters_CreatesCopyOfContactObject()
        {
            // Arrange
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com", "+1123-456-7890",
                                       new DateTime(1990, 1, 1), "1234567890");
            // Act
            Contact clonedContact = contact.Clone();

            // Assert
            Assert.IsNotNull(clonedContact);
            Assert.AreEqual(contact.FullName, clonedContact.FullName);
            Assert.AreEqual(contact.Email, clonedContact.Email);
            Assert.AreEqual(contact.PhoneNumber, clonedContact.PhoneNumber);
            Assert.AreEqual(contact.DateOfBirth, clonedContact.DateOfBirth);
            Assert.AreEqual(contact.VkontakteId, clonedContact.VkontakteId);
        }

        [TestCase("", TestName = "An exception should be generated if FullName emty")]
        [TestCase("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
            TestName = "An exception should be generated if FullNme longer 100 symbols")]
        public void FullNameSetter_SetInvalidParameters_ThrowsArgumentException(string fullName)
        {
            // Arrange
            Contact contact = new Contact();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => contact.FullName = fullName);
            Assert.Throws<ArgumentException>(() => contact.FullName = fullName);
        }

        [TestCase("", TestName = "An exception should be generated if Email emty")]
        [TestCase(
            "OOOOOOOOOOOOOOOOOOOOOOOO@OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOgmail.com",
            TestName = "An exception should be generated if Email longer 100 symbols")]
        [TestCase("Olimov.bekzod.2002gmail.com",
            TestName = "An exception should be generated if Email does't consist '@'")]
        public void EmailSetter_SetInvalidParameters_ThrowsArgumentException(string email)
        {
            // Arrange
            Contact contact = new Contact();

            // Assert
            Assert.Throws<ArgumentException>(() => contact.Email = email);
        }

        [TestCase("", 
            TestName = "An exception should be generated if PhoneNumber emty")]
        [TestCase("13456v8909",
            TestName = "An exception should be generated if PhoneNumber includes prohibited symbols")]
        [TestCase("13213132123123-456-7890",
            TestName = "An exception should be generated if PhoneNumber longer 11 digits")]
        [TestCase("13",
            TestName = "An exception should be generated if PhoneNumber shorter 11 digits")]
        public void PhoneNumberSetter_SetInvalidParameters_ThrowsArgumentException(string phoneNumber)
        {
            // Arrange
            Contact contact = new Contact();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => contact.PhoneNumber = phoneNumber);
        }

        [TestCase("1890-01-01",
            TestName = "An exception should be generated if DateOfBirth is earlier than 1900")]
        [TestCase("2030-01-01",
            TestName = "An exception should be generated if DateOfBirth is older than now")]
        public void DateOfBirthSetter_SetInvalidParameters_ThrowsArgumentException(string dateOfBirth)
        {
            // Arrange
            Contact contact = new Contact();

            // Assert
            Assert.Throws<ArgumentException>(() => contact.DateOfBirth = DateTime.Parse(dateOfBirth));
        }

        [TestCase("",
            TestName = "An exception should be generated if VkontakteId emty")]
        [TestCase("123456789012345678901234567890123456789012345678901234567890",
            TestName = "An exception should be generated if VkontakteId longer 50 symbols")]
        public void VkontakteIdSetter_SetInvalidParameters_ThrowsArgumentException(string vkontakteId)
        {
            // Arrange
            Contact contact = new Contact();

            // Assert
            Assert.Throws<ArgumentException>(() => contact.VkontakteId = vkontakteId);
        }
    }
}