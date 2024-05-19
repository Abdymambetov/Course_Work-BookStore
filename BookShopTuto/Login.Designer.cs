namespace BookShopTuto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            UPassTb = new TextBox();
            UnameTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 426);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.White;
            label7.Location = new Point(53, 259);
            label7.Name = "label7";
            label7.Size = new Size(175, 33);
            label7.TabIndex = 11;
            label7.Text = "Nice Service";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 201);
            label6.Name = "label6";
            label6.Size = new Size(228, 33);
            label6.TabIndex = 10;
            label6.Text = "Large Collection";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 147);
            label5.Name = "label5";
            label5.Size = new Size(144, 33);
            label5.TabIndex = 9;
            label5.Text = "Nice Staff";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(UPassTb);
            panel2.Controls.Add(UnameTb);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(261, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 426);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(499, 0);
            label8.Name = "label8";
            label8.Size = new Size(28, 28);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(232, 377);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 8;
            label4.Text = "Admin";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(221, 311);
            button1.Name = "button1";
            button1.Size = new Size(122, 47);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(34, 228);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(36, 168);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 5;
            label2.Text = "UserName";
            // 
            // UPassTb
            // 
            UPassTb.Location = new Point(185, 232);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '\'';
            UPassTb.Size = new Size(214, 27);
            UPassTb.TabIndex = 4;
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(185, 168);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(214, 27);
            UnameTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(185, 17);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UnameTb;
        private Label label3;
        private Label label2;
        private TextBox UPassTb;
        private Label label5;
        private Label label4;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}