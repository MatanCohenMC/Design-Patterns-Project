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
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.labelEnterLocation = new System.Windows.Forms.Label();
            this.listBoxEventsByLocation = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonFetchEventByLocation = new System.Windows.Forms.Button();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelLoading = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            descriptionLabel.Location = new System.Drawing.Point(36, 43);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(115, 25);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            endTimeLabel.Location = new System.Drawing.Point(49, 206);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(102, 25);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.SystemColors.Control;
            locationLabel.Location = new System.Drawing.Point(59, 109);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(92, 25);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            startTimeLabel.Location = new System.Drawing.Point(43, 170);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(108, 25);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
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
            this.listBoxEventsByLocation.Location = new System.Drawing.Point(12, 73);
            this.listBoxEventsByLocation.Name = "listBoxEventsByLocation";
            this.listBoxEventsByLocation.Size = new System.Drawing.Size(465, 329);
            this.listBoxEventsByLocation.TabIndex = 2;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
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
            this.panelEventDetails.Controls.Add(this.imageLargePictureBox);
            this.panelEventDetails.Controls.Add(locationLabel);
            this.panelEventDetails.Controls.Add(this.locationTextBox);
            this.panelEventDetails.Controls.Add(startTimeLabel);
            this.panelEventDetails.Controls.Add(this.startTimeDateTimePicker);
            this.panelEventDetails.Location = new System.Drawing.Point(507, 74);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(900, 328);
            this.panelEventDetails.TabIndex = 32;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No description]"));
            this.descriptionTextBox.Location = new System.Drawing.Point(157, 43);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(380, 50);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No end time]"));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(157, 209);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(624, 43);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(250, 250);
            this.imageLargePictureBox.TabIndex = 5;
            this.imageLargePictureBox.TabStop = false;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No location]"));
            this.locationTextBox.Location = new System.Drawing.Point(157, 109);
            this.locationTextBox.Multiline = true;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(380, 50);
            this.locationTextBox.TabIndex = 9;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No start time]"));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(157, 172);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startTimeDateTimePicker.TabIndex = 11;
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
            // EventsByLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panelEventDetails);
            this.Controls.Add(this.buttonFetchEventByLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.listBoxEventsByLocation);
            this.Controls.Add(this.labelEnterLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventsByLocationForm";
            this.Text = "EventByLocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEnterLocation;
        private System.Windows.Forms.ListBox listBoxEventsByLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonFetchEventByLocation;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Panel panelEventDetails;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.Label labelLoading;
    }
}