namespace Airline_Management_System
{
    partial class Signup_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signUp_Email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_loginHere = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signUpReset_btn = new System.Windows.Forms.Button();
            this.signupBack_btn = new System.Windows.Forms.Button();
            this.signup_close = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // signUp_Email
            // 
            this.signUp_Email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.signUp_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Email.Location = new System.Drawing.Point(267, 159);
            this.signUp_Email.Multiline = true;
            this.signUp_Email.Name = "signUp_Email";
            this.signUp_Email.Size = new System.Drawing.Size(342, 37);
            this.signUp_Email.TabIndex = 4;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(271, 251);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(342, 37);
            this.name.TabIndex = 5;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(271, 336);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(342, 37);
            this.password.TabIndex = 6;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(267, 431);
            this.type.Multiline = true;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(342, 32);
            this.type.TabIndex = 7;
            // 
            // signUp_btn
            // 
            this.signUp_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.signUp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_btn.Location = new System.Drawing.Point(271, 514);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(132, 45);
            this.signUp_btn.TabIndex = 8;
            this.signUp_btn.Text = "SIGNUP";
            this.signUp_btn.UseVisualStyleBackColor = false;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(292, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an account?";
            // 
            // signup_loginHere
            // 
            this.signup_loginHere.AutoSize = true;
            this.signup_loginHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginHere.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signup_loginHere.Location = new System.Drawing.Point(490, 611);
            this.signup_loginHere.Name = "signup_loginHere";
            this.signup_loginHere.Size = new System.Drawing.Size(94, 20);
            this.signup_loginHere.TabIndex = 10;
            this.signup_loginHere.Text = "Login here";
            this.signup_loginHere.Click += new System.EventHandler(this.signup_loginHere_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 640);
            this.panel2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(55, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Signup Here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Airline_Management_System.Properties.Resources.signup_here;
            this.pictureBox1.Location = new System.Drawing.Point(32, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // signUpReset_btn
            // 
            this.signUpReset_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.signUpReset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpReset_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpReset_btn.Location = new System.Drawing.Point(441, 514);
            this.signUpReset_btn.Name = "signUpReset_btn";
            this.signUpReset_btn.Size = new System.Drawing.Size(132, 45);
            this.signUpReset_btn.TabIndex = 22;
            this.signUpReset_btn.Text = "RESET";
            this.signUpReset_btn.UseVisualStyleBackColor = false;
            this.signUpReset_btn.Click += new System.EventHandler(this.signUpReset_btn_Click);
            // 
            // signupBack_btn
            // 
            this.signupBack_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.signupBack_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBack_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBack_btn.Location = new System.Drawing.Point(617, 514);
            this.signupBack_btn.Name = "signupBack_btn";
            this.signupBack_btn.Size = new System.Drawing.Size(132, 45);
            this.signupBack_btn.TabIndex = 23;
            this.signupBack_btn.Text = "BACK";
            this.signupBack_btn.UseVisualStyleBackColor = false;
            this.signupBack_btn.Click += new System.EventHandler(this.signupBack_btn_Click);
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.BackColor = System.Drawing.Color.White;
            this.signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.ForeColor = System.Drawing.Color.Red;
            this.signup_close.Location = new System.Drawing.Point(794, 9);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(23, 22);
            this.signup_close.TabIndex = 24;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 33);
            this.label7.TabIndex = 25;
            this.label7.Text = "Get started!";
            // 
            // signup_showPass
            // 
            this.signup_showPass.AutoSize = true;
            this.signup_showPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.signup_showPass.Location = new System.Drawing.Point(474, 379);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(148, 24);
            this.signup_showPass.TabIndex = 26;
            this.signup_showPass.Text = "Show Password";
            this.signup_showPass.UseVisualStyleBackColor = true;
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // Signup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(820, 640);
            this.Controls.Add(this.signup_showPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signup_close);
            this.Controls.Add(this.signupBack_btn);
            this.Controls.Add(this.signUpReset_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signup_loginHere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.type);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.signUp_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup_Form";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signUp_Email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label signup_loginHere;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signUpReset_btn;
        private System.Windows.Forms.Button signupBack_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox signup_showPass;
    }
}