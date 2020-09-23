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
            this.radioButtonColorOn = new System.Windows.Forms.RadioButton();
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
            this.vwAllMonitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageNotebooks = new System.Windows.Forms.TabPage();
            this.advancedDataGridViewNotebooks = new Zuby.ADGV.AdvancedDataGridView();
            this.vwAllNotebooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAll_ComputersTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_ComputersTableAdapter();
            this.vwAll_MonitorsTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_MonitorsTableAdapter();
            this.vwAll_NotebooksTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_NotebooksTableAdapter();
            this.iDEquipmentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEquipmentStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEquipmentStatusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelDAtaGrindView.Controls.Add(this.radioButtonColorOn);
            this.panelDAtaGrindView.Controls.Add(this.panel1);
            this.panelDAtaGrindView.Controls.Add(this.tabControl_Warehouse);
            this.panelDAtaGrindView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDAtaGrindView.Location = new System.Drawing.Point(0, 0);
            this.panelDAtaGrindView.Name = "panelDAtaGrindView";
            this.panelDAtaGrindView.Size = new System.Drawing.Size(739, 572);
            this.panelDAtaGrindView.TabIndex = 0;
            // 
            // radioButtonColorOn
            // 
            this.radioButtonColorOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonColorOn.AutoSize = true;
            this.radioButtonColorOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonColorOn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonColorOn.ForeColor = System.Drawing.Color.White;
            this.radioButtonColorOn.Location = new System.Drawing.Point(616, 65);
            this.radioButtonColorOn.Name = "radioButtonColorOn";
            this.radioButtonColorOn.Size = new System.Drawing.Size(115, 22);
            this.radioButtonColorOn.TabIndex = 2;
            this.radioButtonColorOn.TabStop = true;
            this.radioButtonColorOn.Text = "ColorFilter ON";
            this.radioButtonColorOn.UseVisualStyleBackColor = true;
            this.radioButtonColorOn.CheckedChanged += new System.EventHandler(this.radioButtonColorOn_CheckedChanged);
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
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
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
            this.iDEquipmentStatusDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
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
            this.advancedDataGridViewComputers.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.advancedDataGridViewComputers_RowPrePaint);
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
            this.advancedDataGridViewMonitors.AllowUserToOrderColumns = true;
            this.advancedDataGridViewMonitors.AutoGenerateColumns = false;
            this.advancedDataGridViewMonitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridViewMonitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEquipmentStatusDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
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
            this.advancedDataGridViewMonitors.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.advancedDataGridViewMonitors_RowPrePaint);
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
            this.advancedDataGridViewNotebooks.AllowUserToOrderColumns = true;
            this.advancedDataGridViewNotebooks.AutoGenerateColumns = false;
            this.advancedDataGridViewNotebooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridViewNotebooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEquipmentStatusDataGridViewTextBoxColumn2,
            this.statusDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47});
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
            this.advancedDataGridViewNotebooks.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.advancedDataGridViewNotebooks_RowPrePaint);
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
            // iDEquipmentStatusDataGridViewTextBoxColumn
            // 
            this.iDEquipmentStatusDataGridViewTextBoxColumn.DataPropertyName = "IDEquipmentStatus";
            this.iDEquipmentStatusDataGridViewTextBoxColumn.HeaderText = "IDEquipmentStatus";
            this.iDEquipmentStatusDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDEquipmentStatusDataGridViewTextBoxColumn.Name = "iDEquipmentStatusDataGridViewTextBoxColumn";
            this.iDEquipmentStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompterName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompterName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TagService";
            this.dataGridViewTextBoxColumn3.HeaderText = "TagService";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IP";
            this.dataGridViewTextBoxColumn4.HeaderText = "IP";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WarrantyDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "WarrantyDate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Coments";
            this.dataGridViewTextBoxColumn7.HeaderText = "Coments";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn8.HeaderText = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn9.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn10.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn11.HeaderText = "Job";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CPUVersion";
            this.dataGridViewTextBoxColumn12.HeaderText = "CPUVersion";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "HardDriveVersion";
            this.dataGridViewTextBoxColumn13.HeaderText = "HardDriveVersion";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "LocationName";
            this.dataGridViewTextBoxColumn14.HeaderText = "LocationName";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn15.HeaderText = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ModelVersionComputer";
            this.dataGridViewTextBoxColumn16.HeaderText = "ModelVersionComputer";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn17.HeaderText = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "RAMVersion";
            this.dataGridViewTextBoxColumn18.HeaderText = "RAMVersion";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iDEquipmentStatusDataGridViewTextBoxColumn1
            // 
            this.iDEquipmentStatusDataGridViewTextBoxColumn1.DataPropertyName = "IDEquipmentStatus";
            this.iDEquipmentStatusDataGridViewTextBoxColumn1.HeaderText = "IDEquipmentStatus";
            this.iDEquipmentStatusDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.iDEquipmentStatusDataGridViewTextBoxColumn1.Name = "iDEquipmentStatusDataGridViewTextBoxColumn1";
            this.iDEquipmentStatusDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn19.HeaderText = "Id";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TagService";
            this.dataGridViewTextBoxColumn20.HeaderText = "TagService";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "WarrantyDate";
            this.dataGridViewTextBoxColumn22.HeaderText = "WarrantyDate";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn21.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Coments";
            this.dataGridViewTextBoxColumn23.HeaderText = "Coments";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn24.HeaderText = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn25.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn26.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn27.HeaderText = "Job";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "LocationName";
            this.dataGridViewTextBoxColumn28.HeaderText = "LocationName";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "ModelVersionMonitors";
            this.dataGridViewTextBoxColumn29.HeaderText = "ModelVersionMonitors";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // iDEquipmentStatusDataGridViewTextBoxColumn2
            // 
            this.iDEquipmentStatusDataGridViewTextBoxColumn2.DataPropertyName = "IDEquipmentStatus";
            this.iDEquipmentStatusDataGridViewTextBoxColumn2.HeaderText = "IDEquipmentStatus";
            this.iDEquipmentStatusDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.iDEquipmentStatusDataGridViewTextBoxColumn2.Name = "iDEquipmentStatusDataGridViewTextBoxColumn2";
            this.iDEquipmentStatusDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            this.statusDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn30.HeaderText = "Id";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "NotebooksName";
            this.dataGridViewTextBoxColumn31.HeaderText = "NotebooksName";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "TagService";
            this.dataGridViewTextBoxColumn32.HeaderText = "TagService";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "IP";
            this.dataGridViewTextBoxColumn33.HeaderText = "IP";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "WarrantyDate";
            this.dataGridViewTextBoxColumn35.HeaderText = "WarrantyDate";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn34.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Coments";
            this.dataGridViewTextBoxColumn36.HeaderText = "Coments";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn37.HeaderText = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn38.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn39.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn40.HeaderText = "Job";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "CPUVersion";
            this.dataGridViewTextBoxColumn41.HeaderText = "CPUVersion";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "HardDriveVersion";
            this.dataGridViewTextBoxColumn42.HeaderText = "HardDriveVersion";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "LocationName";
            this.dataGridViewTextBoxColumn43.HeaderText = "LocationName";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn44.HeaderText = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "ModelVersionNotebooks";
            this.dataGridViewTextBoxColumn45.HeaderText = "ModelVersionNotebooks";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn46.HeaderText = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn46.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "RAMVersion";
            this.dataGridViewTextBoxColumn47.HeaderText = "RAMVersion";
            this.dataGridViewTextBoxColumn47.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.panelDAtaGrindView.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn notebooksNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagServiceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyFixedAssetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelVersionMonitorsDataGridViewTextBoxColumn;
        private HelpDeskDB_TESTDataSet helpDeskDB_TESTDataSet;
        private System.Windows.Forms.BindingSource vwAllComputersBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_ComputersTableAdapter vwAll_ComputersTableAdapter;
        private System.Windows.Forms.BindingSource vwAllMonitorsBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_MonitorsTableAdapter vwAll_MonitorsTableAdapter;
        private System.Windows.Forms.BindingSource vwAllNotebooksBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_NotebooksTableAdapter vwAll_NotebooksTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonColorOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEquipmentStatusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
    }
}