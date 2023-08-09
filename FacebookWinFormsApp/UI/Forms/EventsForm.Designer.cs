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
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.descriptionLable = new System.Windows.Forms.Label();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(159, 325);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(132, 34);
            this.buttonFetchEvents.TabIndex = 11;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // Pagelabel
            // 
            this.Pagelabel.AutoSize = true;
            this.Pagelabel.Location = new System.Drawing.Point(535, 63);
            this.Pagelabel.Name = "Pagelabel";
            this.Pagelabel.Size = new System.Drawing.Size(96, 20);
            this.Pagelabel.TabIndex = 10;
            this.Pagelabel.Text = "Event Photo";
            this.Pagelabel.Click += new System.EventHandler(this.Pagelabel_Click);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage.Location = new System.Drawing.Point(505, 91);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(161, 125);
            this.pictureBoxPage.TabIndex = 9;
            this.pictureBoxPage.TabStop = false;
            this.pictureBoxPage.Click += new System.EventHandler(this.pictureBoxPage_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(96, 92);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(269, 204);
            this.listBoxEvents.TabIndex = 8;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Location = new System.Drawing.Point(416, 235);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(93, 20);
            this.descriptionLable.TabIndex = 12;
            this.descriptionLable.Text = "Description:";
            this.descriptionLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(505, 235);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(200, 53);
            this.textBoxEventDescription.TabIndex = 17;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(451, 374);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(48, 20);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Date:";
            this.labelDate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(425, 309);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(74, 20);
            this.labelLocation.TabIndex = 20;
            this.labelLocation.Text = "Location:";
            this.labelLocation.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 21;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(505, 306);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 53);
            this.textBoxLocation.TabIndex = 22;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxEventDescription);
            this.Controls.Add(this.descriptionLable);
            this.Controls.Add(this.buttonFetchEvents);
            this.Controls.Add(this.Pagelabel);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxLocation;
    }
}