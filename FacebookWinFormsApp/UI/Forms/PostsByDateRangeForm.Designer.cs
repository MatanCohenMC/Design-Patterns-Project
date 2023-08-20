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
            this.labelEnterMonths = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.commentsLable = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFetchPostsByDate = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
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
            this.listBoxPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 25;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 74);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(529, 329);
            this.listBoxPosts.TabIndex = 5;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaption.Location = new System.Drawing.Point(676, 77);
            this.textBoxCaption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(292, 59);
            this.textBoxCaption.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(584, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Caption:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(676, 305);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(292, 31);
            this.textBoxLocation.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(578, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "Location:";
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPosts.Location = new System.Drawing.Point(1006, 102);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(252, 250);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPosts.TabIndex = 71;
            this.pictureBoxPosts.TabStop = false;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.Location = new System.Drawing.Point(676, 353);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(292, 28);
            this.textBoxDate.TabIndex = 70;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDate.Location = new System.Drawing.Point(611, 353);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 25);
            this.labelDate.TabIndex = 69;
            this.labelDate.Text = "Date:";
            // 
            // commentsLable
            // 
            this.commentsLable.AutoSize = true;
            this.commentsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLable.ForeColor = System.Drawing.SystemColors.Control;
            this.commentsLable.Location = new System.Drawing.Point(563, 158);
            this.commentsLable.Name = "commentsLable";
            this.commentsLable.Size = new System.Drawing.Size(113, 25);
            this.commentsLable.TabIndex = 68;
            this.commentsLable.Text = "Comments:";
            // 
            // listBoxComments
            // 
            this.listBoxComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 25;
            this.listBoxComments.Location = new System.Drawing.Point(676, 158);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(292, 129);
            this.listBoxComments.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1074, 64);
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
            // PostsByDateRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.buttonFetchPostsByDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCaption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPosts);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.commentsLable);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelEnterMonths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostsByDateRangeForm";
            this.Text = "PicturesByDateRange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterMonths;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxPosts;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label commentsLable;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFetchPostsByDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}