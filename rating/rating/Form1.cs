using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace rating
{
    public partial class Form1 : Form
    {
        int counthappy = 0;
        public Form1()
        {
            InitializeComponent();
            lbltime.Visible = false;
            lblcount.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counthappy++;
            lblresult.Text = "Thank you very much for your happy feeling with our service";
            lblresultadd.Text = "We wish you have a good time";
            lblcount.Visible = true;
            lbltime.Visible = true;
            
            if (counthappy==1)
                lblcount.Text = "We're very happy to recieve " + counthappy.ToString() + " vote of customer until now.";
            else
                lblcount.Text = "We're very happy to recieve " + counthappy.ToString() + " votes of customer until now.";
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblresult.Text = "Thank you for your feedback, we will improve it to make you happy";
            lbltime.Visible = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbltime.Text);
            a--;
            lbltime.Text = a.ToString();
            if (a < 0)
            {
                timer1.Stop();
                lblresult.Text = "It's our pleasure to hear your feeling about our service";
                lblresultadd.Text = "";
                lbltime.Text = "10";
                lbltime.Visible = false;
                lblcount.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fUserResponse newform = new fUserResponse();
            newform.Show();
        }
    }
}
