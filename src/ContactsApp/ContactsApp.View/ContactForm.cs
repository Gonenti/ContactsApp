using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ContactsApp.View
{
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
        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

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

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(!checkFormOnErrors())
                this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

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
