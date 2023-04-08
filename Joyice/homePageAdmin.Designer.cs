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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProdCat = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.adminUsers1 = new Joyice.adminUsers();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(160, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 83);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.btnBackup);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnProducts);
            this.panel2.Controls.Add(this.btnProdCat);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 672);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(28, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 88);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 63);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(3, 157);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(156, 63);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnProdCat
            // 
            this.btnProdCat.Location = new System.Drawing.Point(3, 226);
            this.btnProdCat.Name = "btnProdCat";
            this.btnProdCat.Size = new System.Drawing.Size(156, 63);
            this.btnProdCat.TabIndex = 5;
            this.btnProdCat.Text = "PRODUCT CATEGORIES";
            this.btnProdCat.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(3, 295);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(156, 63);
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(3, 364);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(156, 63);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(3, 433);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(156, 63);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "DATABASE BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // adminUsers1
            // 
            this.adminUsers1.Location = new System.Drawing.Point(365, 100);
            this.adminUsers1.Name = "adminUsers1";
            this.adminUsers1.Size = new System.Drawing.Size(723, 562);
            this.adminUsers1.TabIndex = 4;
            this.adminUsers1.Visible = false;
            this.adminUsers1.Load += new System.EventHandler(this.adminUsers1_Load);
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
            // homePageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 674);
            this.Controls.Add(this.adminUsers1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "homePageAdmin";
            this.Text = "homePageAdmin";
            this.Load += new System.EventHandler(this.homePageAdmin_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProdCat;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private adminUsers adminUsers1;
        private System.Windows.Forms.Label label1;
    }
}