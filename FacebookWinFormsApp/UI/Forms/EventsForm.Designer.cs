namespace FacebookApp.UI.Forms
{
    partial class EventsForm
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchEvents.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchEvents.Location = new System.Drawing.Point(12, 11);
            this.buttonFetchEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(135, 40);
            this.buttonFetchEvents.TabIndex = 11;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 25;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 74);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(436, 329);
            this.listBoxEvents.TabIndex = 8;
            // 
            // panelEventDetails
            // 
            this.panelEventDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEventDetails.Controls.Add(descriptionLabel);
            this.panelEventDetails.Controls.Add(this.descriptionTextBox);
            this.panelEventDetails.Controls.Add(endTimeLabel);
            this.panelEventDetails.Controls.Add(this.endTimeDateTimePicker);
            this.panelEventDetails.Controls.Add(this.imageLargePictureBox);
            this.panelEventDetails.Controls.Add(linkToFacebookLabel);
            this.panelEventDetails.Controls.Add(this.linkToFacebookLinkLabel);
            this.panelEventDetails.Controls.Add(locationLabel);
            this.panelEventDetails.Controls.Add(this.locationTextBox);
            this.panelEventDetails.Controls.Add(startTimeLabel);
            this.panelEventDetails.Controls.Add(this.startTimeDateTimePicker);
            this.panelEventDetails.Location = new System.Drawing.Point(468, 74);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(865, 329);
            this.panelEventDetails.TabIndex = 24;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(39, 69);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(164, 66);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(39, 98);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(68, 16);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(164, 94);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(164, 122);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(200, 50);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Location = new System.Drawing.Point(39, 175);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(119, 16);
            linkToFacebookLabel.TabIndex = 6;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(164, 175);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(200, 23);
            this.linkToFacebookLinkLabel.TabIndex = 7;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "linkLabel1";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(39, 204);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(61, 16);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(164, 201);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 22);
            this.locationTextBox.TabIndex = 9;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(39, 233);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(71, 16);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(164, 229);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startTimeDateTimePicker.TabIndex = 11;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelEventDetails);
            this.Controls.Add(this.buttonFetchEvents);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Panel panelEventDetails;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.LinkLabel linkToFacebookLinkLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
    }
}