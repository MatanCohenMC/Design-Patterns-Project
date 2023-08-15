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
            this.labelEnterLocation = new System.Windows.Forms.Label();
            this.listBoxEventsByLocation = new System.Windows.Forms.ListBox();
            this.labelEvents = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.Pagelabel = new System.Windows.Forms.Label();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.descriptionLable = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.buttonFetchEventByLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterLocation
            // 
            this.labelEnterLocation.AutoSize = true;
            this.labelEnterLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEnterLocation.Location = new System.Drawing.Point(29, 127);
            this.labelEnterLocation.Name = "labelEnterLocation";
            this.labelEnterLocation.Size = new System.Drawing.Size(136, 25);
            this.labelEnterLocation.TabIndex = 1;
            this.labelEnterLocation.Text = "Enter location:";
            this.labelEnterLocation.Click += new System.EventHandler(this.labelEnterLocation_Click);
            // 
            // listBoxEventsByLocation
            // 
            this.listBoxEventsByLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEventsByLocation.FormattingEnabled = true;
            this.listBoxEventsByLocation.ItemHeight = 25;
            this.listBoxEventsByLocation.Location = new System.Drawing.Point(468, 58);
            this.listBoxEventsByLocation.Name = "listBoxEventsByLocation";
            this.listBoxEventsByLocation.Size = new System.Drawing.Size(259, 179);
            this.listBoxEventsByLocation.TabIndex = 2;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEvents.Location = new System.Drawing.Point(384, 61);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(78, 25);
            this.labelEvents.TabIndex = 3;
            this.labelEvents.Text = "Events:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.Location = new System.Drawing.Point(468, 260);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(259, 38);
            this.textBoxDate.TabIndex = 25;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDate.Location = new System.Drawing.Point(403, 260);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 25);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "Date:";
            // 
            // Pagelabel
            // 
            this.Pagelabel.AutoSize = true;
            this.Pagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pagelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Pagelabel.Location = new System.Drawing.Point(824, 61);
            this.Pagelabel.Name = "Pagelabel";
            this.Pagelabel.Size = new System.Drawing.Size(118, 25);
            this.Pagelabel.TabIndex = 27;
            this.Pagelabel.Text = "Event Photo";
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEvent.Location = new System.Drawing.Point(777, 97);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(220, 210);
            this.pictureBoxEvent.TabIndex = 26;
            this.pictureBoxEvent.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(468, 326);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(259, 57);
            this.textBoxDescription.TabIndex = 29;
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLable.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionLable.Location = new System.Drawing.Point(347, 328);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(115, 25);
            this.descriptionLable.TabIndex = 28;
            this.descriptionLable.Text = "Description:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(171, 124);
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
            this.buttonFetchEventByLocation.Location = new System.Drawing.Point(198, 53);
            this.buttonFetchEventByLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchEventByLocation.Name = "buttonFetchEventByLocation";
            this.buttonFetchEventByLocation.Size = new System.Drawing.Size(135, 40);
            this.buttonFetchEventByLocation.TabIndex = 31;
            this.buttonFetchEventByLocation.Text = "Fetch Events";
            this.buttonFetchEventByLocation.UseVisualStyleBackColor = true;
            this.buttonFetchEventByLocation.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // EventsByLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1045, 414);
            this.Controls.Add(this.buttonFetchEventByLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.descriptionLable);
            this.Controls.Add(this.Pagelabel);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxEventsByLocation);
            this.Controls.Add(this.labelEnterLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventsByLocationForm";
            this.Text = "EventByLocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEnterLocation;
        private System.Windows.Forms.ListBox listBoxEventsByLocation;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label Pagelabel;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label descriptionLable;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Button buttonFetchEventByLocation;
    }
}