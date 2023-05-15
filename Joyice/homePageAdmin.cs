using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyice
{
    public partial class homePageAdmin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        string defaultProfilePic = ConfigurationManager.AppSettings["defaultProfilePic"];
        string assetsPath = ConfigurationManager.AppSettings["assetsPath"];
        string logoPDFPath = ConfigurationManager.AppSettings["logoPDFPath"];


        private bool isDragging = false;
        private System.Drawing.Point offset;

        public string userIDValue { get; set; }

        public homePageAdmin()
        {
            InitializeComponent();
        }

        private void homePageAdmin_Load(object sender, EventArgs e)
        {
            pbLogo.ImageLocation = logoPDFPath;
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




        private void lklblMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void lbluserID_Click(object sender, EventArgs e)
        {

        }


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void icnbtnHome_Click(object sender, EventArgs e)
        {

            pnlHighlight.Height = icnbtnHome.Height;
            pnlHighlight.Top = icnbtnHome.Top;

            adminHome adminHome = new adminHome();
            adminHome.TopLevel = false;
            pnlScreen.Controls.Add(adminHome);
            adminHome.BringToFront();
            adminHome.Show();

        }

        private void icnbtnUsers_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnbtnUsers.Height;
            pnlHighlight.Top = icnbtnUsers.Top;

            userRegisterAdmin userRegisterAdmin = new userRegisterAdmin();
            userRegisterAdmin.TopLevel = false;
            pnlScreen.Controls.Add(userRegisterAdmin);
            userRegisterAdmin.BringToFront();
            userRegisterAdmin.userIDValue = lbluserID.Text;
            userRegisterAdmin.Show();
        }



        private void icnbtnProdCat_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnbtnProdCat.Height;
            pnlHighlight.Top = icnbtnProdCat.Top;

            ProductCategoryAdmin productCategoryAdmin = new ProductCategoryAdmin();
            productCategoryAdmin.TopLevel = false;
            pnlScreen.Controls.Add(productCategoryAdmin);
            productCategoryAdmin.BringToFront();
            productCategoryAdmin.userIDValue = lbluserID.Text;
            productCategoryAdmin.Show();
        }

        private void btnBackup_Click_1(object sender, EventArgs e)
        {

        }

        private void icnbtnBackup_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnbtnBackup.Height;
            pnlHighlight.Top = icnbtnBackup.Top;

            adminDB adminDB = new adminDB();
            adminDB.TopLevel = false;
            pnlScreen.Controls.Add(adminDB);
            adminDB.BringToFront();
            adminDB.Show();

        }

        private void icnbtnLogout_Click(object sender, EventArgs e)
        {
            lbluserID.Text = string.Empty;
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = iconButton1.Height;
            pnlHighlight.Top = iconButton1.Top;

            AdminEditAccount adminEditAccount = new AdminEditAccount();
            adminEditAccount.TopLevel = false;
            pnlScreen.Controls.Add(adminEditAccount);
            adminEditAccount.userIDValue = lbluserID.Text;
            adminEditAccount.Show();
        }

        private void pnlScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icnbtnProducts_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnbtnProducts.Height;
            pnlHighlight.Top = icnbtnProducts.Top;

            productsAdmin productsAdmin = new productsAdmin();
            productsAdmin.TopLevel = false;
            pnlScreen.Controls.Add(productsAdmin);
            productsAdmin.BringToFront();
            productsAdmin.userIDValue = lbluserID.Text;
            productsAdmin.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icnbtnReports_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnbtnReports.Height;
            pnlHighlight.Top = icnbtnReports.Top;

            reportsAdmin reportsAdmin = new reportsAdmin();
            reportsAdmin.TopLevel = false;
            pnlScreen.Controls.Add(reportsAdmin);
            reportsAdmin.BringToFront();
            reportsAdmin.Show();
        }

        private void icnBtnCustomers_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnBtnCustomers.Height;
            pnlHighlight.Top = icnBtnCustomers.Top;

            customerRegisterAdmin customerRegisterAdmin = new customerRegisterAdmin();
            customerRegisterAdmin.TopLevel = false;
            pnlScreen.Controls.Add(customerRegisterAdmin);
            customerRegisterAdmin.BringToFront();
            customerRegisterAdmin.userIDValue = lbluserID.Text;
            customerRegisterAdmin.Show();

        }

        private void icnbtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void icnbtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                System.Drawing.Point currentScreenPos = PointToScreen(e.Location);
                Location = new System.Drawing.Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
