namespace Joyice
{
    partial class userReg
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmUserType = new System.Windows.Forms.ComboBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(256, 411);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(253, 23);
            this.btnRegister.TabIndex = 51;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmUserType
            // 
            this.cmUserType.FormattingEnabled = true;
            this.cmUserType.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cmUserType.Location = new System.Drawing.Point(256, 293);
            this.cmUserType.Name = "cmUserType";
            this.cmUserType.Size = new System.Drawing.Size(121, 21);
            this.cmUserType.TabIndex = 50;
            this.cmUserType.Text = "Select User Type";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(256, 380);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(253, 20);
            this.txtRePassword.TabIndex = 49;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(256, 351);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(253, 20);
            this.txtPassword.TabIndex = 48;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(256, 320);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 20);
            this.txtUsername.TabIndex = 47;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 20);
            this.txtEmail.TabIndex = 46;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(256, 234);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(253, 20);
            this.txtContactNumber.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(256, 201);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(253, 20);
            this.txtAddress.TabIndex = 44;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(256, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(253, 20);
            this.txtLastName.TabIndex = 43;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(256, 73);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(253, 20);
            this.txtFirstName.TabIndex = 42;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // dtpBday
            // 
            this.dtpBday.CustomFormat = "MM-dd-yyyy";
            this.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBday.Location = new System.Drawing.Point(256, 173);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(253, 20);
            this.dtpBday.TabIndex = 41;
            this.dtpBday.Value = new System.DateTime(2023, 4, 9, 0, 0, 0, 0);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(322, 137);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 40;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(256, 137);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 39;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "REGISTER NEW ACCOUNT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Retype Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "User Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "First Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(657, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 423);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(256, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(253, 23);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(82, 509);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(41, 13);
            this.lblUserID.TabIndex = 54;
            this.lblUserID.Text = "label13";
            this.lblUserID.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(35, 509);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(41, 13);
            this.lblId.TabIndex = 55;
            this.lblId.Text = "label14";
            this.lblId.Visible = false;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(256, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(253, 23);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(654, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(701, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // userReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmUserType);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dtpBday);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userReg";
            this.Size = new System.Drawing.Size(1329, 561);
            this.Load += new System.EventHandler(this.userReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmUserType;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
