using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyice
{
    public partial class userReg : UserControl
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        String sex;
        public userReg()
        {
            InitializeComponent();
        }


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || sex == string.Empty || dtpBday.Text == string.Empty || txtAddress.Text == string.Empty || txtContactNumber.Text == string.Empty || txtEmail.Text == string.Empty || txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtRePassword.Text == string.Empty || cmUserType.Text == "Select user type")
            {
                MessageBox.Show("Populate all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtPassword.Text != txtRePassword.Text)
                {
                    MessageBox.Show("Passwords don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Clear();
                    txtRePassword.Clear();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users_table WHERE username = '" + txtUsername.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Username already in use", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        txtContactNumber.Clear();
                        txtAddress.Clear();
                        txtEmail.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtRePassword.Clear();
                        cmUserType.Text = "Select User Type";
                        rdMale.Checked = false;
                        rdFemale.Checked = false;
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
                        txtRePassword.Clear();
                        cmUserType.Text = "Select User Type";
                        rdMale.Checked = false;
                        rdFemale.Checked = false;

                        MessageBox.Show("User Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand cmd3 = new SqlCommand("SELECT * FROM users_table", conn);

                        SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

                        DataTable dt3 = new DataTable();

                        da3.Fill(dt3);
                        dataGridView1.DataSource = dt3;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userReg_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM users_table", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string sex = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (sex == "male")
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
                dtpBday.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtContactNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmUserType.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                lblId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || sex == string.Empty || dtpBday.Text == string.Empty || txtAddress.Text == string.Empty || txtContactNumber.Text == string.Empty || txtEmail.Text == string.Empty || txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtRePassword.Text == string.Empty || cmUserType.Text == "Select user type")
            {
                MessageBox.Show("Populate all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE users_table SET user_firstName=@user_firstName, user_lastName=@user_lastName, user_sex=@user_sex, user_bday=@user_bday, user_address=@user_address, user_contactNum=@user_contactNum, user_email=@user_email, user_type=@user_type, username=@username, password=@password WHERE userID=@userID", conn);


                cmd.Parameters.AddWithValue("@userID", lblId.Text);
                cmd.Parameters.AddWithValue("@user_firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@user_lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@user_sex", sex);
                cmd.Parameters.AddWithValue("@user_bday", dtpBday.Text);
                cmd.Parameters.AddWithValue("@user_address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@user_contactNum", txtContactNumber.Text);
                cmd.Parameters.AddWithValue("@user_email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@user_type", cmUserType.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmUserType.Text = "Select User Type";
                rdMale.Checked = false;
                rdFemale.Checked = false;
                cmd.ExecuteNonQuery();
                conn.Close();

                txtFirstName.Clear();
                txtLastName.Clear();
                txtContactNumber.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtRePassword.Clear();

                MessageBox.Show("User Credentials Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM users_table", conn);

                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                DataTable dt2 = new DataTable();

                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;



            }
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete user?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE users_table WHERE userID=@userID", conn);


                cmd.Parameters.AddWithValue("@userID", lblId.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                txtFirstName.Clear();
                txtLastName.Clear();
                txtContactNumber.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtRePassword.Clear();
                cmUserType.Text = "Select User Type";
                rdMale.Checked = false;
                rdFemale.Checked = false;

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM users_table", conn);

                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                DataTable dt2 = new DataTable();

                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;

                MessageBox.Show("User Credentials Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM users_table WHERE user_firstName LIKE '%' + @search + '%' OR user_lastName LIKE '%' + @search + '%' OR user_sex LIKE '%' + @search + '%' OR user_bday LIKE '%' + @search + '%' OR user_address LIKE '%' + @search + '%' OR user_contactNum LIKE '%' + @search + '%' OR user_email LIKE '%' + @search + '%' OR user_type LIKE '%' + @search + '%' OR username LIKE '%' + @search + '%' OR 'password' LIKE '%' + @search + '%'", conn);
            cmd.Parameters.AddWithValue("@search", txtSearch.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
