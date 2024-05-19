namespace BookShopTuto
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel2 = new Panel();
            UserDGV = new DataGridView();
            label14 = new Label();
            ResetBtn = new Button();
            DeleteBtn = new Button();
            EditBtn = new Button();
            label12 = new Label();
            label13 = new Label();
            PassTb = new TextBox();
            AddTb = new TextBox();
            label8 = new Label();
            SaveBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            PhoneTb = new TextBox();
            UnameTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel6 = new Panel();
            label10 = new Label();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(UserDGV);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(PassTb);
            panel2.Controls.Add(AddTb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(PhoneTb);
            panel2.Controls.Add(UnameTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(263, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 725);
            panel2.TabIndex = 5;
            // 
            // UserDGV
            // 
            UserDGV.BackgroundColor = Color.White;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDGV.Location = new Point(4, 391);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersWidth = 51;
            UserDGV.Size = new Size(922, 278);
            UserDGV.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label14.ForeColor = Color.ForestGreen;
            label14.Location = new Point(381, 333);
            label14.Name = "label14";
            label14.Size = new Size(150, 33);
            label14.TabIndex = 20;
            label14.Text = "Users List";
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(601, 227);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(122, 47);
            ResetBtn.TabIndex = 18;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(447, 227);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(122, 47);
            DeleteBtn.TabIndex = 17;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(295, 227);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(122, 47);
            EditBtn.TabIndex = 16;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(608, 110);
            label12.Name = "label12";
            label12.Size = new Size(115, 28);
            label12.TabIndex = 15;
            label12.Text = "Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(423, 110);
            label13.Name = "label13";
            label13.Size = new Size(99, 28);
            label13.TabIndex = 14;
            label13.Text = "Address";
            // 
            // PassTb
            // 
            PassTb.Location = new Point(608, 141);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(165, 27);
            PassTb.TabIndex = 13;
            // 
            // AddTb
            // 
            AddTb.Location = new Point(423, 141);
            AddTb.Name = "AddTb";
            AddTb.Size = new Size(158, 27);
            AddTb.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(898, 0);
            label8.Name = "label8";
            label8.Size = new Size(28, 28);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(149, 227);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(122, 47);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(227, 110);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(20, 110);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(227, 141);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(170, 27);
            PhoneTb.TabIndex = 4;
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(20, 141);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(190, 27);
            UnameTb.TabIndex = 3;
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
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(7, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 725);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(label10);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(18, 400);
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
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(18, 322);
            panel5.Name = "panel5";
            panel5.Size = new Size(207, 44);
            panel5.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.White;
            label9.Location = new Point(50, 11);
            label9.Name = "label9";
            label9.Size = new Size(157, 33);
            label9.TabIndex = 13;
            label9.Text = "Dashboard";
            label9.Click += label9_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-9, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(18, 248);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 44);
            panel4.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(61, 11);
            label7.Name = "label7";
            label7.Size = new Size(90, 33);
            label7.TabIndex = 13;
            label7.Text = "Users";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-9, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(18, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 44);
            panel3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(61, 11);
            label6.Name = "label6";
            label6.Size = new Size(93, 33);
            label6.TabIndex = 13;
            label6.Text = "Books";
            label6.Click += label6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-9, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1198, 740);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label14;
        private Button ResetBtn;
        private Button DeleteBtn;
        private Button EditBtn;
        private Label label12;
        private Label label13;
        private TextBox PassTb;
        private TextBox AddTb;
        private Label label8;
        private Button SaveBtn;
        private Label label3;
        private Label label2;
        private TextBox PhoneTb;
        private TextBox UnameTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel6;
        private Label label10;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Label label9;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Label label7;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox3;
        private DataGridView UserDGV;
    }
}