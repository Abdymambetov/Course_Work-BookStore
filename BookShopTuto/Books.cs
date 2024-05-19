using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using Microsoft.Data.SqlClient;
namespace BookShopTuto
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
            this.BookDGV.CellClick += new DataGridViewCellEventHandler(this.BookDGV_CellClick);
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter()
        {
            Con.Open();
            string query = "select * from BookTbl where BCat='" + CatCbSearchCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BauthTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTbl values('" + BTitleTb.Text + "', '" + BauthTb.Text + "', '" + BCatCb.SelectedItem.ToString() + "', " + QtyTb.Text + ", " + PriceTb.Text + " )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Saved Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CatCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;
        }
        private void Reset()
        {
            BTitleTb.Text = "";
            BauthTb.Text = "";
            BCatCb.SelectedIndex = -1;
            PriceTb.Text = "";
            QtyTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        int key = 0;
        private void BookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < BookDGV.Rows.Count)
            {
                DataGridViewRow row = BookDGV.Rows[e.RowIndex];
                if (row != null && row.Cells.Count > 5) // Убедимся, что строка и количество ячеек корректны
                {
                    // Проверяем, что каждая ячейка не пуста перед доступом к ее значению
                    BTitleTb.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                    BauthTb.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                    BCatCb.SelectedItem = row.Cells[3].Value?.ToString() ?? string.Empty;
                    QtyTb.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                    PriceTb.Text = row.Cells[5].Value?.ToString() ?? string.Empty;

                    // Проверка на наличие значений в ключевых ячейках
                    if (row.Cells[0].Value != null && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    {
                        key = Convert.ToInt32(row.Cells[0].Value);
                    }
                    else
                    {
                        key = 0;
                    }

                    // Сообщение для отладки
                    //MessageBox.Show("Selected Key: " + key.ToString());
                }
                else
                {
                    MessageBox.Show("Invalid row or insufficient cells in row.");
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from BookTbl where BId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BauthTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update BookTbl set BTitle='" + BTitleTb.Text + "', BAuthor='" + BauthTb.Text + "', BCat='" + BCatCb.SelectedItem.ToString() + "', BQty='" + QtyTb.Text + "', BPrice='" + PriceTb.Text + "' where BId=" + key + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            DashBoard Obj = new DashBoard();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
