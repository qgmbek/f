using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace r16
{
    public partial class Form1 : Form
    {
        private string fn = string.Empty;
        private bool docChanged = false;

        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Text = string.Empty;
            this.Text = "NkEdit - New Document";
            ParamToolStripMenuItem.Visible = true;
            //ParamToolStripMenuItem.Checked = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text|*.txt";
            openFileDialog1.Title = "Open Document";
            openFileDialog1.Multiselect = false;

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save Document";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OpenDocument()
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;
                this.Text = fn;
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fn);
                    textBox1.Text = sr.ReadToEnd();
                    textBox1.SelectionStart = textBox1.TextLength;
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("File access error\n" + exc.ToString(), "NkEdit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int SaveDocument()
        {
            int result = 0;
            if (fn == string.Empty)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fn = saveFileDialog1.FileName;
                    this.Text = fn;
                }
                else result = -1;
            }

            if (fn != string.Empty)
            {
                try
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(fn);
                    System.IO.StreamWriter sw = fi.CreateText();
                    sw.Write(textBox1.Text);
                    sw.Close();
                    result = 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "NkEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }

        private void FileCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr = MessageBox.Show("Save changes?", "NkEdit",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (SaveDocument() == 0)
                        {
                            textBox1.Clear();
                            docChanged = false;
                        }
                        break;
                    case DialogResult.No:
                        textBox1.Clear();
                        docChanged = false;
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void FileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fn = openFileDialog1.FileName;
                this.Text = fn;
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fn);
                    textBox1.Text = sr.ReadToEnd();
                    textBox1.SelectionStart = textBox1.TextLength;
                    sr.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("File reading error.\n" + exc.ToString(), "NkEdit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void FileExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParamToolStripMenuItem.Visible = !ParamToolStripMenuItem.Visible;
            //ParamToolStripMenuItem.Checked = !ParamToolStripMenuItem.Checked;
        }

        private void ParamFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            docChanged = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (docChanged)
            {
                DialogResult dr = MessageBox.Show("Save changes?", "NkEdit",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (dr)
                {
                    case DialogResult.Yes:
                        if (SaveDocument() != 0)
                            e.Cancel = true;
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void AboutProgramMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}

