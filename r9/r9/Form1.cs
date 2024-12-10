using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace r9
{
    public partial class Form1 : Form
    {
        List<string> imgList = new List<string>();
        int nImg = 0;
        int pbw, pbh, pbX, pbY;
        string aPath;

        public Form1()
        {
            InitializeComponent();
            pbh = pictureBox1.Height;
            pbw = pictureBox1.Width;
            pbX = pictureBox1.Location.X;
            pbY = pictureBox1.Location.Y;

            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            aPath = di.FullName;
            FillListBox(aPath);
        }

        private Boolean FillListBox(string aPath)
        {
            DirectoryInfo di = new DirectoryInfo(aPath);
            FileInfo[] fi = di.GetFiles("*.jpg");
            imgList.Clear();

            foreach (FileInfo fc in fi)
            {
                imgList.Add(fc.Name);
            }

            if (fi.Length == 0)
            {
                pictureBox1.Image = null; // Clear the image display if no images are found
                button2.Enabled = false; // Disable both buttons
                button3.Enabled = false;
                return false;
            }
            else
            {
                nImg = 0; // Reset to the first image
                ShowPicture(aPath + "\\" + imgList[nImg]);

                // Enable or disable buttons based on the number of images
                button2.Enabled = nImg > 0; // Disable "Previous" for the first image
                button3.Enabled = imgList.Count > 1; // Enable "Next" only if there's more than one image
                this.Text = aPath; // Update the form's title with the folder path
                return true;
            }
        }


        private void ShowPicture(string aPicture)
        {
            double mh, mw;
            pictureBox1.Visible = false;
            pictureBox1.Left = pbX;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = new Bitmap(aPicture);

            if ((pictureBox1.Image.Width > pbw) || (pictureBox1.Image.Height > pbh))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                mh = (double)pbh / (double)pictureBox1.Image.Height;
                mw = (double)pbw / (double)pictureBox1.Image.Width;

                if (mh < mw)
                {
                    pictureBox1.Width = Convert.ToInt16(pictureBox1.Image.Width * mh);
                    pictureBox1.Height = pbh;
                }
                else
                {
                    pictureBox1.Width = pbw;
                    pictureBox1.Height = Convert.ToInt16(pictureBox1.Image.Height * mw);
                }
            }

            pictureBox1.Left = pbX + (pbw - pictureBox1.Width) / 2;
            pictureBox1.Top = pbY + (pbh - pictureBox1.Height) / 2;
            pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!button3.Enabled)
                button3.Enabled = true;

            if (nImg > 0)
            {
                nImg--;
                ShowPicture(aPath + "\\" + imgList[nImg]);

                if (nImg == 0)
                    button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!button2.Enabled)
                button2.Enabled = true;

            if (nImg < imgList.Count)
            {
                nImg++;
                ShowPicture(aPath + "\\" + imgList[nImg]);

                if (nImg == imgList.Count - 1)
                    button3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Выберите папку,\nв которой находятся иллюстрации";
            fb.ShowNewFolderButton = false;
            fb.SelectedPath = aPath;

            if (fb.ShowDialog() == DialogResult.OK)
            {
                aPath = fb.SelectedPath;

                if (!FillListBox(fb.SelectedPath))
                    pictureBox1.Image = null;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // Implement any desired functionality for the tooltip popup event here.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
