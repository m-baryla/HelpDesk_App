namespace GUI.Forms
{
    partial class AddMonitorForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMonitorForms));
            this.comboBoxModelMonitors = new System.Windows.Forms.ComboBox();
            this.tabPageInserForm = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerWarrantyDateMonitors = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPurchaseDateMonitors = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfPurchaseMonitor = new System.Windows.Forms.Label();
            this.labelWarrantyDateMonitor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCompanyFixedAssetMonitor = new System.Windows.Forms.Label();
            this.linkLabelAddNewModel = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddNewUser = new System.Windows.Forms.LinkLabel();
            this.labelLocationMonitor = new System.Windows.Forms.Label();
            this.labelModelMonitor = new System.Windows.Forms.Label();
            this.linkLabelAddNewLocation = new System.Windows.Forms.LinkLabel();
            this.labelTagServiceMonitor = new System.Windows.Forms.Label();
            this.comboBoxLocationMonitors = new System.Windows.Forms.ComboBox();
            this.labelUserMonitor = new System.Windows.Forms.Label();
            this.textBoxUserMonitors = new System.Windows.Forms.TextBox();
            this.textBoxCompanyFixedAssetMonitors = new System.Windows.Forms.TextBox();
            this.textBoxTagServiceMonitors = new System.Windows.Forms.TextBox();
            this.richTextBoxComentsMonitors = new System.Windows.Forms.RichTextBox();
            this.buttonGenerateCodeMonitor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonInsertDataMonitors = new System.Windows.Forms.Button();
            this.panelAddNewMonitors = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCloseMonitor = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageComentsMonitor = new System.Windows.Forms.TabPage();
            this.labelComentsMonitor = new System.Windows.Forms.Label();
            this.tabPageBarcodeMonitor = new System.Windows.Forms.TabPage();
            this.tabPageInserForm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAddNewMonitors.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageComentsMonitor.SuspendLayout();
            this.tabPageBarcodeMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxModelMonitors
            // 
            this.comboBoxModelMonitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxModelMonitors.FormattingEnabled = true;
            this.comboBoxModelMonitors.Location = new System.Drawing.Point(170, 210);
            this.comboBoxModelMonitors.Name = "comboBoxModelMonitors";
            this.comboBoxModelMonitors.Size = new System.Drawing.Size(177, 21);
            this.comboBoxModelMonitors.TabIndex = 10;
            // 
            // tabPageInserForm
            // 
            this.tabPageInserForm.BackColor = System.Drawing.Color.Black;
            this.tabPageInserForm.Controls.Add(this.groupBox2);
            this.tabPageInserForm.Controls.Add(this.groupBox1);
            this.tabPageInserForm.Location = new System.Drawing.Point(4, 22);
            this.tabPageInserForm.Name = "tabPageInserForm";
            this.tabPageInserForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInserForm.Size = new System.Drawing.Size(731, 432);
            this.tabPageInserForm.TabIndex = 0;
            this.tabPageInserForm.Text = "Insert Form";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dateTimePickerWarrantyDateMonitors);
            this.groupBox2.Controls.Add(this.dateTimePickerPurchaseDateMonitors);
            this.groupBox2.Controls.Add(this.labelDateOfPurchaseMonitor);
            this.groupBox2.Controls.Add(this.labelWarrantyDateMonitor);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(411, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 159);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // dateTimePickerWarrantyDateMonitors
            // 
            this.dateTimePickerWarrantyDateMonitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerWarrantyDateMonitors.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerWarrantyDateMonitors.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerWarrantyDateMonitors.Location = new System.Drawing.Point(157, 42);
            this.dateTimePickerWarrantyDateMonitors.Name = "dateTimePickerWarrantyDateMonitors";
            this.dateTimePickerWarrantyDateMonitors.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerWarrantyDateMonitors.TabIndex = 15;
            // 
            // dateTimePickerPurchaseDateMonitors
            // 
            this.dateTimePickerPurchaseDateMonitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerPurchaseDateMonitors.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerPurchaseDateMonitors.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPurchaseDateMonitors.Location = new System.Drawing.Point(157, 93);
            this.dateTimePickerPurchaseDateMonitors.Name = "dateTimePickerPurchaseDateMonitors";
            this.dateTimePickerPurchaseDateMonitors.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerPurchaseDateMonitors.TabIndex = 16;
            // 
            // labelDateOfPurchaseMonitor
            // 
            this.labelDateOfPurchaseMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateOfPurchaseMonitor.AutoSize = true;
            this.labelDateOfPurchaseMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateOfPurchaseMonitor.ForeColor = System.Drawing.Color.White;
            this.labelDateOfPurchaseMonitor.Location = new System.Drawing.Point(14, 97);
            this.labelDateOfPurchaseMonitor.Name = "labelDateOfPurchaseMonitor";
            this.labelDateOfPurchaseMonitor.Size = new System.Drawing.Size(106, 16);
            this.labelDateOfPurchaseMonitor.TabIndex = 14;
            this.labelDateOfPurchaseMonitor.Text = "Purchase Date : ";
            // 
            // labelWarrantyDateMonitor
            // 
            this.labelWarrantyDateMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWarrantyDateMonitor.AutoSize = true;
            this.labelWarrantyDateMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarrantyDateMonitor.ForeColor = System.Drawing.Color.White;
            this.labelWarrantyDateMonitor.Location = new System.Drawing.Point(14, 42);
            this.labelWarrantyDateMonitor.Name = "labelWarrantyDateMonitor";
            this.labelWarrantyDateMonitor.Size = new System.Drawing.Size(103, 16);
            this.labelWarrantyDateMonitor.TabIndex = 13;
            this.labelWarrantyDateMonitor.Text = "Warranty Date : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.labelCompanyFixedAssetMonitor);
            this.groupBox1.Controls.Add(this.linkLabelAddNewModel);
            this.groupBox1.Controls.Add(this.linkLabelAddNewUser);
            this.groupBox1.Controls.Add(this.comboBoxModelMonitors);
            this.groupBox1.Controls.Add(this.labelLocationMonitor);
            this.groupBox1.Controls.Add(this.labelModelMonitor);
            this.groupBox1.Controls.Add(this.linkLabelAddNewLocation);
            this.groupBox1.Controls.Add(this.labelTagServiceMonitor);
            this.groupBox1.Controls.Add(this.comboBoxLocationMonitors);
            this.groupBox1.Controls.Add(this.labelUserMonitor);
            this.groupBox1.Controls.Add(this.textBoxUserMonitors);
            this.groupBox1.Controls.Add(this.textBoxCompanyFixedAssetMonitors);
            this.groupBox1.Controls.Add(this.textBoxTagServiceMonitors);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 260);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware Info";
            // 
            // labelCompanyFixedAssetMonitor
            // 
            this.labelCompanyFixedAssetMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCompanyFixedAssetMonitor.AutoSize = true;
            this.labelCompanyFixedAssetMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCompanyFixedAssetMonitor.ForeColor = System.Drawing.Color.White;
            this.labelCompanyFixedAssetMonitor.Location = new System.Drawing.Point(16, 41);
            this.labelCompanyFixedAssetMonitor.Name = "labelCompanyFixedAssetMonitor";
            this.labelCompanyFixedAssetMonitor.Size = new System.Drawing.Size(148, 16);
            this.labelCompanyFixedAssetMonitor.TabIndex = 10;
            this.labelCompanyFixedAssetMonitor.Text = "Company Fixed Asset : ";
            // 
            // linkLabelAddNewModel
            // 
            this.linkLabelAddNewModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelAddNewModel.AutoSize = true;
            this.linkLabelAddNewModel.LinkColor = System.Drawing.Color.Red;
            this.linkLabelAddNewModel.Location = new System.Drawing.Point(217, 232);
            this.linkLabelAddNewModel.Name = "linkLabelAddNewModel";
            this.linkLabelAddNewModel.Size = new System.Drawing.Size(83, 13);
            this.linkLabelAddNewModel.TabIndex = 16;
            this.linkLabelAddNewModel.TabStop = true;
            this.linkLabelAddNewModel.Text = "Add New Model";
            this.linkLabelAddNewModel.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabelAddNewModel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewModel_LinkClicked);
            // 
            // linkLabelAddNewUser
            // 
            this.linkLabelAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelAddNewUser.AutoSize = true;
            this.linkLabelAddNewUser.LinkColor = System.Drawing.Color.Red;
            this.linkLabelAddNewUser.Location = new System.Drawing.Point(220, 185);
            this.linkLabelAddNewUser.Name = "linkLabelAddNewUser";
            this.linkLabelAddNewUser.Size = new System.Drawing.Size(76, 13);
            this.linkLabelAddNewUser.TabIndex = 31;
            this.linkLabelAddNewUser.TabStop = true;
            this.linkLabelAddNewUser.Text = "Add New User";
            this.linkLabelAddNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewUser_LinkClicked);
            // 
            // labelLocationMonitor
            // 
            this.labelLocationMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLocationMonitor.AutoSize = true;
            this.labelLocationMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLocationMonitor.ForeColor = System.Drawing.Color.White;
            this.labelLocationMonitor.Location = new System.Drawing.Point(16, 125);
            this.labelLocationMonitor.Name = "labelLocationMonitor";
            this.labelLocationMonitor.Size = new System.Drawing.Size(68, 16);
            this.labelLocationMonitor.TabIndex = 1;
            this.labelLocationMonitor.Text = "Location : ";
            // 
            // labelModelMonitor
            // 
            this.labelModelMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelModelMonitor.AutoSize = true;
            this.labelModelMonitor.BackColor = System.Drawing.Color.Black;
            this.labelModelMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModelMonitor.ForeColor = System.Drawing.Color.White;
            this.labelModelMonitor.Location = new System.Drawing.Point(16, 215);
            this.labelModelMonitor.Name = "labelModelMonitor";
            this.labelModelMonitor.Size = new System.Drawing.Size(55, 16);
            this.labelModelMonitor.TabIndex = 9;
            this.labelModelMonitor.Text = "Model : ";
            // 
            // linkLabelAddNewLocation
            // 
            this.linkLabelAddNewLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelAddNewLocation.AutoSize = true;
            this.linkLabelAddNewLocation.LinkColor = System.Drawing.Color.Red;
            this.linkLabelAddNewLocation.Location = new System.Drawing.Point(211, 142);
            this.linkLabelAddNewLocation.Name = "linkLabelAddNewLocation";
            this.linkLabelAddNewLocation.Size = new System.Drawing.Size(95, 13);
            this.linkLabelAddNewLocation.TabIndex = 30;
            this.linkLabelAddNewLocation.TabStop = true;
            this.linkLabelAddNewLocation.Text = "Add New Location";
            this.linkLabelAddNewLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewLocation_LinkClicked);
            // 
            // labelTagServiceMonitor
            // 
            this.labelTagServiceMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTagServiceMonitor.AutoSize = true;
            this.labelTagServiceMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTagServiceMonitor.ForeColor = System.Drawing.Color.White;
            this.labelTagServiceMonitor.Location = new System.Drawing.Point(16, 81);
            this.labelTagServiceMonitor.Name = "labelTagServiceMonitor";
            this.labelTagServiceMonitor.Size = new System.Drawing.Size(91, 16);
            this.labelTagServiceMonitor.TabIndex = 8;
            this.labelTagServiceMonitor.Text = "Tag Service : ";
            // 
            // comboBoxLocationMonitors
            // 
            this.comboBoxLocationMonitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLocationMonitors.FormattingEnabled = true;
            this.comboBoxLocationMonitors.Location = new System.Drawing.Point(170, 120);
            this.comboBoxLocationMonitors.Name = "comboBoxLocationMonitors";
            this.comboBoxLocationMonitors.Size = new System.Drawing.Size(177, 21);
            this.comboBoxLocationMonitors.TabIndex = 20;
            // 
            // labelUserMonitor
            // 
            this.labelUserMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserMonitor.AutoSize = true;
            this.labelUserMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserMonitor.ForeColor = System.Drawing.Color.White;
            this.labelUserMonitor.Location = new System.Drawing.Point(16, 168);
            this.labelUserMonitor.Name = "labelUserMonitor";
            this.labelUserMonitor.Size = new System.Drawing.Size(46, 16);
            this.labelUserMonitor.TabIndex = 18;
            this.labelUserMonitor.Text = "User : ";
            // 
            // textBoxUserMonitors
            // 
            this.textBoxUserMonitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserMonitors.Location = new System.Drawing.Point(170, 164);
            this.textBoxUserMonitors.Name = "textBoxUserMonitors";
            this.textBoxUserMonitors.Size = new System.Drawing.Size(177, 20);
            this.textBoxUserMonitors.TabIndex = 25;
            // 
            // textBoxCompanyFixedAssetMonitors
            // 
            this.textBoxCompanyFixedAssetMonitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCompanyFixedAssetMonitors.Location = new System.Drawing.Point(170, 37);
            this.textBoxCompanyFixedAssetMonitors.Name = "textBoxCompanyFixedAssetMonitors";
            this.textBoxCompanyFixedAssetMonitors.Size = new System.Drawing.Size(177, 20);
            this.textBoxCompanyFixedAssetMonitors.TabIndex = 23;
            // 
            // textBoxTagServiceMonitors
            // 
            this.textBoxTagServiceMonitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTagServiceMonitors.Location = new System.Drawing.Point(170, 80);
            this.textBoxTagServiceMonitors.Name = "textBoxTagServiceMonitors";
            this.textBoxTagServiceMonitors.Size = new System.Drawing.Size(177, 20);
            this.textBoxTagServiceMonitors.TabIndex = 24;
            // 
            // richTextBoxComentsMonitors
            // 
            this.richTextBoxComentsMonitors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxComentsMonitors.Location = new System.Drawing.Point(142, 53);
            this.richTextBoxComentsMonitors.Name = "richTextBoxComentsMonitors";
            this.richTextBoxComentsMonitors.Size = new System.Drawing.Size(581, 371);
            this.richTextBoxComentsMonitors.TabIndex = 18;
            this.richTextBoxComentsMonitors.Text = "";
            // 
            // buttonGenerateCodeMonitor
            // 
            this.buttonGenerateCodeMonitor.BackColor = System.Drawing.Color.White;
            this.buttonGenerateCodeMonitor.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateCodeMonitor.Image = ((System.Drawing.Image)(resources.GetObject("buttonGenerateCodeMonitor.Image")));
            this.buttonGenerateCodeMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGenerateCodeMonitor.Location = new System.Drawing.Point(173, 103);
            this.buttonGenerateCodeMonitor.Name = "buttonGenerateCodeMonitor";
            this.buttonGenerateCodeMonitor.Size = new System.Drawing.Size(341, 70);
            this.buttonGenerateCodeMonitor.TabIndex = 20;
            this.buttonGenerateCodeMonitor.Text = "Generate Code";
            this.buttonGenerateCodeMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGenerateCodeMonitor.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(199, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 98);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonInsertDataMonitors
            // 
            this.buttonInsertDataMonitors.BackColor = System.Drawing.Color.Black;
            this.buttonInsertDataMonitors.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInsertDataMonitors.FlatAppearance.BorderSize = 2;
            this.buttonInsertDataMonitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertDataMonitors.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonInsertDataMonitors.ForeColor = System.Drawing.Color.White;
            this.buttonInsertDataMonitors.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsertDataMonitors.Image")));
            this.buttonInsertDataMonitors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInsertDataMonitors.Location = new System.Drawing.Point(509, 0);
            this.buttonInsertDataMonitors.Name = "buttonInsertDataMonitors";
            this.buttonInsertDataMonitors.Size = new System.Drawing.Size(180, 50);
            this.buttonInsertDataMonitors.TabIndex = 27;
            this.buttonInsertDataMonitors.Text = "Insert Data";
            this.buttonInsertDataMonitors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInsertDataMonitors.UseVisualStyleBackColor = false;
            this.buttonInsertDataMonitors.Click += new System.EventHandler(this.buttonInsertDataMonitors_Click);
            // 
            // panelAddNewMonitors
            // 
            this.panelAddNewMonitors.BackColor = System.Drawing.Color.Black;
            this.panelAddNewMonitors.Controls.Add(this.panel1);
            this.panelAddNewMonitors.Controls.Add(this.tabControl1);
            this.panelAddNewMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNewMonitors.Location = new System.Drawing.Point(0, 0);
            this.panelAddNewMonitors.Name = "panelAddNewMonitors";
            this.panelAddNewMonitors.Size = new System.Drawing.Size(739, 572);
            this.panelAddNewMonitors.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonInsertDataMonitors);
            this.panel1.Controls.Add(this.buttonCloseMonitor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 50);
            this.panel1.TabIndex = 29;
            // 
            // buttonCloseMonitor
            // 
            this.buttonCloseMonitor.BackColor = System.Drawing.Color.Black;
            this.buttonCloseMonitor.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseMonitor.FlatAppearance.BorderSize = 2;
            this.buttonCloseMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseMonitor.Font = new System.Drawing.Font("Algerian", 36F);
            this.buttonCloseMonitor.ForeColor = System.Drawing.Color.White;
            this.buttonCloseMonitor.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseMonitor.Image")));
            this.buttonCloseMonitor.Location = new System.Drawing.Point(689, 0);
            this.buttonCloseMonitor.Name = "buttonCloseMonitor";
            this.buttonCloseMonitor.Size = new System.Drawing.Size(50, 50);
            this.buttonCloseMonitor.TabIndex = 28;
            this.buttonCloseMonitor.UseVisualStyleBackColor = false;
            this.buttonCloseMonitor.Click += new System.EventHandler(this.buttonCloseMonitor_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInserForm);
            this.tabControl1.Controls.Add(this.tabPageComentsMonitor);
            this.tabControl1.Controls.Add(this.tabPageBarcodeMonitor);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 458);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPageComentsMonitor
            // 
            this.tabPageComentsMonitor.BackColor = System.Drawing.Color.Black;
            this.tabPageComentsMonitor.Controls.Add(this.richTextBoxComentsMonitors);
            this.tabPageComentsMonitor.Controls.Add(this.labelComentsMonitor);
            this.tabPageComentsMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabPageComentsMonitor.Name = "tabPageComentsMonitor";
            this.tabPageComentsMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComentsMonitor.Size = new System.Drawing.Size(731, 432);
            this.tabPageComentsMonitor.TabIndex = 2;
            this.tabPageComentsMonitor.Text = "Coments";
            // 
            // labelComentsMonitor
            // 
            this.labelComentsMonitor.AutoSize = true;
            this.labelComentsMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelComentsMonitor.ForeColor = System.Drawing.Color.White;
            this.labelComentsMonitor.Location = new System.Drawing.Point(14, 50);
            this.labelComentsMonitor.Name = "labelComentsMonitor";
            this.labelComentsMonitor.Size = new System.Drawing.Size(132, 25);
            this.labelComentsMonitor.TabIndex = 17;
            this.labelComentsMonitor.Text = "Comments : ";
            // 
            // tabPageBarcodeMonitor
            // 
            this.tabPageBarcodeMonitor.BackColor = System.Drawing.Color.Black;
            this.tabPageBarcodeMonitor.Controls.Add(this.buttonGenerateCodeMonitor);
            this.tabPageBarcodeMonitor.Controls.Add(this.pictureBox1);
            this.tabPageBarcodeMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabPageBarcodeMonitor.Name = "tabPageBarcodeMonitor";
            this.tabPageBarcodeMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBarcodeMonitor.Size = new System.Drawing.Size(731, 432);
            this.tabPageBarcodeMonitor.TabIndex = 4;
            this.tabPageBarcodeMonitor.Text = "Barcode";
            // 
            // AddMonitorForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 572);
            this.Controls.Add(this.panelAddNewMonitors);
            this.Name = "AddMonitorForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddMonitorForms";
            this.tabPageInserForm.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAddNewMonitors.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageComentsMonitor.ResumeLayout(false);
            this.tabPageComentsMonitor.PerformLayout();
            this.tabPageBarcodeMonitor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModelMonitors;
        private System.Windows.Forms.TabPage tabPageInserForm;
        private System.Windows.Forms.Label labelModelMonitor;
        private System.Windows.Forms.TextBox textBoxUserMonitors;
        private System.Windows.Forms.TextBox textBoxTagServiceMonitors;
        private System.Windows.Forms.TextBox textBoxCompanyFixedAssetMonitors;
        private System.Windows.Forms.ComboBox comboBoxLocationMonitors;
        private System.Windows.Forms.RichTextBox richTextBoxComentsMonitors;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDateMonitors;
        private System.Windows.Forms.DateTimePicker dateTimePickerWarrantyDateMonitors;
        private System.Windows.Forms.Label labelWarrantyDateMonitor;
        private System.Windows.Forms.Label labelDateOfPurchaseMonitor;
        private System.Windows.Forms.Button buttonGenerateCodeMonitor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonInsertDataMonitors;
        private System.Windows.Forms.Label labelUserMonitor;
        private System.Windows.Forms.Label labelTagServiceMonitor;
        private System.Windows.Forms.Label labelLocationMonitor;
        private System.Windows.Forms.Label labelCompanyFixedAssetMonitor;
        private System.Windows.Forms.Panel panelAddNewMonitors;
        private System.Windows.Forms.TabPage tabPageBarcodeMonitor;
        private System.Windows.Forms.TabPage tabPageComentsMonitor;
        private System.Windows.Forms.Label labelComentsMonitor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.LinkLabel linkLabelAddNewUser;
        private System.Windows.Forms.LinkLabel linkLabelAddNewLocation;
        private System.Windows.Forms.LinkLabel linkLabelAddNewModel;
        private System.Windows.Forms.Button buttonCloseMonitor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}