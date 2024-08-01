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
    public partial class Details : Form
    {
        public static string connectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        static int a;
        static string n;
        static int b;
        static string u;
        public Details(int acc, string name, int bal, string user)
        {
            InitializeComponent();
            a = acc;
            n = name;
            b = bal;
            u = user;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            Fname.Text = n;
            Account.Text = a.ToString();
            Balance.Text = b.ToString();

            con.Open();
            string q = "Select * from Account where AccountNo = " + a + " ";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                AccType.Text = dr["AccountType"].ToString();
                AccDate.Text = dr["AccountOpenDate"].ToString();
            }
            dr.Close();

            q = "Select * from Customer where AccountNo = " + a + " ";
            SqlCommand cm = new SqlCommand(q, con);
            SqlDataReader drr = cm.ExecuteReader();

            if (drr.Read())
            {
                CNIC.Text = drr["CustCNIC"].ToString();
                DOB.Text = drr["CustDOB"].ToString();
                Gender.Text = drr["CustGender"].ToString();
                Phone.Text = drr["CustPhone"].ToString();
                Email.Text = drr["CustEmail"].ToString();
                City.Text = drr["CustCity"].ToString();
                Address.Text = drr["CustAddress"].ToString();
            }
            drr.Close();

            con.Close();


        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard(u);
            f.ShowDialog();
            
        }
    }
}
