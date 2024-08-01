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
    public partial class Deposit : Form
    {
        public static string connectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        static int a;
        static string n;
        static int b;
        static string u;
        public Deposit(int acc, string name, int bal, string user)
        {
            InitializeComponent();
            a = acc;
            n = name;
            b = bal;
            u = user;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            Fname.Text = n;
            Account.Text = a.ToString();
            Balance.Text = b.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard(u);
            f.ShowDialog();
        }

        private void Dep_Click(object sender, EventArgs e)
        {
            int destacc = 0;
            int upbal = 0;
            if (BillType.Text == "Electricity")
            {
                destacc = 111111;
            }

            else if (BillType.Text == "Water")
            {
                destacc = 222222;
            }

            else if (BillType.Text == "Gas")
            {
                destacc = 333333;
            }

            Acc.Text = destacc.ToString();

            if (BillType.Text != "" && Billid.Text != "")
            {
                if (Billid.Text.Length == 5)
                {
                    con.Open();
                    string q = "Select * from transactions where BillID = " + int.Parse(Billid.Text) + " ";
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Invalid Bill ID", "Error");
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();

                        if (b >= 1000)
                        {
                            upbal = 0;
                            q = "insert into transactions (Billid, AccountNo, TransacType, TransacDest, TransacTime, TransacBalance) values ( " + int.Parse(Billid.Text) + ", " + a + ",'Deposit' , " + destacc + " , getdate(), 1000)";
                            SqlCommand cm = new SqlCommand(q, con);
                            cm.ExecuteNonQuery();

                            upbal = b - 1000;
                            q = "update account set AccountBalance = " + upbal + " where AccountNo = " + a + "";
                            SqlCommand cmdd = new SqlCommand(q, con);
                            cmdd.ExecuteNonQuery();

                            MessageBox.Show("Bill has been paid successfully", "Success");

                            con.Close();
                            this.Hide();
                            Dashboard f = new Dashboard(u);
                            f.ShowDialog();
                        }

                        else
                        {
                            con.Close();

                            MessageBox.Show("Insufficient balance to pay bill", "Error");
                        }
                        con.Close();
                    }
                }

                else
                {
                    con.Close();

                    MessageBox.Show("Invalid Bill ID", "Error");
                }
            }

            else
            {
                MessageBox.Show("Invalid Info", "Error");
            }
        }

        private void BillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int destacc = 0;
            if (BillType.Text == "Electricity")
            {
                destacc = 111111;
            }

            else if (BillType.Text == "Water")
            {
                destacc = 222222;
            }

            else if (BillType.Text == "Gas")
            {
                destacc = 333333;
            }

            Acc.Text = destacc.ToString();
        }

        private void Dep1_Click(object sender, EventArgs e)
        {
            int upbal;
            int destacc = 1234567;
            if (TaxID.Text != "" && TaxID.Text.Length == 5)
            {
                con.Open();
                string q = "Select * from transactions where BillID = " + int.Parse(TaxID.Text) + " ";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Invalid Tax ID", "Error");
                    dr.Close();
                    con.Close();
                }
                else
                {
                    dr.Close();

                    if (b >= 1000)
                    {
                        upbal = 0;
                        q = "insert into transactions (Billid, AccountNo, TransacType, TransacDest, TransacTime, TransacBalance) values ( " + int.Parse(TaxID.Text) + ", " + a + ",'Deposit' , " + destacc + " , getdate(), 1000)";
                        SqlCommand cm = new SqlCommand(q, con);
                        cm.ExecuteNonQuery();

                        upbal = b - 1000;
                        q = "update account set AccountBalance = " + upbal + " where AccountNo = " + a + "";
                        SqlCommand cmdd = new SqlCommand(q, con);
                        cmdd.ExecuteNonQuery();

                        MessageBox.Show("Tax has been paid successfully", "Success");

                        con.Close();
                        this.Hide();
                        Dashboard f = new Dashboard(u);
                        f.ShowDialog();
                    }

                    else
                    {
                        con.Close();

                        MessageBox.Show("Insufficient balance to pay tax", "Error");
                    }
                    con.Close();

                }


            }
            else
            {
                MessageBox.Show("Invalid Tax ID");
                con.Close();
            }
        }
    }
}
