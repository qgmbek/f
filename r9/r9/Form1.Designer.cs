namespace r9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(390, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 257);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // button1
            // 
            button1.Location = new Point(54, 328);
            button1.Name = "button1";
            button1.Size = new Size(143, 46);
            button1.TabIndex = 1;
            button1.Text = "Select a folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._3791389;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(390, 328);
            button2.Name = "button2";
            button2.Size = new Size(109, 46);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources._3791389223;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Image = Properties.Resources._3791389223;
            button3.Location = new Point(645, 328);
            button3.Name = "button3";
            button3.Size = new Size(105, 46);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
