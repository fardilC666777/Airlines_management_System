namespace Airline_Management_System
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.home_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.home_backBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Tickets_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.home_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 45);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Airline Management System";
            // 
            // home_close
            // 
            this.home_close.AutoSize = true;
            this.home_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_close.ForeColor = System.Drawing.Color.Red;
            this.home_close.Location = new System.Drawing.Point(936, 9);
            this.home_close.Name = "home_close";
            this.home_close.Size = new System.Drawing.Size(26, 25);
            this.home_close.TabIndex = 0;
            this.home_close.Text = "X";
            this.home_close.Click += new System.EventHandler(this.home_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.home_backBtn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Tickets_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 535);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Airline_Management_System.Properties.Resources.LogoutBtn;
            this.pictureBox4.Location = new System.Drawing.Point(59, 359);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Airline_Management_System.Properties.Resources.HomeFinal;
            this.pictureBox2.Location = new System.Drawing.Point(59, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // home_backBtn
            // 
            this.home_backBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.home_backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_backBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_backBtn.Location = new System.Drawing.Point(16, 342);
            this.home_backBtn.Name = "home_backBtn";
            this.home_backBtn.Size = new System.Drawing.Size(234, 71);
            this.home_backBtn.TabIndex = 4;
            this.home_backBtn.Text = "Logout";
            this.home_backBtn.UseVisualStyleBackColor = false;
            this.home_backBtn.Click += new System.EventHandler(this.home_backBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage User";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tickets_btn
            // 
            this.Tickets_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Tickets_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tickets_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tickets_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tickets_btn.Location = new System.Drawing.Point(12, 257);
            this.Tickets_btn.Name = "Tickets_btn";
            this.Tickets_btn.Size = new System.Drawing.Size(238, 67);
            this.Tickets_btn.TabIndex = 1;
            this.Tickets_btn.Text = "Manage Ticket Seller";
            this.Tickets_btn.UseVisualStyleBackColor = false;
            this.Tickets_btn.Click += new System.EventHandler(this.Tickets_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Airline_Management_System.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(261, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label home_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home_backBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Tickets_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}