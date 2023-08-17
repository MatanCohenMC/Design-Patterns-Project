namespace FacebookApp.UI.Forms
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
            this.PictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.labelAppID = new System.Windows.Forms.Label();
            this.buttonMyProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
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
            this.ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
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
            this.ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxUserProfile
            // 
            this.PictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxUserProfile.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxUserProfile.Name = "PictureBoxUserProfile";
            this.PictureBoxUserProfile.Size = new System.Drawing.Size(154, 157);
            this.PictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxUserProfile.TabIndex = 5;
            this.PictureBoxUserProfile.TabStop = false;
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
            // buttonMyProfile
            // 
            this.buttonMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyProfile.ForeColor = System.Drawing.Color.White;
            this.buttonMyProfile.Location = new System.Drawing.Point(3, 282);
            this.buttonMyProfile.Name = "buttonMyProfile";
            this.buttonMyProfile.Size = new System.Drawing.Size(170, 40);
            this.buttonMyProfile.TabIndex = 57;
            this.buttonMyProfile.Text = "My Profile";
            this.buttonMyProfile.UseVisualStyleBackColor = true;
            this.buttonMyProfile.Click += new System.EventHandler(this.buttonMyProfile_Click);
            // 
            // LoginBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(175, 594);
            this.Controls.Add(this.buttonMyProfile);
            this.Controls.Add(this.labelAppID);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.PictureBoxUserProfile);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginBarForm";
            this.Text = "LoginBarFrom";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.Label labelAppID;
        private System.Windows.Forms.Button buttonMyProfile;
    }
}