using System;
using System.Windows.Forms;

namespace r2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            button1.Enabled = textBox1.Text.Length > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double funt;
            double kg;

            if (double.TryParse(textBox1.Text, out funt))
            {
                kg = funt * 0.4095;
                label2.Text = funt.ToString("N") + " ф. = " + kg.ToString("N") + " кг.";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }
    }
}
