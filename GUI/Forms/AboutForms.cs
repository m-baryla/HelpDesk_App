using System;
using System.Windows.Forms;

namespace HelpDesk_DB.UIDesign.Forms
{
    public partial class AboutForms : Form
    {
        public AboutForms()
        {
            InitializeComponent();
        }
        private void buttonCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
