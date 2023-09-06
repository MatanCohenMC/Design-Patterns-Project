namespace FacebookApp.UI.Forms
{
    partial class RandomMemoryForm
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
            System.Windows.Forms.Label labelLocation;
            this.buttonFetchMemory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxMemory = new System.Windows.Forms.PictureBox();
            this.panelMemoryDetails = new System.Windows.Forms.Panel();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.pictureURLTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            pictureURLLabel = new System.Windows.Forms.Label();
            labelLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemory)).BeginInit();
            this.panelMemoryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchMemory
            // 
            this.buttonFetchMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchMemory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchMemory.Location = new System.Drawing.Point(12, 12);
            this.buttonFetchMemory.Name = "buttonFetchMemory";
            this.buttonFetchMemory.Size = new System.Drawing.Size(156, 63);
            this.buttonFetchMemory.TabIndex = 0;
            this.buttonFetchMemory.Text = "Fetch Random Memory";
            this.buttonFetchMemory.UseVisualStyleBackColor = true;
            this.buttonFetchMemory.Click += new System.EventHandler(this.buttonFetchMemory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1034, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 79;
            this.label4.Text = "Post picture";
            // 
            // pictureBoxMemory
            // 
            this.pictureBoxMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMemory.Location = new System.Drawing.Point(969, 108);
            this.pictureBoxMemory.Name = "pictureBoxMemory";
            this.pictureBoxMemory.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxMemory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMemory.TabIndex = 78;
            this.pictureBoxMemory.TabStop = false;
            // 
            // panelMemoryDetails
            // 
            this.panelMemoryDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMemoryDetails.Controls.Add(labelLocation);
            this.panelMemoryDetails.Controls.Add(this.nameTextBox);
            this.panelMemoryDetails.Controls.Add(createdTimeLabel);
            this.panelMemoryDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelMemoryDetails.Controls.Add(messageLabel);
            this.panelMemoryDetails.Controls.Add(this.messageTextBox);
            this.panelMemoryDetails.Controls.Add(pictureURLLabel);
            this.panelMemoryDetails.Controls.Add(this.pictureURLTextBox);
            this.panelMemoryDetails.Location = new System.Drawing.Point(12, 98);
            this.panelMemoryDetails.Name = "panelMemoryDetails";
            this.panelMemoryDetails.Size = new System.Drawing.Size(660, 304);
            this.panelMemoryDetails.TabIndex = 80;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(9, 60);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(92, 16);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(107, 56);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(9, 87);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(67, 16);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(107, 84);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(200, 22);
            this.messageTextBox.TabIndex = 3;
            // 
            // pictureURLLabel
            // 
            pictureURLLabel.AutoSize = true;
            pictureURLLabel.Location = new System.Drawing.Point(9, 115);
            pictureURLLabel.Name = "pictureURLLabel";
            pictureURLLabel.Size = new System.Drawing.Size(81, 16);
            pictureURLLabel.TabIndex = 4;
            pictureURLLabel.Text = "Picture URL:";
            // 
            // pictureURLTextBox
            // 
            this.pictureURLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "PictureURL", true));
            this.pictureURLTextBox.Location = new System.Drawing.Point(107, 112);
            this.pictureURLTextBox.Name = "pictureURLTextBox";
            this.pictureURLTextBox.Size = new System.Drawing.Size(200, 22);
            this.pictureURLTextBox.TabIndex = 5;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new System.Drawing.Point(29, 156);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new System.Drawing.Size(61, 16);
            labelLocation.TabIndex = 6;
            labelLocation.Text = "Location:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Place.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(107, 150);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // RandomMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelMemoryDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxMemory);
            this.Controls.Add(this.buttonFetchMemory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomMemoryForm";
            this.Text = "RandomMemoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemory)).EndInit();
            this.panelMemoryDetails.ResumeLayout(false);
            this.panelMemoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchMemory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxMemory;
        private System.Windows.Forms.Panel panelMemoryDetails;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox pictureURLTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}