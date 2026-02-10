using System;
using System.Windows.Forms;
using ElectronicDocumentLibrary;

namespace CFD10
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblWebSite.Links.Add(0, lblWebSite.Text.Length, lblWebSite.Text );
            lblInvoice.Links.Add(0, lblInvoice.Text.Length, lblInvoice.Text);
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
            AboutForm aboutform;

            try
            {
                aboutform = new AboutForm();
                aboutform.ShowDialog();
            }
            finally
            {
            }
        }

        private void AboutForm_Shown(object sender, EventArgs e)
        {
            lblVersion.Text = "Versión";
        }
    }
}
