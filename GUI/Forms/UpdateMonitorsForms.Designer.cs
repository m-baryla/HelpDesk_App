namespace GUI.Forms
{
    partial class UpdateMonitorsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMonitorsForms));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUpdateForm = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabelAddNewUser = new System.Windows.Forms.LinkLabel();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelUserComputer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerWarrantyDateMonitors = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPurchaseDateMonitors = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfPurchaseMonitor = new System.Windows.Forms.Label();
            this.labelWarrantyDateMonitor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxIDMonitor = new System.Windows.Forms.TextBox();
            this.linkLabelAddNewLocation = new System.Windows.Forms.LinkLabel();
            this.linkLabelAddNewModel = new System.Windows.Forms.LinkLabel();
            this.labelModelMonitor = new System.Windows.Forms.Label();
            this.comboBoxModelMonitors = new System.Windows.Forms.ComboBox();
            this.textBoxTagServiceMonitors = new System.Windows.Forms.TextBox();
            this.labelIDMonitors = new System.Windows.Forms.Label();
            this.textBoxCompanyFixedAssetMonitors = new System.Windows.Forms.TextBox();
            this.labelCompanyFixedAssetMonitor = new System.Windows.Forms.Label();
            this.comboBoxLocationMonitors = new System.Windows.Forms.ComboBox();
            this.labelLocationMonitor = new System.Windows.Forms.Label();
            this.labelTagServiceMonitor = new System.Windows.Forms.Label();
            this.tabPageComentsMonitors = new System.Windows.Forms.TabPage();
            this.richTextBoxComentsMonitors = new System.Windows.Forms.RichTextBox();
            this.labelComentsMonitor = new System.Windows.Forms.Label();
            this.tabPageBarcodeMonitors = new System.Windows.Forms.TabPage();
            this.buttonGenerateCodeMonitor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUpdateDataMonitor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageUpdateForm.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageComentsMonitors.SuspendLayout();
            this.tabPageBarcodeMonitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUpdateForm);
            this.tabControl1.Controls.Add(this.tabPageComentsMonitors);
            this.tabControl1.Controls.Add(this.tabPageBarcodeMonitors);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 458);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPageUpdateForm
            // 
            this.tabPageUpdateForm.BackColor = System.Drawing.Color.Black;
            this.tabPageUpdateForm.Controls.Add(this.groupBox4);
            this.tabPageUpdateForm.Controls.Add(this.groupBox2);
            this.tabPageUpdateForm.Controls.Add(this.groupBox1);
            this.tabPageUpdateForm.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdateForm.Name = "tabPageUpdateForm";
            this.tabPageUpdateForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateForm.Size = new System.Drawing.Size(731, 432);
            this.tabPageUpdateForm.TabIndex = 1;
            this.tabPageUpdateForm.Text = "Update Form";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.textBoxJob);
            this.groupBox4.Controls.Add(this.textBoxLastName);
            this.groupBox4.Controls.Add(this.textBoxFirstName);
            this.groupBox4.Controls.Add(this.linkLabelAddNewUser);
            this.groupBox4.Controls.Add(this.labelFirstName);
            this.groupBox4.Controls.Add(this.labelJob);
            this.groupBox4.Controls.Add(this.labelLastName);
            this.groupBox4.Controls.Add(this.comboBoxUsers);
            this.groupBox4.Controls.Add(this.labelUserComputer);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(408, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 216);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User";
            // 
            // linkLabelAddNewUser
            // 
            this.linkLabelAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAddNewUser.AutoSize = true;
            this.linkLabelAddNewUser.LinkColor = System.Drawing.Color.Red;
            this.linkLabelAddNewUser.Location = new System.Drawing.Point(107, 177);
            this.linkLabelAddNewUser.Name = "linkLabelAddNewUser";
            this.linkLabelAddNewUser.Size = new System.Drawing.Size(76, 13);
            this.linkLabelAddNewUser.TabIndex = 40;
            this.linkLabelAddNewUser.TabStop = true;
            this.linkLabelAddNewUser.Text = "Add New User";
            this.linkLabelAddNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewUser_LinkClicked);
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(36, 86);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(66, 13);
            this.labelFirstName.TabIndex = 32;
            this.labelFirstName.Text = "First Name : ";
            // 
            // labelJob
            // 
            this.labelJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(36, 148);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(33, 13);
            this.labelJob.TabIndex = 36;
            this.labelJob.Text = "Job : ";
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(36, 117);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(67, 13);
            this.labelLastName.TabIndex = 33;
            this.labelLastName.Text = "Last Name : ";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(68, 41);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(205, 21);
            this.comboBoxUsers.TabIndex = 31;
            // 
            // labelUserComputer
            // 
            this.labelUserComputer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUserComputer.AutoSize = true;
            this.labelUserComputer.BackColor = System.Drawing.Color.Transparent;
            this.labelUserComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserComputer.ForeColor = System.Drawing.Color.White;
            this.labelUserComputer.Location = new System.Drawing.Point(16, 46);
            this.labelUserComputer.Name = "labelUserComputer";
            this.labelUserComputer.Size = new System.Drawing.Size(46, 16);
            this.labelUserComputer.TabIndex = 18;
            this.labelUserComputer.Text = "User : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dateTimePickerWarrantyDateMonitors);
            this.groupBox2.Controls.Add(this.dateTimePickerPurchaseDateMonitors);
            this.groupBox2.Controls.Add(this.labelDateOfPurchaseMonitor);
            this.groupBox2.Controls.Add(this.labelWarrantyDateMonitor);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 159);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // dateTimePickerWarrantyDateMonitors
            // 
            this.dateTimePickerWarrantyDateMonitors.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerWarrantyDateMonitors.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerWarrantyDateMonitors.Location = new System.Drawing.Point(170, 50);
            this.dateTimePickerWarrantyDateMonitors.Name = "dateTimePickerWarrantyDateMonitors";
            this.dateTimePickerWarrantyDateMonitors.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerWarrantyDateMonitors.TabIndex = 15;
            // 
            // dateTimePickerPurchaseDateMonitors
            // 
            this.dateTimePickerPurchaseDateMonitors.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerPurchaseDateMonitors.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPurchaseDateMonitors.Location = new System.Drawing.Point(170, 96);
            this.dateTimePickerPurchaseDateMonitors.Name = "dateTimePickerPurchaseDateMonitors";
            this.dateTimePickerPurchaseDateMonitors.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerPurchaseDateMonitors.TabIndex = 16;
            // 
            // labelDateOfPurchaseMonitor
            // 
            this.labelDateOfPurchaseMonitor.AutoSize = true;
            this.labelDateOfPurchaseMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateOfPurchaseMonitor.ForeColor = System.Drawing.Color.White;
            this.labelDateOfPurchaseMonitor.Location = new System.Drawing.Point(41, 100);
            this.labelDateOfPurchaseMonitor.Name = "labelDateOfPurchaseMonitor";
            this.labelDateOfPurchaseMonitor.Size = new System.Drawing.Size(106, 16);
            this.labelDateOfPurchaseMonitor.TabIndex = 14;
            this.labelDateOfPurchaseMonitor.Text = "Purchase Date : ";
            // 
            // labelWarrantyDateMonitor
            // 
            this.labelWarrantyDateMonitor.AutoSize = true;
            this.labelWarrantyDateMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWarrantyDateMonitor.ForeColor = System.Drawing.Color.White;
            this.labelWarrantyDateMonitor.Location = new System.Drawing.Point(41, 54);
            this.labelWarrantyDateMonitor.Name = "labelWarrantyDateMonitor";
            this.labelWarrantyDateMonitor.Size = new System.Drawing.Size(103, 16);
            this.labelWarrantyDateMonitor.TabIndex = 13;
            this.labelWarrantyDateMonitor.Text = "Warranty Date : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textBoxIDMonitor);
            this.groupBox1.Controls.Add(this.linkLabelAddNewLocation);
            this.groupBox1.Controls.Add(this.linkLabelAddNewModel);
            this.groupBox1.Controls.Add(this.labelModelMonitor);
            this.groupBox1.Controls.Add(this.comboBoxModelMonitors);
            this.groupBox1.Controls.Add(this.textBoxTagServiceMonitors);
            this.groupBox1.Controls.Add(this.labelIDMonitors);
            this.groupBox1.Controls.Add(this.textBoxCompanyFixedAssetMonitors);
            this.groupBox1.Controls.Add(this.labelCompanyFixedAssetMonitor);
            this.groupBox1.Controls.Add(this.comboBoxLocationMonitors);
            this.groupBox1.Controls.Add(this.labelLocationMonitor);
            this.groupBox1.Controls.Add(this.labelTagServiceMonitor);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 216);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware Info";
            // 
            // textBoxIDMonitor
            // 
            this.textBoxIDMonitor.Location = new System.Drawing.Point(170, 19);
            this.textBoxIDMonitor.Name = "textBoxIDMonitor";
            this.textBoxIDMonitor.Size = new System.Drawing.Size(177, 20);
            this.textBoxIDMonitor.TabIndex = 24;
            // 
            // linkLabelAddNewLocation
            // 
            this.linkLabelAddNewLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAddNewLocation.AutoSize = true;
            this.linkLabelAddNewLocation.LinkColor = System.Drawing.Color.Red;
            this.linkLabelAddNewLocation.Location = new System.Drawing.Point(212, 191);
            this.linkLabelAddNewLocation.Name = "linkLabelAddNewLocation";
            this.linkLabelAddNewLocation.Size = new System.Drawing.Size(95, 13);
            this.linkLabelAddNewLocation.TabIndex = 39;
            this.linkLabelAddNewLocation.TabStop = true;
            this.linkLabelAddNewLocation.Text = "Add New Location";
            this.linkLabelAddNewLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewLocation_LinkClicked);
            // 
            // linkLabelAddNewModel
            // 
            this.linkLabelAddNewModel.AutoSize = true;
            this.linkLabelAddNewModel.LinkColor = System.Drawing.Color.Red;
            this.linkLabelAddNewModel.Location = new System.Drawing.Point(218, 74);
            this.linkLabelAddNewModel.Name = "linkLabelAddNewModel";
            this.linkLabelAddNewModel.Size = new System.Drawing.Size(83, 13);
            this.linkLabelAddNewModel.TabIndex = 25;
            this.linkLabelAddNewModel.TabStop = true;
            this.linkLabelAddNewModel.Text = "Add New Model";
            this.linkLabelAddNewModel.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.linkLabelAddNewModel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewModel_LinkClicked);
            // 
            // labelModelMonitor
            // 
            this.labelModelMonitor.AutoSize = true;
            this.labelModelMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModelMonitor.ForeColor = System.Drawing.Color.White;
            this.labelModelMonitor.Location = new System.Drawing.Point(16, 57);
            this.labelModelMonitor.Name = "labelModelMonitor";
            this.labelModelMonitor.Size = new System.Drawing.Size(55, 16);
            this.labelModelMonitor.TabIndex = 9;
            this.labelModelMonitor.Text = "Model : ";
            // 
            // comboBoxModelMonitors
            // 
            this.comboBoxModelMonitors.FormattingEnabled = true;
            this.comboBoxModelMonitors.Location = new System.Drawing.Point(170, 52);
            this.comboBoxModelMonitors.Name = "comboBoxModelMonitors";
            this.comboBoxModelMonitors.Size = new System.Drawing.Size(177, 21);
            this.comboBoxModelMonitors.TabIndex = 10;
            // 
            // textBoxTagServiceMonitors
            // 
            this.textBoxTagServiceMonitors.Location = new System.Drawing.Point(170, 132);
            this.textBoxTagServiceMonitors.Name = "textBoxTagServiceMonitors";
            this.textBoxTagServiceMonitors.Size = new System.Drawing.Size(177, 20);
            this.textBoxTagServiceMonitors.TabIndex = 24;
            // 
            // labelIDMonitors
            // 
            this.labelIDMonitors.AutoSize = true;
            this.labelIDMonitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIDMonitors.ForeColor = System.Drawing.Color.White;
            this.labelIDMonitors.Location = new System.Drawing.Point(16, 23);
            this.labelIDMonitors.Name = "labelIDMonitors";
            this.labelIDMonitors.Size = new System.Drawing.Size(30, 16);
            this.labelIDMonitors.TabIndex = 11;
            this.labelIDMonitors.Text = "ID : ";
            // 
            // textBoxCompanyFixedAssetMonitors
            // 
            this.textBoxCompanyFixedAssetMonitors.Location = new System.Drawing.Point(170, 95);
            this.textBoxCompanyFixedAssetMonitors.Name = "textBoxCompanyFixedAssetMonitors";
            this.textBoxCompanyFixedAssetMonitors.Size = new System.Drawing.Size(177, 20);
            this.textBoxCompanyFixedAssetMonitors.TabIndex = 23;
            // 
            // labelCompanyFixedAssetMonitor
            // 
            this.labelCompanyFixedAssetMonitor.AutoSize = true;
            this.labelCompanyFixedAssetMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCompanyFixedAssetMonitor.ForeColor = System.Drawing.Color.White;
            this.labelCompanyFixedAssetMonitor.Location = new System.Drawing.Point(16, 99);
            this.labelCompanyFixedAssetMonitor.Name = "labelCompanyFixedAssetMonitor";
            this.labelCompanyFixedAssetMonitor.Size = new System.Drawing.Size(148, 16);
            this.labelCompanyFixedAssetMonitor.TabIndex = 10;
            this.labelCompanyFixedAssetMonitor.Text = "Company Fixed Asset : ";
            // 
            // comboBoxLocationMonitors
            // 
            this.comboBoxLocationMonitors.FormattingEnabled = true;
            this.comboBoxLocationMonitors.Location = new System.Drawing.Point(170, 169);
            this.comboBoxLocationMonitors.Name = "comboBoxLocationMonitors";
            this.comboBoxLocationMonitors.Size = new System.Drawing.Size(177, 21);
            this.comboBoxLocationMonitors.TabIndex = 20;
            // 
            // labelLocationMonitor
            // 
            this.labelLocationMonitor.AutoSize = true;
            this.labelLocationMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLocationMonitor.ForeColor = System.Drawing.Color.White;
            this.labelLocationMonitor.Location = new System.Drawing.Point(16, 174);
            this.labelLocationMonitor.Name = "labelLocationMonitor";
            this.labelLocationMonitor.Size = new System.Drawing.Size(68, 16);
            this.labelLocationMonitor.TabIndex = 1;
            this.labelLocationMonitor.Text = "Location : ";
            // 
            // labelTagServiceMonitor
            // 
            this.labelTagServiceMonitor.AutoSize = true;
            this.labelTagServiceMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTagServiceMonitor.ForeColor = System.Drawing.Color.White;
            this.labelTagServiceMonitor.Location = new System.Drawing.Point(16, 136);
            this.labelTagServiceMonitor.Name = "labelTagServiceMonitor";
            this.labelTagServiceMonitor.Size = new System.Drawing.Size(91, 16);
            this.labelTagServiceMonitor.TabIndex = 8;
            this.labelTagServiceMonitor.Text = "Tag Service : ";
            // 
            // tabPageComentsMonitors
            // 
            this.tabPageComentsMonitors.BackColor = System.Drawing.Color.Black;
            this.tabPageComentsMonitors.Controls.Add(this.richTextBoxComentsMonitors);
            this.tabPageComentsMonitors.Controls.Add(this.labelComentsMonitor);
            this.tabPageComentsMonitors.Location = new System.Drawing.Point(4, 22);
            this.tabPageComentsMonitors.Name = "tabPageComentsMonitors";
            this.tabPageComentsMonitors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComentsMonitors.Size = new System.Drawing.Size(731, 432);
            this.tabPageComentsMonitors.TabIndex = 2;
            this.tabPageComentsMonitors.Text = "Coments";
            // 
            // richTextBoxComentsMonitors
            // 
            this.richTextBoxComentsMonitors.Location = new System.Drawing.Point(142, 53);
            this.richTextBoxComentsMonitors.Name = "richTextBoxComentsMonitors";
            this.richTextBoxComentsMonitors.Size = new System.Drawing.Size(581, 371);
            this.richTextBoxComentsMonitors.TabIndex = 18;
            this.richTextBoxComentsMonitors.Text = "";
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
            // tabPageBarcodeMonitors
            // 
            this.tabPageBarcodeMonitors.BackColor = System.Drawing.Color.Black;
            this.tabPageBarcodeMonitors.Controls.Add(this.buttonGenerateCodeMonitor);
            this.tabPageBarcodeMonitors.Controls.Add(this.pictureBox1);
            this.tabPageBarcodeMonitors.Location = new System.Drawing.Point(4, 22);
            this.tabPageBarcodeMonitors.Name = "tabPageBarcodeMonitors";
            this.tabPageBarcodeMonitors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBarcodeMonitors.Size = new System.Drawing.Size(731, 432);
            this.tabPageBarcodeMonitors.TabIndex = 4;
            this.tabPageBarcodeMonitors.Text = "Barcode";
            // 
            // buttonGenerateCodeMonitor
            // 
            this.buttonGenerateCodeMonitor.BackColor = System.Drawing.Color.White;
            this.buttonGenerateCodeMonitor.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateCodeMonitor.Image = ((System.Drawing.Image)(resources.GetObject("buttonGenerateCodeMonitor.Image")));
            this.buttonGenerateCodeMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGenerateCodeMonitor.Location = new System.Drawing.Point(189, 109);
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
            this.pictureBox1.Location = new System.Drawing.Point(215, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 98);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUpdateDataMonitor
            // 
            this.buttonUpdateDataMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateDataMonitor.BackColor = System.Drawing.Color.Black;
            this.buttonUpdateDataMonitor.FlatAppearance.BorderSize = 2;
            this.buttonUpdateDataMonitor.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.buttonUpdateDataMonitor.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateDataMonitor.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateDataMonitor.Image")));
            this.buttonUpdateDataMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdateDataMonitor.Location = new System.Drawing.Point(559, 3);
            this.buttonUpdateDataMonitor.Name = "buttonUpdateDataMonitor";
            this.buttonUpdateDataMonitor.Size = new System.Drawing.Size(177, 48);
            this.buttonUpdateDataMonitor.TabIndex = 27;
            this.buttonUpdateDataMonitor.Text = "Update Data";
            this.buttonUpdateDataMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateDataMonitor.UseVisualStyleBackColor = false;
            this.buttonUpdateDataMonitor.Click += new System.EventHandler(this.buttonUpdateDataMonitor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.buttonUpdateDataMonitor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 572);
            this.panel1.TabIndex = 29;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(126, 83);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 41;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(126, 114);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 42;
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(126, 148);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(100, 20);
            this.textBoxJob.TabIndex = 43;
            // 
            // UpdateMonitorsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 572);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(755, 611);
            this.MinimumSize = new System.Drawing.Size(755, 611);
            this.Name = "UpdateMonitorsForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMonitorsForms";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUpdateForm.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageComentsMonitors.ResumeLayout(false);
            this.tabPageComentsMonitors.PerformLayout();
            this.tabPageBarcodeMonitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBoxModelMonitors;
        private System.Windows.Forms.Label labelModelMonitor;
        private System.Windows.Forms.TabPage tabPageUpdateForm;
        private System.Windows.Forms.TextBox textBoxTagServiceMonitors;
        private System.Windows.Forms.TextBox textBoxCompanyFixedAssetMonitors;
        private System.Windows.Forms.ComboBox comboBoxLocationMonitors;
        private System.Windows.Forms.Label labelTagServiceMonitor;
        private System.Windows.Forms.Label labelLocationMonitor;
        private System.Windows.Forms.Label labelCompanyFixedAssetMonitor;
        private System.Windows.Forms.TabPage tabPageComentsMonitors;
        private System.Windows.Forms.RichTextBox richTextBoxComentsMonitors;
        private System.Windows.Forms.Label labelComentsMonitor;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDateMonitors;
        private System.Windows.Forms.DateTimePicker dateTimePickerWarrantyDateMonitors;
        private System.Windows.Forms.Label labelWarrantyDateMonitor;
        private System.Windows.Forms.Label labelDateOfPurchaseMonitor;
        private System.Windows.Forms.TabPage tabPageBarcodeMonitors;
        private System.Windows.Forms.Button buttonGenerateCodeMonitor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonUpdateDataMonitor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIDMonitor;
        private System.Windows.Forms.Label labelIDMonitors;
        private System.Windows.Forms.LinkLabel linkLabelAddNewModel;
        private System.Windows.Forms.LinkLabel linkLabelAddNewUser;
        private System.Windows.Forms.LinkLabel linkLabelAddNewLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label labelUserComputer;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
    }
}