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
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.Pagelabel = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.descriptionLable = new System.Windows.Forms.Label();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
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
            // Pagelabel
            // 
            this.Pagelabel.AutoSize = true;
            this.Pagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pagelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Pagelabel.Location = new System.Drawing.Point(835, 67);
            this.Pagelabel.Name = "Pagelabel";
            this.Pagelabel.Size = new System.Drawing.Size(118, 25);
            this.Pagelabel.TabIndex = 10;
            this.Pagelabel.Text = "Event Photo";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 25;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 74);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(318, 329);
            this.listBoxEvents.TabIndex = 8;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLable.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionLable.Location = new System.Drawing.Point(366, 73);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(115, 25);
            this.descriptionLable.TabIndex = 12;
            this.descriptionLable.Text = "Description:";
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(487, 71);
            this.textBoxEventDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(230, 123);
            this.textBoxEventDescription.TabIndex = 17;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDate.Location = new System.Drawing.Point(422, 314);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 25);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Date:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLocation.Location = new System.Drawing.Point(389, 220);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(92, 25);
            this.labelLocation.TabIndex = 20;
            this.labelLocation.Text = "Location:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(487, 220);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(230, 65);
            this.textBoxLocation.TabIndex = 22;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage.Location = new System.Drawing.Point(788, 103);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(220, 210);
            this.pictureBoxPage.TabIndex = 9;
            this.pictureBoxPage.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 314);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 65);
            this.textBox1.TabIndex = 23;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1045, 414);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxEventDescription);
            this.Controls.Add(this.descriptionLable);
            this.Controls.Add(this.buttonFetchEvents);
            this.Controls.Add(this.Pagelabel);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Label Pagelabel;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label descriptionLable;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBox1;
    }
}