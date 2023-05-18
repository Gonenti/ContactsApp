namespace ContactsApp.View
{
    using ContactsApp.Model;

    /// <summary>
    /// The ContactForm class represents the form  editing contact.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Error flag 
        /// </summary>
        private bool _ErorFlag = true;

        /// <summary>
        /// Represents a white color for user input fields in a form. 
        /// </summary>
        private Color _whiteColor = Color.White;

        /// <summary>
        /// Represents a LightPink color for erorr in user input fields in a form. 
        /// </summary>
        private Color _errorColor = Color.LightPink;

        /// <summary>
        /// store information about Full name error
        /// </summary>
        private string _fullNameError = "";

        /// <summary>
        /// store information about email error
        /// </summary>
        private string _emailError = "";

        /// <summary>
        /// store information about Phone Number error
        /// </summary>
        private string _phoneNumberError = "";

        /// <summary>
        /// store information about Vk error
        /// </summary>
        private string _vkError = "";

        /// <summary>
        /// Initializes a new instance of the Contact class and assigns it to the _contact field. The new Contact
        /// object is created with randomly generated values for the full name, email, phone number, date of birth,
        /// and Vkontakte ID fields, using the methods provided by the Generator class.
        /// </summary>
        private Contact _contact = new Contact();

        public bool CancelFlag
        {
            get
            {
                return _ErorFlag;
            }
        }

        /// <summary>
        /// property for the contact field
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                UpdateForm();
            }
        }

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
            if (!isErrorsOnForm())
            {
                this.Close();
            }
        }

        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            _ErorFlag= true;
            this.Close();
        }

        /// <summary>
        /// Handles the TextChanged event of the FullNameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

            _fullNameError = "";
            FullNameTextBox.BackColor = _whiteColor;
            try
            {
                _contact.FullName = FullNameTextBox.Text;
            }
            catch (ArgumentException error)
            {
                FullNameTextBox.BackColor = _errorColor;
                _fullNameError = error.Message;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the EmailTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            _emailError = "";
            EmailTextBox.BackColor = _whiteColor;
            try
            {
                _contact.Email = EmailTextBox.Text;
            }
            catch (ArgumentException error)
            {
                EmailTextBox.BackColor = _errorColor;
                _emailError = error.Message;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the PhoneNumberTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            _phoneNumberError = "";
            PhoneNumberTextBox.BackColor = _whiteColor;
            try
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
            }
            catch (ArgumentException error)
            {
                PhoneNumberTextBox.BackColor = _errorColor;
                _phoneNumberError = error.Message;
            }
        }

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _contact.DateOfBirth = BirthdayDateTimePicker.Value;
        }

        /// <summary>
        /// Handles the TextChanged event of the VKTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            _vkError = "";
            VKTextBox.BackColor = _whiteColor;
            try
            {
                _contact.VkontakteId = VKTextBox.Text;
            }
            catch (ArgumentException error)
            {
                VKTextBox.BackColor= _errorColor;
                _vkError = error.Message;
            }
        }

        /// <summary>
        /// Сhecking the form for errors
        /// </summary>_fullNameError
        private bool isErrorsOnForm()
        {
            string error = _fullNameError + _emailError + _phoneNumberError + _vkError;
            if (FullNameTextBox.Text.Equals("") || 
            EmailTextBox.Text.Equals("") ||
            PhoneNumberTextBox.Text.Equals("") ||
            PhoneNumberTextBox.Text.Equals("") ||
            BirthdayDateTimePicker.Text.Equals("") ||
            VKTextBox.Text.Equals(""))
            {
                error = "fill in the empty fields"; 
            }

            if ((error == ""))
                _ErorFlag = false;
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ErorFlag = true;
            }
            return _ErorFlag;
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
