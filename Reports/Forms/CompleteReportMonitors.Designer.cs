namespace Reports.Forms
{
    partial class CompleteReportMonitors
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportsDataSet = new Reports.DataSet.ReportsDataSet();
            this.vwAllMonitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAll_MonitorsTableAdapter = new Reports.DataSet.ReportsDataSetTableAdapters.vwAll_MonitorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllMonitorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMonitors";
            reportDataSource1.Value = this.vwAllMonitorsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.Reports.CompleteReportMonitors.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 836);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwAllMonitorsBindingSource
            // 
            this.vwAllMonitorsBindingSource.DataMember = "vwAll_Monitors";
            this.vwAllMonitorsBindingSource.DataSource = this.reportsDataSet;
            // 
            // vwAll_MonitorsTableAdapter
            // 
            this.vwAll_MonitorsTableAdapter.ClearBeforeFill = true;
            // 
            // CompleteReportMonitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 836);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CompleteReportMonitors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteReportMonitors";
            this.Load += new System.EventHandler(this.CompleteReportMonitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllMonitorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource vwAllMonitorsBindingSource;
        private DataSet.ReportsDataSetTableAdapters.vwAll_MonitorsTableAdapter vwAll_MonitorsTableAdapter;
    }
}