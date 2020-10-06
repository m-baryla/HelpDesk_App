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
            this.sp_Show_All_Notebooks_FromDate_ToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new Reports.DataSet.ReportsDataSet();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.reportViewerReportsNotebooks = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spShowAllNotebooksFromDateToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Show_All_Notebooks_FromDate_ToDateTableAdapter = new Reports.DataSet.ReportsDataSetTableAdapters.sp_Show_All_Notebooks_FromDate_ToDateTableAdapter();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Show_All_Notebooks_FromDate_ToDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllNotebooksFromDateToDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Show_All_Notebooks_FromDate_ToDateBindingSource
            // 
            this.sp_Show_All_Notebooks_FromDate_ToDateBindingSource.DataMember = "sp_Show_All_Notebooks_FromDate_ToDate";
            this.sp_Show_All_Notebooks_FromDate_ToDateBindingSource.DataSource = this.reportsDataSet;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadData.Location = new System.Drawing.Point(652, 12);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(96, 33);
            this.buttonLoadData.TabIndex = 15;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(244, 18);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerToDate.TabIndex = 14;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(181, 22);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(52, 13);
            this.labelToDate.TabIndex = 13;
            this.labelToDate.Text = "To Date: ";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(75, 19);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerFromDate.TabIndex = 12;
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(12, 23);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(62, 13);
            this.labelFromDate.TabIndex = 11;
            this.labelFromDate.Text = "From Date: ";
            // 
            // reportViewerReportsNotebooks
            // 
            this.reportViewerReportsNotebooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetNotebooksFromToDate";
            reportDataSource1.Value = this.sp_Show_All_Notebooks_FromDate_ToDateBindingSource;
            this.reportViewerReportsNotebooks.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerReportsNotebooks.LocalReport.ReportEmbeddedResource = "Reports.Reports.CompleteReportNotebooks.rdlc";
            this.reportViewerReportsNotebooks.Location = new System.Drawing.Point(15, 54);
            this.reportViewerReportsNotebooks.Name = "reportViewerReportsNotebooks";
            this.reportViewerReportsNotebooks.ServerReport.BearerToken = null;
            this.reportViewerReportsNotebooks.Size = new System.Drawing.Size(733, 770);
            this.reportViewerReportsNotebooks.TabIndex = 16;
            // 
            // spShowAllNotebooksFromDateToDateBindingSource
            // 
            this.spShowAllNotebooksFromDateToDateBindingSource.DataMember = "sp_Show_All_Notebooks_FromDate_ToDate";
            this.spShowAllNotebooksFromDateToDateBindingSource.DataSource = this.reportsDataSet;
            // 
            // sp_Show_All_Notebooks_FromDate_ToDateTableAdapter
            // 
            this.sp_Show_All_Notebooks_FromDate_ToDateTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(432, 18);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status: ";
            // 
            // CompleteReportNotebooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 836);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewerReportsNotebooks);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelFromDate);
            this.Name = "CompleteReportNotebooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteReportNotebooks";
            ((System.ComponentModel.ISupportInitialize)(this.sp_Show_All_Notebooks_FromDate_ToDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllNotebooksFromDateToDateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelFromDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReportsNotebooks;
        private System.Windows.Forms.BindingSource sp_Show_All_Notebooks_FromDate_ToDateBindingSource;
        private DataSet.ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource spShowAllNotebooksFromDateToDateBindingSource;
        private DataSet.ReportsDataSetTableAdapters.sp_Show_All_Notebooks_FromDate_ToDateTableAdapter sp_Show_All_Notebooks_FromDate_ToDateTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
    }
}