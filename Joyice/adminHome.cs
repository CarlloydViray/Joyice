using System.Configuration;
using System.Windows.Forms;

namespace Joyice
{
    public partial class adminHome : Form
    {
        string logoPDFPath = ConfigurationManager.AppSettings["logoPDFPath"];
        public adminHome()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminHome_Load(object sender, System.EventArgs e)
        {
            pbLogo.ImageLocation = logoPDFPath;
        }
    }
}
