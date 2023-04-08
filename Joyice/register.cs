using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joyice
{
    public partial class register : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        String sex;

        public register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if(txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || sex == string.Empty || dtpBday.Text == string.Empty || txtAddress.Text == string.Empty || txtContactNumber.Text == string.Empty || txtEmail.Text == string.Empty || txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtRePassword.Text == string.Empty || cmUserType.Text == "Select user type")
            {
                MessageBox.Show("Populate all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtPassword.Text != txtRePassword.Text)
                {
                    MessageBox.Show("Passwords don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Clear();
                    txtRePassword.Clear();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users_table WHERE username = '"+ txtUsername.Text +"'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Username already in use", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                    }
                    else
                    {
                       
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO users_table (user_firstName, user_lastName, user_sex, user_bday, user_address, user_contactNum, user_email, user_type, username, password) VALUES (@user_firstName, @user_lastName, @user_sex, @user_bday, @user_address, @user_contactNum, @user_email, @user_type, @username, @password)", conn);
                        

                        cmd2.Parameters.AddWithValue("@user_firstName", txtFirstName.Text);
                        cmd2.Parameters.AddWithValue("@user_lastName", txtLastName.Text);
                        cmd2.Parameters.AddWithValue("@user_sex", sex);
                        cmd2.Parameters.AddWithValue("@user_bday", dtpBday.Text);
                        cmd2.Parameters.AddWithValue("@user_address", txtAddress.Text);
                        cmd2.Parameters.AddWithValue("@user_contactNum", txtContactNumber.Text);
                        cmd2.Parameters.AddWithValue("@user_email", txtEmail.Text);
                        cmd2.Parameters.AddWithValue("@user_type", cmUserType.Text);
                        cmd2.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd2.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd2.ExecuteNonQuery();
                        conn.Close();

                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtContactNumber.Clear();
                        txtAddress.Clear();
                        txtEmail.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();

                        MessageBox.Show("User Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        login login = new login();
                        login.Show();
                        this.Hide();

                    }
                }
            }
                
            
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
             sex = "male";
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
             sex = "female";
        }
    }
}
