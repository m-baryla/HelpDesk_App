namespace Reports.Forms
{
    partial class CompleteReportNotebooks
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
            this.vwAllNotebooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAll_NotebooksTableAdapter = new Reports.DataSet.ReportsDataSetTableAdapters.vwAll_NotebooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllNotebooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNotebooks";
            reportDataSource1.Value = this.vwAllNotebooksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.Reports.CompleteReportNotebooks.rdlc";
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
            // vwAllNotebooksBindingSource
            // 
            this.vwAllNotebooksBindingSource.DataMember = "vwAll_Notebooks";
            this.vwAllNotebooksBindingSource.DataSource = this.reportsDataSet;
            // 
            // vwAll_NotebooksTableAdapter
            // 
            this.vwAll_NotebooksTableAdapter.ClearBeforeFill = true;
            // 
            // CompleteReportNotebooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 836);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CompleteReportNotebooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteReportNotebooks";
            this.Load += new System.EventHandler(this.CompleteReportNotebooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllNotebooksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource vwAllNotebooksBindingSource;
        private DataSet.ReportsDataSetTableAdapters.vwAll_NotebooksTableAdapter vwAll_NotebooksTableAdapter;
    }
}