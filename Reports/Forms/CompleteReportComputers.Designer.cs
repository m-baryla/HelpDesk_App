namespace Reports.Forms
{
    partial class CompleteReportComputers
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerCompleteReportsComputers = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportsDataSet = new Reports.DataSet.ReportsDataSet();
            this.vwAllComputersBindingSource = new System.Windows.Forms.BindingSource();
            this.vwAll_ComputersTableAdapter = new Reports.DataSet.ReportsDataSetTableAdapters.vwAll_ComputersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllComputersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerCompleteReportsComputers
            // 
            this.reportViewerCompleteReportsComputers.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetComputers";
            reportDataSource1.Value = this.vwAllComputersBindingSource;
            this.reportViewerCompleteReportsComputers.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCompleteReportsComputers.LocalReport.ReportEmbeddedResource = "Reports.Reports.CompleteReportComputers.rdlc";
            this.reportViewerCompleteReportsComputers.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCompleteReportsComputers.Name = "reportViewerCompleteReportsComputers";
            this.reportViewerCompleteReportsComputers.ServerReport.BearerToken = null;
            this.reportViewerCompleteReportsComputers.Size = new System.Drawing.Size(760, 836);
            this.reportViewerCompleteReportsComputers.TabIndex = 0;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAllComputersBindingSource
            // 
            this.vwAllComputersBindingSource.DataMember = "vwAll_Computers";
            this.vwAllComputersBindingSource.DataSource = this.reportsDataSet;
            // 
            // vwAll_ComputersTableAdapter
            // 
            this.vwAll_ComputersTableAdapter.ClearBeforeFill = true;
            // 
            // CompleteReportComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 836);
            this.Controls.Add(this.reportViewerCompleteReportsComputers);
            this.Name = "CompleteReportComputers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteReportComputers";
            this.Load += new System.EventHandler(this.CompleteReportComputers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllComputersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCompleteReportsComputers;
        private DataSet.ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource vwAllComputersBindingSource;
        private DataSet.ReportsDataSetTableAdapters.vwAll_ComputersTableAdapter vwAll_ComputersTableAdapter;
    }
}