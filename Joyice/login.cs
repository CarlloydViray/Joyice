using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyice
{


    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        String userID;
        string logoPDFPath = ConfigurationManager.AppSettings["logoPDFPath"];


        public login()
        {
            InitializeComponent();

            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
            iconButton1.TabIndex = 3;
            iconButton2.TabIndex = 4;

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Username is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT userID FROM users_table WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' AND user_type = 'Admin'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    conn.Open();
                    SqlCommand cmdID = new SqlCommand("SELECT userID FROM users_table WHERE username = @username AND password = @password", conn);
                    cmdID.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmdID.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        userID = reader.GetValue(0).ToString();

                        homePageAdmin homePageAdmin = new homePageAdmin();
                        homePageAdmin.userIDValue = userID;
                        homePageAdmin.Show();
                        this.Hide();
                    }
                    reader.Close();
                    conn.Close();

                }
                else
                {

                    SqlCommand cmd2 = new SqlCommand("SELECT userID FROM users_table WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' AND user_type = 'Staff'", conn);
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                    DataTable dt2 = new DataTable();

                    da2.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        conn.Open();
                        SqlCommand cmdID2 = new SqlCommand("SELECT userID FROM users_table WHERE username = @username AND password = @password", conn);
                        cmdID2.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmdID2.Parameters.AddWithValue("@Password", txtPassword.Text);
                        SqlDataReader reader2 = cmd2.ExecuteReader();


                        if (reader2.Read())
                        {
                            userID = reader2.GetValue(0).ToString();

                            homePageStaff homePageStaff = new homePageStaff();
                            homePageStaff.userIDValue = userID;
                            homePageStaff.Show();
                            this.Hide();
                        }
                        reader2.Close();
                        conn.Close();
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

        private void login_Load(object sender, EventArgs e)
        {
            pbLogo.ImageLocation = logoPDFPath;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
