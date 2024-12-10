using System;
using System.Windows.Forms;

namespace r10
{
    public partial class Form1 : Form
    {
        int m, s, ms;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            m = 0; s = 0; ms = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Start";
                button2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Stop";
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m = 0; s = 0; ms = 0;
            label1.Text = "00";
            label2.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.Visible)
            {
                if (s < 59)
                {
                    s++;
                    label2.Text = s < 10 ? "0" + s.ToString() : s.ToString();
                }
                else
                {
                    if (m < 59)
                    {
                        m++;
                        label1.Text = m < 10 ? "0" + m.ToString() : m.ToString();
                        s = 0;
                        label2.Text = "00";
                    }
                    else
                    {
                        m = 0;
                        label1.Text = "00";
                    }
                }
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
