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
        string logoPDFPath = ConfigurationManager.AppSettings["logoPDFPath"];

        private bool isDragging = false;
        private System.Drawing.Point offset;

        public string userIDValue { get; set; }
        public homePageStaff()
        {
            InitializeComponent();
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

        private void icnbtnProdCat_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnbtnProdCat.Height;
            pnlHighlight.Top = icnbtnProdCat.Top;

            customerOrdersStaff customerOrdersStaff = new customerOrdersStaff();
            customerOrdersStaff.TopLevel = false;
            pnlScreen.Controls.Add(customerOrdersStaff);
            customerOrdersStaff.BringToFront();
            customerOrdersStaff.userIDValue = lbluserID.Text;
            customerOrdersStaff.Show();
        }

        private void icnbtnReports_Click(object sender, EventArgs e)
        {
            pnlHighlight.Height = icnbtnReports.Height;
            pnlHighlight.Top = icnbtnReports.Top;

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

        private void lbluserID_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHighlight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pbProgrammer_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pbUX_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pbUI_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbProjManager_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
