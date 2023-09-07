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
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.ForeColor = System.Drawing.SystemColors.Control;
            birthdayLabel.Location = new System.Drawing.Point(259, 189);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(89, 25);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            birthdayLabel.Click += new System.EventHandler(this.birthdayLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            emailLabel.Location = new System.Drawing.Point(282, 140);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(66, 25);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localeLabel.ForeColor = System.Drawing.SystemColors.Control;
            localeLabel.Location = new System.Drawing.Point(272, 235);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(76, 25);
            localeLabel.TabIndex = 6;
            localeLabel.Text = "Locale:";
            localeLabel.Click += new System.EventHandler(this.localeLabel_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(278, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(70, 25);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // panelUserDetails
            // 
            this.panelUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelUserDetails.Controls.Add(birthdayLabel);
            this.panelUserDetails.Controls.Add(this.birthdayTextBox);
            this.panelUserDetails.Controls.Add(emailLabel);
            this.panelUserDetails.Controls.Add(this.emailTextBox);
            this.panelUserDetails.Controls.Add(this.imageLargePictureBox);
            this.panelUserDetails.Controls.Add(localeLabel);
            this.panelUserDetails.Controls.Add(this.localeTextBox);
            this.panelUserDetails.Controls.Add(nameLabel);
            this.panelUserDetails.Controls.Add(this.nameTextBox);
            this.panelUserDetails.Location = new System.Drawing.Point(12, 22);
            this.panelUserDetails.Name = "panelUserDetails";
            this.panelUserDetails.Size = new System.Drawing.Size(1429, 380);
            this.panelUserDetails.TabIndex = 4;
            this.panelUserDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserDetails_Paint);
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Birthday", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No birthday]"));
            this.birthdayTextBox.Location = new System.Drawing.Point(354, 189);
            this.birthdayTextBox.Multiline = true;
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(210, 34);
            this.birthdayTextBox.TabIndex = 1;
            this.birthdayTextBox.TextChanged += new System.EventHandler(this.birthdayTextBox_TextChanged);
            // 
            // loginResultBindingSource
            // 
            this.loginResultBindingSource.DataSource = typeof(FacebookWrapper.LoginResult);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Email", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No email]"));
            this.emailTextBox.Location = new System.Drawing.Point(354, 140);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(352, 34);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.loginResultBindingSource, "LoggedInUser.ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(754, 63);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(250, 250);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            this.imageLargePictureBox.Click += new System.EventHandler(this.imageLargePictureBox_Click);
            // 
            // localeTextBox
            // 
            this.localeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Locale", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No locale]"));
            this.localeTextBox.Location = new System.Drawing.Point(354, 238);
            this.localeTextBox.Multiline = true;
            this.localeTextBox.Name = "localeTextBox";
            this.localeTextBox.Size = new System.Drawing.Size(210, 32);
            this.localeTextBox.TabIndex = 7;
            this.localeTextBox.TextChanged += new System.EventHandler(this.localeTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No name]"));
            this.nameTextBox.Location = new System.Drawing.Point(354, 91);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(352, 33);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
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