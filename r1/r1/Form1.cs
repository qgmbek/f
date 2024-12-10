using System;
using System.Windows.Forms;

namespace r1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return; 

            if (e.KeyChar == '.')
            {
                e.KeyChar = ','; 
            }

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1) e.Handled = true; 
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) button1.Focus(); 
                return;
            }

            e.Handled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mile;
            double km;

            try
            {
                mile = Convert.ToDouble(textBox1.Text);
                km = mile * 1.609344;
                label2.Text = km.ToString("n") + " км.";
            }
            catch
            {
                textBox1.Focus(); 
            }
        }
    }
}
