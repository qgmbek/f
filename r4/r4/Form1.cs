using System;
using System.Windows.Forms;

namespace r4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Additional logic on load can be added here if needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cena = 0;
            int n;
            double sum;

            if (radioButton1.Checked)
                cena = 8.50;
            if (radioButton2.Checked)
                cena = 10;
            if (radioButton3.Checked)
                cena = 15.5;

            n = Convert.ToInt32(textBox1.Text);
            sum = n * cena;

            label3.Text = "Цена: " + cena.ToString("c") +
                          "\nКоличество: " + n.ToString() + "шт.\n" +
                          "Сумма заказа: " + sum.ToString("C");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length != 0;
            label2.Text = "";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Focus();
        }
    }
}

