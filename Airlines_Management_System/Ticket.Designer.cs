namespace Airline_Management_System
{
    partial class Ticket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ticket_exit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tid = new System.Windows.Forms.TextBox();
            this.PNameTb = new System.Windows.Forms.TextBox();
            this.PPassTb = new System.Windows.Forms.TextBox();
            this.PIdCb = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.TicketDGV = new System.Windows.Forms.DataGridView();
            this.BookTicket_btn = new System.Windows.Forms.Button();
            this.ResetTicket_btn = new System.Windows.Forms.Button();
            this.TicketBack_btn = new System.Windows.Forms.Button();
            this.FCodeCb = new System.Windows.Forms.ComboBox();
            this.PNatTb = new System.Windows.Forms.TextBox();
            this.PAmtTb = new System.Windows.Forms.TextBox();
            this.SnoTb = new System.Windows.Forms.ComboBox();
            this.ClassTb = new System.Windows.Forms.ComboBox();
            this.Search_ticketBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Ticket_exit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 59);
            this.panel1.TabIndex = 47;
            // 
            // Ticket_exit
            // 
            this.Ticket_exit.AutoSize = true;
            this.Ticket_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.Ticket_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ticket_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket_exit.ForeColor = System.Drawing.Color.Red;
            this.Ticket_exit.Location = new System.Drawing.Point(1268, 16);
            this.Ticket_exit.Name = "Ticket_exit";
            this.Ticket_exit.Size = new System.Drawing.Size(28, 26);
            this.Ticket_exit.TabIndex = 2;
            this.Ticket_exit.Text = "X";
            this.Ticket_exit.Click += new System.EventHandler(this.Ticket_exit_Click);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(47, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "Passport:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(54, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 26);
            this.label12.TabIndex = 4;
            this.label12.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(47, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Passenger Id:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(47, 68);
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
            this.label9.Location = new System.Drawing.Point(47, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ticket Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 689);
            this.panel2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(54, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(54, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "SeatNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(54, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nationality:";
            // 
            // Tid
            // 
            this.Tid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Tid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tid.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Tid.Location = new System.Drawing.Point(291, 65);
            this.Tid.Multiline = true;
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(229, 40);
            this.Tid.TabIndex = 50;
            // 
            // PNameTb
            // 
            this.PNameTb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PNameTb.Enabled = false;
            this.PNameTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameTb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PNameTb.Location = new System.Drawing.Point(291, 231);
            this.PNameTb.Multiline = true;
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(229, 40);
            this.PNameTb.TabIndex = 53;
            this.PNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PPassTb
            // 
            this.PPassTb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PPassTb.Enabled = false;
            this.PPassTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPassTb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PPassTb.Location = new System.Drawing.Point(291, 286);
            this.PPassTb.Multiline = true;
            this.PPassTb.Name = "PPassTb";
            this.PPassTb.Size = new System.Drawing.Size(229, 40);
            this.PPassTb.TabIndex = 54;
            this.PPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PIdCb
            // 
            this.PIdCb.BackColor = System.Drawing.Color.SlateGray;
            this.PIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIdCb.FormattingEnabled = true;
            this.PIdCb.Location = new System.Drawing.Point(291, 178);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(229, 30);
            this.PIdCb.TabIndex = 56;
            this.PIdCb.SelectionChangeCommitted += new System.EventHandler(this.PIdCb_SelectionChangeCommitted);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.TicketDGV);
            this.panel6.Location = new System.Drawing.Point(582, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(723, 536);
            this.panel6.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(302, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 26);
            this.label15.TabIndex = 33;
            this.label15.Text = "Booking Details";
            // 
            // TicketDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.TicketDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TicketDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDGV.Location = new System.Drawing.Point(1, 38);
            this.TicketDGV.Name = "TicketDGV";
            this.TicketDGV.RowHeadersWidth = 62;
            this.TicketDGV.RowTemplate.Height = 28;
            this.TicketDGV.Size = new System.Drawing.Size(722, 498);
            this.TicketDGV.TabIndex = 0;
            this.TicketDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDGV_CellContentClick);
            // 
            // BookTicket_btn
            // 
            this.BookTicket_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.BookTicket_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookTicket_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTicket_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BookTicket_btn.Location = new System.Drawing.Point(296, 570);
            this.BookTicket_btn.Name = "BookTicket_btn";
            this.BookTicket_btn.Size = new System.Drawing.Size(132, 52);
            this.BookTicket_btn.TabIndex = 58;
            this.BookTicket_btn.Text = "BOOK";
            this.BookTicket_btn.UseVisualStyleBackColor = false;
            this.BookTicket_btn.Click += new System.EventHandler(this.BookTicket_btn_Click);
            // 
            // ResetTicket_btn
            // 
            this.ResetTicket_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ResetTicket_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetTicket_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetTicket_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ResetTicket_btn.Location = new System.Drawing.Point(434, 570);
            this.ResetTicket_btn.Name = "ResetTicket_btn";
            this.ResetTicket_btn.Size = new System.Drawing.Size(132, 52);
            this.ResetTicket_btn.TabIndex = 59;
            this.ResetTicket_btn.Text = "RESET";
            this.ResetTicket_btn.UseVisualStyleBackColor = false;
            this.ResetTicket_btn.Click += new System.EventHandler(this.ResetTicket_btn_Click);
            // 
            // TicketBack_btn
            // 
            this.TicketBack_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.TicketBack_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketBack_btn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketBack_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TicketBack_btn.Location = new System.Drawing.Point(296, 628);
            this.TicketBack_btn.Name = "TicketBack_btn";
            this.TicketBack_btn.Size = new System.Drawing.Size(132, 52);
            this.TicketBack_btn.TabIndex = 60;
            this.TicketBack_btn.Text = "BACK";
            this.TicketBack_btn.UseVisualStyleBackColor = false;
            this.TicketBack_btn.Click += new System.EventHandler(this.TicketBack_btn_Click);
            // 
            // FCodeCb
            // 
            this.FCodeCb.BackColor = System.Drawing.Color.SlateGray;
            this.FCodeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCodeCb.FormattingEnabled = true;
            this.FCodeCb.Location = new System.Drawing.Point(291, 124);
            this.FCodeCb.Name = "FCodeCb";
            this.FCodeCb.Size = new System.Drawing.Size(229, 30);
            this.FCodeCb.TabIndex = 62;
            // 
            // PNatTb
            // 
            this.PNatTb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PNatTb.Enabled = false;
            this.PNatTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNatTb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PNatTb.Location = new System.Drawing.Point(291, 346);
            this.PNatTb.Multiline = true;
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.Size = new System.Drawing.Size(229, 40);
            this.PNatTb.TabIndex = 63;
            this.PNatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PAmtTb
            // 
            this.PAmtTb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PAmtTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAmtTb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PAmtTb.Location = new System.Drawing.Point(291, 412);
            this.PAmtTb.Multiline = true;
            this.PAmtTb.Name = "PAmtTb";
            this.PAmtTb.Size = new System.Drawing.Size(229, 40);
            this.PAmtTb.TabIndex = 64;
            // 
            // SnoTb
            // 
            this.SnoTb.BackColor = System.Drawing.Color.SlateGray;
            this.SnoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnoTb.FormattingEnabled = true;
            this.SnoTb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.SnoTb.Location = new System.Drawing.Point(291, 472);
            this.SnoTb.Name = "SnoTb";
            this.SnoTb.Size = new System.Drawing.Size(229, 30);
            this.SnoTb.TabIndex = 65;
            // 
            // ClassTb
            // 
            this.ClassTb.BackColor = System.Drawing.Color.SlateGray;
            this.ClassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTb.FormattingEnabled = true;
            this.ClassTb.Items.AddRange(new object[] {
            "ECONOMY",
            "BUSINESS"});
            this.ClassTb.Location = new System.Drawing.Point(291, 522);
            this.ClassTb.Name = "ClassTb";
            this.ClassTb.Size = new System.Drawing.Size(229, 30);
            this.ClassTb.TabIndex = 66;
            // 
            // Search_ticketBtn
            // 
            this.Search_ticketBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Search_ticketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_ticketBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_ticketBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Search_ticketBtn.Location = new System.Drawing.Point(434, 628);
            this.Search_ticketBtn.Name = "Search_ticketBtn";
            this.Search_ticketBtn.Size = new System.Drawing.Size(146, 52);
            this.Search_ticketBtn.TabIndex = 67;
            this.Search_ticketBtn.Text = "Search By Id";
            this.Search_ticketBtn.UseVisualStyleBackColor = false;
            this.Search_ticketBtn.Click += new System.EventHandler(this.Search_ticketBtn_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 694);
            this.Controls.Add(this.Search_ticketBtn);
            this.Controls.Add(this.ClassTb);
            this.Controls.Add(this.SnoTb);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.FCodeCb);
            this.Controls.Add(this.TicketBack_btn);
            this.Controls.Add(this.ResetTicket_btn);
            this.Controls.Add(this.BookTicket_btn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.PPassTb);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ticket_exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.TextBox PNameTb;
        private System.Windows.Forms.TextBox PPassTb;
        private System.Windows.Forms.ComboBox PIdCb;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView TicketDGV;
        private System.Windows.Forms.Button BookTicket_btn;
        private System.Windows.Forms.Button ResetTicket_btn;
        private System.Windows.Forms.Button TicketBack_btn;
        private System.Windows.Forms.ComboBox FCodeCb;
        private System.Windows.Forms.TextBox PNatTb;
        private System.Windows.Forms.TextBox PAmtTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SnoTb;
        private System.Windows.Forms.ComboBox ClassTb;
        private System.Windows.Forms.Button Search_ticketBtn;
    }
}