﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyice
{
    public partial class ProductCategoryAdmin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        DateTime currentDate = DateTime.Now;

        public string userIDValue { get; set; }

        public ProductCategoryAdmin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            homePageAdmin homePageAdmin = new homePageAdmin();
            homePageAdmin.userIDValue = lblUserID.Text;
            homePageAdmin.Show();
            this.Hide();
        }

        private void ProductCategoryAdmin_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT categories_table.cat_ID, categories_table.cat_name, categories_table.cat_createdAt, users_table.userID AS cat_createdByID, users_table.user_firstName as cat_creatorFirstName, users_table.user_lastName AS cat_creatorLastName, categories_table.cat_modifiedByID, categories_table.cat_modifiedAt\r\nFROM categories_table \r\nINNER JOIN users_table ON categories_table.userID = users_table.userID\r\n", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            lblUserID.Text = userIDValue;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == string.Empty)
            {
                MessageBox.Show("Category must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM categories_table WHERE cat_name = '" + txtCategory.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Category already in exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategory.Clear();
                    conn.Close();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO categories_table (cat_name, cat_createdAt, userID) VALUES (@cat_name, @cat_createdAt, @userID)", conn);
                    cmd2.Parameters.AddWithValue("@cat_name", txtCategory.Text);
                    cmd2.Parameters.AddWithValue("@cat_createdAt", currentDate);
                    cmd2.Parameters.AddWithValue("@userID", lblUserID.Text);
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    txtCategory.Clear();

                    SqlCommand cmd3 = new SqlCommand("SELECT categories_table.cat_ID, categories_table.cat_name, categories_table.cat_createdAt, users_table.userID AS cat_createdByID, users_table.user_firstName as cat_creatorFirstName, users_table.user_lastName AS cat_creatorLastName, categories_table.cat_modifiedByID, categories_table.cat_modifiedAt\r\nFROM categories_table \r\nINNER JOIN users_table ON categories_table.userID = users_table.userID\r\n", conn);

                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

                    DataTable dt3 = new DataTable();

                    da3.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == string.Empty)
            {
                MessageBox.Show("Category must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE categories_table SET cat_name=@cat_name, cat_modifiedAt=@cat_modifiedAt, cat_modifiedByID=@cat_modifiedByID WHERE cat_ID=@cat_ID", conn);


                cmd.Parameters.AddWithValue("@cat_name", txtCategory.Text);
                cmd.Parameters.AddWithValue("@cat_modifiedAt", currentDate);
                cmd.Parameters.AddWithValue("@cat_modifiedByID", lblUserID.Text);
                cmd.Parameters.AddWithValue("@cat_ID", lblCatID.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                txtCategory.Clear();


                MessageBox.Show("Category Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlCommand cmd2 = new SqlCommand("SELECT categories_table.cat_ID, categories_table.cat_name, categories_table.cat_createdAt, users_table.userID AS cat_createdByID, users_table.user_firstName as cat_creatorFirstName, users_table.user_lastName AS cat_creatorLastName, categories_table.cat_modifiedByID, categories_table.cat_modifiedAt\r\nFROM categories_table \r\nINNER JOIN users_table ON categories_table.userID = users_table.userID\r\n", conn);

                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                DataTable dt2 = new DataTable();

                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;



            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblCatID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}