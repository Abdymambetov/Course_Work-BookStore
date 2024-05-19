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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\BookShopDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from BookTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BookDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(QuanTb.Text);
            try
            {
                Con.Open();
                string query = "update BookTbl set BQty='" + newQty + "' where BId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Updated Successfully");
                Con.Close();
                populate();
                //Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int n = 0, GrdTotal = 0;
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (QuanTb.Text == "" || Convert.ToInt32(QuanTb.Text) > stock)
            {
                MessageBox.Show("No enough stock");
            }
            else
            {
                int total = Convert.ToInt32(QuanTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BTitleTb.Text;
                newRow.Cells[2].Value = QuanTb.Text;
                newRow.Cells[3].Value = PriceTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateBook();
                GrdTotal = GrdTotal + total;
                TotalLbl.Text = "RS" + GrdTotal;
            }
        }
        int key = 0, stock = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < BookDGV.Rows.Count)
            {
                DataGridViewRow row = BookDGV.Rows[e.RowIndex];
                if (row != null && row.Cells.Count > 5) // Убедимся, что строка и количество ячеек корректны
                {
                    // Проверяем, что каждая ячейка не пуста перед доступом к ее значению
                    BTitleTb.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                    //QuanTb.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
                    PriceTb.Text = row.Cells[5].Value?.ToString() ?? string.Empty;

                    // Проверка на наличие значений в ключевых ячейках
                    if (row.Cells[0].Value != null && !string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    {
                        key = Convert.ToInt32(row.Cells[0].Value);
                        stock = Convert.ToInt32(row.Cells[4].Value);
                    }
                    else
                    {
                        key = 0;
                        stock = 0;
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
        private void Reset()
        {
            BTitleTb.Text = "";
            QuanTb.Text = "";
            ClientNameTb.Text = "";
            PriceTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            if (ClientNameTb.Text == "" || BTitleTb.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values('" + UserNameLbl.Text + "', '" + ClientNameTb.Text + "', " + GrdTotal + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Saved Successfully");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }

            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: RS" + GrdTotal, new Font("Century", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("***********BookStore***********", new Font("Century", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            UserNameLbl.Text = Login.UserName;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
