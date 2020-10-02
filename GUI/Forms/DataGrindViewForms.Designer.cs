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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.radioButtonColorFilterOFF = new System.Windows.Forms.RadioButton();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.radioButtonColorOn = new System.Windows.Forms.RadioButton();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl_Warehouse = new System.Windows.Forms.TabControl();
            this.tabPageComputers = new System.Windows.Forms.TabPage();
            this.advancedDataGridViewComputers = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwAllComputersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpDeskDB_TESTDataSet = new GUI.HelpDeskDB_TESTDataSet();
            this.tabPageMonitors = new System.Windows.Forms.TabPage();
            this.advancedDataGridViewMonitors = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwAllMonitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageNotebooks = new System.Windows.Forms.TabPage();
            this.advancedDataGridViewNotebooks = new Zuby.ADGV.AdvancedDataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwAllNotebooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwAll_ComputersTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_ComputersTableAdapter();
            this.vwAll_MonitorsTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_MonitorsTableAdapter();
            this.vwAll_NotebooksTableAdapter = new GUI.HelpDeskDB_TESTDataSetTableAdapters.vwAll_NotebooksTableAdapter();
            this.ButtonClearFilter = new GUI.CustomControls.BitmapButton();
            this.buttonFullScrean = new GUI.CustomControls.BitmapButton();
            this.buttonExel = new GUI.CustomControls.BitmapButton();
            this.buttonRefresh = new GUI.CustomControls.BitmapButton();
            this.buttonDelete = new GUI.CustomControls.BitmapButton();
            this.buttonEdit = new GUI.CustomControls.BitmapButton();
            this.buttonCloseDataGrind = new GUI.CustomControls.BitmapButton();
            this.panelDAtaGrindView.SuspendLayout();
            this.panelButtons.SuspendLayout();
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
            this.panelDAtaGrindView.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelDAtaGrindView.Controls.Add(this.panelButtons);
            this.panelDAtaGrindView.Controls.Add(this.tabControl_Warehouse);
            this.panelDAtaGrindView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDAtaGrindView.Location = new System.Drawing.Point(0, 0);
            this.panelDAtaGrindView.Name = "panelDAtaGrindView";
            this.panelDAtaGrindView.Size = new System.Drawing.Size(868, 572);
            this.panelDAtaGrindView.TabIndex = 0;
            this.panelDAtaGrindView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDAtaGrindView_Paint);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.ButtonClearFilter);
            this.panelButtons.Controls.Add(this.radioButtonColorFilterOFF);
            this.panelButtons.Controls.Add(this.splitter7);
            this.panelButtons.Controls.Add(this.buttonFullScrean);
            this.panelButtons.Controls.Add(this.radioButtonColorOn);
            this.panelButtons.Controls.Add(this.splitter6);
            this.panelButtons.Controls.Add(this.buttonExel);
            this.panelButtons.Controls.Add(this.splitter5);
            this.panelButtons.Controls.Add(this.buttonRefresh);
            this.panelButtons.Controls.Add(this.splitter4);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Controls.Add(this.splitter3);
            this.panelButtons.Controls.Add(this.buttonEdit);
            this.panelButtons.Controls.Add(this.splitter2);
            this.panelButtons.Controls.Add(this.buttonCloseDataGrind);
            this.panelButtons.Controls.Add(this.splitter1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(868, 69);
            this.panelButtons.TabIndex = 3;
            // 
            // radioButtonColorFilterOFF
            // 
            this.radioButtonColorFilterOFF.AutoSize = true;
            this.radioButtonColorFilterOFF.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonColorFilterOFF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonColorFilterOFF.ForeColor = System.Drawing.Color.White;
            this.radioButtonColorFilterOFF.Location = new System.Drawing.Point(6, 40);
            this.radioButtonColorFilterOFF.Name = "radioButtonColorFilterOFF";
            this.radioButtonColorFilterOFF.Size = new System.Drawing.Size(122, 22);
            this.radioButtonColorFilterOFF.TabIndex = 4;
            this.radioButtonColorFilterOFF.TabStop = true;
            this.radioButtonColorFilterOFF.Text = "ColorFilter OFF";
            this.radioButtonColorFilterOFF.UseVisualStyleBackColor = false;
            this.radioButtonColorFilterOFF.CheckedChanged += new System.EventHandler(this.radioButtonColorFilterOFF_CheckedChanged);
            // 
            // splitter7
            // 
            this.splitter7.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter7.Location = new System.Drawing.Point(322, 0);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(3, 69);
            this.splitter7.TabIndex = 31;
            this.splitter7.TabStop = false;
            this.splitter7.Visible = false;
            // 
            // radioButtonColorOn
            // 
            this.radioButtonColorOn.AutoSize = true;
            this.radioButtonColorOn.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonColorOn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonColorOn.ForeColor = System.Drawing.Color.White;
            this.radioButtonColorOn.Location = new System.Drawing.Point(7, 12);
            this.radioButtonColorOn.Name = "radioButtonColorOn";
            this.radioButtonColorOn.Size = new System.Drawing.Size(116, 22);
            this.radioButtonColorOn.TabIndex = 2;
            this.radioButtonColorOn.TabStop = true;
            this.radioButtonColorOn.Text = "ColorFilter ON";
            this.radioButtonColorOn.UseVisualStyleBackColor = false;
            this.radioButtonColorOn.CheckedChanged += new System.EventHandler(this.radioButtonColorOn_CheckedChanged);
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter6.Location = new System.Drawing.Point(418, 0);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(3, 69);
            this.splitter6.TabIndex = 29;
            this.splitter6.TabStop = false;
            this.splitter6.Visible = false;
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter5.Location = new System.Drawing.Point(514, 0);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(3, 69);
            this.splitter5.TabIndex = 27;
            this.splitter5.TabStop = false;
            this.splitter5.Visible = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(610, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 69);
            this.splitter4.TabIndex = 25;
            this.splitter4.TabStop = false;
            this.splitter4.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(706, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 69);
            this.splitter3.TabIndex = 23;
            this.splitter3.TabStop = false;
            this.splitter3.Visible = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(802, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 69);
            this.splitter2.TabIndex = 21;
            this.splitter2.TabStop = false;
            this.splitter2.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(865, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 69);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.Visible = false;
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
            this.tabControl_Warehouse.Location = new System.Drawing.Point(0, 76);
            this.tabControl_Warehouse.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Warehouse.Name = "tabControl_Warehouse";
            this.tabControl_Warehouse.SelectedIndex = 0;
            this.tabControl_Warehouse.Size = new System.Drawing.Size(868, 496);
            this.tabControl_Warehouse.TabIndex = 1;
            // 
            // tabPageComputers
            // 
            this.tabPageComputers.Controls.Add(this.advancedDataGridViewComputers);
            this.tabPageComputers.Location = new System.Drawing.Point(4, 22);
            this.tabPageComputers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageComputers.Name = "tabPageComputers";
            this.tabPageComputers.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageComputers.Size = new System.Drawing.Size(860, 470);
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
            this.dataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
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
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.advancedDataGridViewComputers.DataSource = this.vwAllComputersBindingSource;
            this.advancedDataGridViewComputers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridViewComputers.FilterAndSortEnabled = true;
            this.advancedDataGridViewComputers.Location = new System.Drawing.Point(4, 4);
            this.advancedDataGridViewComputers.Name = "advancedDataGridViewComputers";
            this.advancedDataGridViewComputers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridViewComputers.Size = new System.Drawing.Size(852, 462);
            this.advancedDataGridViewComputers.TabIndex = 0;
            this.advancedDataGridViewComputers.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridViewComputers_SortStringChanged);
            this.advancedDataGridViewComputers.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.advancedDataGridViewComputers_FilterStringChanged);
            this.advancedDataGridViewComputers.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.advancedDataGridViewComputers_RowPrePaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDEquipmentStatus";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDEquipmentStatus";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompterName";
            this.dataGridViewTextBoxColumn3.HeaderText = "CompterName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TagService";
            this.dataGridViewTextBoxColumn4.HeaderText = "TagService";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IP";
            this.dataGridViewTextBoxColumn5.HeaderText = "IP";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "WarrantyDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "WarrantyDate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Coments";
            this.dataGridViewTextBoxColumn8.HeaderText = "Coments";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn9.HeaderText = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn10.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn11.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn12.HeaderText = "Job";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CPUVersion";
            this.dataGridViewTextBoxColumn13.HeaderText = "CPUVersion";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "HardDriveVersion";
            this.dataGridViewTextBoxColumn14.HeaderText = "HardDriveVersion";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "LocationName";
            this.dataGridViewTextBoxColumn15.HeaderText = "LocationName";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn16.HeaderText = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ModelVersionComputer";
            this.dataGridViewTextBoxColumn17.HeaderText = "ModelVersionComputer";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn18.HeaderText = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "RAMVersion";
            this.dataGridViewTextBoxColumn19.HeaderText = "RAMVersion";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.tabPageMonitors.Size = new System.Drawing.Size(860, 470);
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
            this.dataGridViewTextBoxColumn20,
            this.statusDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31});
            this.advancedDataGridViewMonitors.DataSource = this.vwAllMonitorsBindingSource;
            this.advancedDataGridViewMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridViewMonitors.FilterAndSortEnabled = true;
            this.advancedDataGridViewMonitors.Location = new System.Drawing.Point(4, 4);
            this.advancedDataGridViewMonitors.Name = "advancedDataGridViewMonitors";
            this.advancedDataGridViewMonitors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridViewMonitors.Size = new System.Drawing.Size(852, 462);
            this.advancedDataGridViewMonitors.TabIndex = 0;
            this.advancedDataGridViewMonitors.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridViewMonitors_SortStringChanged);
            this.advancedDataGridViewMonitors.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.advancedDataGridViewMonitors_FilterStringChanged);
            this.advancedDataGridViewMonitors.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.advancedDataGridViewMonitors_RowPrePaint);
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "IDEquipmentStatus";
            this.dataGridViewTextBoxColumn20.HeaderText = "IDEquipmentStatus";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn21.HeaderText = "Id";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "TagService";
            this.dataGridViewTextBoxColumn22.HeaderText = "TagService";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "WarrantyDate";
            this.dataGridViewTextBoxColumn23.HeaderText = "WarrantyDate";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn24.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Coments";
            this.dataGridViewTextBoxColumn25.HeaderText = "Coments";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn26.HeaderText = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn27.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn28.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn29.HeaderText = "Job";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "LocationName";
            this.dataGridViewTextBoxColumn30.HeaderText = "LocationName";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "ModelVersionMonitors";
            this.dataGridViewTextBoxColumn31.HeaderText = "ModelVersionMonitors";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.tabPageNotebooks.Size = new System.Drawing.Size(860, 470);
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
            this.dataGridViewTextBoxColumn32,
            this.statusDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
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
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50});
            this.advancedDataGridViewNotebooks.DataSource = this.vwAllNotebooksBindingSource;
            this.advancedDataGridViewNotebooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridViewNotebooks.FilterAndSortEnabled = true;
            this.advancedDataGridViewNotebooks.Location = new System.Drawing.Point(4, 4);
            this.advancedDataGridViewNotebooks.Name = "advancedDataGridViewNotebooks";
            this.advancedDataGridViewNotebooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridViewNotebooks.Size = new System.Drawing.Size(852, 462);
            this.advancedDataGridViewNotebooks.TabIndex = 0;
            this.advancedDataGridViewNotebooks.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.advancedDataGridViewNotebooks_SortStringChanged);
            this.advancedDataGridViewNotebooks.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.advancedDataGridViewNotebooks_FilterStringChanged);
            this.advancedDataGridViewNotebooks.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.advancedDataGridViewNotebooks_RowPrePaint);
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "IDEquipmentStatus";
            this.dataGridViewTextBoxColumn32.HeaderText = "IDEquipmentStatus";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn2.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            this.statusDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn33.HeaderText = "Id";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "NotebooksName";
            this.dataGridViewTextBoxColumn34.HeaderText = "NotebooksName";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "TagService";
            this.dataGridViewTextBoxColumn35.HeaderText = "TagService";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "IP";
            this.dataGridViewTextBoxColumn36.HeaderText = "IP";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "WarrantyDate";
            this.dataGridViewTextBoxColumn37.HeaderText = "WarrantyDate";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "PurchaseDate";
            this.dataGridViewTextBoxColumn38.HeaderText = "PurchaseDate";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Coments";
            this.dataGridViewTextBoxColumn39.HeaderText = "Coments";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn40.HeaderText = "CompanyFixedAsset";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn41.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn42.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Job";
            this.dataGridViewTextBoxColumn43.HeaderText = "Job";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "CPUVersion";
            this.dataGridViewTextBoxColumn44.HeaderText = "CPUVersion";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "HardDriveVersion";
            this.dataGridViewTextBoxColumn45.HeaderText = "HardDriveVersion";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "LocationName";
            this.dataGridViewTextBoxColumn46.HeaderText = "LocationName";
            this.dataGridViewTextBoxColumn46.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn47.HeaderText = "MicrosoftOfficeVersion";
            this.dataGridViewTextBoxColumn47.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "ModelVersionNotebooks";
            this.dataGridViewTextBoxColumn48.HeaderText = "ModelVersionNotebooks";
            this.dataGridViewTextBoxColumn48.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn49.HeaderText = "OperatingSystemVersion";
            this.dataGridViewTextBoxColumn49.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "RAMVersion";
            this.dataGridViewTextBoxColumn50.HeaderText = "RAMVersion";
            this.dataGridViewTextBoxColumn50.MinimumWidth = 22;
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // ButtonClearFilter
            // 
            this.ButtonClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClearFilter.BorderColor = System.Drawing.Color.DimGray;
            this.ButtonClearFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClearFilter.FocusRectangleEnabled = true;
            this.ButtonClearFilter.Image = null;
            this.ButtonClearFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonClearFilter.ImageBorderColor = System.Drawing.Color.Transparent;
            this.ButtonClearFilter.ImageBorderEnabled = true;
            this.ButtonClearFilter.ImageDropShadow = true;
            this.ButtonClearFilter.ImageFocused = ((System.Drawing.Image)(resources.GetObject("ButtonClearFilter.ImageFocused")));
            this.ButtonClearFilter.ImageInactive = null;
            this.ButtonClearFilter.ImageMouseOver = ((System.Drawing.Image)(resources.GetObject("ButtonClearFilter.ImageMouseOver")));
            this.ButtonClearFilter.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ButtonClearFilter.ImageNormal")));
            this.ButtonClearFilter.ImagePressed = null;
            this.ButtonClearFilter.InnerBorderColor = System.Drawing.Color.Transparent;
            this.ButtonClearFilter.InnerBorderColor_Focus = System.Drawing.Color.Transparent;
            this.ButtonClearFilter.InnerBorderColor_MouseOver = System.Drawing.Color.Transparent;
            this.ButtonClearFilter.Location = new System.Drawing.Point(229, 0);
            this.ButtonClearFilter.Name = "ButtonClearFilter";
            this.ButtonClearFilter.OffsetPressedContent = true;
            this.ButtonClearFilter.Size = new System.Drawing.Size(93, 69);
            this.ButtonClearFilter.StretchImage = false;
            this.ButtonClearFilter.TabIndex = 32;
            this.ButtonClearFilter.Text = "Clear All Filter";
            this.ButtonClearFilter.TextDropShadow = true;
            this.ButtonClearFilter.UseVisualStyleBackColor = false;
            this.ButtonClearFilter.Click += new System.EventHandler(this.ButtonClearFilter_Click);
            // 
            // buttonFullScrean
            // 
            this.buttonFullScrean.BackColor = System.Drawing.Color.Transparent;
            this.buttonFullScrean.BorderColor = System.Drawing.Color.DimGray;
            this.buttonFullScrean.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFullScrean.FocusRectangleEnabled = true;
            this.buttonFullScrean.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.buttonFullScrean.Image = null;
            this.buttonFullScrean.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFullScrean.ImageBorderColor = System.Drawing.Color.Transparent;
            this.buttonFullScrean.ImageBorderEnabled = true;
            this.buttonFullScrean.ImageDropShadow = true;
            this.buttonFullScrean.ImageFocused = ((System.Drawing.Image)(resources.GetObject("buttonFullScrean.ImageFocused")));
            this.buttonFullScrean.ImageInactive = null;
            this.buttonFullScrean.ImageMouseOver = ((System.Drawing.Image)(resources.GetObject("buttonFullScrean.ImageMouseOver")));
            this.buttonFullScrean.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonFullScrean.ImageNormal")));
            this.buttonFullScrean.ImagePressed = null;
            this.buttonFullScrean.InnerBorderColor = System.Drawing.Color.Transparent;
            this.buttonFullScrean.InnerBorderColor_Focus = System.Drawing.Color.Transparent;
            this.buttonFullScrean.InnerBorderColor_MouseOver = System.Drawing.Color.Transparent;
            this.buttonFullScrean.Location = new System.Drawing.Point(325, 0);
            this.buttonFullScrean.Name = "buttonFullScrean";
            this.buttonFullScrean.OffsetPressedContent = true;
            this.buttonFullScrean.Size = new System.Drawing.Size(93, 69);
            this.buttonFullScrean.StretchImage = false;
            this.buttonFullScrean.TabIndex = 30;
            this.buttonFullScrean.Text = "FullScrean";
            this.buttonFullScrean.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFullScrean.TextDropShadow = true;
            this.buttonFullScrean.UseVisualStyleBackColor = false;
            this.buttonFullScrean.Click += new System.EventHandler(this.buttonFullScrean_Click);
            // 
            // buttonExel
            // 
            this.buttonExel.BackColor = System.Drawing.Color.Transparent;
            this.buttonExel.BorderColor = System.Drawing.Color.DimGray;
            this.buttonExel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExel.FocusRectangleEnabled = true;
            this.buttonExel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.buttonExel.Image = null;
            this.buttonExel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExel.ImageBorderColor = System.Drawing.Color.Transparent;
            this.buttonExel.ImageBorderEnabled = true;
            this.buttonExel.ImageDropShadow = true;
            this.buttonExel.ImageFocused = ((System.Drawing.Image)(resources.GetObject("buttonExel.ImageFocused")));
            this.buttonExel.ImageInactive = null;
            this.buttonExel.ImageMouseOver = ((System.Drawing.Image)(resources.GetObject("buttonExel.ImageMouseOver")));
            this.buttonExel.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonExel.ImageNormal")));
            this.buttonExel.ImagePressed = null;
            this.buttonExel.InnerBorderColor = System.Drawing.Color.Transparent;
            this.buttonExel.InnerBorderColor_Focus = System.Drawing.Color.Transparent;
            this.buttonExel.InnerBorderColor_MouseOver = System.Drawing.Color.Transparent;
            this.buttonExel.Location = new System.Drawing.Point(421, 0);
            this.buttonExel.Name = "buttonExel";
            this.buttonExel.OffsetPressedContent = true;
            this.buttonExel.Size = new System.Drawing.Size(93, 69);
            this.buttonExel.StretchImage = false;
            this.buttonExel.TabIndex = 28;
            this.buttonExel.Text = "Exel";
            this.buttonExel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExel.TextDropShadow = true;
            this.buttonExel.UseVisualStyleBackColor = false;
            this.buttonExel.Click += new System.EventHandler(this.buttonExel_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.BorderColor = System.Drawing.Color.DimGray;
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefresh.FocusRectangleEnabled = true;
            this.buttonRefresh.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.buttonRefresh.Image = null;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.ImageBorderColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.ImageBorderEnabled = true;
            this.buttonRefresh.ImageDropShadow = true;
            this.buttonRefresh.ImageFocused = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.ImageFocused")));
            this.buttonRefresh.ImageInactive = null;
            this.buttonRefresh.ImageMouseOver = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.ImageMouseOver")));
            this.buttonRefresh.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.ImageNormal")));
            this.buttonRefresh.ImagePressed = null;
            this.buttonRefresh.InnerBorderColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.InnerBorderColor_Focus = System.Drawing.Color.Transparent;
            this.buttonRefresh.InnerBorderColor_MouseOver = System.Drawing.Color.Transparent;
            this.buttonRefresh.Location = new System.Drawing.Point(517, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.OffsetPressedContent = true;
            this.buttonRefresh.Size = new System.Drawing.Size(93, 69);
            this.buttonRefresh.StretchImage = false;
            this.buttonRefresh.TabIndex = 26;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.TextDropShadow = true;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BorderColor = System.Drawing.Color.DimGray;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.FocusRectangleEnabled = true;
            this.buttonDelete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.buttonDelete.Image = null;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.ImageBorderColor = System.Drawing.Color.Transparent;
            this.buttonDelete.ImageBorderEnabled = true;
            this.buttonDelete.ImageDropShadow = true;
            this.buttonDelete.ImageFocused = ((System.Drawing.Image)(resources.GetObject("buttonDelete.ImageFocused")));
            this.buttonDelete.ImageInactive = null;
            this.buttonDelete.ImageMouseOver = ((System.Drawing.Image)(resources.GetObject("buttonDelete.ImageMouseOver")));
            this.buttonDelete.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonDelete.ImageNormal")));
            this.buttonDelete.ImagePressed = null;
            this.buttonDelete.InnerBorderColor = System.Drawing.Color.Transparent;
            this.buttonDelete.InnerBorderColor_Focus = System.Drawing.Color.Transparent;
            this.buttonDelete.InnerBorderColor_MouseOver = System.Drawing.Color.Transparent;
            this.buttonDelete.Location = new System.Drawing.Point(613, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.OffsetPressedContent = true;
            this.buttonDelete.Size = new System.Drawing.Size(93, 69);
            this.buttonDelete.StretchImage = false;
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.TextDropShadow = true;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BorderColor = System.Drawing.Color.DimGray;
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEdit.FocusRectangleEnabled = true;
            this.buttonEdit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.buttonEdit.Image = null;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.ImageBorderColor = System.Drawing.Color.Transparent;
            this.buttonEdit.ImageBorderEnabled = true;
            this.buttonEdit.ImageDropShadow = true;
            this.buttonEdit.ImageFocused = ((System.Drawing.Image)(resources.GetObject("buttonEdit.ImageFocused")));
            this.buttonEdit.ImageInactive = null;
            this.buttonEdit.ImageMouseOver = ((System.Drawing.Image)(resources.GetObject("buttonEdit.ImageMouseOver")));
            this.buttonEdit.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonEdit.ImageNormal")));
            this.buttonEdit.ImagePressed = null;
            this.buttonEdit.InnerBorderColor = System.Drawing.Color.Transparent;
            this.buttonEdit.InnerBorderColor_Focus = System.Drawing.Color.Transparent;
            this.buttonEdit.InnerBorderColor_MouseOver = System.Drawing.Color.Transparent;
            this.buttonEdit.Location = new System.Drawing.Point(709, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.OffsetPressedContent = true;
            this.buttonEdit.Size = new System.Drawing.Size(93, 69);
            this.buttonEdit.StretchImage = false;
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.TextDropShadow = true;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCloseDataGrind
            // 
            this.buttonCloseDataGrind.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseDataGrind.BorderColor = System.Drawing.Color.DimGray;
            this.buttonCloseDataGrind.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseDataGrind.FocusRectangleEnabled = true;
            this.buttonCloseDataGrind.Image = null;
            this.buttonCloseDataGrind.ImageBorderColor = System.Drawing.Color.Transparent;
            this.buttonCloseDataGrind.ImageBorderEnabled = true;
            this.buttonCloseDataGrind.ImageDropShadow = true;
            this.buttonCloseDataGrind.ImageFocused = ((System.Drawing.Image)(resources.GetObject("buttonCloseDataGrind.ImageFocused")));
            this.buttonCloseDataGrind.ImageInactive = null;
            this.buttonCloseDataGrind.ImageMouseOver = ((System.Drawing.Image)(resources.GetObject("buttonCloseDataGrind.ImageMouseOver")));
            this.buttonCloseDataGrind.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonCloseDataGrind.ImageNormal")));
            this.buttonCloseDataGrind.ImagePressed = null;
            this.buttonCloseDataGrind.InnerBorderColor = System.Drawing.Color.Transparent;
            this.buttonCloseDataGrind.InnerBorderColor_Focus = System.Drawing.Color.Transparent;
            this.buttonCloseDataGrind.InnerBorderColor_MouseOver = System.Drawing.Color.Transparent;
            this.buttonCloseDataGrind.Location = new System.Drawing.Point(805, 0);
            this.buttonCloseDataGrind.Name = "buttonCloseDataGrind";
            this.buttonCloseDataGrind.OffsetPressedContent = true;
            this.buttonCloseDataGrind.Size = new System.Drawing.Size(60, 69);
            this.buttonCloseDataGrind.StretchImage = false;
            this.buttonCloseDataGrind.TabIndex = 20;
            this.buttonCloseDataGrind.TextDropShadow = true;
            this.buttonCloseDataGrind.UseVisualStyleBackColor = false;
            this.buttonCloseDataGrind.Click += new System.EventHandler(this.buttonCloseDataGrind_Click);
            // 
            // DataGrindViewForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 572);
            this.Controls.Add(this.panelDAtaGrindView);
            this.Name = "DataGrindViewForms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataGrindViewForms";
            this.Load += new System.EventHandler(this.DataGrindViewForms_Load);
            this.panelDAtaGrindView.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
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

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewComputers;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewMonitors;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewNotebooks;
        private System.Windows.Forms.RadioButton radioButtonColorOn;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter7;
        private CustomControls.BitmapButton buttonFullScrean;
        private System.Windows.Forms.Splitter splitter6;
        private CustomControls.BitmapButton buttonExel;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Splitter splitter4;
        private CustomControls.BitmapButton buttonDelete;
        private System.Windows.Forms.Splitter splitter3;
        private CustomControls.BitmapButton buttonEdit;
        private System.Windows.Forms.Splitter splitter2;
        private CustomControls.BitmapButton buttonCloseDataGrind;
        private CustomControls.BitmapButton buttonRefresh;
       
        private HelpDeskDB_TESTDataSet helpDeskDB_TESTDataSet;
        private System.Windows.Forms.BindingSource vwAllComputersBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_ComputersTableAdapter vwAll_ComputersTableAdapter;
        private System.Windows.Forms.BindingSource vwAllMonitorsBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_MonitorsTableAdapter vwAll_MonitorsTableAdapter;
        private System.Windows.Forms.BindingSource vwAllNotebooksBindingSource;
        private HelpDeskDB_TESTDataSetTableAdapters.vwAll_NotebooksTableAdapter vwAll_NotebooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.RadioButton radioButtonColorFilterOFF;
        private CustomControls.BitmapButton ButtonClearFilter;
    }
}