using System;

namespace FacebookApp.UI.Forms
{
    partial class AlbumsForm
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.descriptionLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 25;
            this.listBoxAlbums.Location = new System.Drawing.Point(12, 74);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(318, 329);
            this.listBoxAlbums.TabIndex = 60;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonFetchAlbum
            // 
            this.buttonFetchAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchAlbum.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchAlbum.Location = new System.Drawing.Point(12, 11);
            this.buttonFetchAlbum.Name = "buttonFetchAlbum";
            this.buttonFetchAlbum.Size = new System.Drawing.Size(141, 40);
            this.buttonFetchAlbum.TabIndex = 59;
            this.buttonFetchAlbum.Text = "Fetch Albums";
            this.buttonFetchAlbum.UseVisualStyleBackColor = true;
            this.buttonFetchAlbum.Click += new System.EventHandler(this.fetch_albums_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(822, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Latest Picture";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(780, 111);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(220, 210);
            this.pictureBoxAlbum.TabIndex = 61;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.Click += new System.EventHandler(this.pictureBoxAlbum_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 320);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 65);
            this.textBox1.TabIndex = 68;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(492, 226);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(230, 65);
            this.textBoxLocation.TabIndex = 67;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLocation.Location = new System.Drawing.Point(394, 226);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(92, 25);
            this.labelLocation.TabIndex = 66;
            this.labelLocation.Text = "Location:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDate.Location = new System.Drawing.Point(427, 320);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 25);
            this.labelDate.TabIndex = 65;
            this.labelDate.Text = "Date:";
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(492, 77);
            this.textBoxEventDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(230, 123);
            this.textBoxEventDescription.TabIndex = 64;
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLable.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionLable.Location = new System.Drawing.Point(371, 79);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(115, 25);
            this.descriptionLable.TabIndex = 63;
            this.descriptionLable.Text = "Description:";
            // 
            // AlbumsForm
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonFetchAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonFetchAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.Label descriptionLable;
    }
}