﻿namespace FacebookApp.UI.Forms
{
    partial class LoginBarForm
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
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.labelAppID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogout.ForeColor = System.Drawing.Color.White;
            this.ButtonLogout.Location = new System.Drawing.Point(2, 542);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(170, 40);
            this.ButtonLogout.TabIndex = 7;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(2, 183);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(170, 40);
            this.ButtonLogin.TabIndex = 6;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(154, 157);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfile.TabIndex = 5;
            this.pictureBoxUserProfile.TabStop = false;
            this.pictureBoxUserProfile.Click += new System.EventHandler(this.pictureBoxUserProfile_Click);
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppID.Location = new System.Drawing.Point(52, 232);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(120, 20);
            this.textBoxAppID.TabIndex = 55;
            this.textBoxAppID.Text = "2308383616014756";
            // 
            // labelAppID
            // 
            this.labelAppID.AutoSize = true;
            this.labelAppID.ForeColor = System.Drawing.Color.White;
            this.labelAppID.Location = new System.Drawing.Point(0, 234);
            this.labelAppID.Name = "labelAppID";
            this.labelAppID.Size = new System.Drawing.Size(51, 16);
            this.labelAppID.TabIndex = 56;
            this.labelAppID.Text = "App ID:";
            // 
            // LoginBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(175, 594);
            this.Controls.Add(this.labelAppID);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginBarForm";
            this.Text = "LoginBarFrom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Label labelAppID;
    }
}