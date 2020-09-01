namespace HelpDesk_DB.UIDesign.Forms
{
    partial class AboutForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForms));
            this.buttonCloseAbout = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelVersionNumber = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCloseAbout
            // 
            this.buttonCloseAbout.BackColor = System.Drawing.Color.White;
            this.buttonCloseAbout.Font = new System.Drawing.Font("Algerian", 36F);
            this.buttonCloseAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseAbout.Image")));
            this.buttonCloseAbout.Location = new System.Drawing.Point(220, 4);
            this.buttonCloseAbout.Name = "buttonCloseAbout";
            this.buttonCloseAbout.Size = new System.Drawing.Size(42, 42);
            this.buttonCloseAbout.TabIndex = 27;
            this.buttonCloseAbout.UseVisualStyleBackColor = false;
            this.buttonCloseAbout.Click += new System.EventHandler(this.buttonCloseAbout_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Comic Sans MS", 26.25F);
            this.labelAbout.Location = new System.Drawing.Point(59, 64);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(148, 49);
            this.labelAbout.TabIndex = 26;
            this.labelAbout.Text = "ABOUT";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(65, 146);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(51, 13);
            this.labelVersion.TabIndex = 29;
            this.labelVersion.Text = "Version : ";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(65, 181);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 13);
            this.labelAuthor.TabIndex = 30;
            this.labelAuthor.Text = "Author : ";
            // 
            // labelVersionNumber
            // 
            this.labelVersionNumber.AutoSize = true;
            this.labelVersionNumber.Location = new System.Drawing.Point(131, 146);
            this.labelVersionNumber.Name = "labelVersionNumber";
            this.labelVersionNumber.Size = new System.Drawing.Size(31, 13);
            this.labelVersionNumber.TabIndex = 31;
            this.labelVersionNumber.Text = "1.0.0";
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(131, 181);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(52, 13);
            this.labelAuthorName.TabIndex = 33;
            this.labelAuthorName.Text = "No Name";
            // 
            // AboutForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 229);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelVersionNumber);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonCloseAbout);
            this.Controls.Add(this.labelAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCloseAbout;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelVersionNumber;
        private System.Windows.Forms.Label labelAuthorName;
    }
}