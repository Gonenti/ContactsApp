using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContactsApp.View
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            GithubLinkLabel.LinkVisited = true;
            //with a URL:
            var parameter = new ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://github.com/Gonenti" };
            Process.Start(parameter);

        }

        private void IconLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Change the color of the link text by setting LinkVisited
            // to true.
            GithubLinkLabel.LinkVisited = true;
            GithubLinkLabel.LinkArea = new LinkArea(11, 4);
            //with a URL:
            var parameter = new ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://disk.yandex.ru/d/xkREY5uu1A6czA" };
            Process.Start(parameter);
        }
    }

}
