using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace r5
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            double discount;
            double total;
            sum = 309000;
            discount = 0;

            if (checkBox1.Checked)
            {
                sum += 8390;
            }

            if (checkBox2.Checked)
            {
                sum += 5990;
            }

            if (checkBox3.Checked)
            {
                sum += 7590;
            }

            total = sum;
            string st;
            st = "Цена в выбранной комплектации: " + sum.ToString("C");

            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                discount = sum * 0.01;
                total = total - discount;
                st += "\nСкидка (1%): " + discount.ToString("C") +
                      "\nИтого: " + total.ToString("C");
            }

            label3.Text = st;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
