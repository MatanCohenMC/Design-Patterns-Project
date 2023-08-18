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
            this.textBoxUpdatedTime = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelUpdatedTime = new System.Windows.Forms.Label();
            this.textBoxPictureCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(846, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Latest Picture";
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(804, 112);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(220, 210);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 61;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // textBoxUpdatedTime
            // 
            this.textBoxUpdatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpdatedTime.Location = new System.Drawing.Point(542, 228);
            this.textBoxUpdatedTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUpdatedTime.Multiline = true;
            this.textBoxUpdatedTime.Name = "textBoxUpdatedTime";
            this.textBoxUpdatedTime.Size = new System.Drawing.Size(230, 36);
            this.textBoxUpdatedTime.TabIndex = 68;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocation.Location = new System.Drawing.Point(542, 112);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(230, 90);
            this.textBoxLocation.TabIndex = 67;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLocation.Location = new System.Drawing.Point(444, 112);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(92, 25);
            this.labelLocation.TabIndex = 66;
            this.labelLocation.Text = "Location:";
            // 
            // labelUpdatedTime
            // 
            this.labelUpdatedTime.AutoSize = true;
            this.labelUpdatedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdatedTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUpdatedTime.Location = new System.Drawing.Point(403, 228);
            this.labelUpdatedTime.Name = "labelUpdatedTime";
            this.labelUpdatedTime.Size = new System.Drawing.Size(129, 25);
            this.labelUpdatedTime.TabIndex = 65;
            this.labelUpdatedTime.Text = "Created time:";
            // 
            // textBoxPictureCount
            // 
            this.textBoxPictureCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPictureCount.Location = new System.Drawing.Point(542, 290);
            this.textBoxPictureCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPictureCount.Multiline = true;
            this.textBoxPictureCount.Name = "textBoxPictureCount";
            this.textBoxPictureCount.Size = new System.Drawing.Size(230, 32);
            this.textBoxPictureCount.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(356, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Amount of pictures:";
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1045, 414);
            this.Controls.Add(this.textBoxPictureCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUpdatedTime);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelUpdatedTime);
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
        private System.Windows.Forms.TextBox textBoxUpdatedTime;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelUpdatedTime;
        private System.Windows.Forms.TextBox textBoxPictureCount;
        private System.Windows.Forms.Label label2;
    }
}