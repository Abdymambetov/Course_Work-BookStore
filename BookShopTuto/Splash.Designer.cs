namespace BookShopTuto
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Myprogress = new ProgressBar();
            label2 = new Label();
            PercentageLbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(357, 28);
            label1.TabIndex = 0;
            label1.Text = "Book Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Myprogress
            // 
            Myprogress.BackColor = Color.White;
            Myprogress.Location = new Point(0, 298);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(730, 13);
            Myprogress.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(12, 272);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 3;
            label2.Text = "Loading...";
            // 
            // PercentageLbl
            // 
            PercentageLbl.AutoSize = true;
            PercentageLbl.Font = new Font("Century", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PercentageLbl.ForeColor = Color.DarkGreen;
            PercentageLbl.Location = new Point(120, 267);
            PercentageLbl.Name = "PercentageLbl";
            PercentageLbl.Size = new Size(31, 28);
            PercentageLbl.TabIndex = 4;
            PercentageLbl.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(730, 323);
            Controls.Add(PercentageLbl);
            Controls.Add(label2);
            Controls.Add(Myprogress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar Myprogress;
        private Label label2;
        private Label PercentageLbl;
        private System.Windows.Forms.Timer timer1;
    }
}
