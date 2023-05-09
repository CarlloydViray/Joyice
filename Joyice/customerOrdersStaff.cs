using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Joyice
{
    public partial class customerOrdersStaff : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91I62MI\\SQLEXPRESS;Initial Catalog=joyice;Integrated Security=True");
        DateTime currentDate = DateTime.Now;

        public string userIDValue { get; set; }

        String datagridQuery2 = "SELECT prod_id, prod_name AS Product_Name, prod_qty AS Product_Quantity, prod_price AS Product_Price FROM products_table";
        String datagridQuery = "SELECT orders_table.order_ID, customers_table.cus_name AS Customer_Name, products_table.prod_name AS Product_Name, orders_table.order_qty AS Order_Quantity,orders_table.order_price AS Order_OverallPrice, orders_table.order_date AS Order_Date, users_table.user_firstName +' '+ users_table.user_lastName AS order_createdBy FROM orders_table INNER JOIN products_table ON orders_table.prod_ID = products_table.prod_ID INNER JOIN customers_table ON orders_table.cus_ID = customers_table.cus_ID INNER JOIN users_table ON orders_table.userID = users_table.userID";
        public customerOrdersStaff()
        {
            InitializeComponent();
            cmName.TabIndex = 0;
            txtProduct.TabIndex = 1;
            txtQty.TabIndex = 2;
        }

        private void customerOrdersStaff_Load(object sender, EventArgs e)
        {
            lblUserID.Text = userIDValue;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM customers_table", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmName.DataSource = dt;
            cmName.DisplayMember = "cus_name";
            cmName.ValueMember = "cus_ID";

            SqlCommand cmd3 = new SqlCommand(datagridQuery, conn);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

            SqlCommand cmd4 = new SqlCommand(datagridQuery2, conn);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dataGridView2.DataSource = dt4;
            conn.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form passwordDialog = new Form();
            TextBox txtPasswordDialogue = new TextBox();
            Button btnOK = new Button();
            Button btnCancelDialogue = new Button();
            Label lblPassword = new Label();

            lblPassword.Text = "Enter Password";
            passwordDialog.Text = "Confirm User";
            txtPasswordDialogue.PasswordChar = '*';
            txtPasswordDialogue.UseSystemPasswordChar = true;
            btnOK.Text = "OK";
            btnCancelDialogue.Text = "Cancel";
            btnOK.DialogResult = DialogResult.OK;
            btnCancelDialogue.DialogResult = DialogResult.Cancel;

            lblPassword.Location = new Point(10, 5);
            lblPassword.Size = new Size(100, 20);
            txtPasswordDialogue.Location = new Point(10, 25);
            txtPasswordDialogue.Size = new Size(250, 50);
            btnOK.Location = new Point(10, 50);
            btnCancelDialogue.Location = new Point(90, 50);

            passwordDialog.ClientSize = new Size(275, 80);
            passwordDialog.Controls.Add(lblPassword);
            passwordDialog.Controls.Add(txtPasswordDialogue);
            passwordDialog.Controls.Add(btnOK);
            passwordDialog.Controls.Add(btnCancelDialogue);

            passwordDialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            passwordDialog.StartPosition = FormStartPosition.CenterScreen;
            passwordDialog.AcceptButton = btnOK;
            passwordDialog.CancelButton = btnCancelDialogue;

            if (passwordDialog.ShowDialog() == DialogResult.OK)
            {
                string password = txtPasswordDialogue.Text;

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM users_table WHERE userID= '" + lblUserID.Text + "' AND password= '" + password + "'", conn);


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    btnCreate.Visible = false;

                    cmName.Enabled = true;
                    txtQty.Enabled = true;
                    btnOrder.Visible = true;
                    btnCancelRegister.Visible = true;
                    txtBill.Enabled = true;
                    txtBill.Visible = true;

                    dataGridView1.Enabled = false;

                    txtQty.Clear();
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                }
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmName.Text == string.Empty || txtProduct.Text == string.Empty || txtQty.Text == string.Empty)
            {
                MessageBox.Show("Populate all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                SqlCommand cmd5 = new SqlCommand("SELECT prod_qty FROM products_table WHERE prod_ID = @prod_ID", conn);

                cmd5.Parameters.AddWithValue("@prod_ID", lblProd_ID.Text);
                int currentQty = (int)cmd5.ExecuteScalar();

                if (currentQty >= int.Parse(txtQty.Text))
                {

                    if (double.TryParse(txtBill.Text, out double billAmount) && double.TryParse(txtOverall.Text, out double overall))
                    {
                        if (billAmount > overall)
                        {
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO orders_table (cus_ID, prod_ID, order_qty, order_price, order_date, userID) VALUES (@cus_ID, @prod_ID, @order_qty, @order_price, @order_date, @userID)", conn);

                            cmd2.Parameters.AddWithValue("@cus_ID", cmName.SelectedValue);
                            cmd2.Parameters.AddWithValue("@prod_ID", lblProd_ID.Text);
                            cmd2.Parameters.AddWithValue("@order_qty", txtQty.Text);
                            cmd2.Parameters.AddWithValue("@order_price", overall);
                            cmd2.Parameters.AddWithValue("@order_date", currentDate);
                            cmd2.Parameters.AddWithValue("@userID", lblUserID.Text);
                            cmd2.ExecuteNonQuery();


                            SqlCommand cmd3 = new SqlCommand("UPDATE products_table SET prod_qty = prod_qty - @order_qty WHERE prod_ID = @prod_ID", conn);

                            cmd3.Parameters.AddWithValue("@order_qty", txtQty.Text);
                            cmd3.Parameters.AddWithValue("@prod_ID", lblProd_ID.Text);
                            cmd3.ExecuteNonQuery();


                            conn.Close();

                            cmName.SelectedIndex = -1;
                            txtProduct.Clear();
                            txtQty.Clear();


                            MessageBox.Show($"Order Created! Change is: {billAmount - overall}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            SqlCommand cmd4 = new SqlCommand(datagridQuery, conn);

                            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);

                            DataTable dt4 = new DataTable();

                            da4.Fill(dt4);
                            dataGridView1.DataSource = dt4;

                            SqlCommand cmd6 = new SqlCommand(datagridQuery2, conn);
                            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                            DataTable dt6 = new DataTable();
                            da6.Fill(dt6);
                            dataGridView2.DataSource = dt6;

                            btnCreate.Visible = true;

                            cmName.Enabled = false;
                            txtQty.Enabled = false;
                            btnOrder.Visible = false;
                            btnCancelRegister.Visible = false;
                            txtBill.Enabled = false;

                            txtBill.Clear();
                            txtOverall.Clear();
                            txtPrice.Clear();
                            txtQty.Clear();

                            dataGridView1.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Insufficient Funds", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtBill.Clear();
                            conn.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Insufficient product quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                }
                conn.Close();
            }
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            btnCreate.Visible = true;

            cmName.Enabled = false;
            txtQty.Enabled = false;
            btnOrder.Visible = false;
            btnCancelRegister.Visible = false;
            txtBill.Visible = false;
            txtBill.Enabled = false;
            txtQty.Clear();
            txtOverall.Clear();
            txtBill.Clear();

            dataGridView1.Enabled = true;
        }

        private void cmName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"{datagridQuery} WHERE cus_name LIKE '%" + txtSearch.Text + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProduct.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblProd_ID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblPrice.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQty.Text, out int quantity) && double.TryParse(lblPrice.Text, out double price))
            {
                double total = quantity * price;
                txtOverall.Text = total.ToString();
            }

        }

        private void txtBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

