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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Frontpage f = new Frontpage();
            this.Hide();
            f.ShowDialog();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            if (Constraint())
            {
                string ConnectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string user = Username.Text;
                string pass = Password.Text;

                string q = "Select * from login where username= '" + user + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Name has been taken");
                    dr.Close();
                }

                else
                {
                    dr.Close();
                    con.Close();
                    SignupDashboard f = new SignupDashboard(user,pass);
                    this.Hide();
                    f.ShowDialog();
                }
                con.Close();
            }


        }


        private void Username_Leave(object sender, EventArgs e)
        {
            
        }

        bool Constraint()
        {
            bool User = false;
            bool Pass = false;
            string username = Username.Text;
            string password = Password.Text;

            if(username.Length>=5)
            {
                Userlen.ForeColor = Color.White;
                for (int i = 0; i < username.Length; i++)
                {
                    if ((username[i] >= 'a' && username[i] <= 'z') ||
                        (username[i] >= 'A' && username[i] <= 'Z') ||
                        (username[i] >= '0' && username[i] <= '9') ||
                        (username[i] == '_' || username[i] == '-'))
                    {
                        Invch.ForeColor = Color.White;
                        User = true;
                    }

                    else
                    {
                        Invch.ForeColor = Color.Red;
                        User = false;
                        break;
                    }
                }
            }

            else
            {
                Userlen.ForeColor = Color.Red;
                User = false;
            }
                


            if (password.Length>=5)
            {
                Passlen.ForeColor = Color.White;
                Pass = true;
            }

            else
            {
                Passlen.ForeColor = Color.Red;
            }

            if (User == true && Pass == true)
                return true;

            else
            {
                return false;
            }
                
        }

    }

}
