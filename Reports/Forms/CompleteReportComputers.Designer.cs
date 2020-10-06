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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.labelToDate = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.reportViewerReportsComputers = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.sp_Show_All_Computers_FromDate_ToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsDataSet = new Reports.DataSet.ReportsDataSet();
            this.spShowAllComputersFromDateToDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Show_All_Computers_FromDate_ToDateTableAdapter = new Reports.DataSet.ReportsDataSetTableAdapters.sp_Show_All_Computers_FromDate_ToDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Show_All_Computers_FromDate_ToDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllComputersFromDateToDateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(12, 20);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(62, 13);
            this.labelFromDate.TabIndex = 1;
            this.labelFromDate.Text = "From Date: ";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(73, 16);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerFromDate.TabIndex = 2;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(276, 15);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerToDate.TabIndex = 4;
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(224, 19);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(52, 13);
            this.labelToDate.TabIndex = 3;
            this.labelToDate.Text = "To Date: ";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadData.Location = new System.Drawing.Point(652, 9);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(96, 33);
            this.buttonLoadData.TabIndex = 5;
            this.buttonLoadData.Text = "Load Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // reportViewerReportsComputers
            // 
            this.reportViewerReportsComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetComputerFromToDate";
            reportDataSource1.Value = this.sp_Show_All_Computers_FromDate_ToDateBindingSource;
            this.reportViewerReportsComputers.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerReportsComputers.LocalReport.ReportEmbeddedResource = "Reports.Reports.CompleteReportComputers.rdlc";
            this.reportViewerReportsComputers.Location = new System.Drawing.Point(15, 48);
            this.reportViewerReportsComputers.Name = "reportViewerReportsComputers";
            this.reportViewerReportsComputers.ServerReport.BearerToken = null;
            this.reportViewerReportsComputers.Size = new System.Drawing.Size(733, 776);
            this.reportViewerReportsComputers.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status: ";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(469, 14);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 8;
            // 
            // sp_Show_All_Computers_FromDate_ToDateBindingSource
            // 
            this.sp_Show_All_Computers_FromDate_ToDateBindingSource.DataMember = "sp_Show_All_Computers_FromDate_ToDate";
            this.sp_Show_All_Computers_FromDate_ToDateBindingSource.DataSource = this.reportsDataSet;
            // 
            // reportsDataSet
            // 
            this.reportsDataSet.DataSetName = "ReportsDataSet";
            this.reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spShowAllComputersFromDateToDateBindingSource
            // 
            this.spShowAllComputersFromDateToDateBindingSource.DataMember = "sp_Show_All_Computers_FromDate_ToDate";
            this.spShowAllComputersFromDateToDateBindingSource.DataSource = this.reportsDataSet;
            // 
            // sp_Show_All_Computers_FromDate_ToDateTableAdapter
            // 
            this.sp_Show_All_Computers_FromDate_ToDateTableAdapter.ClearBeforeFill = true;
            // 
            // CompleteReportComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 836);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewerReportsComputers);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.labelFromDate);
            this.Name = "CompleteReportComputers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteReportComputers";
            ((System.ComponentModel.ISupportInitialize)(this.sp_Show_All_Computers_FromDate_ToDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spShowAllComputersFromDateToDateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Button buttonLoadData;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReportsComputers;
        private System.Windows.Forms.BindingSource spShowAllComputersFromDateToDateBindingSource;
        private DataSet.ReportsDataSet reportsDataSet;
        private DataSet.ReportsDataSetTableAdapters.sp_Show_All_Computers_FromDate_ToDateTableAdapter sp_Show_All_Computers_FromDate_ToDateTableAdapter;
        private System.Windows.Forms.BindingSource sp_Show_All_Computers_FromDate_ToDateBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}