namespace Joyice
{
    partial class homePageAdmin
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProdCat = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lbluserID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lklblMyAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(30, 254);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(156, 37);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click_1);
            // 
            // btnProdCat
            // 
            this.btnProdCat.Location = new System.Drawing.Point(30, 314);
            this.btnProdCat.Name = "btnProdCat";
            this.btnProdCat.Size = new System.Drawing.Size(156, 37);
            this.btnProdCat.TabIndex = 17;
            this.btnProdCat.Text = "PRODUCT CATEGORIES";
            this.btnProdCat.UseVisualStyleBackColor = true;
            this.btnProdCat.Click += new System.EventHandler(this.btnProdCat_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(30, 374);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(156, 37);
            this.btnProducts.TabIndex = 18;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(30, 434);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(156, 37);
            this.btnReports.TabIndex = 19;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(30, 494);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(156, 37);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "DATABASE BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lbluserID
            // 
            this.lbluserID.AutoSize = true;
            this.lbluserID.Location = new System.Drawing.Point(1277, 652);
            this.lbluserID.Name = "lbluserID";
            this.lbluserID.Size = new System.Drawing.Size(38, 13);
            this.lbluserID.TabIndex = 21;
            this.lbluserID.Text = "userID";
            this.lbluserID.Visible = false;
            this.lbluserID.Click += new System.EventHandler(this.lbluserID_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(30, 194);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 37);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(30, 554);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(156, 37);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lklblMyAccount
            // 
            this.lklblMyAccount.AutoSize = true;
            this.lklblMyAccount.Location = new System.Drawing.Point(63, 158);
            this.lklblMyAccount.Name = "lklblMyAccount";
            this.lklblMyAccount.Size = new System.Drawing.Size(85, 13);
            this.lklblMyAccount.TabIndex = 25;
            this.lklblMyAccount.TabStop = true;
            this.lklblMyAccount.Text = "Edit My Account";
            this.lklblMyAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblMyAccount_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lklblMyAccount);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnProdCat);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 677);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 100);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // homePageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbluserID);
            this.Controls.Add(this.panel2);
            this.Name = "homePageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePageAdmin";
            this.Load += new System.EventHandler(this.homePageAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnProdCat;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lbluserID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklblMyAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}