using HelpDesk_DB;

namespace GUI.Forms
{
    partial class DataGrindViewForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrindViewForms));
            this.panelDAtaGrindView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFullScrean = new System.Windows.Forms.Button();
            this.buttonExel = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCloseDataGrind = new System.Windows.Forms.Button();
            this.tabControl_Warehouse = new System.Windows.Forms.TabControl();
            this.tabPageComputers = new System.Windows.Forms.TabPage();
            this.advancedDataGridViewComputers = new Zuby.ADGV.AdvancedDataGridView();
            this.vwAllComputersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpDeskDB_TESTDataSet = new GUI.HelpDeskDB_TESTDataSet();
            this.tabPageMonitors = new System.Windows.Forms.TabPage();
            this.advancedDataGridViewMonitors = new Zuby.ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyFixedAssetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelVersionMonitorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwAllMonitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageNotebooks = new System.Windows.Forms.TabPage();
            this.advancedDataGridViewNotebooks = new Zuby.ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notebooksNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagServiceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyFixedAssetDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardDriveVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microsoftOfficeVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelVersionNotebooksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMVersionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwAllNotebooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAll_ComputersTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_ComputersTableAdapter();
            this.vwAll_MonitorsTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_MonitorsTableAdapter();
            this.vwAll_NotebooksTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_NotebooksTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyFixedAssetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardDriveVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microsoftOfficeVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelVersionComputerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatingSystemVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDAtaGrindView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl_Warehouse.SuspendLayout();
            this.tabPageComputers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllComputersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpDeskDB_TESTDataSet)).BeginInit();
            this.tabPageMonitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewMonitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllMonitorsBindingSource)).BeginInit();
            this.tabPageNotebooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewNotebooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllNotebooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDAtaGrindView
            // 
            this.panelDAtaGrindView.BackColor = System.Drawing.Color.Black;
            this.panelDAtaGrindView.Controls.Add(this.panel1);
            this.panelDAtaGrindView.Controls.Add(this.tabControl_Warehouse);
            this.panelDAtaGrindView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDAtaGrindView.Location = new System.Drawing.Point(0, 0);
            this.panelDAtaGrindView.Name = "panelDAtaGrindView";
            this.panelDAtaGrindView.Size = new System.Drawing.Size(739, 572);
            this.panelDAtaGrindView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFullScrean);
            this.panel1.Controls.Add(this.buttonExel);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonCloseDataGrind);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 50);
            this.panel1.TabIndex = 1;
            // 
            // buttonFullScrean
            // 
            this.buttonFullScrean.BackColor = System.Drawing.Color.Black;
            this.buttonFullScrean.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFullScrean.FlatAppearance.BorderSize = 2;
            this.buttonFullScrean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullScrean.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonFullScrean.ForeColor = System.Drawing.Color.White;
            this.buttonFullScrean.Image = ((System.Drawing.Image)(resources.GetObject("buttonFullScrean.Image")));
            this.buttonFullScrean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFullScrean.Location = new System.Drawing.Point(3, 0);
            this.buttonFullScrean.Name = "buttonFullScrean";
            this.buttonFullScrean.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonFullScrean.Size = new System.Drawing.Size(172, 50);
            this.buttonFullScrean.TabIndex = 32;
            this.buttonFullScrean.Text = "FullScrean";
            this.buttonFullScrean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFullScrean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFullScrean.UseVisualStyleBackColor = false;
            this.buttonFullScrean.Click += new System.EventHandler(this.buttonFullScrean_Click);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.Color.Black;
            this.buttonExel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExel.FlatAppearance.BorderSize = 2;
            this.buttonExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonExel.ForeColor = System.Drawing.Color.White;
            this.buttonExel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExel.Image")));
            this.buttonExel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExel.Location = new System.Drawing.Point(175, 0);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExel.Size = new System.Drawing.Size(111, 50);
            this.buttonExel.TabIndex = 30;
            this.buttonExel.Text = "Exel";
            this.buttonExel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExel.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Black;
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefresh.FlatAppearance.BorderSize = 2;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(286, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRefresh.Size = new System.Drawing.Size(153, 50);
            this.buttonRefresh.TabIndex = 31;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.FlatAppearance.BorderSize = 2;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(439, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDelete.Size = new System.Drawing.Size(136, 50);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEdit.FlatAppearance.BorderSize = 2;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(575, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonEdit.Size = new System.Drawing.Size(114, 50);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCloseDataGrind
            // 
            this.buttonCloseDataGrind.BackColor = System.Drawing.Color.Black;
            this.buttonCloseDataGrind.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseDataGrind.FlatAppearance.BorderSize = 2;
            this.buttonCloseDataGrind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseDataGrind.Font = new System.Drawing.Font("Algerian", 36F);
            this.buttonCloseDataGrind.ForeColor = System.Drawing.Color.White;
            this.buttonCloseDataGrind.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseDataGrind.Image")));
            this.buttonCloseDataGrind.Location = new System.Drawing.Point(689, 0);
            this.buttonCloseDataGrind.Name = "buttonCloseDataGrind";
            this.buttonCloseDataGrind.Size = new System.Drawing.Size(50, 50);
            this.buttonCloseDataGrind.TabIndex = 29;
            this.buttonCloseDataGrind.UseVisualStyleBackColor = false;
            this.buttonCloseDataGrind.Click += new System.EventHandler(this.buttonCloseDataGrind_Click);
            // 
            // tabControl_Warehouse
            // 
            this.tabControl_Warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Warehouse.Controls.Add(this.tabPageComputers);
            this.tabControl_Warehouse.Controls.Add(this.tabPageMonitors);
            this.tabControl_Warehouse.Controls.Add(this.tabPageNotebooks);
            this.tabControl_Warehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl_Warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControl_Warehouse.Location = new System.Drawing.Point(0, 83);
            this.tabControl_Warehouse.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Warehouse.Name = "tabControl_Warehouse";
            this.tabControl_Warehouse.SelectedIndex = 0;
            this.tabControl_Warehouse.Size = new System.Drawing.Size(739, 489);
            this.tabControl_Warehouse.TabIndex = 1;
            // 
            // tabPageComputers
            // 
            this.tabPageComputers.Controls.Add(this.advancedDataGridViewComputers);
            this.tabPageComputers.Location = new System.Drawing.Point(4, 22);
            this.tabPageComputers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageComputers.Name = "tabPageComputers";
            this.tabPageComputers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageComputers.Size = new System.Drawing.Size(731, 463);
            this.tabPageComputers.TabIndex = 0;
            this.tabPageComputers.Text = "Computers";
            this.tabPageComputers.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridViewComputers
            // 
            this.advancedDataGridViewComputers.AllowUserToOrderColumns = true;
            this.advancedDataGridViewComputers.AutoGenerateColumns = false;
            this.advancedDataGridViewComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridViewComputers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.compterNameDataGridViewTextBoxColumn,
            this.tagServiceDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.warrantyDateDataGridViewTextBoxColumn,
            this.comentsDataGridViewTextBoxColumn,
            this.companyFixedAssetDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.cPUVersionDataGridViewTextBoxColumn,
            this.hardDriveVersionDataGridViewTextBoxColumn,
            this.locationNameDataGridViewTextBoxColumn,
            this.microsoftOfficeVersionDataGridViewTextBoxColumn,
            this.modelVersionComputerDataGridViewTextBoxColumn,
            this.operatingSystemVersionDataGridViewTextBoxColumn,
            this.rAMVersionDataGridViewTextBoxColumn});
            this.advancedDataGridViewComputers.DataSource = this.vwAllComputersBindingSource;
            this.advancedDataGridViewComputers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridViewComputers.FilterAndSortEnabled = true;
            this.advancedDataGridViewComputers.Location = new System.Drawing.Point(4, 4);
            this.advancedDataGridViewComputers.Name = "advancedDataGridViewComputers";
            this.advancedDataGridViewComputers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridViewComputers.Size = new System.Drawing.Size(723, 455);
            this.advancedDataGridViewComputers.TabIndex = 0;
            this.advancedDataGridViewComputers.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridViewComputers_SortStringChanged);
            this.advancedDataGridViewComputers.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.advancedDataGridViewComputers_FilterStringChanged);
            // 
            // vwAllComputersBindingSource
            // 
            this.vwAllComputersBindingSource.DataMember = "vwAll_Computers";
            this.vwAllComputersBindingSource.DataSource = this.helpDeskDB_TESTDataSet;
            // 
            // helpDeskDB_TESTDataSet
            // 
            this.helpDeskDB_TESTDataSet.DataSetName = "HelpDeskDB_TESTDataSet";
            this.helpDeskDB_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageMonitors
            // 
            this.tabPageMonitors.Controls.Add(this.advancedDataGridViewMonitors);
            this.tabPageMonitors.Location = new System.Drawing.Point(4, 22);
            this.tabPageMonitors.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMonitors.Name = "tabPageMonitors";
            this.tabPageMonitors.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMonitors.Size = new System.Drawing.Size(731, 463);
            this.tabPageMonitors.TabIndex = 1;
            this.tabPageMonitors.Text = "Monitors";
            this.tabPageMonitors.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridViewMonitors
            // 
            this.advancedDataGridViewMonitors.AutoGenerateColumns = false;
            this.advancedDataGridViewMonitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridViewMonitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tagServiceDataGridViewTextBoxColumn1,
            this.purchaseDateDataGridViewTextBoxColumn1,
            this.warrantyDateDataGridViewTextBoxColumn1,
            this.barcodeDataGridViewTextBoxColumn,
            this.comentsDataGridViewTextBoxColumn1,
            this.companyFixedAssetDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.jobDataGridViewTextBoxColumn1,
            this.locationNameDataGridViewTextBoxColumn1,
            this.modelVersionMonitorsDataGridViewTextBoxColumn});
            this.advancedDataGridViewMonitors.DataSource = this.vwAllMonitorsBindingSource;
            this.advancedDataGridViewMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridViewMonitors.FilterAndSortEnabled = true;
            this.advancedDataGridViewMonitors.Location = new System.Drawing.Point(4, 4);
            this.advancedDataGridViewMonitors.Name = "advancedDataGridViewMonitors";
            this.advancedDataGridViewMonitors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridViewMonitors.Size = new System.Drawing.Size(723, 455);
            this.advancedDataGridViewMonitors.TabIndex = 0;
            this.advancedDataGridViewMonitors.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridViewMonitors_SortStringChanged);
            this.advancedDataGridViewMonitors.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.advancedDataGridViewMonitors_FilterStringChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tagServiceDataGridViewTextBoxColumn1
            // 
            this.tagServiceDataGridViewTextBoxColumn1.DataPropertyName = "TagService";
            this.tagServiceDataGridViewTextBoxColumn1.HeaderText = "TagService";
            this.tagServiceDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.tagServiceDataGridViewTextBoxColumn1.Name = "tagServiceDataGridViewTextBoxColumn1";
            this.tagServiceDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // purchaseDateDataGridViewTextBoxColumn1
            // 
            this.purchaseDateDataGridViewTextBoxColumn1.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn1.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.purchaseDateDataGridViewTextBoxColumn1.Name = "purchaseDateDataGridViewTextBoxColumn1";
            this.purchaseDateDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // warrantyDateDataGridViewTextBoxColumn1
            // 
            this.warrantyDateDataGridViewTextBoxColumn1.DataPropertyName = "WarrantyDate";
            this.warrantyDateDataGridViewTextBoxColumn1.HeaderText = "WarrantyDate";
            this.warrantyDateDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.warrantyDateDataGridViewTextBoxColumn1.Name = "warrantyDateDataGridViewTextBoxColumn1";
            this.warrantyDateDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comentsDataGridViewTextBoxColumn1
            // 
            this.comentsDataGridViewTextBoxColumn1.DataPropertyName = "Coments";
            this.comentsDataGridViewTextBoxColumn1.HeaderText = "Coments";
            this.comentsDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.comentsDataGridViewTextBoxColumn1.Name = "comentsDataGridViewTextBoxColumn1";
            this.comentsDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // companyFixedAssetDataGridViewTextBoxColumn1
            // 
            this.companyFixedAssetDataGridViewTextBoxColumn1.DataPropertyName = "CompanyFixedAsset";
            this.companyFixedAssetDataGridViewTextBoxColumn1.HeaderText = "CompanyFixedAsset";
            this.companyFixedAssetDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.companyFixedAssetDataGridViewTextBoxColumn1.Name = "companyFixedAssetDataGridViewTextBoxColumn1";
            this.companyFixedAssetDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // jobDataGridViewTextBoxColumn1
            // 
            this.jobDataGridViewTextBoxColumn1.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn1.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.jobDataGridViewTextBoxColumn1.Name = "jobDataGridViewTextBoxColumn1";
            this.jobDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // locationNameDataGridViewTextBoxColumn1
            // 
            this.locationNameDataGridViewTextBoxColumn1.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn1.HeaderText = "LocationName";
            this.locationNameDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.locationNameDataGridViewTextBoxColumn1.Name = "locationNameDataGridViewTextBoxColumn1";
            this.locationNameDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // modelVersionMonitorsDataGridViewTextBoxColumn
            // 
            this.modelVersionMonitorsDataGridViewTextBoxColumn.DataPropertyName = "ModelVersionMonitors";
            this.modelVersionMonitorsDataGridViewTextBoxColumn.HeaderText = "ModelVersionMonitors";
            this.modelVersionMonitorsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.modelVersionMonitorsDataGridViewTextBoxColumn.Name = "modelVersionMonitorsDataGridViewTextBoxColumn";
            this.modelVersionMonitorsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vwAllMonitorsBindingSource
            // 
            this.vwAllMonitorsBindingSource.DataMember = "vwAll_Monitors";
            this.vwAllMonitorsBindingSource.DataSource = this.helpDeskDB_TESTDataSet;
            // 
            // tabPageNotebooks
            // 
            this.tabPageNotebooks.Controls.Add(this.advancedDataGridViewNotebooks);
            this.tabPageNotebooks.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotebooks.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageNotebooks.Name = "tabPageNotebooks";
            this.tabPageNotebooks.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageNotebooks.Size = new System.Drawing.Size(731, 463);
            this.tabPageNotebooks.TabIndex = 2;
            this.tabPageNotebooks.Text = "Notebooks";
            this.tabPageNotebooks.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridViewNotebooks
            // 
            this.advancedDataGridViewNotebooks.AutoGenerateColumns = false;
            this.advancedDataGridViewNotebooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridViewNotebooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.notebooksNameDataGridViewTextBoxColumn,
            this.tagServiceDataGridViewTextBoxColumn2,
            this.iPDataGridViewTextBoxColumn1,
            this.purchaseDateDataGridViewTextBoxColumn2,
            this.warrantyDateDataGridViewTextBoxColumn2,
            this.barcodeDataGridViewTextBoxColumn1,
            this.comentsDataGridViewTextBoxColumn2,
            this.companyFixedAssetDataGridViewTextBoxColumn2,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2,
            this.jobDataGridViewTextBoxColumn2,
            this.cPUVersionDataGridViewTextBoxColumn1,
            this.hardDriveVersionDataGridViewTextBoxColumn1,
            this.locationNameDataGridViewTextBoxColumn2,
            this.microsoftOfficeVersionDataGridViewTextBoxColumn1,
            this.modelVersionNotebooksDataGridViewTextBoxColumn,
            this.operatingSystemVersionDataGridViewTextBoxColumn1,
            this.rAMVersionDataGridViewTextBoxColumn1});
            this.advancedDataGridViewNotebooks.DataSource = this.vwAllNotebooksBindingSource;
            this.advancedDataGridViewNotebooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridViewNotebooks.FilterAndSortEnabled = true;
            this.advancedDataGridViewNotebooks.Location = new System.Drawing.Point(4, 4);
            this.advancedDataGridViewNotebooks.Name = "advancedDataGridViewNotebooks";
            this.advancedDataGridViewNotebooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridViewNotebooks.Size = new System.Drawing.Size(723, 455);
            this.advancedDataGridViewNotebooks.TabIndex = 0;
            this.advancedDataGridViewNotebooks.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridViewNotebooks_SortStringChanged);
            this.advancedDataGridViewNotebooks.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.advancedDataGridViewNotebooks_FilterStringChanged);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // notebooksNameDataGridViewTextBoxColumn
            // 
            this.notebooksNameDataGridViewTextBoxColumn.DataPropertyName = "NotebooksName";
            this.notebooksNameDataGridViewTextBoxColumn.HeaderText = "NotebooksName";
            this.notebooksNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.notebooksNameDataGridViewTextBoxColumn.Name = "notebooksNameDataGridViewTextBoxColumn";
            this.notebooksNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tagServiceDataGridViewTextBoxColumn2
            // 
            this.tagServiceDataGridViewTextBoxColumn2.DataPropertyName = "TagService";
            this.tagServiceDataGridViewTextBoxColumn2.HeaderText = "TagService";
            this.tagServiceDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.tagServiceDataGridViewTextBoxColumn2.Name = "tagServiceDataGridViewTextBoxColumn2";
            this.tagServiceDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iPDataGridViewTextBoxColumn1
            // 
            this.iPDataGridViewTextBoxColumn1.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn1.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.iPDataGridViewTextBoxColumn1.Name = "iPDataGridViewTextBoxColumn1";
            this.iPDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // purchaseDateDataGridViewTextBoxColumn2
            // 
            this.purchaseDateDataGridViewTextBoxColumn2.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn2.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.purchaseDateDataGridViewTextBoxColumn2.Name = "purchaseDateDataGridViewTextBoxColumn2";
            this.purchaseDateDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // warrantyDateDataGridViewTextBoxColumn2
            // 
            this.warrantyDateDataGridViewTextBoxColumn2.DataPropertyName = "WarrantyDate";
            this.warrantyDateDataGridViewTextBoxColumn2.HeaderText = "WarrantyDate";
            this.warrantyDateDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.warrantyDateDataGridViewTextBoxColumn2.Name = "warrantyDateDataGridViewTextBoxColumn2";
            this.warrantyDateDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // barcodeDataGridViewTextBoxColumn1
            // 
            this.barcodeDataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.barcodeDataGridViewTextBoxColumn1.Name = "barcodeDataGridViewTextBoxColumn1";
            this.barcodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comentsDataGridViewTextBoxColumn2
            // 
            this.comentsDataGridViewTextBoxColumn2.DataPropertyName = "Coments";
            this.comentsDataGridViewTextBoxColumn2.HeaderText = "Coments";
            this.comentsDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.comentsDataGridViewTextBoxColumn2.Name = "comentsDataGridViewTextBoxColumn2";
            this.comentsDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // companyFixedAssetDataGridViewTextBoxColumn2
            // 
            this.companyFixedAssetDataGridViewTextBoxColumn2.DataPropertyName = "CompanyFixedAsset";
            this.companyFixedAssetDataGridViewTextBoxColumn2.HeaderText = "CompanyFixedAsset";
            this.companyFixedAssetDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.companyFixedAssetDataGridViewTextBoxColumn2.Name = "companyFixedAssetDataGridViewTextBoxColumn2";
            this.companyFixedAssetDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // jobDataGridViewTextBoxColumn2
            // 
            this.jobDataGridViewTextBoxColumn2.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn2.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.jobDataGridViewTextBoxColumn2.Name = "jobDataGridViewTextBoxColumn2";
            this.jobDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cPUVersionDataGridViewTextBoxColumn1
            // 
            this.cPUVersionDataGridViewTextBoxColumn1.DataPropertyName = "CPUVersion";
            this.cPUVersionDataGridViewTextBoxColumn1.HeaderText = "CPUVersion";
            this.cPUVersionDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.cPUVersionDataGridViewTextBoxColumn1.Name = "cPUVersionDataGridViewTextBoxColumn1";
            this.cPUVersionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // hardDriveVersionDataGridViewTextBoxColumn1
            // 
            this.hardDriveVersionDataGridViewTextBoxColumn1.DataPropertyName = "HardDriveVersion";
            this.hardDriveVersionDataGridViewTextBoxColumn1.HeaderText = "HardDriveVersion";
            this.hardDriveVersionDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.hardDriveVersionDataGridViewTextBoxColumn1.Name = "hardDriveVersionDataGridViewTextBoxColumn1";
            this.hardDriveVersionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // locationNameDataGridViewTextBoxColumn2
            // 
            this.locationNameDataGridViewTextBoxColumn2.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn2.HeaderText = "LocationName";
            this.locationNameDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.locationNameDataGridViewTextBoxColumn2.Name = "locationNameDataGridViewTextBoxColumn2";
            this.locationNameDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // microsoftOfficeVersionDataGridViewTextBoxColumn1
            // 
            this.microsoftOfficeVersionDataGridViewTextBoxColumn1.DataPropertyName = "MicrosoftOfficeVersion";
            this.microsoftOfficeVersionDataGridViewTextBoxColumn1.HeaderText = "MicrosoftOfficeVersion";
            this.microsoftOfficeVersionDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.microsoftOfficeVersionDataGridViewTextBoxColumn1.Name = "microsoftOfficeVersionDataGridViewTextBoxColumn1";
            this.microsoftOfficeVersionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // modelVersionNotebooksDataGridViewTextBoxColumn
            // 
            this.modelVersionNotebooksDataGridViewTextBoxColumn.DataPropertyName = "ModelVersionNotebooks";
            this.modelVersionNotebooksDataGridViewTextBoxColumn.HeaderText = "ModelVersionNotebooks";
            this.modelVersionNotebooksDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.modelVersionNotebooksDataGridViewTextBoxColumn.Name = "modelVersionNotebooksDataGridViewTextBoxColumn";
            this.modelVersionNotebooksDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // operatingSystemVersionDataGridViewTextBoxColumn1
            // 
            this.operatingSystemVersionDataGridViewTextBoxColumn1.DataPropertyName = "OperatingSystemVersion";
            this.operatingSystemVersionDataGridViewTextBoxColumn1.HeaderText = "OperatingSystemVersion";
            this.operatingSystemVersionDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.operatingSystemVersionDataGridViewTextBoxColumn1.Name = "operatingSystemVersionDataGridViewTextBoxColumn1";
            this.operatingSystemVersionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // rAMVersionDataGridViewTextBoxColumn1
            // 
            this.rAMVersionDataGridViewTextBoxColumn1.DataPropertyName = "RAMVersion";
            this.rAMVersionDataGridViewTextBoxColumn1.HeaderText = "RAMVersion";
            this.rAMVersionDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.rAMVersionDataGridViewTextBoxColumn1.Name = "rAMVersionDataGridViewTextBoxColumn1";
            this.rAMVersionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vwAllNotebooksBindingSource
            // 
            this.vwAllNotebooksBindingSource.DataMember = "vwAll_Notebooks";
            this.vwAllNotebooksBindingSource.DataSource = this.helpDeskDB_TESTDataSet;
            // 
            // vwAll_ComputersTableAdapter
            // 
            this.vwAll_ComputersTableAdapter.ClearBeforeFill = true;
            // 
            // vwAll_MonitorsTableAdapter
            // 
            this.vwAll_MonitorsTableAdapter.ClearBeforeFill = true;
            // 
            // vwAll_NotebooksTableAdapter
            // 
            this.vwAll_NotebooksTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // compterNameDataGridViewTextBoxColumn
            // 
            this.compterNameDataGridViewTextBoxColumn.DataPropertyName = "CompterName";
            this.compterNameDataGridViewTextBoxColumn.HeaderText = "CompterName";
            this.compterNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.compterNameDataGridViewTextBoxColumn.Name = "compterNameDataGridViewTextBoxColumn";
            this.compterNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tagServiceDataGridViewTextBoxColumn
            // 
            this.tagServiceDataGridViewTextBoxColumn.DataPropertyName = "TagService";
            this.tagServiceDataGridViewTextBoxColumn.HeaderText = "TagService";
            this.tagServiceDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tagServiceDataGridViewTextBoxColumn.Name = "tagServiceDataGridViewTextBoxColumn";
            this.tagServiceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            this.iPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // warrantyDateDataGridViewTextBoxColumn
            // 
            this.warrantyDateDataGridViewTextBoxColumn.DataPropertyName = "WarrantyDate";
            this.warrantyDateDataGridViewTextBoxColumn.HeaderText = "WarrantyDate";
            this.warrantyDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.warrantyDateDataGridViewTextBoxColumn.Name = "warrantyDateDataGridViewTextBoxColumn";
            this.warrantyDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // comentsDataGridViewTextBoxColumn
            // 
            this.comentsDataGridViewTextBoxColumn.DataPropertyName = "Coments";
            this.comentsDataGridViewTextBoxColumn.HeaderText = "Coments";
            this.comentsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.comentsDataGridViewTextBoxColumn.Name = "comentsDataGridViewTextBoxColumn";
            this.comentsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // companyFixedAssetDataGridViewTextBoxColumn
            // 
            this.companyFixedAssetDataGridViewTextBoxColumn.DataPropertyName = "CompanyFixedAsset";
            this.companyFixedAssetDataGridViewTextBoxColumn.HeaderText = "CompanyFixedAsset";
            this.companyFixedAssetDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.companyFixedAssetDataGridViewTextBoxColumn.Name = "companyFixedAssetDataGridViewTextBoxColumn";
            this.companyFixedAssetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cPUVersionDataGridViewTextBoxColumn
            // 
            this.cPUVersionDataGridViewTextBoxColumn.DataPropertyName = "CPUVersion";
            this.cPUVersionDataGridViewTextBoxColumn.HeaderText = "CPUVersion";
            this.cPUVersionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cPUVersionDataGridViewTextBoxColumn.Name = "cPUVersionDataGridViewTextBoxColumn";
            this.cPUVersionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // hardDriveVersionDataGridViewTextBoxColumn
            // 
            this.hardDriveVersionDataGridViewTextBoxColumn.DataPropertyName = "HardDriveVersion";
            this.hardDriveVersionDataGridViewTextBoxColumn.HeaderText = "HardDriveVersion";
            this.hardDriveVersionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.hardDriveVersionDataGridViewTextBoxColumn.Name = "hardDriveVersionDataGridViewTextBoxColumn";
            this.hardDriveVersionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            this.locationNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // microsoftOfficeVersionDataGridViewTextBoxColumn
            // 
            this.microsoftOfficeVersionDataGridViewTextBoxColumn.DataPropertyName = "MicrosoftOfficeVersion";
            this.microsoftOfficeVersionDataGridViewTextBoxColumn.HeaderText = "MicrosoftOfficeVersion";
            this.microsoftOfficeVersionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.microsoftOfficeVersionDataGridViewTextBoxColumn.Name = "microsoftOfficeVersionDataGridViewTextBoxColumn";
            this.microsoftOfficeVersionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // modelVersionComputerDataGridViewTextBoxColumn
            // 
            this.modelVersionComputerDataGridViewTextBoxColumn.DataPropertyName = "ModelVersionComputer";
            this.modelVersionComputerDataGridViewTextBoxColumn.HeaderText = "ModelVersionComputer";
            this.modelVersionComputerDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.modelVersionComputerDataGridViewTextBoxColumn.Name = "modelVersionComputerDataGridViewTextBoxColumn";
            this.modelVersionComputerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // operatingSystemVersionDataGridViewTextBoxColumn
            // 
            this.operatingSystemVersionDataGridViewTextBoxColumn.DataPropertyName = "OperatingSystemVersion";
            this.operatingSystemVersionDataGridViewTextBoxColumn.HeaderText = "OperatingSystemVersion";
            this.operatingSystemVersionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.operatingSystemVersionDataGridViewTextBoxColumn.Name = "operatingSystemVersionDataGridViewTextBoxColumn";
            this.operatingSystemVersionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // rAMVersionDataGridViewTextBoxColumn
            // 
            this.rAMVersionDataGridViewTextBoxColumn.DataPropertyName = "RAMVersion";
            this.rAMVersionDataGridViewTextBoxColumn.HeaderText = "RAMVersion";
            this.rAMVersionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rAMVersionDataGridViewTextBoxColumn.Name = "rAMVersionDataGridViewTextBoxColumn";
            this.rAMVersionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DataGrindViewForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 572);
            this.Controls.Add(this.panelDAtaGrindView);
            this.Name = "DataGrindViewForms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGrindViewForms";
            this.Load += new System.EventHandler(this.DataGrindViewForms_Load);
            this.panelDAtaGrindView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl_Warehouse.ResumeLayout(false);
            this.tabPageComputers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllComputersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpDeskDB_TESTDataSet)).EndInit();
            this.tabPageMonitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewMonitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllMonitorsBindingSource)).EndInit();
            this.tabPageNotebooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewNotebooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwAllNotebooksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDAtaGrindView;
        private System.Windows.Forms.TabControl tabControl_Warehouse;
        private System.Windows.Forms.TabPage tabPageComputers;
        private System.Windows.Forms.TabPage tabPageMonitors;
        private System.Windows.Forms.TabPage tabPageNotebooks;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCloseDataGrind;       
        private System.Windows.Forms.Button buttonRefresh;

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewComputers;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewMonitors;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewNotebooks;
       
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExel;
        private System.Windows.Forms.Button buttonFullScrean;
        private HelpDeskDB_TESTDataSet helpDeskDB_TESTDataSet;
        private System.Windows.Forms.BindingSource vwAllComputersBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_ComputersTableAdapter vwAll_ComputersTableAdapter;
        private System.Windows.Forms.BindingSource vwAllMonitorsBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_MonitorsTableAdapter vwAll_MonitorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyFixedAssetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelVersionMonitorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwAllNotebooksBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_NotebooksTableAdapter vwAll_NotebooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn notebooksNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagServiceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyFixedAssetDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardDriveVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn microsoftOfficeVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelVersionNotebooksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMVersionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyFixedAssetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardDriveVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn microsoftOfficeVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelVersionComputerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMVersionDataGridViewTextBoxColumn;
    }
}