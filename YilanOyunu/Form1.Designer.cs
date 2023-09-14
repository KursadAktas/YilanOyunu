namespace YilanOyunu
{
    partial class Form1
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
            panel1 = new Panel();
            lblPuan = new Label();
            lblScore = new Label();
            lblBaslat = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 0;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuan.Location = new Point(705, 29);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(80, 35);
            lblPuan.TabIndex = 1;
            lblPuan.Text = "PUAN";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(807, 29);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(28, 35);
            lblScore.TabIndex = 2;
            lblScore.Text = "0";
            lblScore.Click += lblScore_Click;
            // 
            // lblBaslat
            // 
            lblBaslat.AutoSize = true;
            lblBaslat.BackColor = Color.Red;
            lblBaslat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslat.ForeColor = SystemColors.ButtonHighlight;
            lblBaslat.Location = new Point(884, 29);
            lblBaslat.Name = "lblBaslat";
            lblBaslat.Size = new Size(98, 35);
            lblBaslat.TabIndex = 3;
            lblBaslat.Text = "BAŞLAT";
            lblBaslat.Click += lblBaslat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(680, 164);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1007, 706);
            Controls.Add(label1);
            Controls.Add(lblBaslat);
            Controls.Add(lblScore);
            Controls.Add(lblPuan);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "SnakeGame";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblPuan;
        private Label lblScore;
        private Label lblBaslat;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}