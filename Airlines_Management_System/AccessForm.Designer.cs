namespace Airline_Management_System
{
    partial class AccessForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AccessAdmin_btn = new System.Windows.Forms.Button();
            this.AccessUser_btn = new System.Windows.Forms.Button();
            this.AccessSeller_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 443);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 59);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Select Type:";
            // 
            // AccessAdmin_btn
            // 
            this.AccessAdmin_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AccessAdmin_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessAdmin_btn.Location = new System.Drawing.Point(211, 231);
            this.AccessAdmin_btn.Name = "AccessAdmin_btn";
            this.AccessAdmin_btn.Size = new System.Drawing.Size(118, 50);
            this.AccessAdmin_btn.TabIndex = 15;
            this.AccessAdmin_btn.Text = "ADMIN";
            this.AccessAdmin_btn.UseVisualStyleBackColor = false;
            this.AccessAdmin_btn.Click += new System.EventHandler(this.AccessAdmin_btn_Click);
            // 
            // AccessUser_btn
            // 
            this.AccessUser_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AccessUser_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessUser_btn.Location = new System.Drawing.Point(394, 231);
            this.AccessUser_btn.Name = "AccessUser_btn";
            this.AccessUser_btn.Size = new System.Drawing.Size(118, 50);
            this.AccessUser_btn.TabIndex = 16;
            this.AccessUser_btn.Text = "USER";
            this.AccessUser_btn.UseVisualStyleBackColor = false;
            this.AccessUser_btn.Click += new System.EventHandler(this.AccessUser_btn_Click);
            // 
            // AccessSeller_btn
            // 
            this.AccessSeller_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AccessSeller_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessSeller_btn.Location = new System.Drawing.Point(578, 231);
            this.AccessSeller_btn.Name = "AccessSeller_btn";
            this.AccessSeller_btn.Size = new System.Drawing.Size(194, 50);
            this.AccessSeller_btn.TabIndex = 17;
            this.AccessSeller_btn.Text = "TICKET SELLER";
            this.AccessSeller_btn.UseVisualStyleBackColor = false;
            this.AccessSeller_btn.Click += new System.EventHandler(this.AccessSeller_btn_Click);
            // 
            // AccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 500);
            this.Controls.Add(this.AccessSeller_btn);
            this.Controls.Add(this.AccessUser_btn);
            this.Controls.Add(this.AccessAdmin_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AccessAdmin_btn;
        private System.Windows.Forms.Button AccessUser_btn;
        private System.Windows.Forms.Button AccessSeller_btn;
    }
}