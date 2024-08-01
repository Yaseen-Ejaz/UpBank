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
    public partial class Dashboard : Form
    {
        public static string connectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        static string u;
        static int a=0;
        static string name = "";
        static int bal = 0;
        public Dashboard(string user)
        {
            InitializeComponent();
            u = user;
        }

        private void Account_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();

            string q = "Select * from Account where Username= '" + u + "' ";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                Account.Text = dr["AccountNo"].ToString();
                Balance.Text = dr["AccountBalance"].ToString();
                a = int.Parse(dr["AccountNo"].ToString());
                bal = int.Parse(dr["AccountBalance"].ToString());
            }
            dr.Close();

            q = "Select * from Customer where AccountNo= " + a + " ";
            SqlCommand cmd1 = new SqlCommand(q, con);
            SqlDataReader drr = cmd1.ExecuteReader();

            string f=".";
            string l = ".";
            if (drr.Read())
            {
                f = drr["CustFName"].ToString();
                l = drr["CustLName"].ToString();
            }

            drr.Close();
            name = f + " " + l;
            Fname.Text = name;

            q = "Select * from Transactions where AccountNo= " + a + " ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select * from Transactions where AccountNo= " + a + " ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer f = new Transfer(a,name,bal,u);
            f.ShowDialog();
            
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontpage f = new Frontpage();
            f.ShowDialog();
        }

        private void Loan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loan f = new Loan(a, name, bal, u);
            f.ShowDialog();
        }

        private void Details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Details f = new Details(a, name, bal, u);
            f.ShowDialog();
            
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit f = new Deposit(a, name, bal, u);
            f.ShowDialog();
        }

        private void Trans_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select TransacID, TransacType, TransacDest, TransacTime, TransacBalance from Transactions where AccountNo= " + a + " and TransacType = 'Transfer' ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select TransacID, BillID, TransacType, TransacDest, TransacTime, TransacBalance from Transactions where AccountNo= " + a + " and TransacType = 'Deposit' ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }
    }

}
