namespace BookShopTuto
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel2 = new Panel();
            UserNameLbl = new Label();
            pictureBox2 = new PictureBox();
            TotalLbl = new Label();
            ClientNameTb = new TextBox();
            label7 = new Label();
            BillDGV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label6 = new Label();
            PriceTb = new TextBox();
            label14 = new Label();
            BookDGV = new DataGridView();
            ResetBtn = new Button();
            PrintBtn = new Button();
            label8 = new Label();
            SaveBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            QuanTb = new TextBox();
            BTitleTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            label10 = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(UserNameLbl);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(TotalLbl);
            panel2.Controls.Add(ClientNameTb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(BillDGV);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(BookDGV);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(PrintBtn);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(QuanTb);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(229, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 725);
            panel2.TabIndex = 5;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserNameLbl.ForeColor = SystemColors.ControlDarkDark;
            UserNameLbl.Location = new Point(71, 20);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(155, 33);
            UserNameLbl.TabIndex = 32;
            UserNameLbl.Text = "UserName";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TotalLbl.ForeColor = Color.ForestGreen;
            TotalLbl.Location = new Point(578, 536);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(84, 33);
            TotalLbl.TabIndex = 30;
            TotalLbl.Text = "Total";
            // 
            // ClientNameTb
            // 
            ClientNameTb.Location = new Point(4, 224);
            ClientNameTb.Name = "ClientNameTb";
            ClientNameTb.Size = new Size(153, 27);
            ClientNameTb.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(643, 74);
            label7.Name = "label7";
            label7.Size = new Size(148, 33);
            label7.TabIndex = 28;
            label7.Text = "Books Bill";
            // 
            // BillDGV
            // 
            BillDGV.BackgroundColor = Color.White;
            BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BillDGV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            BillDGV.Location = new Point(348, 110);
            BillDGV.Name = "BillDGV";
            BillDGV.RowHeadersWidth = 51;
            BillDGV.Size = new Size(615, 308);
            BillDGV.TabIndex = 27;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Books";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(3, 193);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 26;
            label4.Text = "Client Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(176, 193);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 25;
            label6.Text = "Price";
            // 
            // PriceTb
            // 
            PriceTb.Enabled = false;
            PriceTb.Location = new Point(176, 224);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(109, 27);
            PriceTb.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.ForeColor = Color.ForestGreen;
            label14.Location = new Point(120, 385);
            label14.Name = "label14";
            label14.Size = new Size(153, 33);
            label14.TabIndex = 20;
            label14.Text = "Books List";
            // 
            // BookDGV
            // 
            BookDGV.BackgroundColor = Color.White;
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Location = new Point(4, 458);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.Size = new Size(460, 248);
            BookDGV.TabIndex = 19;
            BookDGV.CellContentClick += BookDGV_CellContentClick;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(174, 277);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(111, 37);
            ResetBtn.TabIndex = 18;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // PrintBtn
            // 
            PrintBtn.Location = new Point(578, 588);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(108, 31);
            PrintBtn.TabIndex = 16;
            PrintBtn.Text = "Print";
            PrintBtn.UseVisualStyleBackColor = true;
            PrintBtn.Click += PrintBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(931, 3);
            label8.Name = "label8";
            label8.Size = new Size(28, 28);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(21, 277);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(111, 37);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Add To Bill";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(165, 110);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 6;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(4, 110);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 5;
            label2.Text = "Book Name";
            // 
            // QuanTb
            // 
            QuanTb.Location = new Point(165, 141);
            QuanTb.Name = "QuanTb";
            QuanTb.Size = new Size(120, 27);
            QuanTb.TabIndex = 4;
            // 
            // BTitleTb
            // 
            BTitleTb.Enabled = false;
            BTitleTb.Location = new Point(4, 141);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(153, 27);
            BTitleTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(398, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(374, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 33);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 725);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(label10);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(9, 662);
            panel6.Name = "panel6";
            panel6.Size = new Size(207, 44);
            panel6.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.White;
            label10.Location = new Point(50, 11);
            label10.Name = "label10";
            label10.Size = new Size(105, 33);
            label10.TabIndex = 13;
            label10.Text = "Logout";
            label10.Click += label10_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-9, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 20);
            label5.Name = "label5";
            label5.Size = new Size(157, 33);
            label5.TabIndex = 11;
            label5.Text = "Book Store";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 53);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1198, 734);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            Load += Billing_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BillDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label14;
        private DataGridView BookDGV;
        private Button ResetBtn;
        private Button PrintBtn;
        //private Label label12;
        //private Label label13;
        private TextBox PriceTb;
        private TextBox QtyTb;
        private Label label11;
        private ComboBox BCatCb;
        private Label label8;
        private Button SaveBtn;
        private Label label3;
        private Label label2;
        private TextBox QuanTb;
        private TextBox BTitleTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel6;
        private Label label10;
        private PictureBox pictureBox6;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private DataGridView BillDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox ClientNameTb;
        private Label TotalLbl;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox2;
        private Label UserNameLbl;
    }
}