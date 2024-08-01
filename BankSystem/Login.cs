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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Frontpage f = new Frontpage();
            this.Hide();
            f.ShowDialog();
        }


        private void Signup_Click(object sender, EventArgs e)
        {
            Signup f = new Signup();
            this.Hide();
            f.ShowDialog();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {

            if(Username.Text == "admin" && Password.Text == "123")
            {
                this.Hide();
                Admin f = new Admin();
                f.ShowDialog();
            }

            else
            {
                string ConnectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string user = Username.Text;
                string pass = Password.Text;

                string q = "Select * from login where username= '" + user + "' and password= '" + pass + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Invalid.ForeColor = Color.White;
                    MessageBox.Show("Login Successful");
                    dr.Close();
                    con.Close();
                    this.Hide();
                    Dashboard f = new Dashboard(user);
                    f.ShowDialog();
                }

                else
                {
                    Invalid.ForeColor = Color.Red;
                    dr.Close();
                    con.Close();
                }
                con.Close();
            }
            
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
