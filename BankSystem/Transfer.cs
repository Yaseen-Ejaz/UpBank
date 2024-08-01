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
    public partial class Transfer : Form
    {
        public static string connectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        static int a;
        static string n;
        static int b;
        static int destacc;
        static bool accc=false;
        static string u;
        public Transfer(int acc, string name, int bal, string user)
        {
            InitializeComponent();
            a = acc;
            n = name;
            b = bal;
            u = user;
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            con.Open();

            if(Acc.Text!="")
            {
                destacc = int.Parse(Acc.Text);
                string q = "Select AccountNo from Account where AccountNo= " + destacc + " ";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    accc = true;
                    AmountLab.Show();
                    Amount.Show();
                    NameLab.Show();
                    Namee.Show();
                    CNIC.Show();
                    CNICLab.Show();
                    NotLab.Hide();
                    Min.Show();

                    dr.Close();

                    q = "Select CustFname,CustLName, CustCNIC from Customer where AccountNo= " + destacc + " ";
                    SqlCommand cm = new SqlCommand(q, con);
                    SqlDataReader drr = cm.ExecuteReader();
                    string f = "";
                    string l = "";
                    if (drr.Read())
                    {
                        f = drr["CustFName"].ToString();
                        l = drr["CustLName"].ToString();

                        f = f + " " + l;
                        Namee.Text = f;
                        CNIC.Text = drr["CustCNIC"].ToString();
                    }
                    drr.Close();
                    
                }

                else
                {
                    accc = false;
                    AmountLab.Hide();
                    Amount.Hide();
                    NameLab.Hide();
                    Namee.Hide();
                    CNIC.Hide();
                    CNICLab.Hide();
                    NotLab.Show();
                    Min.Hide();
                }
                dr.Close();
                con.Close();
            }
            con.Close();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            accc = false;
            Fname.Text = n;
            Account.Text = a.ToString();
            Balance.Text = b.ToString();
            AmountLab.Hide();
            Amount.Hide();
            NameLab.Hide();
            Namee.Hide();
            CNIC.Hide();
            CNICLab.Hide();
            NotLab.Hide();
            Min.Hide();
        }

        private void Trans_Click(object sender, EventArgs e)
        {
            if(check() && a!=destacc)
            {
                con.Open();

                string q = "Select AccountBalance from Account where AccountNo= " + destacc + " ";
                SqlCommand cm = new SqlCommand(q, con);
                SqlDataReader dr = cm.ExecuteReader();

                int am = 0;
                if(dr.Read())
                {
                    am = int.Parse(dr["AccountBalance"].ToString());
                }
                dr.Close();
                am = am + int.Parse(Amount.Text);

                q = "Update Account set AccountBalance = "+am+" where AccountNo= " + destacc + " ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();

                int balance;

                balance = b - int.Parse(Amount.Text);

                q = "Update Account set AccountBalance = " + balance + " where AccountNo= " + a + " ";
                SqlCommand cmd1 = new SqlCommand(q, con);
                cmd1.ExecuteNonQuery();

                if(Amount.Text!="")
                {
                    int trbal = 0;
                    trbal = int.Parse(Amount.Text);
                    q = "insert into Transactions(AccountNo, TransacType, TransacDest, TransacTime, TransacBalance) values (" + a + ", 'Transfer', " + destacc + " ,getdate(), " + trbal + " ) ";
                    SqlCommand cmdd = new SqlCommand(q, con);
                    cmdd.ExecuteNonQuery();

                    MessageBox.Show("Transfer Successful");
                    this.Hide();
                    Dashboard f = new Dashboard(u);
                    f.ShowDialog();
                }

                con.Close();
            }

            else
            {
                MessageBox.Show("An Error Occured","Error");
                con.Close();
            }
        }

        public bool check()
        {
            bool bal=false;

            if(Account.Text=="")
            {
                accc = false;
            }

            else if(Amount.Text=="")
            {
                bal = false;
            }

            else if (b >= int.Parse(Amount.Text) && int.Parse(Amount.Text)>=500 )
            {
                bal = true;
            }

            else if(b < int.Parse(Amount.Text))
            {
                bal = false;
                MessageBox.Show("Amount Entered is more than Account Balance", "Error");
            }

            else if(int.Parse(Amount.Text) < 500 || Amount.Text == "")
            {
                bal = false;
                MessageBox.Show("Amount is less than 500", "Error");
            }

            if (bal && accc)
                return true;
            return false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard(u);
            f.ShowDialog();
            
        }
    }
}
