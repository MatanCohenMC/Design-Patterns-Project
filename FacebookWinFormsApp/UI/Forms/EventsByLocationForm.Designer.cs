namespace FacebookApp.UI.Forms
{
    partial class EventsByLocationForm
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
            System.Windows.Forms.Label imageLargeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.labelEnterLocation = new System.Windows.Forms.Label();
            this.listBoxEventsByLocation = new System.Windows.Forms.ListBox();
            this.labelEvents = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonFetchEventByLocation = new System.Windows.Forms.Button();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterLocation
            // 
            this.labelEnterLocation.AutoSize = true;
            this.labelEnterLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEnterLocation.Location = new System.Drawing.Point(17, 19);
            this.labelEnterLocation.Name = "labelEnterLocation";
            this.labelEnterLocation.Size = new System.Drawing.Size(136, 25);
            this.labelEnterLocation.TabIndex = 1;
            this.labelEnterLocation.Text = "Enter location:";
            // 
            // listBoxEventsByLocation
            // 
            this.listBoxEventsByLocation.DataSource = this.eventBindingSource;
            this.listBoxEventsByLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEventsByLocation.FormattingEnabled = true;
            this.listBoxEventsByLocation.ItemHeight = 25;
            this.listBoxEventsByLocation.Location = new System.Drawing.Point(93, 81);
            this.listBoxEventsByLocation.Name = "listBoxEventsByLocation";
            this.listBoxEventsByLocation.Size = new System.Drawing.Size(379, 304);
            this.listBoxEventsByLocation.TabIndex = 2;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEvents.Location = new System.Drawing.Point(9, 84);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(78, 25);
            this.labelEvents.TabIndex = 3;
            this.labelEvents.Text = "Events:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(159, 16);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(162, 38);
            this.textBoxLocation.TabIndex = 30;
            // 
            // buttonFetchEventByLocation
            // 
            this.buttonFetchEventByLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchEventByLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchEventByLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchEventByLocation.Location = new System.Drawing.Point(337, 16);
            this.buttonFetchEventByLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchEventByLocation.Name = "buttonFetchEventByLocation";
            this.buttonFetchEventByLocation.Size = new System.Drawing.Size(135, 40);
            this.buttonFetchEventByLocation.TabIndex = 31;
            this.buttonFetchEventByLocation.Text = "Fetch Events";
            this.buttonFetchEventByLocation.UseVisualStyleBackColor = true;
            this.buttonFetchEventByLocation.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // panelEventDetails
            // 
            this.panelEventDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelEventDetails.Controls.Add(descriptionLabel);
            this.panelEventDetails.Controls.Add(this.descriptionTextBox);
            this.panelEventDetails.Controls.Add(endTimeLabel);
            this.panelEventDetails.Controls.Add(this.endTimeDateTimePicker);
            this.panelEventDetails.Controls.Add(imageLargeLabel);
            this.panelEventDetails.Controls.Add(this.imageLargePictureBox);
            this.panelEventDetails.Controls.Add(locationLabel);
            this.panelEventDetails.Controls.Add(this.locationTextBox);
            this.panelEventDetails.Controls.Add(startTimeLabel);
            this.panelEventDetails.Controls.Add(this.startTimeDateTimePicker);
            this.panelEventDetails.Location = new System.Drawing.Point(498, 81);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(835, 321);
            this.panelEventDetails.TabIndex = 32;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(81, 57);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(206, 54);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(81, 183);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(68, 16);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(206, 179);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Location = new System.Drawing.Point(81, 110);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(86, 16);
            imageLargeLabel.TabIndex = 4;
            imageLargeLabel.Text = "Image Large:";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(206, 110);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(200, 50);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(81, 85);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(61, 16);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(206, 82);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 22);
            this.locationTextBox.TabIndex = 9;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(81, 221);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(71, 16);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(206, 217);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startTimeDateTimePicker.TabIndex = 11;
            // 
            // EventsByLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelEventDetails);
            this.Controls.Add(this.buttonFetchEventByLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxEventsByLocation);
            this.Controls.Add(this.labelEnterLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventsByLocationForm";
            this.Text = "EventByLocationForm";
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEnterLocation;
        private System.Windows.Forms.ListBox listBoxEventsByLocation;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonFetchEventByLocation;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panelEventDetails;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
    }
}