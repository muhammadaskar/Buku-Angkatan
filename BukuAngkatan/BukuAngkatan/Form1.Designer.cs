﻿namespace BukuAngkatan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daftarIsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuAngkatanFILKOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarIsiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daftarIsiToolStripMenuItem
            // 
            this.daftarIsiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukuAngkatanFILKOMToolStripMenuItem});
            this.daftarIsiToolStripMenuItem.Name = "daftarIsiToolStripMenuItem";
            this.daftarIsiToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.daftarIsiToolStripMenuItem.Text = "Daftar Isi";
            // 
            // bukuAngkatanFILKOMToolStripMenuItem
            // 
            this.bukuAngkatanFILKOMToolStripMenuItem.Name = "bukuAngkatanFILKOMToolStripMenuItem";
            this.bukuAngkatanFILKOMToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.bukuAngkatanFILKOMToolStripMenuItem.Text = "Buku Angkatan FILKOM";
            this.bukuAngkatanFILKOMToolStripMenuItem.Click += new System.EventHandler(this.bukuAngkatanFILKOMToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 507);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Buku Angkatan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daftarIsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuAngkatanFILKOMToolStripMenuItem;
    }
}

