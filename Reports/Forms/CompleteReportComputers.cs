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
    public partial class CompleteReportComputers : Form
    {
        public CompleteReportComputers()
        {
            InitializeComponent();
        }

        private void CompleteReportComputers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsDataSet.vwAll_Computers' table. You can move, or remove it, as needed.
            this.vwAll_ComputersTableAdapter.Fill(this.reportsDataSet.vwAll_Computers);
            this.reportViewerCompleteReportsComputers.RefreshReport();
        }
    }
}
