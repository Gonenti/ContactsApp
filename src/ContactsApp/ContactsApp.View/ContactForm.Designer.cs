namespace ContactsApp.View
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKCancelPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.OKCancelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OKCancelPanel
            // 
            this.OKCancelPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OKCancelPanel.Controls.Add(this.OkButton);
            this.OKCancelPanel.Controls.Add(this.CancelButton);
            this.OKCancelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKCancelPanel.Location = new System.Drawing.Point(0, 306);
            this.OKCancelPanel.Name = "OKCancelPanel";
            this.OKCancelPanel.Size = new System.Drawing.Size(524, 45);
            this.OKCancelPanel.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(356, 10);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.TabStop = false;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(437, 10);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // VKTextBox
            // 
            this.VKTextBox.BackColor = System.Drawing.Color.White;
            this.VKTextBox.Location = new System.Drawing.Point(118, 251);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(150, 23);
            this.VKTextBox.TabIndex = 21;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(118, 233);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 15);
            this.VKLabel.TabIndex = 20;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 179);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(73, 15);
            this.DateOfBirthLabel.TabIndex = 18;
            this.DateOfBirthLabel.Text = "Date of Birth";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(118, 143);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(150, 23);
            this.PhoneNumberTextBox.TabIndex = 17;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 125);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(88, 15);
            this.PhoneNumberLabel.TabIndex = 16;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.BackColor = System.Drawing.Color.White;
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTextBox.Location = new System.Drawing.Point(118, 89);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(394, 23);
            this.EmailTextBox.TabIndex = 15;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(118, 69);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(44, 15);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.BackColor = System.Drawing.Color.White;
            this.FullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 33);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(394, 23);
            this.FullNameTextBox.TabIndex = 13;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(118, 15);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FullNameLabel.TabIndex = 12;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 11;
            this.PhotoPictureBox.TabStop = false;
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(118, 197);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(150, 23);
            this.BirthdayDateTimePicker.TabIndex = 22;
            // 
            // AddPhotoPictureBox
            // 
            this.AddPhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoPictureBox.Location = new System.Drawing.Point(30, 118);
            this.AddPhotoPictureBox.Name = "AddPhotoPictureBox";
            this.AddPhotoPictureBox.Size = new System.Drawing.Size(63, 33);
            this.AddPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoPictureBox.TabIndex = 23;
            this.AddPhotoPictureBox.TabStop = false;
            this.AddPhotoPictureBox.MouseEnter += new System.EventHandler(this.AddPhotoPictureBox_MouseEnter);
            this.AddPhotoPictureBox.MouseLeave += new System.EventHandler(this.AddPhotoPictureBox_MouseLeave);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 351);
            this.Controls.Add(this.AddPhotoPictureBox);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.VKTextBox);
            this.Controls.Add(this.OKCancelPanel);
            this.Controls.Add(this.VKLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.OKCancelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel OKCancelPanel;
        private Button OkButton;
        private Button CancelButton;
        private TextBox VKTextBox;
        private Label VKLabel;
        private Label DateOfBirthLabel;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private PictureBox PhotoPictureBox;
        private DateTimePicker BirthdayDateTimePicker;
        private PictureBox AddPhotoPictureBox;
    }
}