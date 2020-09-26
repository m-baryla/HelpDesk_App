namespace GUI.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.panelAddNewSubMenu = new System.Windows.Forms.Panel();
            this.panelComputerButton = new System.Windows.Forms.Panel();
            this.panelMonitorsButton = new System.Windows.Forms.Panel();
            this.panelNotebooksButton = new System.Windows.Forms.Panel();
            this.buttonAddNewMonitors = new System.Windows.Forms.Button();
            this.buttonAddNewNotebooks = new System.Windows.Forms.Button();
            this.buttonAddNewComputers = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panelReportsSubMenu = new System.Windows.Forms.Panel();
            this.buttonReport_3 = new System.Windows.Forms.Button();
            this.buttonReport_2 = new System.Windows.Forms.Button();
            this.buttonReport_1 = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBoxHelpDeskDataBase = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogoBlack = new System.Windows.Forms.PictureBox();
            this.panelHidePanel = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttoSetings = new System.Windows.Forms.Button();
            this.buttonListMenu = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLogo.SuspendLayout();
            this.panelAddNewSubMenu.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelReportsSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpDeskDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoBlack)).BeginInit();
            this.panelHidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Controls.Add(this.buttonLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(193, 160);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackColor = System.Drawing.Color.Black;
            this.buttonLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogo.ForeColor = System.Drawing.Color.White;
            this.buttonLogo.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogo.Image")));
            this.buttonLogo.Location = new System.Drawing.Point(0, 0);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(193, 160);
            this.buttonLogo.TabIndex = 0;
            this.buttonLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogo.UseVisualStyleBackColor = false;
            this.buttonLogo.Click += new System.EventHandler(this.buttonLogo_Click);
            this.buttonLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogo_Paint);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.Black;
            this.buttonAddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddNew.FlatAppearance.BorderSize = 0;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNew.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNew.ForeColor = System.Drawing.Color.White;
            this.buttonAddNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNew.Image")));
            this.buttonAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNew.Location = new System.Drawing.Point(0, 160);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonAddNew.Size = new System.Drawing.Size(193, 40);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "   Add New";
            this.buttonAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            this.buttonAddNew.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonAddNew_Paint);
            this.buttonAddNew.MouseLeave += new System.EventHandler(this.buttonAddNew_MouseLeave);
            this.buttonAddNew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAddNew_MouseMove);
            // 
            // panelAddNewSubMenu
            // 
            this.panelAddNewSubMenu.Controls.Add(this.panelComputerButton);
            this.panelAddNewSubMenu.Controls.Add(this.panelMonitorsButton);
            this.panelAddNewSubMenu.Controls.Add(this.panelNotebooksButton);
            this.panelAddNewSubMenu.Controls.Add(this.buttonAddNewMonitors);
            this.panelAddNewSubMenu.Controls.Add(this.buttonAddNewNotebooks);
            this.panelAddNewSubMenu.Controls.Add(this.buttonAddNewComputers);
            this.panelAddNewSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddNewSubMenu.Location = new System.Drawing.Point(0, 200);
            this.panelAddNewSubMenu.Name = "panelAddNewSubMenu";
            this.panelAddNewSubMenu.Size = new System.Drawing.Size(193, 105);
            this.panelAddNewSubMenu.TabIndex = 1;
            // 
            // panelComputerButton
            // 
            this.panelComputerButton.BackColor = System.Drawing.Color.Black;
            this.panelComputerButton.Location = new System.Drawing.Point(0, 0);
            this.panelComputerButton.Name = "panelComputerButton";
            this.panelComputerButton.Size = new System.Drawing.Size(10, 35);
            this.panelComputerButton.TabIndex = 2;
            // 
            // panelMonitorsButton
            // 
            this.panelMonitorsButton.BackColor = System.Drawing.Color.Black;
            this.panelMonitorsButton.Location = new System.Drawing.Point(0, 70);
            this.panelMonitorsButton.Name = "panelMonitorsButton";
            this.panelMonitorsButton.Size = new System.Drawing.Size(10, 35);
            this.panelMonitorsButton.TabIndex = 4;
            // 
            // panelNotebooksButton
            // 
            this.panelNotebooksButton.BackColor = System.Drawing.Color.Black;
            this.panelNotebooksButton.Location = new System.Drawing.Point(0, 35);
            this.panelNotebooksButton.Name = "panelNotebooksButton";
            this.panelNotebooksButton.Size = new System.Drawing.Size(10, 35);
            this.panelNotebooksButton.TabIndex = 3;
            // 
            // buttonAddNewMonitors
            // 
            this.buttonAddNewMonitors.BackColor = System.Drawing.Color.Black;
            this.buttonAddNewMonitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddNewMonitors.FlatAppearance.BorderSize = 0;
            this.buttonAddNewMonitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewMonitors.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewMonitors.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewMonitors.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNewMonitors.Image")));
            this.buttonAddNewMonitors.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddNewMonitors.Location = new System.Drawing.Point(0, 70);
            this.buttonAddNewMonitors.Name = "buttonAddNewMonitors";
            this.buttonAddNewMonitors.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.buttonAddNewMonitors.Size = new System.Drawing.Size(193, 35);
            this.buttonAddNewMonitors.TabIndex = 2;
            this.buttonAddNewMonitors.Text = "MONITORS";
            this.buttonAddNewMonitors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNewMonitors.UseVisualStyleBackColor = false;
            this.buttonAddNewMonitors.Click += new System.EventHandler(this.buttonAddNewMonitors_Click);
            this.buttonAddNewMonitors.MouseLeave += new System.EventHandler(this.buttonAddNewMonitors_MouseLeave);
            this.buttonAddNewMonitors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAddNewMonitors_MouseMove);
            // 
            // buttonAddNewNotebooks
            // 
            this.buttonAddNewNotebooks.BackColor = System.Drawing.Color.Black;
            this.buttonAddNewNotebooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddNewNotebooks.FlatAppearance.BorderSize = 0;
            this.buttonAddNewNotebooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewNotebooks.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewNotebooks.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewNotebooks.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNewNotebooks.Image")));
            this.buttonAddNewNotebooks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddNewNotebooks.Location = new System.Drawing.Point(0, 35);
            this.buttonAddNewNotebooks.Name = "buttonAddNewNotebooks";
            this.buttonAddNewNotebooks.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.buttonAddNewNotebooks.Size = new System.Drawing.Size(193, 35);
            this.buttonAddNewNotebooks.TabIndex = 1;
            this.buttonAddNewNotebooks.Text = "NOTEBOOKS";
            this.buttonAddNewNotebooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNewNotebooks.UseVisualStyleBackColor = false;
            this.buttonAddNewNotebooks.Click += new System.EventHandler(this.buttonAddNewNotebooks_Click);
            this.buttonAddNewNotebooks.MouseLeave += new System.EventHandler(this.buttonAddNewNotebooks_MouseLeave);
            this.buttonAddNewNotebooks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAddNewNotebooks_MouseMove);
            // 
            // buttonAddNewComputers
            // 
            this.buttonAddNewComputers.BackColor = System.Drawing.Color.Black;
            this.buttonAddNewComputers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddNewComputers.FlatAppearance.BorderSize = 0;
            this.buttonAddNewComputers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewComputers.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewComputers.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewComputers.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNewComputers.Image")));
            this.buttonAddNewComputers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddNewComputers.Location = new System.Drawing.Point(0, 0);
            this.buttonAddNewComputers.Name = "buttonAddNewComputers";
            this.buttonAddNewComputers.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.buttonAddNewComputers.Size = new System.Drawing.Size(193, 35);
            this.buttonAddNewComputers.TabIndex = 0;
            this.buttonAddNewComputers.Text = "COMPUTERS";
            this.buttonAddNewComputers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNewComputers.UseVisualStyleBackColor = false;
            this.buttonAddNewComputers.Click += new System.EventHandler(this.buttonAddNewComputers_Click);
            this.buttonAddNewComputers.MouseLeave += new System.EventHandler(this.buttonAddNewComputers_MouseLeave);
            this.buttonAddNewComputers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAddNewComputers_MouseMove);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Black;
            this.panelSideMenu.Controls.Add(this.buttonShow);
            this.panelSideMenu.Controls.Add(this.panelReportsSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonReports);
            this.panelSideMenu.Controls.Add(this.panelAddNewSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonAddNew);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSideMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSideMenu.Location = new System.Drawing.Point(40, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(193, 611);
            this.panelSideMenu.TabIndex = 2;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.Black;
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShow.ForeColor = System.Drawing.Color.White;
            this.buttonShow.Image = ((System.Drawing.Image)(resources.GetObject("buttonShow.Image")));
            this.buttonShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.Location = new System.Drawing.Point(0, 450);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonShow.Size = new System.Drawing.Size(193, 40);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "   Show Data";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            this.buttonShow.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonShow_Paint);
            this.buttonShow.MouseLeave += new System.EventHandler(this.buttonShow_MouseLeave);
            this.buttonShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonShow_MouseMove);
            // 
            // panelReportsSubMenu
            // 
            this.panelReportsSubMenu.Controls.Add(this.buttonReport_3);
            this.panelReportsSubMenu.Controls.Add(this.buttonReport_2);
            this.panelReportsSubMenu.Controls.Add(this.buttonReport_1);
            this.panelReportsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportsSubMenu.Location = new System.Drawing.Point(0, 345);
            this.panelReportsSubMenu.Name = "panelReportsSubMenu";
            this.panelReportsSubMenu.Size = new System.Drawing.Size(193, 105);
            this.panelReportsSubMenu.TabIndex = 3;
            // 
            // buttonReport_3
            // 
            this.buttonReport_3.BackColor = System.Drawing.Color.Black;
            this.buttonReport_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport_3.FlatAppearance.BorderSize = 0;
            this.buttonReport_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport_3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReport_3.ForeColor = System.Drawing.Color.White;
            this.buttonReport_3.Location = new System.Drawing.Point(0, 70);
            this.buttonReport_3.Name = "buttonReport_3";
            this.buttonReport_3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonReport_3.Size = new System.Drawing.Size(193, 35);
            this.buttonReport_3.TabIndex = 2;
            this.buttonReport_3.Text = "raport 3";
            this.buttonReport_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport_3.UseVisualStyleBackColor = false;
            // 
            // buttonReport_2
            // 
            this.buttonReport_2.BackColor = System.Drawing.Color.Black;
            this.buttonReport_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport_2.FlatAppearance.BorderSize = 0;
            this.buttonReport_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport_2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReport_2.ForeColor = System.Drawing.Color.White;
            this.buttonReport_2.Location = new System.Drawing.Point(0, 35);
            this.buttonReport_2.Name = "buttonReport_2";
            this.buttonReport_2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonReport_2.Size = new System.Drawing.Size(193, 35);
            this.buttonReport_2.TabIndex = 1;
            this.buttonReport_2.Text = "raport 2";
            this.buttonReport_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport_2.UseVisualStyleBackColor = false;
            // 
            // buttonReport_1
            // 
            this.buttonReport_1.BackColor = System.Drawing.Color.Black;
            this.buttonReport_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport_1.FlatAppearance.BorderSize = 0;
            this.buttonReport_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport_1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReport_1.ForeColor = System.Drawing.Color.White;
            this.buttonReport_1.Location = new System.Drawing.Point(0, 0);
            this.buttonReport_1.Name = "buttonReport_1";
            this.buttonReport_1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonReport_1.Size = new System.Drawing.Size(193, 35);
            this.buttonReport_1.TabIndex = 0;
            this.buttonReport_1.Text = "raport 1";
            this.buttonReport_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport_1.UseVisualStyleBackColor = false;
            // 
            // buttonReports
            // 
            this.buttonReports.BackColor = System.Drawing.Color.Black;
            this.buttonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReports.FlatAppearance.BorderSize = 0;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReports.ForeColor = System.Drawing.Color.White;
            this.buttonReports.Image = ((System.Drawing.Image)(resources.GetObject("buttonReports.Image")));
            this.buttonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.Location = new System.Drawing.Point(0, 305);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonReports.Size = new System.Drawing.Size(193, 40);
            this.buttonReports.TabIndex = 2;
            this.buttonReports.Text = "   Create New Reports";
            this.buttonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReports.UseVisualStyleBackColor = false;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            this.buttonReports.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonReports_Paint);
            this.buttonReports.MouseLeave += new System.EventHandler(this.buttonReports_MouseLeave);
            this.buttonReports.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonReports_MouseMove);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Black;
            this.panelChildForm.Controls.Add(this.pictureBoxHelpDeskDataBase);
            this.panelChildForm.Controls.Add(this.pictureBoxLogoBlack);
            this.panelChildForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelChildForm.Location = new System.Drawing.Point(233, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(901, 611);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBoxHelpDeskDataBase
            // 
            this.pictureBoxHelpDeskDataBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxHelpDeskDataBase.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelpDeskDataBase.Image")));
            this.pictureBoxHelpDeskDataBase.Location = new System.Drawing.Point(342, 286);
            this.pictureBoxHelpDeskDataBase.Name = "pictureBoxHelpDeskDataBase";
            this.pictureBoxHelpDeskDataBase.Size = new System.Drawing.Size(150, 19);
            this.pictureBoxHelpDeskDataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHelpDeskDataBase.TabIndex = 1;
            this.pictureBoxHelpDeskDataBase.TabStop = false;
            // 
            // pictureBoxLogoBlack
            // 
            this.pictureBoxLogoBlack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogoBlack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoBlack.Image")));
            this.pictureBoxLogoBlack.Location = new System.Drawing.Point(314, 160);
            this.pictureBoxLogoBlack.Name = "pictureBoxLogoBlack";
            this.pictureBoxLogoBlack.Size = new System.Drawing.Size(198, 198);
            this.pictureBoxLogoBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogoBlack.TabIndex = 0;
            this.pictureBoxLogoBlack.TabStop = false;
            // 
            // panelHidePanel
            // 
            this.panelHidePanel.BackColor = System.Drawing.Color.Black;
            this.panelHidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelHidePanel.Controls.Add(this.buttonAbout);
            this.panelHidePanel.Controls.Add(this.buttoSetings);
            this.panelHidePanel.Controls.Add(this.buttonListMenu);
            this.panelHidePanel.Controls.Add(this.buttonHome);
            this.panelHidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHidePanel.Location = new System.Drawing.Point(0, 0);
            this.panelHidePanel.Name = "panelHidePanel";
            this.panelHidePanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelHidePanel.Size = new System.Drawing.Size(40, 611);
            this.panelHidePanel.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Black;
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(0, 140);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(40, 40);
            this.buttonAbout.TabIndex = 13;
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonAbout_Paint);
            this.buttonAbout.MouseLeave += new System.EventHandler(this.buttonAbout_MouseLeave);
            this.buttonAbout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonAbout_MouseMove);
            // 
            // buttoSetings
            // 
            this.buttoSetings.BackColor = System.Drawing.Color.Black;
            this.buttoSetings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttoSetings.FlatAppearance.BorderSize = 0;
            this.buttoSetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoSetings.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttoSetings.ForeColor = System.Drawing.Color.White;
            this.buttoSetings.Image = ((System.Drawing.Image)(resources.GetObject("buttoSetings.Image")));
            this.buttoSetings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoSetings.Location = new System.Drawing.Point(0, 100);
            this.buttoSetings.Name = "buttoSetings";
            this.buttoSetings.Size = new System.Drawing.Size(40, 40);
            this.buttoSetings.TabIndex = 12;
            this.buttoSetings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoSetings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttoSetings.UseVisualStyleBackColor = false;
            this.buttoSetings.Paint += new System.Windows.Forms.PaintEventHandler(this.buttoSetings_Paint);
            this.buttoSetings.MouseLeave += new System.EventHandler(this.buttoSetings_MouseLeave);
            this.buttoSetings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttoSetings_MouseMove);
            // 
            // buttonListMenu
            // 
            this.buttonListMenu.BackColor = System.Drawing.Color.Black;
            this.buttonListMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListMenu.FlatAppearance.BorderSize = 0;
            this.buttonListMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListMenu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonListMenu.ForeColor = System.Drawing.Color.White;
            this.buttonListMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonListMenu.Image")));
            this.buttonListMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListMenu.Location = new System.Drawing.Point(0, 60);
            this.buttonListMenu.Name = "buttonListMenu";
            this.buttonListMenu.Size = new System.Drawing.Size(40, 40);
            this.buttonListMenu.TabIndex = 11;
            this.buttonListMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonListMenu.UseVisualStyleBackColor = false;
            this.buttonListMenu.Click += new System.EventHandler(this.buttonListMenu_Click);
            this.buttonListMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonListMenu_Paint);
            this.buttonListMenu.MouseLeave += new System.EventHandler(this.buttonListMenu_MouseLeave);
            this.buttonListMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonListMenu_MouseMove);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Black;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 20);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 14;
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonHome_Paint);
            this.buttonHome.MouseLeave += new System.EventHandler(this.buttonHome_MouseLeave);
            this.buttonHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonHome_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelHidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 650);
            this.MinimumSize = new System.Drawing.Size(1150, 650);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelLogo.ResumeLayout(false);
            this.panelAddNewSubMenu.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelReportsSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelpDeskDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoBlack)).EndInit();
            this.panelHidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Panel panelAddNewSubMenu;
        private System.Windows.Forms.Button buttonAddNewMonitors;
        private System.Windows.Forms.Button buttonAddNewNotebooks;
        private System.Windows.Forms.Button buttonAddNewComputers;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelReportsSubMenu;
        private System.Windows.Forms.Button buttonReport_3;
        private System.Windows.Forms.Button buttonReport_2;
        private System.Windows.Forms.Button buttonReport_1;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.PictureBox pictureBoxLogoBlack;
        private System.Windows.Forms.PictureBox pictureBoxHelpDeskDataBase;
        private System.Windows.Forms.Panel panelComputerButton;
        private System.Windows.Forms.Panel panelMonitorsButton;
        private System.Windows.Forms.Panel panelNotebooksButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelHidePanel;
        private System.Windows.Forms.Button buttonListMenu;
        private System.Windows.Forms.Button buttoSetings;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonLogo;
    }
}