namespace ContactsApp.Tests
{
    [TestFixture]
    public class ProjectTests
    {
        private Project _project;

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        public void SortContactsByFullName_ShouldSortContactsByName_ContactsSorted()
        {
            // Arrange
            _project = new Project();
            Contact contact1 = new Contact("Frank Ferduck", "Ferduck.Frank.2012@gmail.com",
                                                    "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Elis Juper", "Juper.Elis.1980@gmail.com",
                                                    "+1123-456-7891", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact3 = new Contact("Dana Danko", "Danko.Dana.2000@gmail.com",
                                                    "+1123-456-7892", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact4 = new Contact("Christopher Colins", "Colins.Christopher.1987@gmail.com",
                                                    "+1123-456-7893", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact5 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                                    "+1123-456-7894", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact6 = new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Alex394123");
            _project.AddContact(contact1);
            _project.AddContact(contact2);
            _project.AddContact(contact3);
            _project.AddContact(contact4);
            _project.AddContact(contact5);
            _project.AddContact(contact6);

            // Act
            List<Contact> sortedContacts = _project.SortContactsByFullName();

            // Assert
            Assert.AreEqual(contact6, sortedContacts[0]);
            Assert.AreEqual(contact5, sortedContacts[1]);
            Assert.AreEqual(contact4, sortedContacts[2]);
            Assert.AreEqual(contact3, sortedContacts[3]);
            Assert.AreEqual(contact2, sortedContacts[4]);
            Assert.AreEqual(contact1, sortedContacts[5]);
        }

        [Test]
        public void SortContactsByFullName_ShouldSortContactsByNameInEmpyList_ContactsSorted()
        {
            // Arrange
            _project = new Project();

            // Act
            List<Contact> sortedContacts = new List<Contact>(); 

            // Assert
            Assert.AreEqual(sortedContacts, _project.SortContactsByFullName());
        }

        [Test]
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

        [Test]
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

        [Test]
        public void FindContactbySubstring_FindContactBySubstringInEmtyList_FoundContact()
        {
            // Arrange
            _project = new Project();


            // Assert
            Assert.AreEqual(0, _project.GetContactsBySubstring("Bekzod").Count);
        }

        [Test]
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

        