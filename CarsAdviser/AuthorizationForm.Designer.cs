﻿
namespace CarsAdviser
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.appLogoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.enLangBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ruLangBtn = new Guna.UI2.WinForms.Guna2Button();
            this.chooseLangLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appLogoPictureBox
            // 
            this.appLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.appLogoPictureBox.Image = global::CarsAdviser.Properties.Resources.logo;
            this.appLogoPictureBox.ImageRotate = 0F;
            resources.ApplyResources(this.appLogoPictureBox, "appLogoPictureBox");
            this.appLogoPictureBox.Name = "appLogoPictureBox";
            this.appLogoPictureBox.TabStop = false;
            // 
            // enLangBtn
            // 
            this.enLangBtn.Animated = true;
            this.enLangBtn.BorderRadius = 3;
            this.enLangBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.enLangBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.enLangBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enLangBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.enLangBtn.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.enLangBtn, "enLangBtn");
            this.enLangBtn.ForeColor = System.Drawing.Color.White;
            this.enLangBtn.Image = global::CarsAdviser.Properties.Resources.united_states_flag;
            this.enLangBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.enLangBtn.Name = "enLangBtn";
            this.enLangBtn.Click += new System.EventHandler(this.enLangBtn_Click);
            // 
            // ruLangBtn
            // 
            this.ruLangBtn.Animated = true;
            this.ruLangBtn.BorderRadius = 3;
            this.ruLangBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ruLangBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ruLangBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ruLangBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ruLangBtn.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ruLangBtn, "ruLangBtn");
            this.ruLangBtn.ForeColor = System.Drawing.Color.White;
            this.ruLangBtn.Image = global::CarsAdviser.Properties.Resources.russia_flag;
            this.ruLangBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.ruLangBtn.Name = "ruLangBtn";
            this.ruLangBtn.Click += new System.EventHandler(this.ruLangBtn_Click);
            // 
            // chooseLangLabel
            // 
            this.chooseLangLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chooseLangLabel, "chooseLangLabel");
            this.chooseLangLabel.Name = "chooseLangLabel";
            // 
            // appNameLabel
            // 
            this.appNameLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.appNameLabel, "appNameLabel");
            this.appNameLabel.Name = "appNameLabel";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ruLangBtn);
            this.guna2Panel1.Controls.Add(this.enLangBtn);
            this.guna2Panel1.Controls.Add(this.appNameLabel);
            this.guna2Panel1.Controls.Add(this.appLogoPictureBox);
            this.guna2Panel1.Controls.Add(this.chooseLangLabel);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            // 
            // AuthorizationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.mainPanel);
            this.Name = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox appLogoPictureBox;
        private System.Windows.Forms.Label appNameLabel;
        private Guna.UI2.WinForms.Guna2Button ruLangBtn;
        private System.Windows.Forms.Label chooseLangLabel;
        private Guna.UI2.WinForms.Guna2Button enLangBtn;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}