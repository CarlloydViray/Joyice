using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyice
{
    public partial class homePageAdmin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        string backupDBFilePath = ConfigurationManager.AppSettings["backupDBFilePath"];
        string imgPath = ConfigurationManager.AppSettings["imgFilePath"];

        DateTime currentTime = DateTime.Now;


        public string userIDValue { get; set; }

        public homePageAdmin()
        {
            InitializeComponent();
        }

        private void homePageAdmin_Load(object sender, EventArgs e)
        {
            lbluserID.Text = userIDValue;

            SqlCommand cmd = new SqlCommand("SELECT * FROM users_table WHERE userID= '" + lbluserID.Text + "'", conn);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (reader["user_profilePic"].ToString() == string.Empty)
                    {
                        pictureBox1.ImageLocation = $"{imgPath}\\default.jpg";
                    }
                    else
                    {
                        pictureBox1.ImageLocation = reader["user_profilePic"].ToString();
                    }
                }
            }
            conn.Close();


        }


        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            userRegisterAdmin userRegisterAdmin = new userRegisterAdmin();
            userRegisterAdmin.userIDValue = lbluserID.Text;
            userRegisterAdmin.Show();
            this.Hide();

        }

        private void btnProdCat_Click(object sender, EventArgs e)
        {
            ProductCategoryAdmin productCategoryAdmin = new ProductCategoryAdmin();
            productCategoryAdmin.userIDValue = lbluserID.Text;
            productCategoryAdmin.Show();
            this.Hide();

        }

        private void lklblMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminEditAccount adminEditAccount = new AdminEditAccount();
            adminEditAccount.userIDValue = lbluserID.Text;
            adminEditAccount.Show();
            this.Hide();
        }

        private void lbluserID_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            conn.Open();
            string fileName = "MyDatabase_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";
            string backupQuery = $"BACKUP DATABASE joyice TO DISK = '{backupDBFilePath}\\{fileName}'";


            SqlCommand command = new SqlCommand(backupQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show($"{fileName} created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lbluserID.Text = string.Empty;
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
