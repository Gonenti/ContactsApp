namespace ContactsApp.View
{
    using System.Diagnostics;
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

        /// <summary>
        /// Handles the LinkClicked event of the GithubLinkLabel control.
        /// Changes the color of the link text by setting LinkVisited to true
        /// and opens a URL in the default browser.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A LinkLabelLinkClickedEventArgs that contains the event data.</param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            GithubLinkLabel.LinkVisited = true;
            //with a URL:
            var parameter = new ProcessStartInfo { Verb = "open", FileName = "explorer", Arguments = "https://github.com/Gonenti" };
            Process.Start(parameter);

        }

        /// <summary>
        /// Handles the LinkClicked event of the IconLinkLabel control.
        /// Changes the color and the active area of the link text by setting LinkVisited
        /// and LinkArea properties to true and opens a URL in the default browser.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A LinkLabelLinkClickedEventArgs that contains the event data.</param>
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

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }

}
