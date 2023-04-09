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
    

    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Username is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
            }else if(txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM users_table WHERE username = '"+ txtUsername.Text +"' AND password = '"+ txtPassword.Text + "' AND user_type = 'Admin'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    homePageAdmin homePageAdmin = new homePageAdmin(); 
                    homePageAdmin.Show();
                    this.Hide();
                }
                else
                {

                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM users_table WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' AND user_type = 'Staff'", conn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    if (dt2.Rows.Count > 0)
                    {
                        homePageStaff adminStaff = new homePageStaff();
                        adminStaff.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect email/password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }


                }
            }
        }
    }
}
