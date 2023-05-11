namespace ContactsApp.View
{

    using ContactsApp.Model;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;

    public partial class MainForm : Form
    {
        /// <summary>
        /// Creating a new object of type project
        /// </summary>
        private Project _project = new Project();
        private ProjectSerializer _projectSerializer = new ProjectSerializer();
        public MainForm()
        {
            InitializeComponent();
            _project = _projectSerializer.LoadFromFile();
            UpdateList();
        }

        /// <summary>
        /// Clears the selected object by resetting all text boxes to empty strings.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            DateOfBirthtextBox.Text = "";
            VKTextBox.Text = "";
        }

        /// <summary>
        /// Updates the selected object by filling in text boxes with the information from the selected contact.
        /// </summary>
        /// <param name="index">The index of the selected contact.</param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1) return;
            if (_project.AllContacts.Count == 0) return;
            List<Contact> foundedContacts = _project.GetContactsBySubstring(FindTextBox.Text);
            Contact contact = foundedContacts[index];
            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            DateOfBirthtextBox.Text = contact.DateOfBirth.ToString();
            VKTextBox.Text = contact.VkontakteId;
        }

        /// <summary>
        /// Removes the contact at the specified index, and updates the list.
        /// </summary>
        /// <param name="index">The index of the contact to remove.</param>
        private void RemoveContact(int index)
        {
            if (index == -1) return;

            List<Contact> foundedContacts = _project.GetContactsBySubstring(FindTextBox.Text);
            if (MessageBox.Show($"Do you really want to remove {foundedContacts[index].FullName}", 
                "Delete contact",
                MessageBoxButtons.OKCancel) 
                == DialogResult.Cancel) return;

            int projectIndex = _project.FindContact(foundedContacts[index]);
            _project.RemoveContact(_project.AllContacts[projectIndex]);
            if (foundedContacts.Count == index + 1)
            {
                UpdateSelectedContact(0);
            }
            else
            {
                UpdateSelectedContact(index);
            }
            UpdateList();
            _projectSerializer.SaveToFile(_project);

        }

        /// <summary>
        /// Adds a new contact to the project with generated information, and updates the list.
        /// </summary>
        private void AddContact(Contact contact)
        {
            try
            {
                _project.AddContact(contact);
                _projectSerializer.SaveToFile(_project);
            }
            catch (ArgumentException error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditContact(int index)
        {
            if (index == -1) return;
            List<Contact> foundedContacts = _project.GetContactsBySubstring(FindTextBox.Text);
            Contact selectedContact = foundedContacts[index].Clone();
            var contactForm = new ContactForm();
            contactForm.Contact = selectedContact;
            contactForm.ShowDialog();

            if (contactForm.CancelFlag) return;
            Contact updatedData = contactForm.Contact;
            int projectIndex = _project.FindContact(foundedContacts[index]);
            _project.InsertContactByIndex(updatedData, projectIndex);
            UpdateSelectedContact(index);
            UpdateList();
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// Updates the ContactsListBox with the last name of each contact in the project.
        /// </summary>
        private void UpdateList()
        {
            // Clear all elements from the list
            ContactsListBox.Items.Clear();

            // Get the contacts from the project
            List<Contact> contacts = _project.SortContactsByFullName();


            // Add the last name of each contact to the list
            foreach (Contact contact in contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// Handles the FormClosing event of the MainForm control.
        /// Asks the user to confirm the exit action.
        /// If the user selects Yes, exits the application.
        /// Otherwise, cancels the closing event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
                _projectSerializer.SaveToFile(_project);
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Handles the click event for the AddContactButton by adding a new contact to the project, updating the list.
        /// </summary>
        /// <param name="sender">The control that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var contactForm = new ContactForm();
            contactForm.ShowDialog();

            if (contactForm.CancelFlag) return;
            var updatedData = contactForm.Contact;
            AddContact(updatedData);
            UpdateList();
            
        }

        /// <summary>
        /// Handles the click event for the EditContactButton by adding a new contact to the project, updating the list.
        /// </summary>
        /// <param name="sender">The control that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Handles the click event for the RemoveContactButton by removing the selected contact from the project and updating the list.
        /// </summary>
        /// <param name="sender">The control that triggered the event.</param>
        /// <param name="e">The event arguments.</param>s
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Sets the image and background color of the AddContactButton when the mouse enters the button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }


        /// <summary>
        /// Handles the KeyDown event for the MainForm and shows the AboutForm when the F1 key is pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The KeyEventArgs for the event.</param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var form = new AboutForm();
                form.Show();
            }
        }

        /// <summary>
        /// Resets the image and background color of the AddContactButton when the mouse leaves the button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Sets the image and background color of the EditContactButton when the mouse enters the button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Resets the image and background color of the EditContactButton when the mouse leaves the button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Sets the image and background color of the RemoveContactButton when the mouse enters the button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// Resets the image and background color of the RemoveContactButton when the mouse leaves the button.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Handles the Click event of the BirthdayPanelCloseButton control.
        /// Hides the birthday panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ContactsListBox control.
        /// If the selected index is -1, clears the selected object.
        /// Otherwise, updates the selected object with the selected index.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) ClearSelectedContact();
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Contact>  foundedContact = _project.GetContactsBySubstring(FindTextBox.Text);

            ContactsListBox.Items.Clear();
            foreach (Contact contact in foundedContact)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }
    }
}