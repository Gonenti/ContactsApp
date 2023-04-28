using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ContactsApp.Model;
namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private Random random = new Random();
        private Project _project = new Project();

        
        public MainForm()
        {
            InitializeComponent();
            var form = new ContactForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Clears the selected object by resetting all text boxes to empty strings.
        /// </summary>
        private void ClearSelectedObject()
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
        private void UpdateSelectedObject(int index)
        {
            List<Contact> contacts = _project.GetAllContacts();

            FullNameTextBox.Text = contacts[index].FullName;
            EmailTextBox.Text = contacts[index].Email;
            PhoneNumberTextBox.Text = contacts[index].PhoneNumber;
            DateOfBirthtextBox.Text = contacts[index].DateOfBirth.ToString();
            VKTextBox.Text = contacts[index].VkontakteId;

        }

        /// <summary>
        /// Removes the contact at the specified index, and updates the list.
        /// </summary>
        /// <param name="index">The index of the contact to remove.</param>
        private void RemoveContact(int index)
        {
            if (index == -1) return;

            List<Contact> contacts = _project.GetAllContacts();
            if (MessageBox.Show($"Do you really want to remove {contacts[index].FullName}", 
                "Delete contact",
                MessageBoxButtons.OKCancel) 
                == DialogResult.Cancel) return;

            _project.RemoveContact(contacts[index]);
            UpdateList();

        }

        /// <summary>
        /// Adds a new contact to the project with generated information, and updates the list.
        /// </summary>
        private void AddContact()
        {
            Contact contact = new Contact(Generator.FullName(), Generator.Email(), 
                                        Generator.PhoneNumber(), Generator.TimeStamp(),
                                        Generator.VkId());
            _project.AddContact(contact);
        }

        /// <summary>
        /// Updates the ContactsListBox with the last name of each contact in the project.
        /// </summary>
        private void UpdateList()
        {
            // Clear all elements from the list
            ContactsListBox.Items.Clear();

            // Get the contacts from the project
            List<Contact> contacts = _project.GetAllContacts();

            // Add the last name of each contact to the list
            foreach (Contact contact in contacts)
            {
                ContactsListBox.Items.Add(contact.FullName);
            }
        }

        /// <summary>
        /// Handles the click event for the AddContactButton by adding a new contact to the project, updating the list.
        /// </summary>
        /// <param name="sender">The control that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            
            AddContact();
            UpdateList();
            //var form = new ContactForm();
            //form.ShowDialog();
        }

        /// <summary>
        /// Handles the click event for the EditContactButton by adding a new contact to the project, updating the list.
        /// </summary>
        /// <param name="sender">The control that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateList();
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
        /// Handles the Click event of the BirthdayPanelCloseButton control.
        /// Hides the birthday panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible= false;
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
            if (ContactsListBox.SelectedIndex == -1) ClearSelectedObject();
            UpdateSelectedObject(ContactsListBox.SelectedIndex);
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
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}