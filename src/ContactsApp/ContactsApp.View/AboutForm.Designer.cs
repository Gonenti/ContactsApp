namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.GmailLabel = new System.Windows.Forms.Label();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.WhereWereThePhotosTakenLabel = new System.Windows.Forms.Label();
            this.IconLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OKPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.OKPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactsAppLabel.Location = new System.Drawing.Point(17, 47);
            this.ContactsAppLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(231, 58);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            this.ContactsAppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(24, 105);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(50, 25);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v 1.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(24, 157);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(57, 25);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Autor";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(24, 245);
            this.GithubLabel.Margin = new System.Windows.Forms.Padding(4, 17, 4, 0);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(65, 25);
            this.GithubLabel.TabIndex = 3;
            this.GithubLabel.Text = "Github";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(24, 198);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 17, 4, 5);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(61, 25);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(124, 157);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(133, 25);
            this.FullNameLabel.TabIndex = 5;
            this.FullNameLabel.Text = "Olimov Bekzod";
            // 
            // GmailLabel
            // 
            this.GmailLabel.AutoSize = true;
            this.GmailLabel.Location = new System.Drawing.Point(124, 198);
            this.GmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GmailLabel.Name = "GmailLabel";
            this.GmailLabel.Size = new System.Drawing.Size(274, 25);
            this.GmailLabel.TabIndex = 6;
            this.GmailLabel.Text = "olimov.bekzod.2002@gmail.com";
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.AutoSize = true;
            this.GithubLinkLabel.Location = new System.Drawing.Point(124, 245);
            this.GithubLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(231, 25);
            this.GithubLinkLabel.TabIndex = 7;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "https:\\\\github.com\\Gonenti";
            this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.BackColor = System.Drawing.Color.White;
            this.LicenseTextBox.Location = new System.Drawing.Point(24, 297);
            this.LicenseTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LicenseTextBox.Multiline = true;
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.ReadOnly = true;
            this.LicenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LicenseTextBox.Size = new System.Drawing.Size(705, 257);
            this.LicenseTextBox.TabIndex = 8;
            this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            // 
            // WhereWereThePhotosTakenLabel
            // 
            this.WhereWereThePhotosTakenLabel.AutoSize = true;
            this.WhereWereThePhotosTakenLabel.Location = new System.Drawing.Point(24, 562);
            this.WhereWereThePhotosTakenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WhereWereThePhotosTakenLabel.Name = "WhereWereThePhotosTakenLabel";
            this.WhereWereThePhotosTakenLabel.Size = new System.Drawing.Size(329, 25);
            this.WhereWereThePhotosTakenLabel.TabIndex = 9;
            this.WhereWereThePhotosTakenLabel.Text = "All used  images are downloaded from: ";
            // 
            // IconLinkLabel
            // 
            this.IconLinkLabel.AutoSize = true;
            this.IconLinkLabel.Location = new System.Drawing.Point(326, 562);
            this.IconLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IconLinkLabel.Name = "IconLinkLabel";
            this.IconLinkLabel.Size = new System.Drawing.Size(102, 25);
            this.IconLinkLabel.TabIndex = 10;
            this.IconLinkLabel.TabStop = true;
            this.IconLinkLabel.Text = "icons8.com";
            this.IconLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IconLinkLabel_LinkClicked);
            // 
            // OKPanel
            // 
            this.OKPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OKPanel.Controls.Add(this.OKButton);
            this.OKPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OKPanel.Location = new System.Drawing.Point(0, 582);
            this.OKPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OKPanel.Name = "OKPanel";
            this.OKPanel.Size = new System.Drawing.Size(740, 75);
            this.OKPanel.TabIndex = 11;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(624, 17);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(107, 38);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 657);
            this.Controls.Add(this.OKPanel);
            this.Controls.Add(this.IconLinkLabel);
            this.Controls.Add(this.WhereWereThePhotosTakenLabel);
            this.Controls.Add(this.LicenseTextBox);
            this.Controls.Add(this.GithubLinkLabel);
            this.Controls.Add(this.GmailLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(762, 713);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.OKPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ContactsAppLabel;
        private Label VersionLabel;
        private Label AuthorLabel;
        private Label GithubLabel;
        private Label EmailLabel;
        private Label FullNameLabel;
        private Label GmailLabel;
        private LinkLabel GithubLinkLabel;
        private TextBox LicenseTextBox;
        private Label WhereWereThePhotosTakenLabel;
        private LinkLabel IconLinkLabel;
        private Panel OKPanel;
        private Button OKButton;
    }
}