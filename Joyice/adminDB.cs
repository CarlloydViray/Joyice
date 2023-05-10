using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Joyice
{
    public partial class adminDB : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        string backupDBFilePath = ConfigurationManager.AppSettings["backupDBFilePath"];
        public adminDB()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            btnBackup.Visible = false;
            btnRestore.Visible = true;
            btnCancel.Visible = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "bak files(*.bak)|*.bak";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
            }


        }

        private void btnBackup_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Do you want to create database backup?", "Database Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string fileName = "JoyiceDB_" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ".bak";
                fileName = fileName.Replace("/", "-").Replace(":", ".");
                string backupQuery = $"BACKUP DATABASE joyice TO DISK = '{backupDBFilePath}\\{fileName}'";


                SqlCommand command = new SqlCommand(backupQuery, conn);
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"Backup created in file path {backupDBFilePath}\\{fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnBackup.Visible = true;
            btnRestore.Visible = false;
            btnCancel.Visible = false;

            txtPath.Clear();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(txtPath.Text);

            if (txtPath.Text == string.Empty)
            {
                MessageBox.Show("Please browse a backup file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show($"Do you want to restore {fileName} now?", "Restore Now?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string database = conn.Database.ToString();
                    conn.Open();
                    this.Cursor = Cursors.WaitCursor;
                    try
                    {
                        string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                        SqlCommand cmd1 = new SqlCommand(str1, conn);
                        cmd1.ExecuteNonQuery();

                        string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + txtPath.Text + "' WITH REPLACE;";
                        SqlCommand cmd2 = new SqlCommand(str2, conn);
                        cmd2.ExecuteNonQuery();

                        string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                        SqlCommand cmd3 = new SqlCommand(str3, conn);
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("Database Restored!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        // Handle SQL exceptions
                        MessageBox.Show("An error occurred while restoring the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        // Handle other exceptions
                        MessageBox.Show("An error occurred while restoring the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                        btnBackup.Visible = true;
                        btnRestore.Visible = false;
                        btnCancel.Visible = false;

                        txtPath.Clear();
                    }
                }
            }
        }
    }
}
