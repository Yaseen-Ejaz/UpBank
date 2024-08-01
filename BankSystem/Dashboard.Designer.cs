namespace BankSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Balance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Label();
            this.Deposit = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.Button();
            this.Loan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trans = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.Balance);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Account);
            this.panel1.Controls.Add(this.Fname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Backbutton);
            this.panel1.Location = new System.Drawing.Point(-20, -15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 886);
            this.panel1.TabIndex = 8;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.Balance.Location = new System.Drawing.Point(39, 649);
            this.Balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(61, 37);
            this.Balance.TabIndex = 14;
            this.Balance.Text = "Bal";
            this.Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mont Bold", 28.00001F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 575);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 52);
            this.label3.TabIndex = 13;
            this.label3.Text = "Balance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mont Bold", 28.00001F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 52);
            this.label2.TabIndex = 12;
            this.label2.Text = "Account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mont Bold", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("Mont Bold", 20F, System.Drawing.FontStyle.Bold);
            this.Account.Location = new System.Drawing.Point(39, 449);
            this.Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(70, 37);
            this.Account.TabIndex = 10;
            this.Account.Text = "Acc";
            this.Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Font = new System.Drawing.Font("Mont Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(38, 254);
            this.Fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(113, 44);
            this.Fname.TabIndex = 8;
            this.Fname.Text = "label1";
            this.Fname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Backbutton
            // 
            this.Backbutton.AutoSize = true;
            this.Backbutton.Font = new System.Drawing.Font("Nexa Bold", 15F, System.Drawing.FontStyle.Bold);
            this.Backbutton.Location = new System.Drawing.Point(41, 823);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(58, 25);
            this.Backbutton.TabIndex = 6;
            this.Backbutton.Text = "Back";
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Deposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deposit.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Deposit.Location = new System.Drawing.Point(362, 20);
            this.Deposit.Margin = new System.Windows.Forms.Padding(2);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(206, 117);
            this.Deposit.TabIndex = 9;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Transfer.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Transfer.Location = new System.Drawing.Point(640, 20);
            this.Transfer.Margin = new System.Windows.Forms.Padding(2);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(207, 117);
            this.Transfer.TabIndex = 11;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Details
            // 
            this.Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Details.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Details.Location = new System.Drawing.Point(1189, 20);
            this.Details.Margin = new System.Windows.Forms.Padding(2);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(207, 117);
            this.Details.TabIndex = 13;
            this.Details.Text = "Details";
            this.Details.UseVisualStyleBackColor = false;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // Loan
            // 
            this.Loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Loan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loan.Font = new System.Drawing.Font("Mont Bold", 25F, System.Drawing.FontStyle.Bold);
            this.Loan.Location = new System.Drawing.Point(912, 20);
            this.Loan.Margin = new System.Windows.Forms.Padding(2);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(207, 117);
            this.Loan.TabIndex = 14;
            this.Loan.Text = "Loan";
            this.Loan.UseVisualStyleBackColor = false;
            this.Loan.Click += new System.EventHandler(this.Loan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mont Bold", 28F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(688, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 52);
            this.label4.TabIndex = 15;
            this.label4.Text = "Transaction History";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 452);
            this.dataGridView1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BankSystem.Properties.Resources._25275;
            this.pictureBox2.Location = new System.Drawing.Point(1318, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // Trans
            // 
            this.Trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Trans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Trans.Font = new System.Drawing.Font("Mont Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Trans.Location = new System.Drawing.Point(435, 779);
            this.Trans.Margin = new System.Windows.Forms.Padding(2);
            this.Trans.Name = "Trans";
            this.Trans.Size = new System.Drawing.Size(166, 68);
            this.Trans.TabIndex = 61;
            this.Trans.Text = "Transfer";
            this.Trans.UseVisualStyleBackColor = false;
            this.Trans.Click += new System.EventHandler(this.Trans_Click);
            // 
            // Bill
            // 
            this.Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Bill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bill.Font = new System.Drawing.Font("Mont Bold", 18F, System.Drawing.FontStyle.Bold);
            this.Bill.Location = new System.Drawing.Point(1189, 779);
            this.Bill.Margin = new System.Windows.Forms.Padding(2);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(166, 68);
            this.Bill.TabIndex = 62;
            this.Bill.Text = "Bill";
            this.Bill.UseVisualStyleBackColor = false;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.Trans);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Loan);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Backbutton;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Button Loan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Trans;
        private System.Windows.Forms.Button Bill;
    }
}