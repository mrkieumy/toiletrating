using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rating
{
    public partial class fUserResponse : Form
    {
        public fUserResponse()
        {
            InitializeComponent();
            //lbltime1.Visible = false;
            lbltime2.Visible = false;
            timer1.Start();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            lblsorry.Text = "We recieved you feedback, if you have any other problem, please call our staff at 088888 1080.";
            lblquestion.Text = "Thank you very much, we wish you have a good time.";
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            btnsend.Visible = false;
            lbltime1.Visible = false;
            lbltime2.Visible = true;
            timer1.Stop();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbltime1.Text);
            a--;
            lbltime1.Text = a.ToString();
            if (a < 0)
            {
                timer1.Stop();
                lbltime1.Text = "20";
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbltime2.Text);
            a--;
            lbltime2.Text = a.ToString();
            if (a < 0)
            {
                timer2.Stop();
                lbltime2.Text = "10";
                this.Close();
            }
        }
    }
}
