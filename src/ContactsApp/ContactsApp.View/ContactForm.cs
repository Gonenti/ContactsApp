namespace ContactsApp.View
{
    using ContactsApp.Model;

    /// <summary>
    /// The ContactForm class represents the form  editing contact.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Represents a set of colors and error messages that can be used to validate and display errors for
        /// user input fields in a form. The "WhiteColor" field represents the default background color of the
        /// input fields, while "ErrorColor" represents the background color to be used when there is an error
        /// in the user's input. The "FullNameError", "EmailError", "PhoneNumberError", and "VKError" fields
        /// represent the error messages to be displayed for each corresponding user input field.
        /// </summary>
        private Color WhiteColor = Color.White;
        private Color ErrorColor = Color.LightPink;
        private string FullNameError = "";
        private string EmailError = "";
        private string PhoneNumberError = "";
        private string VKError = "";

        /// <summary>
        /// Initializes a new instance of the Contact class and assigns it to the _contact field. The new Contact
        /// object is created with randomly generated values for the full name, email, phone number, date of birth,
        /// and Vkontakte ID fields, using the methods provided by the Generator class.
        /// </summary>
        private Contact _contact = Generator.getContact();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactForm"/> class.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        /// <summary>
        /// Filling form fields with data from _contact
        /// </summary>
        private void UpdateForm()
        {

            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            BirthdayDateTimePicker.Text = _contact.DateOfBirth.ToString();
            VKTextBox.Text = _contact.VkontakteId;
        }

        /// <summary>
        /// Event handler for when the mouse enters the "Add Photo" picture box. This changes the image
        /// displayed in the picture box to a "plus" icon, indicating that the user can click on it to
        /// add a new photo.
        /// </summary>
        /// <param name="sender">The object that raised the event (the "Add Photo" picture box).</param>
        /// <param name="e">The event arguments.</param>
        private void AddPhotoPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoPictureBox.Image = Properties.Resources.add_photo_32x32;
        }

        /// <summary>
        /// Event handler for when the mouse leaves the "Add Photo" picture box. This changes the image
        /// displayed in the picture box to a grayed-out "plus" icon, indicating that the user cannot click
        /// on it to add a new photo at this time.
        /// </summary>
        /// <param name="sender">The object that raised the event (the "Add Photo" picture box).</param>
        /// <param name="e">The event arguments.</param>
        private void AddPhotoPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoPictureBox.Image = Properties.Resources.add_photo_32x32_gray;
        }

        /// <summary>
        /// Handles the Click event of the OkButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if(!isErrorsOnForm())
                this.Close();
        }

        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /// <summary>
        /// Handles the TextChanged event of the FullNameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FullNameTextBox.BackColor = WhiteColor;
            try
            {
                _contact.FullName = FullNameTextBox.Text;
            }
            catch (ArgumentException error)
            {
                FullNameTextBox.BackColor = ErrorColor;
                FullNameError = error.Message;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the EmailTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailTextBox.BackColor = WhiteColor;
            try
            {
                _contact.Email = EmailTextBox.Text;
            }
            catch (ArgumentException error)
            {
                EmailTextBox.BackColor = ErrorColor;
                EmailError = error.Message;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the PhoneNumberTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            PhoneNumberTextBox.BackColor = WhiteColor;
            try
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
            }
            catch (ArgumentException error)
            {
                PhoneNumberTextBox.BackColor = ErrorColor;
                PhoneNumberError = error.Message;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the VKTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            VKTextBox.BackColor = WhiteColor;
            try
            {
                _contact.VkontakteId = VKTextBox.Text;
            }
            catch (ArgumentException error)
            {
                VKTextBox.BackColor= ErrorColor;
                VKError = error.Message;
            }
        }

        /// <summary>
        /// Сhecking the form for errors
        /// </summary>
        private bool isErrorsOnForm()
        {
            string error = FullNameError + EmailError + PhoneNumberError + VKError;

            if (error == "")
                return false;
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
    }
}
