namespace r16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            parameterToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutProgramMenuItem = new ToolStripMenuItem();
            ParamToolStripMenuItem = new ToolStrip();
            FileCreateToolStripMenuItem = new ToolStripButton();
            FileOpenToolStripMenuItem = new ToolStripButton();
            FileSaveToolStripMenuItem = new ToolStripButton();
            FileExitToolStripMenuItem = new ToolStripButton();
            PFontToolStripMenuItem = new ToolStripButton();
            PrintMenuItem = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            printDialog1 = new PrintDialog();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            ParamToolStripMenuItem.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, parameterToolStripMenuItem, helpToolStripMenuItem, AboutProgramMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += FileExitToolStripMenuItem_Click;
            // 
            // parameterToolStripMenuItem
            // 
            parameterToolStripMenuItem.Name = "parameterToolStripMenuItem";
            parameterToolStripMenuItem.Size = new Size(90, 24);
            parameterToolStripMenuItem.Text = "Parameter";
            parameterToolStripMenuItem.Click += ParamToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AboutProgramMenuItem
            // 
            AboutProgramMenuItem.Name = "AboutProgramMenuItem";
            AboutProgramMenuItem.Size = new Size(125, 24);
            AboutProgramMenuItem.Text = "About Program";
            AboutProgramMenuItem.Click += AboutProgramMenuItem_Click;
            // 
            // ParamToolStripMenuItem
            // 
            ParamToolStripMenuItem.ImageScalingSize = new Size(20, 20);
            ParamToolStripMenuItem.Items.AddRange(new ToolStripItem[] { FileCreateToolStripMenuItem, FileOpenToolStripMenuItem, FileSaveToolStripMenuItem, FileExitToolStripMenuItem, PFontToolStripMenuItem, PrintMenuItem });
            ParamToolStripMenuItem.Location = new Point(0, 28);
            ParamToolStripMenuItem.Name = "ParamToolStripMenuItem";
            ParamToolStripMenuItem.Size = new Size(800, 27);
            ParamToolStripMenuItem.TabIndex = 1;
            ParamToolStripMenuItem.Text = "toolStrip1";
            // 
            // FileCreateToolStripMenuItem
            // 
            FileCreateToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FileCreateToolStripMenuItem.Image = (Image)resources.GetObject("FileCreateToolStripMenuItem.Image");
            FileCreateToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            FileCreateToolStripMenuItem.Name = "FileCreateToolStripMenuItem";
            FileCreateToolStripMenuItem.Size = new Size(29, 24);
            FileCreateToolStripMenuItem.Text = "Create";
            FileCreateToolStripMenuItem.Click += FileCreateToolStripMenuItem_Click;
            // 
            // FileOpenToolStripMenuItem
            // 
            FileOpenToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FileOpenToolStripMenuItem.Image = (Image)resources.GetObject("FileOpenToolStripMenuItem.Image");
            FileOpenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            FileOpenToolStripMenuItem.Name = "FileOpenToolStripMenuItem";
            FileOpenToolStripMenuItem.Size = new Size(29, 24);
            FileOpenToolStripMenuItem.Text = "Open";
            FileOpenToolStripMenuItem.Click += FileOpenToolStripMenuItem_Click;
            // 
            // FileSaveToolStripMenuItem
            // 
            FileSaveToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FileSaveToolStripMenuItem.Image = (Image)resources.GetObject("FileSaveToolStripMenuItem.Image");
            FileSaveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            FileSaveToolStripMenuItem.Name = "FileSaveToolStripMenuItem";
            FileSaveToolStripMenuItem.Size = new Size(29, 24);
            FileSaveToolStripMenuItem.Text = "Save";
            FileSaveToolStripMenuItem.Click += FileSaveToolStripMenuItem_Click;
            // 
            // FileExitToolStripMenuItem
            // 
            FileExitToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FileExitToolStripMenuItem.Image = (Image)resources.GetObject("FileExitToolStripMenuItem.Image");
            FileExitToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            FileExitToolStripMenuItem.Name = "FileExitToolStripMenuItem";
            FileExitToolStripMenuItem.Size = new Size(29, 24);
            FileExitToolStripMenuItem.Text = "Exit";
            FileExitToolStripMenuItem.Click += FileExitToolStripMenuItem_Click;
            // 
            // PFontToolStripMenuItem
            // 
            PFontToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PFontToolStripMenuItem.Image = (Image)resources.GetObject("PFontToolStripMenuItem.Image");
            PFontToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            PFontToolStripMenuItem.Name = "PFontToolStripMenuItem";
            PFontToolStripMenuItem.Size = new Size(29, 24);
            PFontToolStripMenuItem.Text = "Paramfont";
            PFontToolStripMenuItem.Click += ParamFontToolStripMenuItem_Click;
            // 
            // PrintMenuItem
            // 
            PrintMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PrintMenuItem.Image = (Image)resources.GetObject("PrintMenuItem.Image");
            PrintMenuItem.ImageTransparentColor = Color.Magenta;
            PrintMenuItem.Name = "PrintMenuItem";
            PrintMenuItem.Size = new Size(29, 24);
            PrintMenuItem.Text = "Print";
            PrintMenuItem.Click += PrintMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(ParamToolStripMenuItem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ParamToolStripMenuItem.ResumeLayout(false);
            ParamToolStripMenuItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip ParamToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private PrintDialog printDialog1;
        private TextBox textBox1;
        private ToolStripButton FileCreateToolStripMenuItem;
        private ToolStripButton FileOpenToolStripMenuItem;
        private ToolStripButton FileSaveToolStripMenuItem;
        private ToolStripButton file;
        private ToolStripButton PFontToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem parameterToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripButton PrintMenuItem;
        private ToolStripMenuItem AboutProgramMenuItem;
        private ToolStripButton FileExitToolStripMenuItem;
    }
}
