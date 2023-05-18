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
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                                    "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Alex394123");
            _project.AddContact(contact2);
            _project.AddContact(contact1);

            // Act
            List<Contact> sortedContacts = _project.SortContactsByFullName();

            // Assert
            Assert.AreEqual(contact2, sortedContacts[0]);
            Assert.AreEqual(contact1, sortedContacts[1]);
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


            // ACT & Assert
            Assert.AreEqual(0, _project.FindContact(contact1));
        }

        [Test]
        public void FindContactbySubstring_FindContactSubstring_FoundContact()
        {
            // Arrange
            _project = new Project();
            Contact contact1 = new Contact("Bekzod Olimov", "Olimov.bekzod.2002@gmail.com",
                                                    "+1123-456-7890", new DateTime(1980, 1, 1), "Bekzod");
            Contact contact2 = new Contact("Alex Vovorunov", "Alex.doe@example.com",
                                        "+12345678901", new DateTime(1985, 2, 2), "Alex394123");
            _project.AddContact(contact1);
            _project.AddContact(contact2);


            // ACT & Assert
            Assert.AreEqual("Bekzod Olimov", _project.GetContactsBySubstring("Bekzod")[0].FullName);
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

        