namespace BookShopTuto
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            UPassTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(UPassTb);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 426);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(284, 240);
            button1.Name = "button1";
            button1.Size = new Size(149, 47);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(218, 152);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // UPassTb
            // 
            UPassTb.Location = new Point(378, 153);
            UPassTb.Name = "UPassTb";
            UPassTb.PasswordChar = '\'';
            UPassTb.Size = new Size(214, 27);
            UPassTb.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(325, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(294, 15);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 3;
            label1.Text = "Admin Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(322, 318);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 11;
            label2.Text = "Cancel";
            label2.Click += label2_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(782, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox UPassTb;
        private Label label2;
    }
}