namespace Joyice
{
    partial class AdminEditAccount
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
            this.btnProdCat = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnChangePicture = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.lblPicName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProdCat
            // 
            this.btnProdCat.Location = new System.Drawing.Point(30, 314);
            this.btnProdCat.Name = "btnProdCat";
            this.btnProdCat.Size = new System.Drawing.Size(156, 37);
            this.btnProdCat.TabIndex = 17;
            this.btnProdCat.Text = "PRODUCT CATEGORIES";
            this.btnProdCat.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(30, 254);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(156, 37);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(30, 494);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(156, 37);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "DATABASE BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(30, 434);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(156, 37);
            this.btnReports.TabIndex = 19;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(30, 374);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(156, 37);
            this.btnProducts.TabIndex = 18;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(1276, 651);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(38, 13);
            this.lblUserID.TabIndex = 29;
            this.lblUserID.Text = "userID";
            this.lblUserID.Visible = false;
            this.lblUserID.Click += new System.EventHandler(this.lbluserID_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Edit Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(625, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnProdCat);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 677);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(213, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 100);
            this.panel2.TabIndex = 31;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(656, 405);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(38, 13);
            this.email.TabIndex = 32;
            this.email.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Username: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(702, 405);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(702, 441);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(81, 13);
            this.lblContactNumber.TabIndex = 36;
            this.lblContactNumber.Text = "ContactNumber";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(702, 474);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 37;
            this.lblUsername.Text = "Username";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(705, 585);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(128, 23);
            this.btnEditAccount.TabIndex = 38;
            this.btnEditAccount.Text = "Edit Account";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnChangePicture
            // 
            this.btnChangePicture.Location = new System.Drawing.Point(893, 228);
            this.btnChangePicture.Name = "btnChangePicture";
            this.btnChangePicture.Size = new System.Drawing.Size(128, 23);
            this.btnChangePicture.TabIndex = 39;
            this.btnChangePicture.Text = "Change Picture";
            this.btnChangePicture.UseVisualStyleBackColor = true;
            this.btnChangePicture.Visible = false;
            this.btnChangePicture.Click += new System.EventHandler(this.btnChangePicture_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(705, 402);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 20);
            this.txtEmail.TabIndex = 40;
            this.txtEmail.Visible = false;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(705, 438);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(128, 20);
            this.txtContactNumber.TabIndex = 41;
            this.txtContactNumber.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(705, 471);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 20);
            this.txtUsername.TabIndex = 42;
            this.txtUsername.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(704, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(705, 615);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(705, 502);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Password: ";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(705, 540);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(128, 20);
            this.txtRePassword.TabIndex = 51;
            this.txtRePassword.Visible = false;
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Location = new System.Drawing.Point(596, 543);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(96, 13);
            this.lblRetypePassword.TabIndex = 49;
            this.lblRetypePassword.Text = "Retype Password: ";
            this.lblRetypePassword.Visible = false;
            // 
            // lblPicName
            // 
            this.lblPicName.AutoSize = true;
            this.lblPicName.Location = new System.Drawing.Point(827, 370);
            this.lblPicName.Name = "lblPicName";
            this.lblPicName.Size = new System.Drawing.Size(60, 13);
            this.lblPicName.TabIndex = 52;
            this.lblPicName.Text = "lblPicName";
            this.lblPicName.Visible = false;
            // 
            // AdminEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 674);
            this.Controls.Add(this.lblPicName);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.lblRetypePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnChangePicture);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditAccount";
            this.Load += new System.EventHandler(this.AdminEditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProdCat;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label lblUserID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnChangePicture;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.Label lblPicName;
    }
}