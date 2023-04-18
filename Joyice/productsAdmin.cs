using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Joyice
{
    public partial class productsAdmin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        DateTime currentDate = DateTime.Now;

        public string userIDValue { get; set; }

        public productsAdmin()
        {
            InitializeComponent();

        }

        private void productsAdmin_Load(object sender, EventArgs e)
        {
            lblUserID.Text = userIDValue;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM categories_table", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmProdCat.DataSource = dt;
            cmProdCat.DisplayMember = "cat_name";
            cmProdCat.ValueMember = "cat_ID";

            SqlCommand cmd3 = new SqlCommand("SELECT \r\nproducts_table.prod_ID, \r\ncategories_table.cat_name AS category, \r\nproducts_table.prod_name, \r\nproducts_table.prod_qty, \r\nusers_table.user_firstName + ' ' + users_table.user_lastName AS Created_by, \r\nproducts_table.prod_createdAt, \r\nproducts_table.prod_modifiedBy AS modified_byID,\r\nproducts_table.prod_modifiedAt\r\nFROM products_table \r\nINNER JOIN categories_table ON products_table.cat_ID = categories_table.cat_ID\r\nINNER JOIN users_table ON products_table.prod_createdBy = users_table.userID\r\n", conn);

            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

            DataTable dt3 = new DataTable();

            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

            conn.Close();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnCancel.Visible = true;

            btnInsert.Visible = true;

            txtProduct.Clear();
            txtQty.Clear();

            dataGridView1.Enabled = false;
            txtProduct.Enabled = true;
            txtQty.Enabled = true;
            cmProdCat.Enabled = true;
        }

        private void cmProdCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtProduct.Text == string.Empty || txtQty.Text == string.Empty || cmProdCat.Text == string.Empty)
            {

                MessageBox.Show("Populate all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM products_table WHERE prod_name = '" + txtProduct.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Product already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProduct.Clear();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO products_table (prod_name, cat_ID, prod_qty, prod_createdBy, prod_createdAt) VALUES (@prod_name, @cat_ID, @prod_qty, @prod_createdBy, @prod_createdAt)", conn);
                    cmd2.Parameters.AddWithValue("@prod_name", txtProduct.Text);
                    cmd2.Parameters.AddWithValue("@cat_ID", cmProdCat.SelectedValue);
                    cmd2.Parameters.AddWithValue("@prod_qty", txtQty.Text);
                    cmd2.Parameters.AddWithValue("@prod_createdBy", lblUserID.Text);
                    cmd2.Parameters.AddWithValue("@prod_createdAt", currentDate);

                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    txtProduct.Clear();
                    txtQty.Clear();

                    SqlCommand cmd3 = new SqlCommand("SELECT \r\nproducts_table.prod_ID, \r\ncategories_table.cat_name AS category, \r\nproducts_table.prod_name, \r\nproducts_table.prod_qty, \r\nusers_table.user_firstName + ' ' + users_table.user_lastName AS Created_by, \r\nproducts_table.prod_createdAt, \r\nproducts_table.prod_modifiedBy AS modified_byID,\r\nproducts_table.prod_modifiedAt\r\nFROM products_table \r\nINNER JOIN categories_table ON products_table.cat_ID = categories_table.cat_ID\r\nINNER JOIN users_table ON products_table.prod_createdBy = users_table.userID\r\n", conn);
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

                    DataTable dt3 = new DataTable();

                    da3.Fill(dt3);
                    dataGridView1.DataSource = dt3;

                    btnCreate.Visible = true;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    btnCancel.Visible = false;

                    btnInsert.Visible = false;

                    txtProduct.Clear();
                    txtQty.Clear();

                    dataGridView1.Enabled = true;
                    txtProduct.Enabled = false;
                    txtQty.Enabled = false;
                    cmProdCat.Enabled = false;

                    MessageBox.Show("Product added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCreate.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;

            btnInsert.Visible = false;
            btnNewUpdate.Visible = false;

            txtProduct.Clear();
            txtQty.Clear();

            dataGridView1.Enabled = true;
            txtProduct.Enabled = false;
            txtQty.Enabled = false;
            cmProdCat.Enabled = false;
            btnCancel.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
