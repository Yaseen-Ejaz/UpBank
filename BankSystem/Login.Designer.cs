
namespace BankSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameTitle = new System.Windows.Forms.Label();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Noacc = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Button();
            this.Signupbutton = new System.Windows.Forms.Button();
            this.Invalid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Mont Bold", 45F, System.Drawing.FontStyle.Bold);
            this.LoginTitle.Location = new System.Drawing.Point(50, 366);
            this.LoginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(215, 83);
            this.LoginTitle.TabIndex = 5;
            this.LoginTitle.Text = "Log In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.Backbutton);
            this.panel1.Controls.Add(this.LoginTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 739);
            this.panel1.TabIndex = 6;
            // 
            // Backbutton
            // 
            this.Backbutton.AutoSize = true;
            this.Backbutton.Font = new System.Drawing.Font("Nexa Bold", 10F, System.Drawing.FontStyle.Bold);
            this.Backbutton.Location = new System.Drawing.Point(9, 705);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(41, 17);
            this.Backbutton.TabIndex = 6;
            this.Backbutton.Text = "Back";
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BankSystem.Properties.Resources.upbanklogo;
            this.pictureBox1.Location = new System.Drawing.Point(50, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameTitle
            // 
            this.UsernameTitle.AutoSize = true;
            this.UsernameTitle.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.UsernameTitle.Location = new System.Drawing.Point(366, 134);
            this.UsernameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameTitle.Name = "UsernameTitle";
            this.UsernameTitle.Size = new System.Drawing.Size(157, 37);
            this.UsernameTitle.TabIndex = 10;
            this.UsernameTitle.Text = "Username";
            // 
            // PasswordTitle
            // 
            this.PasswordTitle.AutoSize = true;
            this.PasswordTitle.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.PasswordTitle.Location = new System.Drawing.Point(366, 325);
            this.PasswordTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordTitle.Name = "PasswordTitle";
            this.PasswordTitle.Size = new System.Drawing.Size(151, 37);
            this.PasswordTitle.TabIndex = 11;
            this.PasswordTitle.Text = "Password";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Nexa Bold", 15F);
            this.Username.Location = new System.Drawing.Point(372, 184);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(314, 32);
            this.Username.TabIndex = 13;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Nexa Bold", 15F);
            this.Password.Location = new System.Drawing.Point(372, 379);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(314, 32);
            this.Password.TabIndex = 14;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Noacc
            // 
            this.Noacc.AutoSize = true;
            this.Noacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noacc.Location = new System.Drawing.Point(841, 647);
            this.Noacc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Noacc.Name = "Noacc";
            this.Noacc.Size = new System.Drawing.Size(158, 17);
            this.Noacc.TabIndex = 15;
            this.Noacc.Text = "Don\'t have an account?";
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signup.Font = new System.Drawing.Font("Mont Bold", 10F, System.Drawing.FontStyle.Bold);
            this.Signup.ForeColor = System.Drawing.Color.Black;
            this.Signup.Location = new System.Drawing.Point(872, 665);
            this.Signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(83, 37);
            this.Signup.TabIndex = 16;
            this.Signup.Text = "Sign Up";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Signupbutton
            // 
            this.Signupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signupbutton.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.Signupbutton.ForeColor = System.Drawing.Color.Black;
            this.Signupbutton.Location = new System.Drawing.Point(372, 548);
            this.Signupbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Signupbutton.Name = "Signupbutton";
            this.Signupbutton.Size = new System.Drawing.Size(155, 70);
            this.Signupbutton.TabIndex = 25;
            this.Signupbutton.Text = "Log In";
            this.Signupbutton.UseVisualStyleBackColor = false;
            this.Signupbutton.Click += new System.EventHandler(this.Signupbutton_Click);
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invalid.ForeColor = System.Drawing.Color.White;
            this.Invalid.Location = new System.Drawing.Point(369, 500);
            this.Invalid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(165, 16);
            this.Invalid.TabIndex = 26;
            this.Invalid.Text = "Invalid Username/Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 731);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.Signupbutton);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Noacc);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordTitle);
            this.Controls.Add(this.UsernameTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Backbutton;
        private System.Windows.Forms.Label UsernameTitle;
        private System.Windows.Forms.Label PasswordTitle;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Noacc;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Button Signupbutton;
        private System.Windows.Forms.Label Invalid;
    }
}