using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyice
{
    public partial class homePageStaff : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        string backupDBFilePath = ConfigurationManager.AppSettings["backupDBFilePath"];
        string imgPath = ConfigurationManager.AppSettings["imgFilePath"];
        string assetsPath = ConfigurationManager.AppSettings["assetsPath"];
        string defaultProfilePic = ConfigurationManager.AppSettings["defaultProfilePic"];

        public string userIDValue { get; set; }
        public homePageStaff()
        {
            InitializeComponent();
        }

        private void icnbtnHome_Click(object sender, EventArgs e)
        {
            adminHome adminHome = new adminHome();
            adminHome.TopLevel = false;
            pnlScreen.Controls.Add(adminHome);
            adminHome.BringToFront();
            adminHome.Show();
        }

        private void icnbtnLogout_Click(object sender, EventArgs e)
        {
            lbluserID.Text = string.Empty;
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void pnlScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homePageStaff_Load(object sender, EventArgs e)
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
                        pictureBox1.ImageLocation = defaultProfilePic;
                    }
                    else
                    {
                        pictureBox1.ImageLocation = reader["user_profilePic"].ToString();
                    }
                }
            }
            conn.Close();

            pbProjManager.ImageLocation = $"{assetsPath}//ProjectManager.jpg";
            pbUI.ImageLocation = $"{assetsPath}//UI.jpg";
            pbUX.ImageLocation = $"{assetsPath}//UX.jpg";
            pbProgrammer.ImageLocation = $"{assetsPath}//Programmer.jpg";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AdminEditAccount adminEditAccount = new AdminEditAccount();
            adminEditAccount.TopLevel = false;
            pnlScreen.Controls.Add(adminEditAccount);
            adminEditAccount.userIDValue = lbluserID.Text;
            adminEditAccount.Show();
        }

        private void icnbtnProducts_Click(object sender, EventArgs e)
        {
            productsAdmin productsAdmin = new productsAdmin();
            productsAdmin.TopLevel = false;
            pnlScreen.Controls.Add(productsAdmin);
            productsAdmin.BringToFront();
            productsAdmin.userIDValue = lbluserID.Text;
            productsAdmin.Show();
        }

        private void icnbtnProdCat_Click(object sender, EventArgs e)
        {
            customerOrdersStaff customerOrdersStaff = new customerOrdersStaff();
            customerOrdersStaff.TopLevel = false;
            pnlScreen.Controls.Add(customerOrdersStaff);
            customerOrdersStaff.BringToFront();
            customerOrdersStaff.userIDValue = lbluserID.Text;
            customerOrdersStaff.Show();
        }

        private void icnbtnReports_Click(object sender, EventArgs e)
        {
            printOrdersStaff printOrdersStaff = new printOrdersStaff();
            printOrdersStaff.TopLevel = false;
            pnlScreen.Controls.Add(printOrdersStaff);
            printOrdersStaff.BringToFront();
            printOrdersStaff.Show();

        }

        private void icnbtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void icnbtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
