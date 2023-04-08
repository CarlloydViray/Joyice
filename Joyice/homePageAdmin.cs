using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            adminUsers1.Visible = true;
        }

        private void adminUsers1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            adminUsers1.Visible = false;
        }
    }
}
