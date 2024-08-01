namespace BankSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Backbutton = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Button();
            this.Loan = new System.Windows.Forms.Button();
            this.Loginbox = new System.Windows.Forms.ComboBox();
            this.Accountbox = new System.Windows.Forms.ComboBox();
            this.Customerbox = new System.Windows.Forms.ComboBox();
            this.Transactionbox = new System.Windows.Forms.ComboBox();
            this.Loanbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Backbutton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 886);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mont Bold", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Font = new System.Drawing.Font("Mont Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(22, 426);
            this.Fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(131, 44);
            this.Fname.TabIndex = 8;
            this.Fname.Text = "ADMIN";
            this.Fname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Backbutton
            // 
            this.Backbutton.AutoSize = true;
            this.Backbutton.Font = new System.Drawing.Font("Nexa Bold", 15F, System.Drawing.FontStyle.Bold);
            this.Backbutton.Location = new System.Drawing.Point(11, 827);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(58, 25);
            this.Backbutton.TabIndex = 6;
            this.Backbutton.Text = "Back";
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Login.Location = new System.Drawing.Point(368, 11);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(206, 88);
            this.Login.TabIndex = 12;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Account.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Account.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Account.Location = new System.Drawing.Point(592, 11);
            this.Account.Margin = new System.Windows.Forms.Padding(2);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(206, 88);
            this.Account.TabIndex = 13;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Customer.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Customer.Location = new System.Drawing.Point(813, 11);
            this.Customer.Margin = new System.Windows.Forms.Padding(2);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(206, 88);
            this.Customer.TabIndex = 14;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = false;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transactions.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.Transactions.Location = new System.Drawing.Point(1032, 11);
            this.Transactions.Margin = new System.Windows.Forms.Padding(2);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(206, 88);
            this.Transactions.TabIndex = 15;
            this.Transactions.Text = "Transactions";
            this.Transactions.UseVisualStyleBackColor = false;
            this.Transactions.Click += new System.EventHandler(this.Transactions_Click);
            // 
            // Loan
            // 
            this.Loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Loan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loan.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Loan.Location = new System.Drawing.Point(1251, 11);
            this.Loan.Margin = new System.Windows.Forms.Padding(2);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(206, 88);
            this.Loan.TabIndex = 16;
            this.Loan.Text = "Loan";
            this.Loan.UseVisualStyleBackColor = false;
            this.Loan.Click += new System.EventHandler(this.Loan_Click);
            // 
            // Loginbox
            // 
            this.Loginbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Loginbox.Font = new System.Drawing.Font("Nexa Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Loginbox.FormattingEnabled = true;
            this.Loginbox.Items.AddRange(new object[] {
            "Username",
            "Password"});
            this.Loginbox.Location = new System.Drawing.Point(368, 136);
            this.Loginbox.Margin = new System.Windows.Forms.Padding(2);
            this.Loginbox.Name = "Loginbox";
            this.Loginbox.Size = new System.Drawing.Size(312, 38);
            this.Loginbox.TabIndex = 56;
            // 
            // Accountbox
            // 
            this.Accountbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Accountbox.Font = new System.Drawing.Font("Nexa Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Accountbox.FormattingEnabled = true;
            this.Accountbox.Items.AddRange(new object[] {
            "Username",
            "AccountNo",
            "AccountType",
            "AccountOpenDate",
            "AccountBalance"});
            this.Accountbox.Location = new System.Drawing.Point(368, 189);
            this.Accountbox.Margin = new System.Windows.Forms.Padding(2);
            this.Accountbox.Name = "Accountbox";
            this.Accountbox.Size = new System.Drawing.Size(312, 38);
            this.Accountbox.TabIndex = 57;
            // 
            // Customerbox
            // 
            this.Customerbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Customerbox.Font = new System.Drawing.Font("Nexa Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Customerbox.FormattingEnabled = true;
            this.Customerbox.Items.AddRange(new object[] {
            "AccountNo",
            "CustFname",
            "CustLname",
            "CustCNIC",
            "CustDOB",
            "CustGender",
            "CustPhone",
            "CustEmail",
            "CustCity",
            "CustAddress"});
            this.Customerbox.Location = new System.Drawing.Point(368, 244);
            this.Customerbox.Margin = new System.Windows.Forms.Padding(2);
            this.Customerbox.Name = "Customerbox";
            this.Customerbox.Size = new System.Drawing.Size(312, 38);
            this.Customerbox.TabIndex = 58;
            // 
            // Transactionbox
            // 
            this.Transactionbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Transactionbox.Font = new System.Drawing.Font("Nexa Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Transactionbox.FormattingEnabled = true;
            this.Transactionbox.Items.AddRange(new object[] {
            "TransacID",
            "AccountNo",
            "TransacType",
            "TransacDest",
            "TransacTime",
            "TransacBalance",
            "BillID"});
            this.Transactionbox.Location = new System.Drawing.Point(368, 301);
            this.Transactionbox.Margin = new System.Windows.Forms.Padding(2);
            this.Transactionbox.Name = "Transactionbox";
            this.Transactionbox.Size = new System.Drawing.Size(312, 38);
            this.Transactionbox.TabIndex = 59;
            // 
            // Loanbox
            // 
            this.Loanbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Loanbox.Font = new System.Drawing.Font("Nexa Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Loanbox.FormattingEnabled = true;
            this.Loanbox.Items.AddRange(new object[] {
            "LoanID",
            "AccountNo",
            "LoanType",
            "LoanDate",
            "LoanBalance",
            "LoanStatus",
            "ReturnDate"});
            this.Loanbox.Location = new System.Drawing.Point(368, 355);
            this.Loanbox.Margin = new System.Windows.Forms.Padding(2);
            this.Loanbox.Name = "Loanbox";
            this.Loanbox.Size = new System.Drawing.Size(312, 38);
            this.Loanbox.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(712, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 686);
            this.dataGridView1.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(361, 494);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 63;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Nexa Bold", 18F);
            this.Search.Location = new System.Drawing.Point(368, 547);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(312, 37);
            this.Search.TabIndex = 62;
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Searchbutton.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.Searchbutton.Location = new System.Drawing.Point(434, 618);
            this.Searchbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(170, 63);
            this.Searchbutton.TabIndex = 64;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Loanbox);
            this.Controls.Add(this.Transactionbox);
            this.Controls.Add(this.Customerbox);
            this.Controls.Add(this.Accountbox);
            this.Controls.Add(this.Loginbox);
            this.Controls.Add(this.Loan);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Backbutton;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Transactions;
        private System.Windows.Forms.Button Loan;
        private System.Windows.Forms.ComboBox Loginbox;
        private System.Windows.Forms.ComboBox Accountbox;
        private System.Windows.Forms.ComboBox Customerbox;
        private System.Windows.Forms.ComboBox Transactionbox;
        private System.Windows.Forms.ComboBox Loanbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button Searchbutton;
    }
}