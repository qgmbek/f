using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using r12.Properties;

namespace r12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = Settings.Default.Left;
            this.Top = Settings.Default.Top;
            this.label2.Text = Settings.Default.User;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Left = this.Left;
            Settings.Default.Top = this.Top;
            Settings.Default.Save();
        }
    }
}

