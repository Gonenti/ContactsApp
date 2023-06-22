namespace ContactsApp.Tests
{
    [TestFixture]
    public class ProjectTests
    {
        private Project _project;

        [Test(Description = "Test project constructor")]
        public void ProjectConstructor_WithValidParameters_CreatesProjectObject()
        {
            // Arrange
            Project project = new Project();

            // Act
            List<Contact> contacts = project.AllContacts;

            // Assert
            Assert.IsNotNull(contacts);
            Assert.AreEqual(0, contacts.Count);
        }

        [Test(Description = "Test getter for all contacts property")]
        public void AllContacts_ShouldGetAllContacts_AllContacts()
        {
            // Arrange
            _project = new Project();
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                        "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Alex394123");
            Contact contact3 = new Contact("Bigi Vivi", "bigi.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Bigi23342");
            _project.AddContact(contact1);
            _project.AddContact(contact2);
            _project.AddContact(contact3);

            // Act
           List<Contact> allContacts = _project.AllContacts;

            // Assert
            Assert.Contains(contact1, allContacts);
            Assert.Contains(contact2, allContacts);
            Assert.Contains(contact3, allContacts);
        }

        [Test(Description = "Test add contact function wit valid parametrs")]
        public void AddContact_ShouldAddContactToList_ContactAddedToList()
        {
            // Arrange
            _project = new Project();
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");

            // Act
            _project.AddContact(contact);

            // Assert
            Assert.Contains(contact, _project.AllContacts);
        }

        [Test(Description = "Test add contact funcion with invalid parametrs")]
        public void AddContact_ShouldThrowArgumentException_ThrowsArgumentException()
        {
            // Arrange
            _project = new Project();
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                            "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");

            // Act
            _project.AddContact(contact);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _project.AddContact(contact));
        }

        [Test(Description = "Test Replace by index method with valid parametrs")]
        public void ReplaceContactByIndex_ShouldReplaceContactAtSpecifiedIndex_ContactHasChangedInTheIndex()
        {
            // Arrange
            _project = new Project();
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                            "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Bigi Vivi", "bigi.doe@example.com", 
                            "+12345678901", new DateTime(1985, 2, 2), "Bigi23342");

            _project.AddContact(contact1);

            // Act
            _project.ReplaceContactByIndex(contact2, 0);

            // Assert
            Assert.AreEqual(1, _project.AllContacts.Count);
            Assert.AreEqual(contact2, _project.AllContacts[0]);
        }

        [Test(Description = "Test to replace contact by negative index")]
        public void ReplaceContactByIndex_ShouldReplaceContactAtSpecifiedIndex_NothingChanged()
        {
            // Arrange
            _project = new Project();
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                            "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Bigi Vivi", "bigi.doe@example.com",
                            "+12345678901", new DateTime(1985, 2, 2), "Bigi23342");

            _project.AddContact(contact1);

            // Act
            _project.ReplaceContactByIndex(contact2, -1);

            // Assert
            Assert.AreEqual(1, _project.AllContacts.Count);
            Assert.AreEqual(contact1, _project.AllContacts[0]);
        }

        [Test(Description = "Test remove contact function with valid parametrs")]
        public void RemoveContact_ShouldRemoveContactFromList_ContactRemovedFromProject()
        {
            // Arrange
            _project = new Project();
            Contact contact = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                        "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            _project.AddContact(contact);

            // Act
            _project.RemoveContact(contact);

            // Assert
            Assert.IsEmpty(_project.AllContacts);
        }

        [Test(Description = "Test sort contacts function")]
        public void SortContactsByFullName_ShouldSortContactsByName_ContactsSorted()
        {
            // Arrange
            int NUMBER_OF_CONTACTS = 6;
            _project = new Project();
            List<Contact> ListOfAddedСontacts = new List<Contact>();
            ListOfAddedСontacts.Add(new Contact("Frank Ferduck", "Ferduck.Frank.2012@gmail.com",
                                                    "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod"));
            ListOfAddedСontacts.Add(new Contact("Elis Juper", "Juper.Elis.1980@gmail.com",
                                                    "+1123-456-7891", new DateTime(1980, 1, 1), "Bekzod"));
            ListOfAddedСontacts.Add(new Contact("Dana Danko", "Danko.Dana.2000@gmail.com",
                                                    "+1123-456-7892", new DateTime(1980, 1, 1), "Bekzod"));
            ListOfAddedСontacts.Add(new Contact("Christopher Colins", "Colins.Christopher.1987@gmail.com",
                                                     "+1123-456-7893", new DateTime(1980, 1, 1), "Bekzod"));
            ListOfAddedСontacts.Add(new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                                     "+1123-456-7894", new DateTime(1980, 1, 1), "Bekzod"));
            ListOfAddedСontacts.Add(new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Alex394123"));

            for (int i = 0; i < NUMBER_OF_CONTACTS; i++) 
            { 
                _project.AddContact(ListOfAddedСontacts[i]);
            }

            // Act
            List<Contact> sortedContacts = _project.SortContactsByFullName();

            // Assert
            for (int i = 0; i < NUMBER_OF_CONTACTS; i++)
            {
                Assert.AreEqual(ListOfAddedСontacts[NUMBER_OF_CONTACTS - i - 1], sortedContacts[i]);
            }
        }

        [Test(Description = "Test sort contact function in empty list")]
        public void SortContactsByFullName_ShouldSortContactsByNameInEmpyList_ContactsSorted()
        {
            // Arrange
            _project = new Project();

            // Act
            List<Contact> sortedContacts = new List<Contact>(); 

            // Assert
            Assert.AreEqual(sortedContacts, _project.SortContactsByFullName());
        }

        [Test(Description = "Test find contact function")]
        public void FindContact_FindContact_FoundContact()
        {
            // Arrange
            _project = new Project();
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                                    "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Alex394123");
            _project.AddContact(contact1);
            _project.AddContact(contact2);


            // Assert
            Assert.AreEqual(0, _project.FindContact(contact1));
        }

        [Test(Description = "Test find contact by substring function")]
        public void FindContactbySubstring_FindContactBySubstring_FoundContact()
        {
            // Arrange
            _project = new Project();
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                                    "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Alex394123");
            _project.AddContact(contact1);
            _project.AddContact(contact2);


            // Assert
            Assert.AreEqual("Bekzod Olimov", _project.GetContactsBySubstring("Bekzod")[0].FullName);
        }

        [Test(Description = "Test find contact by substring in empty list")]
        public void FindContactbySubstring_FindContactBySubstringInEmtyList_FoundContact()
        {
            // Arrange
            _project = new Project();


            // Assert
            Assert.AreEqual(0, _project.GetContactsBySubstring("Bekzod").Count);
        }

        [Test(Description = "Test find contact by birthday function")]
        public void FindContactsBirthday_ReturnsContactsWithMatchingBirthday()
        {
            // Arrange
            Project project = new Project();
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                                    "+1123-456-7890", DateTime.Now, "Bekzod");
            Contact contact2 = new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", DateTime.Now, "Alex394123");
            Contact contact3 = new Contact("Bigi Vivi", "bigi.doe@example.com",
                            "+12345678901", new DateTime(1985, 2, 2), "Bigi23342");
            project.AddContact(contact1);
            project.AddContact(contact2);
            project.AddContact(contact3);

            // Act
            List<Contact> contactsBirthdays = project.FindContactsBirthday();

            // Assert
            Assert.IsNotNull(contactsBirthdays);
            Assert.AreEqual(2, contactsBirthdays.Count);
            CollectionAssert.Contains(contactsBirthdays, contact1);
            CollectionAssert.Contains(contactsBirthdays, contact2);
        }
    }
}

        