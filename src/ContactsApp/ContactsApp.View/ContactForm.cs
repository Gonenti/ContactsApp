namespace ContactsApp.View
{
    using ContactsApp.Model;

    /// <summary>
    /// The ContactForm class represents the form  editing contact.
    /// </summary>
    public partial class ContactForm : Form
    {
        private Color WhiteColor = Color.White;
        private Color ErrorColor = Color.LightPink;
        private string FullNameError = "";
        private string EmailError = "";
        private string PhoneNumberError = "";
        private string VKError = "";

        private Contact _contact = new Contact(Generator.FullName(), 
            Generator.Email(),Generator.PhoneNumber(),
            Generator.TimeStamp(),Generator.VkId());

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

        private void AddPhotoPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoPictureBox.Image = Properties.Resources.add_photo_32x32;
        }

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
            if(!checkFormOnErrors())
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
        private bool checkFormOnErrors()
        {
            string error = "";
            if (FullNameError != "") {
                error += $"NameError: {FullNameError}\n";
            }

            if (EmailError != "")
            {
                error += $"EmailError: {EmailError}\n";
            }

            if (PhoneNumberError != "")
            {
                error += $"PhoneNumberError: {PhoneNumberError}\n";
            }

            if (VKError != "")
            {
                error += $"VKError: {VKError}\n";
            }

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
