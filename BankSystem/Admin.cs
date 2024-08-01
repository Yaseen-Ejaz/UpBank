using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankSystem
{
    public partial class Admin : Form
    {
        static bool l, a, c, t, lo;
        
        public static string connectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        public Admin()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontpage f = new Frontpage();
            f.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Loginbox.Show();
            Customerbox.Hide();
            Accountbox.Hide();
            Transactionbox.Hide();
            Loanbox.Hide();
            l= a = c = t = lo = false;

            con.Open();
            string q = "Select * from Account ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Loginbox.Show();
            Customerbox.Hide();
            Accountbox.Hide();
            Transactionbox.Hide();
            Loanbox.Hide();
            a = c = t = lo = false;
            l = true;

            con.Open();
            string q = "Select * from Login ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            Loginbox.Hide();
            Customerbox.Hide();
            Accountbox.Show();
            Transactionbox.Hide();
            Loanbox.Hide();
            l = c = t = lo = false;
            a = true;

            con.Open();
            string q = "Select * from Account ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Loginbox.Hide();
            Customerbox.Show();
            Accountbox.Hide();
            Transactionbox.Hide();
            Loanbox.Hide();

            l = a = t = lo = false;
            c = true;

            con.Open();
            string q = "Select * from Customer ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            Loginbox.Hide();
            Customerbox.Hide();
            Accountbox.Hide();
            Transactionbox.Show();
            Loanbox.Hide();

            l = a = c = lo = false;
            t = true;

            con.Open();
            string q = "Select * from Transactions ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Loan_Click(object sender, EventArgs e)
        {
            Loginbox.Hide();
            Customerbox.Hide();
            Accountbox.Hide();
            Transactionbox.Hide();
            Loanbox.Show();

            l = a = c = t = false;
            lo = true;

            con.Open();
            string q = "Select * from Loan ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string q="Select * from Account";
            if(Search.Text!="")
            {
                if (l)
                {
                    q = "Select * from Login where " + Loginbox.Text + " = '" + Search.Text + "' ";
                }

                else if (a)
                {
                    q = "Select * from Account where " + Accountbox.Text + " = '" + Search.Text + "' ";
                }

                else if (c)
                {
                    q = "Select * from Customer where " + Customerbox.Text + " = '" + Search.Text + "' ";
                }

                else if (t)
                {
                    q = "Select * from Transactions where " + Transactionbox.Text + " = '" + Search.Text + "' ";
                }

                else if (lo)
                {
                    q = "Select * from Loan where " + Loanbox.Text + " = '" + Search.Text + "' ";
                }
            }

            else
            {
                if (l)
                {
                    q = "Select * from Login ";
                }

                else if (a)
                {
                    q = "Select * from Account";
                }

                else if (c)
                {
                    q = "Select * from Customer";
                }

                else if (t)
                {
                    q = "Select * from Transactions";
                }

                else if (lo)
                {
                    q = "Select * from Loan";
                }
            }

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
