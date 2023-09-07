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
            this.labelLoading = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
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
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.ForeColor = System.Drawing.SystemColors.Control;
            birthdayLabel.Location = new System.Drawing.Point(17, 109);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(89, 25);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localeLabel.ForeColor = System.Drawing.SystemColors.Control;
            localeLabel.Location = new System.Drawing.Point(30, 176);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(76, 25);
            localeLabel.TabIndex = 6;
            localeLabel.Text = "Locale:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(36, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(70, 25);
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
            this.listBoxFriends.Size = new System.Drawing.Size(465, 329);
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
            this.panelFriendDetails.Controls.Add(this.imageLargePictureBox);
            this.panelFriendDetails.Controls.Add(localeLabel);
            this.panelFriendDetails.Controls.Add(this.localeTextBox);
            this.panelFriendDetails.Controls.Add(nameLabel);
            this.panelFriendDetails.Controls.Add(this.nameTextBox);
            this.panelFriendDetails.Location = new System.Drawing.Point(507, 74);
            this.panelFriendDetails.Name = "panelFriendDetails";
            this.panelFriendDetails.Size = new System.Drawing.Size(900, 329);
            this.panelFriendDetails.TabIndex = 15;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Birthday", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No birthday]"));
            this.birthdayTextBox.Location = new System.Drawing.Point(112, 109);
            this.birthdayTextBox.Multiline = true;
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(380, 40);
            this.birthdayTextBox.TabIndex = 1;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.loginResultBindingSource, "LoggedInUser.ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(630, 43);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(250, 250);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            this.imageLargePictureBox.Click += new System.EventHandler(this.imageLargePictureBox_Click);
            // 
            // localeTextBox
            // 
            this.localeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Locale", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No locale]"));
            this.localeTextBox.Location = new System.Drawing.Point(112, 176);
            this.localeTextBox.Multiline = true;
            this.localeTextBox.Name = "localeTextBox";
            this.localeTextBox.Size = new System.Drawing.Size(100, 31);
            this.localeTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginResultBindingSource, "LoggedInUser.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No name]"));
            this.nameTextBox.Location = new System.Drawing.Point(112, 43);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(380, 50);
            this.nameTextBox.TabIndex = 9;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.White;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(20, 80);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(97, 25);
            this.labelLoading.TabIndex = 64;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // FriendsInUsersAgeRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
            this.Controls.Add(this.labelLoading);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label labelLoading;
    }
}