﻿namespace ENPDotNetCore.WinFormsApp
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            blogToolStripMenuItem = new ToolStripMenuItem();
            blogToolStripMenuItem1 = new ToolStripMenuItem();
            newBlogToolStripMenuItem1 = new ToolStripMenuItem();
            blogsToolStripMenuItem = new ToolStripMenuItem();
            newBlogToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { blogToolStripMenuItem, blogToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // blogToolStripMenuItem
            // 
            blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            blogToolStripMenuItem.Size = new Size(12, 20);
            // 
            // blogToolStripMenuItem1
            // 
            blogToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newBlogToolStripMenuItem1, blogsToolStripMenuItem });
            blogToolStripMenuItem1.Name = "blogToolStripMenuItem1";
            blogToolStripMenuItem1.Size = new Size(43, 20);
            blogToolStripMenuItem1.Text = "Blog";
            blogToolStripMenuItem1.Click += blogToolStripMenuItem1_Click;
            // 
            // newBlogToolStripMenuItem1
            // 
            newBlogToolStripMenuItem1.Name = "newBlogToolStripMenuItem1";
            newBlogToolStripMenuItem1.Size = new Size(180, 22);
            newBlogToolStripMenuItem1.Text = "New Blog";
            // 
            // blogsToolStripMenuItem
            // 
            blogsToolStripMenuItem.Name = "blogsToolStripMenuItem";
            blogsToolStripMenuItem.Size = new Size(180, 22);
            blogsToolStripMenuItem.Text = "Blogs";
            blogsToolStripMenuItem.Click += blogsToolStripMenuItem_Click;
            // 
            // newBlogToolStripMenuItem
            // 
            newBlogToolStripMenuItem.Name = "newBlogToolStripMenuItem";
            newBlogToolStripMenuItem.Size = new Size(180, 22);
            newBlogToolStripMenuItem.Text = "New Blog";
            newBlogToolStripMenuItem.Click += newBlogToolStripMenuItem_Click;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem blogToolStripMenuItem;
        private ToolStripMenuItem newBlogToolStripMenuItem;
        private ToolStripMenuItem blogToolStripMenuItem1;
        private ToolStripMenuItem newBlogToolStripMenuItem1;
        private ToolStripMenuItem blogsToolStripMenuItem;
    }
}