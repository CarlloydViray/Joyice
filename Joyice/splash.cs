using Joyice;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace splashscreenjoyice
{
    public partial class splash : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = ("CreateRoundRectRgn"))]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public splash()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Value += 5;

                label2.Text = progressBar2.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                login login = new login();
                login.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
