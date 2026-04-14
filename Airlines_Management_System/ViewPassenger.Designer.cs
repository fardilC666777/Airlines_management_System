namespace Airline_Management_System
{
    partial class ViewPassenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.V_flight_exit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PphoneTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GendCb = new System.Windows.Forms.ComboBox();
            this.natcb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PaddTb = new System.Windows.Forms.TextBox();
            this.PpassTb = new System.Windows.Forms.TextBox();
            this.PnameTb = new System.Windows.Forms.TextBox();
            this.ViewPassBack_btn = new System.Windows.Forms.Button();
            this.ViewDelete_btn = new System.Windows.Forms.Button();
            this.ViewPassRes_btn = new System.Windows.Forms.Button();
            this.ViewPassUpdt_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PidTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PassengerDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.V_flight_exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 59);
            this.panel1.TabIndex = 1;
            // 
            // V_flight_exit
            // 
            this.V_flight_exit.AutoSize = true;
            this.V_flight_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.V_flight_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_flight_exit.ForeColor = System.Drawing.Color.Red;
            this.V_flight_exit.Location = new System.Drawing.Point(1243, 15);
            this.V_flight_exit.Name = "V_flight_exit";
            this.V_flight_exit.Size = new System.Drawing.Size(28, 26);
            this.V_flight_exit.TabIndex = 2;
            this.V_flight_exit.Text = "X";
            this.V_flight_exit.Click += new System.EventHandler(this.V_flight_exit_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.PphoneTb);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.GendCb);
            this.panel2.Controls.Add(this.natcb);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.PaddTb);
            this.panel2.Controls.Add(this.PpassTb);
            this.panel2.Controls.Add(this.PnameTb);
            this.panel2.Controls.Add(this.ViewPassBack_btn);
            this.panel2.Controls.Add(this.ViewDelete_btn);
            this.panel2.Controls.Add(this.ViewPassRes_btn);
            this.panel2.Controls.Add(this.ViewPassUpdt_btn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PidTb);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(16, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 599);
            this.panel2.TabIndex = 2;
            // 
            // PphoneTb
            // 
            this.PphoneTb.BackColor = System.Drawing.SystemColors.Menu;
            this.PphoneTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PphoneTb.Location = new System.Drawing.Point(168, 386);
            this.PphoneTb.Multiline = true;
            this.PphoneTb.Name = "PphoneTb";
            this.PphoneTb.Size = new System.Drawing.Size(215, 40);
            this.PphoneTb.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(15, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 27);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone:";
            // 
            // GendCb
            // 
            this.GendCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GendCb.FormattingEnabled = true;
            this.GendCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GendCb.Location = new System.Drawing.Point(168, 332);
            this.GendCb.Name = "GendCb";
            this.GendCb.Size = new System.Drawing.Size(215, 30);
            this.GendCb.TabIndex = 27;
            // 
            // natcb
            // 
            this.natcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natcb.FormattingEnabled = true;
            this.natcb.Items.AddRange(new object[] {
            "BANGLADESHI",
            "INDIAN",
            "CHINESE",
            "AMERICAN",
            "BRAZILIAN",
            "SRILANKAN",
            "AUSTRALIAN"});
            this.natcb.Location = new System.Drawing.Point(168, 279);
            this.natcb.Name = "natcb";
            this.natcb.Size = new System.Drawing.Size(215, 30);
            this.natcb.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(15, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 27);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gender:";
            // 
            // PaddTb
            // 
            this.PaddTb.BackColor = System.Drawing.SystemColors.Menu;
            this.PaddTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaddTb.Location = new System.Drawing.Point(168, 225);
            this.PaddTb.Multiline = true;
            this.PaddTb.Name = "PaddTb";
            this.PaddTb.Size = new System.Drawing.Size(215, 40);
            this.PaddTb.TabIndex = 24;
            // 
            // PpassTb
            // 
            this.PpassTb.BackColor = System.Drawing.SystemColors.Menu;
            this.PpassTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PpassTb.Location = new System.Drawing.Point(168, 160);
            this.PpassTb.Multiline = true;
            this.PpassTb.Name = "PpassTb";
            this.PpassTb.Size = new System.Drawing.Size(215, 40);
            this.PpassTb.TabIndex = 23;
            // 
            // PnameTb
            // 
            this.PnameTb.BackColor = System.Drawing.SystemColors.Menu;
            this.PnameTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnameTb.Location = new System.Drawing.Point(168, 89);
            this.PnameTb.Multiline = true;
            this.PnameTb.Name = "PnameTb";
            this.PnameTb.Size = new System.Drawing.Size(215, 40);
            this.PnameTb.TabIndex = 22;
            // 
            // ViewPassBack_btn
            // 
            this.ViewPassBack_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ViewPassBack_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPassBack_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPassBack_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewPassBack_btn.Location = new System.Drawing.Point(203, 522);
            this.ViewPassBack_btn.Name = "ViewPassBack_btn";
            this.ViewPassBack_btn.Size = new System.Drawing.Size(132, 52);
            this.ViewPassBack_btn.TabIndex = 21;
            this.ViewPassBack_btn.Text = "BACK";
            this.ViewPassBack_btn.UseVisualStyleBackColor = false;
            this.ViewPassBack_btn.Click += new System.EventHandler(this.ViewPassBack_btn_Click);
            // 
            // ViewDelete_btn
            // 
            this.ViewDelete_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ViewDelete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewDelete_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDelete_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewDelete_btn.Location = new System.Drawing.Point(203, 449);
            this.ViewDelete_btn.Name = "ViewDelete_btn";
            this.ViewDelete_btn.Size = new System.Drawing.Size(132, 52);
            this.ViewDelete_btn.TabIndex = 20;
            this.ViewDelete_btn.Text = "DELETE";
            this.ViewDelete_btn.UseVisualStyleBackColor = false;
            this.ViewDelete_btn.Click += new System.EventHandler(this.ViewDelete_btn_Click);
            // 
            // ViewPassRes_btn
            // 
            this.ViewPassRes_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ViewPassRes_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPassRes_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPassRes_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewPassRes_btn.Location = new System.Drawing.Point(20, 522);
            this.ViewPassRes_btn.Name = "ViewPassRes_btn";
            this.ViewPassRes_btn.Size = new System.Drawing.Size(132, 52);
            this.ViewPassRes_btn.TabIndex = 19;
            this.ViewPassRes_btn.Text = "RESET";
            this.ViewPassRes_btn.UseVisualStyleBackColor = false;
            this.ViewPassRes_btn.Click += new System.EventHandler(this.ViewPassRes_btn_Click);
            // 
            // ViewPassUpdt_btn
            // 
            this.ViewPassUpdt_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ViewPassUpdt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPassUpdt_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPassUpdt_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewPassUpdt_btn.Location = new System.Drawing.Point(20, 449);
            this.ViewPassUpdt_btn.Name = "ViewPassUpdt_btn";
            this.ViewPassUpdt_btn.Size = new System.Drawing.Size(132, 52);
            this.ViewPassUpdt_btn.TabIndex = 18;
            this.ViewPassUpdt_btn.Text = "UPDATE";
            this.ViewPassUpdt_btn.UseVisualStyleBackColor = false;
            this.ViewPassUpdt_btn.Click += new System.EventHandler(this.ViewPassUpdt_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(15, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nationality:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(15, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // PidTb
            // 
            this.PidTb.BackColor = System.Drawing.SystemColors.Menu;
            this.PidTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PidTb.Location = new System.Drawing.Point(168, 29);
            this.PidTb.Multiline = true;
            this.PidTb.Name = "PidTb";
            this.PidTb.Size = new System.Drawing.Size(215, 40);
            this.PidTb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Passenger Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Passport:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.PassengerDGV);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(440, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 599);
            this.panel3.TabIndex = 3;
            // 
            // PassengerDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.PassengerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PassengerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PassengerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PassengerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PassengerDGV.Location = new System.Drawing.Point(0, 48);
            this.PassengerDGV.Name = "PassengerDGV";
            this.PassengerDGV.RowHeadersWidth = 62;
            this.PassengerDGV.RowTemplate.Height = 28;
            this.PassengerDGV.Size = new System.Drawing.Size(831, 548);
            this.PassengerDGV.TabIndex = 1;
            this.PassengerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PassengerDGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "View Passenger Info";
            // 
            // ViewPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 686);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassenger";
            this.Load += new System.EventHandler(this.ViewPassenger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label V_flight_exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewPassBack_btn;
        private System.Windows.Forms.Button ViewDelete_btn;
        private System.Windows.Forms.Button ViewPassRes_btn;
        private System.Windows.Forms.Button ViewPassUpdt_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PidTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView PassengerDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PaddTb;
        private System.Windows.Forms.TextBox PpassTb;
        private System.Windows.Forms.TextBox PnameTb;
        private System.Windows.Forms.TextBox PphoneTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GendCb;
        private System.Windows.Forms.ComboBox natcb;
    }
}