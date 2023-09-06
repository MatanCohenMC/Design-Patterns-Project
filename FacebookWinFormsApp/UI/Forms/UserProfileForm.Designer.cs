namespace FacebookApp.UI.Forms
{
    partial class UserProfileForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label imageLargeLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label nameLabel;
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.loginResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.localeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panelUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(73, 109);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(59, 16);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(73, 82);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Location = new System.Drawing.Point(368, 66);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(86, 16);
            imageLargeLabel.TabIndex = 4;
            imageLargeLabel.Text = "Image Large:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Location = new System.Drawing.Point(73, 137);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(51, 16);
            localeLabel.TabIndex = 6;
            localeLabel.Text = "Locale:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(73, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // panelUserDetails
            // 
            this.panelUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUserDetails.Controls.Add(birthdayLabel);
            this.panelUserDetails.Controls.Add(this.birthdayTextBox);
            this.panelUserDetails.Controls.Add(emailLabel);
            this.panelUserDetails.Controls.Add(this.emailTextBox);
            this.panelUserDetails.Controls.Add(imageLargeLabel);
            this.panelUserDetails.Controls.Add(this.imageLargePictureBox);
            this.panelUserDetails.Controls.Add(localeLabel);
            this.panelUserDetails.Controls.Add(this.localeTextBox);
            this.panelUserDetails.Controls.Add(nameLabel);
            this.panelUserDetails.Controls.Add(this.nameTextBox);
            this.panelUserDetails.Location = new System.Drawing.Point(12, 22);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(838, 380);
            this.panelUserDetails.TabIndex = 4;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(165, 106);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 22);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // loginResultBindingSource
            // 
            this.loginResultBindingSource.DataSource = typeof(FacebookWrapper.LoginResult);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(165, 79);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.loginResultBindingSource, "LoggedInUser.ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(460, 66);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(269, 264);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            // 
            // localeTextBox
            // 
            this.localeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Locale", true));
            this.localeTextBox.Location = new System.Drawing.Point(165, 134);
            this.localeTextBox.Name = "localeTextBox";
            this.localeTextBox.Size = new System.Drawing.Size(100, 22);
            this.localeTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(165, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1045, 414);
            this.Controls.Add(this.panelUserDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfileForm";
            this.Text = "UserProfileForm";
            this.Load += new System.EventHandler(this.userProfileForm_Load);
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUserDetails;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.BindingSource loginResultBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox localeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}