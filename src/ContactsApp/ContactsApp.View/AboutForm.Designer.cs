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
            this.VersionLlabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.GmailLabel = new System.Windows.Forms.Label();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IconLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OKPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.OKPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactsAppLabel.Location = new System.Drawing.Point(12, 28);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(162, 35);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            this.ContactsAppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactsAppLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // VersionLlabel
            // 
            this.VersionLlabel.AutoSize = true;
            this.VersionLlabel.Location = new System.Drawing.Point(17, 63);
            this.VersionLlabel.Name = "VersionLlabel";
            this.VersionLlabel.Size = new System.Drawing.Size(31, 15);
            this.VersionLlabel.TabIndex = 1;
            this.VersionLlabel.Text = "v 1.0";
            this.VersionLlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(17, 94);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(37, 15);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Autor";
            // 
            // GithubLabel
            // 
            this.GithubLabel.AutoSize = true;
            this.GithubLabel.Location = new System.Drawing.Point(17, 147);
            this.GithubLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.GithubLabel.Name = "GithubLabel";
            this.GithubLabel.Size = new System.Drawing.Size(43, 15);
            this.GithubLabel.TabIndex = 3;
            this.GithubLabel.Text = "Github";
            this.GithubLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(17, 119);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 15);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "E-mail";
            this.EmailLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(87, 94);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(87, 15);
            this.FullNameLabel.TabIndex = 5;
            this.FullNameLabel.Text = "Olimov Bekzod";
            this.FullNameLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // GmailLabel
            // 
            this.GmailLabel.AutoSize = true;
            this.GmailLabel.Location = new System.Drawing.Point(87, 119);
            this.GmailLabel.Name = "GmailLabel";
            this.GmailLabel.Size = new System.Drawing.Size(180, 15);
            this.GmailLabel.TabIndex = 6;
            this.GmailLabel.Text = "olimov.bekzod.2002@gmail.com";
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.AutoSize = true;
            this.GithubLinkLabel.Location = new System.Drawing.Point(87, 147);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(156, 15);
            this.GithubLinkLabel.TabIndex = 7;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "https:\\\\github.com\\Gonenti";
            this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.Location = new System.Drawing.Point(17, 178);
            this.LicenseTextBox.Multiline = true;
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.Size = new System.Drawing.Size(495, 156);
            this.LicenseTextBox.TabIndex = 8;
            this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "All used  images are downloaded from: ";
            // 
            // IconLinkLabel
            // 
            this.IconLinkLabel.AutoSize = true;
            this.IconLinkLabel.Location = new System.Drawing.Point(228, 337);
            this.IconLinkLabel.Name = "IconLinkLabel";
            this.IconLinkLabel.Size = new System.Drawing.Size(68, 15);
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
            this.OKPanel.Location = new System.Drawing.Point(0, 366);
            this.OKPanel.Name = "OKPanel";
            this.OKPanel.Size = new System.Drawing.Size(524, 45);
            this.OKPanel.TabIndex = 11;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(437, 10);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 411);
            this.Controls.Add(this.OKPanel);
            this.Controls.Add(this.IconLinkLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LicenseTextBox);
            this.Controls.Add(this.GithubLinkLabel);
            this.Controls.Add(this.GmailLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLlabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.OKPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ContactsAppLabel;
        private Label VersionLlabel;
        private Label AuthorLabel;
        private Label GithubLabel;
        private Label EmailLabel;
        private Label FullNameLabel;
        private Label GmailLabel;
        private LinkLabel GithubLinkLabel;
        private TextBox LicenseTextBox;
        private Label label8;
        private LinkLabel IconLinkLabel;
        private Panel OKPanel;
        private Button OKButton;
    }
}