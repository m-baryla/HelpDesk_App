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
            this.sp_Show_All_Monitors_FromDate_ToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new Reports.DataSet.ReportsDataSet();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.reportViewerReportsMonitors = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spShowAllMonitorsFromDateToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Show_All_Monitors_FromDate_ToDateTableAdapter = new Reports.DataSet.ReportsDataSetTableAdapters.sp_Show_All_Monitors_FromDate_ToDateTableAdapter();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Show_All_Monitors_FromDate_ToDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllMonitorsFromDateToDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_Show_All_Monitors_FromDate_ToDateBindingSource
            // 
            this.sp_Show_All_Monitors_FromDate_ToDateBindingSource.DataMember = "sp_Show_All_Monitors_FromDate_ToDate";
            this.sp_Show_All_Monitors_FromDate_ToDateBindingSource.DataSource = this.reportsDataSet;
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
            this.buttonLoadData.TabIndex = 10;
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
            this.dateTimePickerToDate.TabIndex = 9;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(181, 22);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(52, 13);
            this.labelToDate.TabIndex = 8;
            this.labelToDate.Text = "To Date: ";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(75, 19);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerFromDate.TabIndex = 7;
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(12, 23);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(62, 13);
            this.labelFromDate.TabIndex = 6;
            this.labelFromDate.Text = "From Date: ";
            // 
            // reportViewerReportsMonitors
            // 
            this.reportViewerReportsMonitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetMonitorsFromToDate";
            reportDataSource1.Value = this.sp_Show_All_Monitors_FromDate_ToDateBindingSource;
            this.reportViewerReportsMonitors.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerReportsMonitors.LocalReport.ReportEmbeddedResource = "Reports.Reports.CompleteReportMonitors.rdlc";
            this.reportViewerReportsMonitors.Location = new System.Drawing.Point(15, 55);
            this.reportViewerReportsMonitors.Name = "reportViewerReportsMonitors";
            this.reportViewerReportsMonitors.ServerReport.BearerToken = null;
            this.reportViewerReportsMonitors.Size = new System.Drawing.Size(733, 769);
            this.reportViewerReportsMonitors.TabIndex = 11;
            // 
            // spShowAllMonitorsFromDateToDateBindingSource
            // 
            this.spShowAllMonitorsFromDateToDateBindingSource.DataMember = "sp_Show_All_Monitors_FromDate_ToDate";
            this.spShowAllMonitorsFromDateToDateBindingSource.DataSource = this.reportsDataSet;
            // 
            // sp_Show_All_Monitors_FromDate_ToDateTableAdapter
            // 
            this.sp_Show_All_Monitors_FromDate_ToDateTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(449, 19);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status: ";
            // 
            // CompleteReportMonitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 836);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewerReportsMonitors);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelFromDate);
            this.Name = "CompleteReportMonitors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteReportMonitors";
            ((System.ComponentModel.ISupportInitialize)(this.sp_Show_All_Monitors_FromDate_ToDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllMonitorsFromDateToDateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelFromDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReportsMonitors;
        private System.Windows.Forms.BindingSource sp_Show_All_Monitors_FromDate_ToDateBindingSource;
        private DataSet.ReportsDataSet reportsDataSet;
        private System.Windows.Forms.BindingSource spShowAllMonitorsFromDateToDateBindingSource;
        private DataSet.ReportsDataSetTableAdapters.sp_Show_All_Monitors_FromDate_ToDateTableAdapter sp_Show_All_Monitors_FromDate_ToDateTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
    }
}