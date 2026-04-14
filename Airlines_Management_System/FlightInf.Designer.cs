namespace Airline_Management_System
{
    partial class FlightInf
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
            this.label5 = new System.Windows.Forms.Label();
            this.V_flight_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RecordFlight_btn = new System.Windows.Forms.Button();
            this.Flight_Update_btn = new System.Windows.Forms.Button();
            this.Flights_Delete_btn = new System.Windows.Forms.Button();
            this.Flight_Reset_btn = new System.Windows.Forms.Button();
            this.FlightBack_btn = new System.Windows.Forms.Button();
            this.FlightRefresh_btn = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // V_flight_exit
            // 
            this.V_flight_exit.AutoSize = true;
            this.V_flight_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.V_flight_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.V_flight_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_flight_exit.ForeColor = System.Drawing.Color.Red;
            this.V_flight_exit.Location = new System.Drawing.Point(1264, 16);
            this.V_flight_exit.Name = "V_flight_exit";
            this.V_flight_exit.Size = new System.Drawing.Size(28, 26);
            this.V_flight_exit.TabIndex = 2;
            this.V_flight_exit.Text = "X";
            this.V_flight_exit.Click += new System.EventHandler(this.V_flight_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 581);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flight Time:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(55, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "NumOfSeat:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(56, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 26);
            this.label12.TabIndex = 4;
            this.label12.Text = "TakeOfDate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(56, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Destination:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(56, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "From:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(56, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Flight Code:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.V_flight_exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 59);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Location = new System.Drawing.Point(609, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(683, 536);
            this.panel6.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(305, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 23);
            this.label15.TabIndex = 33;
            this.label15.Text = "Flight Schedule";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(709, 498);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(296, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 40);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DHAKA",
            "TOKYO",
            "BERLIN",
            "TORONTO",
            "SYDNEY",
            "BARCELONA",
            "MADRID"});
            this.comboBox2.Location = new System.Drawing.Point(296, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 30);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DHAKA",
            "TOKYO",
            "BERLIN",
            "TORONTO",
            "SYDNEY",
            "BARCELONA",
            "MADRID"});
            this.comboBox1.Location = new System.Drawing.Point(296, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 30);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 241);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 26);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(296, 288);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 40);
            this.textBox3.TabIndex = 40;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RecordFlight_btn
            // 
            this.RecordFlight_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.RecordFlight_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordFlight_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordFlight_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RecordFlight_btn.Location = new System.Drawing.Point(296, 425);
            this.RecordFlight_btn.Name = "RecordFlight_btn";
            this.RecordFlight_btn.Size = new System.Drawing.Size(132, 52);
            this.RecordFlight_btn.TabIndex = 41;
            this.RecordFlight_btn.Text = "Record";
            this.RecordFlight_btn.UseVisualStyleBackColor = false;
            this.RecordFlight_btn.Click += new System.EventHandler(this.RecordFlight_btn_Click);
            // 
            // Flight_Update_btn
            // 
            this.Flight_Update_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Flight_Update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Flight_Update_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight_Update_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Flight_Update_btn.Location = new System.Drawing.Point(455, 425);
            this.Flight_Update_btn.Name = "Flight_Update_btn";
            this.Flight_Update_btn.Size = new System.Drawing.Size(132, 52);
            this.Flight_Update_btn.TabIndex = 42;
            this.Flight_Update_btn.Text = "UPDATE";
            this.Flight_Update_btn.UseVisualStyleBackColor = false;
            this.Flight_Update_btn.Click += new System.EventHandler(this.Flight_Update_btn_Click);
            // 
            // Flights_Delete_btn
            // 
            this.Flights_Delete_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Flights_Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Flights_Delete_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flights_Delete_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Flights_Delete_btn.Location = new System.Drawing.Point(296, 497);
            this.Flights_Delete_btn.Name = "Flights_Delete_btn";
            this.Flights_Delete_btn.Size = new System.Drawing.Size(132, 52);
            this.Flights_Delete_btn.TabIndex = 43;
            this.Flights_Delete_btn.Text = "DELETE";
            this.Flights_Delete_btn.UseVisualStyleBackColor = false;
            this.Flights_Delete_btn.Click += new System.EventHandler(this.Flights_Delete_btn_Click);
            // 
            // Flight_Reset_btn
            // 
            this.Flight_Reset_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Flight_Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Flight_Reset_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight_Reset_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Flight_Reset_btn.Location = new System.Drawing.Point(455, 497);
            this.Flight_Reset_btn.Name = "Flight_Reset_btn";
            this.Flight_Reset_btn.Size = new System.Drawing.Size(132, 52);
            this.Flight_Reset_btn.TabIndex = 44;
            this.Flight_Reset_btn.Text = "RESET";
            this.Flight_Reset_btn.UseVisualStyleBackColor = false;
            this.Flight_Reset_btn.Click += new System.EventHandler(this.Flight_Reset_btn_Click);
            // 
            // FlightBack_btn
            // 
            this.FlightBack_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.FlightBack_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlightBack_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightBack_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FlightBack_btn.Location = new System.Drawing.Point(296, 573);
            this.FlightBack_btn.Name = "FlightBack_btn";
            this.FlightBack_btn.Size = new System.Drawing.Size(132, 52);
            this.FlightBack_btn.TabIndex = 45;
            this.FlightBack_btn.Text = "BACK";
            this.FlightBack_btn.UseVisualStyleBackColor = false;
            this.FlightBack_btn.Click += new System.EventHandler(this.FlightBack_btn_Click);
            // 
            // FlightRefresh_btn
            // 
            this.FlightRefresh_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.FlightRefresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlightRefresh_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightRefresh_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FlightRefresh_btn.Location = new System.Drawing.Point(455, 573);
            this.FlightRefresh_btn.Name = "FlightRefresh_btn";
            this.FlightRefresh_btn.Size = new System.Drawing.Size(132, 52);
            this.FlightRefresh_btn.TabIndex = 46;
            this.FlightRefresh_btn.Text = "Refresh";
            this.FlightRefresh_btn.UseVisualStyleBackColor = false;
            this.FlightRefresh_btn.Click += new System.EventHandler(this.FlightRefresh_btn_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "11:50pm",
            "1:00am",
            "2:15am",
            "5:00am",
            "6:10am",
            "4:00pm"});
            this.comboBox3.Location = new System.Drawing.Point(296, 355);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(229, 30);
            this.comboBox3.TabIndex = 47;
            // 
            // FlightInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 637);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.FlightRefresh_btn);
            this.Controls.Add(this.FlightBack_btn);
            this.Controls.Add(this.Flight_Reset_btn);
            this.Controls.Add(this.Flights_Delete_btn);
            this.Controls.Add(this.Flight_Update_btn);
            this.Controls.Add(this.RecordFlight_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightInf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightInf";
            this.Load += new System.EventHandler(this.FlightInf_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label V_flight_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button RecordFlight_btn;
        private System.Windows.Forms.Button Flight_Update_btn;
        private System.Windows.Forms.Button Flights_Delete_btn;
        private System.Windows.Forms.Button Flight_Reset_btn;
        private System.Windows.Forms.Button FlightBack_btn;
        private System.Windows.Forms.Button FlightRefresh_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}