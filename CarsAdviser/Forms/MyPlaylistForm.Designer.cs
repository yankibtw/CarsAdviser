﻿namespace CarsAdviser.Forms
{
    partial class MyPlaylistForm
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
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PlaylistPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.PlaylistPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1904, 1041);
            this.mainPanel.TabIndex = 0;
            // 
            // PlaylistPanel
            // 
            this.PlaylistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaylistPanel.Location = new System.Drawing.Point(0, 0);
            this.PlaylistPanel.Name = "PlaylistPanel";
            this.PlaylistPanel.Padding = new System.Windows.Forms.Padding(50, 39, 0, 0);
            this.PlaylistPanel.Size = new System.Drawing.Size(1904, 1041);
            this.PlaylistPanel.TabIndex = 62;
            // 
            // MyPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.mainPanel);
            this.Name = "MyPlaylistForm";
            this.Text = "MyPlaylistForm";
            this.Load += new System.EventHandler(this.UserPlaylistForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel PlaylistPanel;
    }
}