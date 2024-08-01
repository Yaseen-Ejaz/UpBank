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
    public partial class Loan : Form
    {
        public static string connectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        static int a;
        static string n;
        static int b;
        static string u;
        public Loan(int acc, string name, int bal, string user)
        {
            InitializeComponent();
            a = acc;
            n = name;
            b = bal;
            u = user;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if(Loantype.Text!="" && LoanAmount.Text!="")
            {
                Info.Hide();

                int max, min,newb;
                max = min = newb = 0;

                if(Loantype.Text=="Personal")
                {
                    min = 30000; max = 100000;
                }

                else if (Loantype.Text == "Business")
                {
                    min = 100000; max = 1000000;
                }

                else if (Loantype.Text == "Student")
                {
                    min = 50000; max = 200000;
                }

                else if (Loantype.Text == "Debt")
                {
                    min = 80000; max = 500000;
                }

                int loan = int.Parse(LoanAmount.Text);

                if(loan>=min && loan<=max)
                {
                    con.Open();
                    int la = int.Parse(LoanAmount.Text);
                    string q = "insert into loan(AccountNo, LoanType, LoanDate, LoanBalance, LoanStatus) values (" + a + ", '" + Loantype.Text + "', getdate(), " + la + ", 'Pending' )";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Loan Amount has been added to your account");

                    newb = loan + b;
                    
                    q = "update account set AccountBalance = "+ newb +" ";
                    SqlCommand cmdd = new SqlCommand(q, con);
                    cmdd.ExecuteNonQuery();

                    con.Close();

                    this.Hide();
                    Dashboard f = new Dashboard(u);
                    f.ShowDialog();

                }

                else
                {
                    MessageBox.Show("Amount is out of range");
                }
            }

            else
            {
                Info.Show();
            }
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            Fname.Text = n;
            Account.Text = a.ToString();
            Balance.Text = b.ToString();
            Info.Hide();
            con.Open();
            string q = "Select * from Loan where AccountNo= " + a + " ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard(u);
            f.ShowDialog();
        }

        private void Pending_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select * from Loan where AccountNo= " + a + " and LoanStatus = 'Pending' ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Returned_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "Select * from Loan where AccountNo= " + a + " and LoanStatus = 'Returned' ";

            SqlDataAdapter db = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            db.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            if(LoanID.Text!="")
            {
                con.Open();
                int upbal = 0;
                string q ="Select * from Loan where LoanID = " + int.Parse(LoanID.Text) + " and LoanStatus='Pending' ";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    if(b >= int.Parse(dr["LoanBalance"].ToString()))
                    {
                        
                        upbal = b - int.Parse(dr["LoanBalance"].ToString());

                        dr.Close();
                        q = "update loan set loanstatus = 'Returned', ReturnDate=getdate() where LoanID = "+int.Parse(LoanID.Text)+" ";
                        SqlCommand cmdd = new SqlCommand(q, con);
                        cmdd.ExecuteNonQuery();

                        q = "update Account set AccountBalance = "+upbal+" where AccountNo = "+a+"";
                        SqlCommand cm = new SqlCommand(q, con);
                        cm.ExecuteNonQuery();

                        MessageBox.Show("Loan has been returned" , "Success");
                        this.Hide();
                        Dashboard f = new Dashboard(u);
                        f.ShowDialog();

                        con.Close();
                    }

                    else
                    {
                        dr.Close();
                        MessageBox.Show("Account does not have enough balance to return loan", "Error");
                    }
                }

                else
                {
                    MessageBox.Show("Loan ID Not Found", "Error");
                }
                con.Close();
            }

            else
            {
                MessageBox.Show("ID Not Found", "Error");
            }
        }

        private void Loantype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int max, min;
            max = min = 0;

            if (Loantype.Text == "Personal")
            {
                min = 30000; max = 100000;
            }

            else if (Loantype.Text == "Business")
            {
                min = 100000; max = 1000000;
            }

            else if (Loantype.Text == "Student")
            {
                min = 50000; max = 200000;
            }

            else if (Loantype.Text == "Debt")
            {
                min = 80000; max = 500000;
            }

            Min.Text = min.ToString() ;
            Max.Text = max.ToString() ;
        }
    }
}
