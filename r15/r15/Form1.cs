using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace r15
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
            string filePath = Application.StartupPath + "\\usd.txt";

            if (!System.IO.File.Exists(filePath))
            {
                try
                {
                    System.IO.File.WriteAllText(filePath, "01/01/2023\nExample Data\n"); // Default content
                    MessageBox.Show(
                        "The file 'usd.txt' was not found, so it has been created with default content.\n" +
                        "You can now modify it as needed.",
                        "File Created",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(
                        "An error occurred while creating the file:\n" +
                        exc.ToString(),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            System.IO.StreamReader sr;
            try
            {
                sr = new System.IO.StreamReader(filePath, System.Text.Encoding.UTF8);

                DateTime dateStart = monthCalendar1.SelectionStart;
                DateTime dateEnd = monthCalendar1.SelectionEnd;

                string st1, st2 = "";
                DateTime date;
                listBox1.Items.Clear();

                while (!sr.EndOfStream)
                {
                    st1 = sr.ReadLine();
                    date = System.Convert.ToDateTime(st1);
                    st2 = sr.ReadLine();
                    if ((date >= dateStart) && (date <= dateEnd))
                    {
                        listBox1.Items.Add(st1 + " " + st2);
                    }
                }
                sr.Close();

                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add("--- no data available ---");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(
                    "Error accessing data file\n" +
                    exc.ToString(),
                    "Quotes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                button1.Enabled = false;
            }
        }
    }
}
