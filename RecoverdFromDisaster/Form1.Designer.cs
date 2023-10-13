using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            rerangeToolStripMenuItem = new ToolStripMenuItem();
            cheatToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(492, 397);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 181);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Number :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(232, 227);
            button2.Name = "button2";
            button2.Size = new Size(114, 29);
            button2.TabIndex = 3;
            button2.Text = "Check Number";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, aboutToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(604, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, rerangeToolStripMenuItem, cheatToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(147, 26);
            toolStripMenuItem1.Text = "Range";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // rerangeToolStripMenuItem
            // 
            rerangeToolStripMenuItem.Name = "rerangeToolStripMenuItem";
            rerangeToolStripMenuItem.Size = new Size(147, 26);
            rerangeToolStripMenuItem.Text = "Rerange";
            rerangeToolStripMenuItem.Click += rerangeToolStripMenuItem_Click;
            // 
            // cheatToolStripMenuItem
            // 
            cheatToolStripMenuItem.Name = "cheatToolStripMenuItem";
            cheatToolStripMenuItem.Size = new Size(147, 26);
            cheatToolStripMenuItem.Text = "Cheat!";
            cheatToolStripMenuItem.Click += cheatToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(51, 24);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 411);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(492, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(88, 27);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 61);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 12;
            label2.Text = "Your Range ";
            // 
            // button3
            // 
            button3.Location = new Point(466, 257);
            button3.Name = "button3";
            button3.Size = new Size(114, 29);
            button3.TabIndex = 13;
            button3.Text = "debug button";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 450);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "StickyNumber";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        public Label label1;
        public TextBox textBox1;
        public Button button2;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem optionsToolStripMenuItem;
        public ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem cheatToolStripMenuItem;
        private ToolStripMenuItem rerangeToolStripMenuItem;
        private TextBox textBox2;
        private ToolStripMenuItem quitToolStripMenuItem;
        private TextBox textBox3;
        private Label label2;
        private Button button3;
    }
}