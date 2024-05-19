using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopTuto
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
            this.UserDGV.CellClick += new DataGridViewCellEventHandler(this.UserDGV_CellClick);
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('" + UnameTb.Text + "', '" + PhoneTb.Text + "', '" + AddTb.Text + "', '" + PassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved Successfully");
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
        private void Reset()
        {
            UnameTb.Text = "";
            PhoneTb.Text = "";
            AddTb.Text = "";
            PassTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
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
                    string query = "delete from UserTbl where UId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
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
        int key = 0;
        private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UserDGV.Rows.Count)
            {
                DataGridViewRow row = UserDGV.Rows[e.RowIndex];
                if (row != null && row.Cells.Count >= 4) // Убедимся, что строка и количество ячеек корректны
                {
                    // Проверяем, что каждая ячейка не пуста перед доступом к ее значению
                    UnameTb.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                    PhoneTb.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                    AddTb.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                    PassTb.Text = row.Cells[4].Value?.ToString() ?? string.Empty;

                    // Проверка на наличие значений в ключевых ячейках
                    if (row.Cells[0].Value != null && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    {
                        key = Convert.ToInt32(row.Cells[0].Value);
                    }
                    else
                    {
                        key = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row or insufficient cells in row.");
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTbl set Uname='" + UnameTb.Text + "', UPhone='" + PhoneTb.Text + "', UAdd='" + AddTb.Text + "', UPass='" + PassTb.Text + "' where UId=" + key + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
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

        private void label6_Click(object sender, EventArgs e)
        {
            Books Obj = new Books();
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
