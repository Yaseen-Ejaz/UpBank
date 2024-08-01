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
    public partial class SignupDashboard : Form
    {
        public static string connectionString = "Data Source=MSI;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);
        static string u;
        static string p;
        public SignupDashboard(string user, string pass)
        {
            InitializeComponent();
            u = user;
            p = pass;
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Frontpage f = new Frontpage();
            this.Hide();
            f.ShowDialog();
        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            if(check())
            {
                con.Open();
                string q = "insert into login values('" + u + "','" + p + "') ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();

                int depamount = int.Parse(Deposit.Text);
                q = "insert into Account(Username,AccountType,AccountOpenDate,AccountBalance) values ('" + u + "','"+Acctype.Text+"', getdate() ," + depamount + ")";
                SqlCommand cmd1 = new SqlCommand(q, con);
                cmd1.ExecuteNonQuery();

                q = "select AccountNo from Account where username = '" + u + "' ";
                SqlCommand cmd2 = new SqlCommand(q, con);
                SqlDataReader dr = cmd2.ExecuteReader();

                int acc=0;
                if(dr.Read())
                {
                    acc = int.Parse(dr["AccountNo"].ToString());
                }
                dr.Close();

                q = "insert into Customer values (" + acc + ",'" + Firstname.Text + "','" + Lastname.Text + "','" + CNIC.Text + "','" + DOB.Text + "','" + Gender.Text + "','" + Phone.Text + "','" + Email.Text + "','" + City.Text + "','" + Address.Text + "')";
                SqlCommand cmd3 = new SqlCommand(q, con);
                cmd3.ExecuteNonQuery();

                con.Close();
                
                
                MessageBox.Show("Account has been created successfully");

                this.Hide();
                Dashboard f = new Dashboard(u);
                f.ShowDialog();

            }
        }

        bool check()
        {
            bool fname, lname, cnic, gender, dob, phone, email, address, city, dep, acc;
            fname = lname = cnic = gender = dob = phone = email = address = city = dep = acc = false;

            //First name~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if (Firstname.Text!="" && (Firstname.Text[0]>='A' && Firstname.Text[0] <= 'Z') && (Firstname.Text.Length>=2) )
            {
                fname = true;
                Fin.ForeColor = Color.White;
            }

            else
            {
                Fin.ForeColor = Color.Red;
            }

            //Last name~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if (Lastname.Text != "" && (Lastname.Text[0] >= 'A' && Lastname.Text[0] <= 'Z') && (Lastname.Text.Length >= 2) )
            {
                lname = true;
                Lin.ForeColor = Color.White;
            }

            else
            {
                Lin.ForeColor = Color.Red;
            }

            //CNIC~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            bool x,y;
            x = y = false;
           
            if(CNIC.Text!="" && CNIC.Text.Length==15)
            {
                for(int i=0;i<=4;i++)
                {
                    if(CNIC.Text[i]>='0' && CNIC.Text[i]<='9')
                        x = true;
                    else
                    {
                        x = false;
                        break;
                    }
                }

                for (int i = 6; i <= 12; i++)
                {
                    if (CNIC.Text[i] >= '0' && CNIC.Text[i] <= '9')
                        y = true;
                    else
                    {
                        y = false;
                        break;
                    }
                }

                if(x && y && (CNIC.Text[5] == '-') && (CNIC.Text[13]=='-') && (CNIC.Text[14]>='0' && CNIC.Text[14]<='9'))
                {
                    cnic = true;
                    Cin.ForeColor = Color.White;
                }

                else
                {
                    Cin.ForeColor = Color.Red;
                }

                /*if 
               ((CNIC.Text[0] >= '0' && CNIC.Text[0] <= '9') &&
                (CNIC.Text[1] >= '0' && CNIC.Text[1] <= '9') &&
                (CNIC.Text[2] >= '0' && CNIC.Text[2] <= '9') &&
                (CNIC.Text[3] >= '0' && CNIC.Text[3] <= '9') &&
                (CNIC.Text[4] >= '0' && CNIC.Text[4] <= '9') &&
                (CNIC.Text[5] == '-')&&
                (CNIC.Text[6] >= '0' && CNIC.Text[6] <= '9') &&
                (CNIC.Text[7] >= '0' && CNIC.Text[7] <= '9') &&
                (CNIC.Text[8] >= '0' && CNIC.Text[8] <= '9') &&
                (CNIC.Text[9] >= '0' && CNIC.Text[9] <= '9') &&
                (CNIC.Text[10] >= '0' && CNIC.Text[10] <= '9') &&
                (CNIC.Text[11] >= '0' && CNIC.Text[11] <= '9') &&
                (CNIC.Text[12] >= '0' && CNIC.Text[12] <= '9') &&
                (CNIC.Text[13] == '-') &&
                (CNIC.Text[14] >= '0' && CNIC.Text[14] <= '9')
                )
                {
                    cnic = true;
                    Cin.ForeColor = Color.White;
                }

                else
                {
                    Cin.ForeColor = Color.Red;
                }*/
            }

            else
            {
                Cin.ForeColor = Color.Red;
            }

            //Gender~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if(Gender.Text=="Male" || Gender.Text == "Female" || Gender.Text == "Other")
            {
                gender = true;
                Gin.ForeColor = Color.White;
            }

            else if(Gender.Text=="")
            {
                Gin.ForeColor = Color.Red;
            }

            //DOB~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if(DOB.Text!="")
            {
                dob = true;
                DOB.ForeColor = Color.White;
            }

            else 
            {
                DOB.ForeColor = Color.Red;
            }

            //Phone~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            bool p = false;
            if(Phone.Text!="" && Phone.Text.Length==10)
            {
                for(int i=0;i<=9;i++)
                {
                    if(Phone.Text[i]>='0' && Phone.Text[i]<='9')
                    {
                        p = true;
                    }

                    else
                    {
                        p = false;
                        break;
                    }
                }

                if(p)
                {
                    phone = true;
                    Pin.ForeColor = Color.White;
                }
            }

            else
            {
                Pin.ForeColor = Color.Red;
            }

            //Email~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            bool em=false;
            if(Email.Text!="")
            {
                for(int i=0;i<=Email.Text.Length;i++)
                {
                    if (Email.Text[i] == '@')
                    {
                        em = true;
                        break;
                    }
                }

                if(em==true)
                {
                    Emailin.ForeColor = Color.White;
                    email = true;
                }

                else
                {
                    Emailin.ForeColor = Color.Red;
                }
            }

            else if(Email.Text == "" || em==false)
            {
                Emailin.ForeColor = Color.Red;
            }


            //Address~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if(Address.Text!="")
            {
                Addressin.ForeColor = Color.White;
                address = true;
            }

            else if(Address.Text == "")
            {
                Addressin.ForeColor = Color.Red;
            }


            //City~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if(City.Text!="")
            {
                Cityin.ForeColor = Color.White;
                city = true;
            }

            else
            {
                Cityin.ForeColor = Color.Red;
            }
            //Deposit~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            int depamount=0;
            
            if (Deposit.Text != "")
            {
                depamount = int.Parse(Deposit.Text);
                if (depamount >= 500)
                {
                    Depin.ForeColor = Color.White;
                    dep = true;
                }

                else if(depamount < 500) Depin.ForeColor = Color.Red;

            }

            else if(Deposit.Text == "" || depamount < 500)
            {
                Depin.ForeColor = Color.Red;
            }

            //Account Type~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            if (Acctype.Text != "")
            {
                Accin.ForeColor = Color.White;
                acc = true;
            }

            else
            {
                Accin.ForeColor = Color.Red;
            }

            if (fname && lname && cnic && gender && dob && phone && email && address && city && dep && acc)
                return true;
            else return false;
        }

       
    }
}
