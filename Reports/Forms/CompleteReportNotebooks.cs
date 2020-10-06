using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports.Forms
{
    public partial class CompleteReportNotebooks : Form
    {
        public CompleteReportNotebooks()
        {
            InitializeComponent();
        }

        private void CompleteReportNotebooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsDataSet.vwAll_Notebooks' table. You can move, or remove it, as needed.
            this.vwAll_NotebooksTableAdapter.Fill(this.reportsDataSet.vwAll_Notebooks);

            this.reportViewer1.RefreshReport();
        }
    }
}
