namespace Airline_Management_System
{
    partial class CancellationTbl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TidCb = new System.Windows.Forms.ComboBox();
            this.CancTicketBack_btn = new System.Windows.Forms.Button();
            this.CancResetTicket_btn = new System.Windows.Forms.Button();
            this.CancTicket_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.CancelDGV = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancDate = new System.Windows.Forms.DateTimePicker();
            this.CanId = new System.Windows.Forms.TextBox();
            this.CancelRefresh_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CancelDGV)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TidCb
            // 
            this.TidCb.BackColor = System.Drawing.Color.SlateGray;
            this.TidCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TidCb.FormattingEnabled = true;
            this.TidCb.Location = new System.Drawing.Point(291, 273);
            this.TidCb.Name = "TidCb";
            this.TidCb.Size = new System.Drawing.Size(229, 30);
            this.TidCb.TabIndex = 75;
            this.TidCb.SelectionChangeCommitted += new System.EventHandler(this.TidCb_SelectionChangeCommitted);
            // 
            // CancTicketBack_btn
            // 
            this.CancTicketBack_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancTicketBack_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancTicketBack_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancTicketBack_btn.Location = new System.Drawing.Point(291, 559);
            this.CancTicketBack_btn.Name = "CancTicketBack_btn";
            this.CancTicketBack_btn.Size = new System.Drawing.Size(132, 52);
            this.CancTicketBack_btn.TabIndex = 74;
            this.CancTicketBack_btn.Text = "BACK";
            this.CancTicketBack_btn.UseVisualStyleBackColor = false;
            this.CancTicketBack_btn.Click += new System.EventHandler(this.CancTicketBack_btn_Click);
            // 
            // CancResetTicket_btn
            // 
            this.CancResetTicket_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancResetTicket_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancResetTicket_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancResetTicket_btn.Location = new System.Drawing.Point(429, 498);
            this.CancResetTicket_btn.Name = "CancResetTicket_btn";
            this.CancResetTicket_btn.Size = new System.Drawing.Size(132, 52);
            this.CancResetTicket_btn.TabIndex = 73;
            this.CancResetTicket_btn.Text = "RESET";
            this.CancResetTicket_btn.UseVisualStyleBackColor = false;
            this.CancResetTicket_btn.Click += new System.EventHandler(this.CancResetTicket_btn_Click);
            // 
            // CancTicket_btn
            // 
            this.CancTicket_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancTicket_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancTicket_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancTicket_btn.Location = new System.Drawing.Point(291, 498);
            this.CancTicket_btn.Name = "CancTicket_btn";
            this.CancTicket_btn.Size = new System.Drawing.Size(132, 52);
            this.CancTicket_btn.TabIndex = 72;
            this.CancTicket_btn.Text = "CANCEL";
            this.CancTicket_btn.UseVisualStyleBackColor = false;
            this.CancTicket_btn.Click += new System.EventHandler(this.CancTicket_btn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(302, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 26);
            this.label15.TabIndex = 33;
            this.label15.Text = "Cancellation List";
            // 
            // CancelDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.CancelDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CancelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancelDGV.Location = new System.Drawing.Point(1, 38);
            this.CancelDGV.Name = "CancelDGV";
            this.CancelDGV.RowHeadersWidth = 62;
            this.CancelDGV.RowTemplate.Height = 28;
            this.CancelDGV.Size = new System.Drawing.Size(701, 481);
            this.CancelDGV.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.CancelDGV);
            this.panel6.Location = new System.Drawing.Point(582, 75);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(699, 520);
            this.panel6.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 592);
            this.panel2.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cancel Id:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Airline_Management_System.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(72, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(67, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 26);
            this.label12.TabIndex = 9;
            this.label12.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(67, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Flight Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(67, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ticket Id:";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(1264, 15);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 26);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Airline Management System";
            // 
            // FcodeTb
            // 
            this.FcodeTb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.FcodeTb.Enabled = false;
            this.FcodeTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcodeTb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FcodeTb.Location = new System.Drawing.Point(291, 336);
            this.FcodeTb.Multiline = true;
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(229, 40);
            this.FcodeTb.TabIndex = 67;
            this.FcodeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 59);
            this.panel1.TabIndex = 65;
            // 
            // CancDate
            // 
            this.CancDate.Location = new System.Drawing.Point(291, 417);
            this.CancDate.Name = "CancDate";
            this.CancDate.Size = new System.Drawing.Size(229, 26);
            this.CancDate.TabIndex = 26;
            // 
            // CanId
            // 
            this.CanId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CanId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanId.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CanId.Location = new System.Drawing.Point(291, 207);
            this.CanId.Multiline = true;
            this.CanId.Name = "CanId";
            this.CanId.Size = new System.Drawing.Size(229, 40);
            this.CanId.TabIndex = 76;
            // 
            // CancelRefresh_btn
            // 
            this.CancelRefresh_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancelRefresh_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelRefresh_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelRefresh_btn.Location = new System.Drawing.Point(429, 556);
            this.CancelRefresh_btn.Name = "CancelRefresh_btn";
            this.CancelRefresh_btn.Size = new System.Drawing.Size(132, 52);
            this.CancelRefresh_btn.TabIndex = 77;
            this.CancelRefresh_btn.Text = "REFRESH";
            this.CancelRefresh_btn.UseVisualStyleBackColor = false;
            this.CancelRefresh_btn.Click += new System.EventHandler(this.CancelRefresh_btn_Click);
            // 
            // CancellationTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 646);
            this.Controls.Add(this.CancelRefresh_btn);
            this.Controls.Add(this.CanId);
            this.Controls.Add(this.CancDate);
            this.Controls.Add(this.TidCb);
            this.Controls.Add(this.CancTicketBack_btn);
            this.Controls.Add(this.CancResetTicket_btn);
            this.Controls.Add(this.CancTicket_btn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancellationTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancellationTbl";
            this.Load += new System.EventHandler(this.CancellationTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CancelDGV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TidCb;
        private System.Windows.Forms.Button CancTicketBack_btn;
        private System.Windows.Forms.Button CancResetTicket_btn;
        private System.Windows.Forms.Button CancTicket_btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView CancelDGV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker CancDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CanId;
        private System.Windows.Forms.Button CancelRefresh_btn;
    }
}