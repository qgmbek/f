using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Event triggered when the form loads
        private void Form2_Load(object sender, EventArgs e)
        {
            // Add any initialization logic here if needed
        }

        // Handle click event on the web link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string webRef = linkLabel1.Text;

            // Ensure the URL starts with a valid protocol (http or https)
            if (!webRef.StartsWith("http://") && !webRef.StartsWith("https://"))
            {
                webRef = "http://" + webRef; // Add default protocol if missing
            }

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = webRef,
                    UseShellExecute = true // Ensures the default web browser is used
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

