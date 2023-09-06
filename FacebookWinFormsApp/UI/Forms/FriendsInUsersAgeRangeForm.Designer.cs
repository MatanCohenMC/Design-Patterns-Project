namespace FacebookApp.UI.Forms
{
    partial class FriendsInUsersAgeRangeForm
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
            System.Windows.Forms.Label imageLargeLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label nameLabel;
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.loginResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFriendDetails = new System.Windows.Forms.Panel();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.localeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            birthdayLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginResultBindingSource)).BeginInit();
            this.panelFriendDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(44, 98);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(59, 16);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Location = new System.Drawing.Point(44, 151);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(86, 16);
            imageLargeLabel.TabIndex = 4;
            imageLargeLabel.Text = "Image Large:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Location = new System.Drawing.Point(44, 210);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(51, 16);
            localeLabel.TabIndex = 6;
            localeLabel.Text = "Locale:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(44, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchFriends.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchFriends.Location = new System.Drawing.Point(12, 11);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(318, 40);
            this.buttonFetchFriends.TabIndex = 9;
            this.buttonFetchFriends.Text = "Fetch friends in your age range";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriends.DataSource = this.loginResultBindingSource;
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 25;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 74);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(318, 329);
            this.listBoxFriends.TabIndex = 8;
            // 
            // loginResultBindingSource
            // 
            this.loginResultBindingSource.DataSource = typeof(FacebookWrapper.LoginResult);
            // 
            // panelFriendDetails
            // 
            this.panelFriendDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelFriendDetails.Controls.Add(birthdayLabel);
            this.panelFriendDetails.Controls.Add(this.birthdayTextBox);
            this.panelFriendDetails.Controls.Add(imageLargeLabel);
            this.panelFriendDetails.Controls.Add(this.imageLargePictureBox);
            this.panelFriendDetails.Controls.Add(localeLabel);
            this.panelFriendDetails.Controls.Add(this.localeTextBox);
            this.panelFriendDetails.Controls.Add(nameLabel);
            this.panelFriendDetails.Controls.Add(this.nameTextBox);
            this.panelFriendDetails.Location = new System.Drawing.Point(380, 74);
            this.panelFriendDetails.Name = "panelFriendDetails";
            this.panelFriendDetails.Size = new System.Drawing.Size(460, 328);
            this.panelFriendDetails.TabIndex = 15;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(136, 95);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 22);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.loginResultBindingSource, "LoggedInUser.ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(136, 151);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            // 
            // localeTextBox
            // 
            this.localeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Locale", true));
            this.localeTextBox.Location = new System.Drawing.Point(136, 207);
            this.localeTextBox.Name = "localeTextBox";
            this.localeTextBox.Size = new System.Drawing.Size(100, 22);
            this.localeTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(136, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // FriendsInUsersAgeRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelFriendDetails);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.listBoxFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FriendsInUsersAgeRangeForm";
            this.Text = "FriendsInUsersAgeRange";
            ((System.ComponentModel.ISupportInitialize)(this.loginResultBindingSource)).EndInit();
            this.panelFriendDetails.ResumeLayout(false);
            this.panelFriendDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.BindingSource loginResultBindingSource;
        private System.Windows.Forms.Panel panelFriendDetails;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox localeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}