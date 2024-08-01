using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);

            if(progressBar1.Value==100)
            {
                timer1.Enabled = false;
                Frontpage f = new Frontpage();
                this.Hide();
                f.ShowDialog();
            }

        }
    }
}
