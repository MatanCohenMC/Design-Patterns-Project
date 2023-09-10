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
            System.Windows.Forms.Label labelLocation;
            this.buttonFetchMemory = new System.Windows.Forms.Button();
            this.panelMemoryDetails = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            labelLocation = new System.Windows.Forms.Label();
            this.panelMemoryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            createdTimeLabel.Location = new System.Drawing.Point(15, 169);
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
            messageLabel.Location = new System.Drawing.Point(53, 36);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(99, 25);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelLocation.ForeColor = System.Drawing.SystemColors.Control;
            labelLocation.Location = new System.Drawing.Point(60, 104);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new System.Drawing.Size(92, 25);
            labelLocation.TabIndex = 6;
            labelLocation.Text = "Location:";
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
            // panelMemoryDetails
            // 
            this.panelMemoryDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelMemoryDetails.Controls.Add(labelLocation);
            this.panelMemoryDetails.Controls.Add(this.nameTextBox);
            this.panelMemoryDetails.Controls.Add(createdTimeLabel);
            this.panelMemoryDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelMemoryDetails.Controls.Add(messageLabel);
            this.panelMemoryDetails.Controls.Add(this.messageTextBox);
            this.panelMemoryDetails.Location = new System.Drawing.Point(12, 98);
            this.panelMemoryDetails.Name = "panelMemoryDetails";
            this.panelMemoryDetails.Size = new System.Drawing.Size(553, 304);
            this.panelMemoryDetails.TabIndex = 80;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Place.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No location]"));
            this.nameTextBox.Location = new System.Drawing.Point(158, 104);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(380, 50);
            this.nameTextBox.TabIndex = 7;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(158, 172);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No massage]"));
            this.messageTextBox.Location = new System.Drawing.Point(158, 36);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(380, 50);
            this.messageTextBox.TabIndex = 3;
            // 
            // RandomMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
            this.Controls.Add(this.panelMemoryDetails);
            this.Controls.Add(this.buttonFetchMemory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomMemoryForm";
            this.Text = "RandomMemoryForm";
            this.panelMemoryDetails.ResumeLayout(false);
            this.panelMemoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchMemory;
        private System.Windows.Forms.Panel panelMemoryDetails;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}