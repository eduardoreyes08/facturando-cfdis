using System;
using System.Windows.Forms;

namespace CFD10
{
    partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            lblWebSite.Links.Add(0, lblWebSite.Text.Length, lblWebSite.Text );
        }

        private void lblWebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void lblInvoice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        public static void ShowForm()
        {
            HelpForm helpform;

            try
            {
                helpform = new HelpForm();
                helpform.ShowDialog();
            }
            finally
            {
            }
        }
    }
}
