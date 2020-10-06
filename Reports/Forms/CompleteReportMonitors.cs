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
    public partial class CompleteReportMonitors : Form
    {
        public CompleteReportMonitors()
        {
            InitializeComponent();
        }

        private void CompleteReportMonitors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsDataSet.vwAll_Monitors' table. You can move, or remove it, as needed.
            this.vwAll_MonitorsTableAdapter.Fill(this.reportsDataSet.vwAll_Monitors);

            this.reportViewer1.RefreshReport();
        }
    }
}
