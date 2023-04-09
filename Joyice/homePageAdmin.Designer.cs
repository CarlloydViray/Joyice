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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnProdCat = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userReg1 = new Joyice.userReg();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnProdCat);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 116);
            this.panel1.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(1050, 64);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(156, 37);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "DATABASE BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(864, 64);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(156, 37);
            this.btnReports.TabIndex = 19;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(680, 64);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(156, 37);
            this.btnProducts.TabIndex = 18;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnProdCat
            // 
            this.btnProdCat.Location = new System.Drawing.Point(503, 64);
            this.btnProdCat.Name = "btnProdCat";
            this.btnProdCat.Size = new System.Drawing.Size(156, 37);
            this.btnProdCat.TabIndex = 17;
            this.btnProdCat.Text = "PRODUCT CATEGORIES";
            this.btnProdCat.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(325, 64);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(156, 37);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(140, 64);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 37);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(400, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADMIN HOME  //insert additional elements";
            // 
            // userReg1
            // 
            this.userReg1.Location = new System.Drawing.Point(-1, 116);
            this.userReg1.Name = "userReg1";
            this.userReg1.Size = new System.Drawing.Size(1329, 561);
            this.userReg1.TabIndex = 6;
            this.userReg1.Load += new System.EventHandler(this.userReg1_Load);
            // 
            // homePageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 674);
            this.Controls.Add(this.userReg1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "homePageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePageAdmin";
            this.Load += new System.EventHandler(this.homePageAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProdCat;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnHome;
        private userReg userReg1;
    }
}