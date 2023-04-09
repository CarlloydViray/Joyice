using System;
using System.Windows.Forms;

namespace Joyice
{
    public partial class homePageAdmin : Form
    {
        public homePageAdmin()
        {
            InitializeComponent();
        }

        private void homePageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void adminUsers1_Load(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            userReg1.Visible = true;

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            userReg1.Visible = false;
        }

        private void userReg1_Load(object sender, EventArgs e)
        {

        }
    }
}
