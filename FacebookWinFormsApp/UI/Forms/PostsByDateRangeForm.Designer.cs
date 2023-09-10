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
            System.Windows.Forms.Label nameLabel;
            this.labelEnterMonths = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchPostsByDate = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.panelPostDetails = new System.Windows.Forms.Panel();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.labelLoading = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panelPostDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            createdTimeLabel.Location = new System.Drawing.Point(3, 181);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(137, 25);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.ForeColor = System.Drawing.SystemColors.Control;
            messageLabel.Location = new System.Drawing.Point(42, 43);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(99, 25);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(49, 114);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(92, 25);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Location:";
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
            this.listBoxPosts.Size = new System.Drawing.Size(465, 329);
            this.listBoxPosts.TabIndex = 5;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // buttonFetchPostsByDate
            // 
            this.buttonFetchPostsByDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchPostsByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchPostsByDate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchPostsByDate.Location = new System.Drawing.Point(687, 13);
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
            this.panelPostDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelPostDetails.Controls.Add(nameLabel);
            this.panelPostDetails.Controls.Add(this.textBoxLocation);
            this.panelPostDetails.Controls.Add(createdTimeLabel);
            this.panelPostDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelPostDetails.Controls.Add(messageLabel);
            this.panelPostDetails.Controls.Add(this.messageTextBox);
            this.panelPostDetails.Location = new System.Drawing.Point(507, 74);
            this.panelPostDetails.Name = "panelPostDetails";
            this.panelPostDetails.Size = new System.Drawing.Size(543, 329);
            this.panelPostDetails.TabIndex = 80;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Place.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No location]"));
            this.textBoxLocation.Location = new System.Drawing.Point(147, 114);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(380, 50);
            this.textBoxLocation.TabIndex = 7;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(147, 183);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No message]"));
            this.messageTextBox.Location = new System.Drawing.Point(147, 43);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(380, 50);
            this.messageTextBox.TabIndex = 3;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.White;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(20, 80);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(97, 25);
            this.labelLoading.TabIndex = 81;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // PostsByDateRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panelPostDetails);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.buttonFetchPostsByDate);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelEnterMonths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostsByDateRangeForm";
            this.Text = "PicturesByDateRange";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panelPostDetails.ResumeLayout(false);
            this.panelPostDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterMonths;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonFetchPostsByDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Panel panelPostDetails;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label labelLoading;
    }
}