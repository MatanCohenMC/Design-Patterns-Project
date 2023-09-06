namespace FacebookApp.UI.Forms
{
    partial class PostsByDateRangeForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label pictureURLLabel;
            System.Windows.Forms.Label nameLabel;
            this.labelEnterMonths = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFetchPostsByDate = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.panelPostDetails = new System.Windows.Forms.Panel();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.pictureURLTextBox = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            pictureURLLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            this.panelPostDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterMonths
            // 
            this.labelEnterMonths.AutoSize = true;
            this.labelEnterMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterMonths.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEnterMonths.Location = new System.Drawing.Point(9, 19);
            this.labelEnterMonths.Name = "labelEnterMonths";
            this.labelEnterMonths.Size = new System.Drawing.Size(133, 25);
            this.labelEnterMonths.TabIndex = 0;
            this.labelEnterMonths.Text = "Enter months:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFrom.Location = new System.Drawing.Point(148, 19);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(57, 25);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTo.Location = new System.Drawing.Point(428, 21);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(36, 25);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 25;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 74);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(529, 329);
            this.listBoxPosts.TabIndex = 5;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPosts.Location = new System.Drawing.Point(1072, 132);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(252, 250);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPosts.TabIndex = 71;
            this.pictureBoxPosts.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1140, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Post picture";
            // 
            // buttonFetchPostsByDate
            // 
            this.buttonFetchPostsByDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchPostsByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchPostsByDate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchPostsByDate.Location = new System.Drawing.Point(676, 11);
            this.buttonFetchPostsByDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchPostsByDate.Name = "buttonFetchPostsByDate";
            this.buttonFetchPostsByDate.Size = new System.Drawing.Size(135, 40);
            this.buttonFetchPostsByDate.TabIndex = 77;
            this.buttonFetchPostsByDate.Text = "Fetch Posts";
            this.buttonFetchPostsByDate.UseVisualStyleBackColor = true;
            this.buttonFetchPostsByDate.Click += new System.EventHandler(this.buttonFetchPostsByDate_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(211, 21);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 78;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(470, 22);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 79;
            // 
            // panelPostDetails
            // 
            this.panelPostDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelPostDetails.Controls.Add(nameLabel);
            this.panelPostDetails.Controls.Add(this.textBoxLocation);
            this.panelPostDetails.Controls.Add(createdTimeLabel);
            this.panelPostDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelPostDetails.Controls.Add(messageLabel);
            this.panelPostDetails.Controls.Add(this.messageTextBox);
            this.panelPostDetails.Controls.Add(pictureURLLabel);
            this.panelPostDetails.Controls.Add(this.pictureURLTextBox);
            this.panelPostDetails.Location = new System.Drawing.Point(561, 74);
            this.panelPostDetails.Name = "panelPostDetails";
            this.panelPostDetails.Size = new System.Drawing.Size(565, 332);
            this.panelPostDetails.TabIndex = 80;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(59, 76);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(92, 16);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(157, 72);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(59, 103);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(67, 16);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(157, 100);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(200, 22);
            this.messageTextBox.TabIndex = 3;
            // 
            // pictureURLLabel
            // 
            pictureURLLabel.AutoSize = true;
            pictureURLLabel.Location = new System.Drawing.Point(59, 131);
            pictureURLLabel.Name = "pictureURLLabel";
            pictureURLLabel.Size = new System.Drawing.Size(81, 16);
            pictureURLLabel.TabIndex = 4;
            pictureURLLabel.Text = "Picture URL:";
            // 
            // pictureURLTextBox
            // 
            this.pictureURLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "PictureURL", true));
            this.pictureURLTextBox.Location = new System.Drawing.Point(157, 128);
            this.pictureURLTextBox.Name = "pictureURLTextBox";
            this.pictureURLTextBox.Size = new System.Drawing.Size(200, 22);
            this.pictureURLTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(90, 170);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 16);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Location:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Place.Name", true));
            this.textBoxLocation.Location = new System.Drawing.Point(157, 167);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocation.TabIndex = 7;
            // 
            // PostsByDateRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelPostDetails);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.buttonFetchPostsByDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelEnterMonths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostsByDateRangeForm";
            this.Text = "PicturesByDateRange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            this.panelPostDetails.ResumeLayout(false);
            this.panelPostDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterMonths;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFetchPostsByDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Panel panelPostDetails;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox pictureURLTextBox;
    }
}