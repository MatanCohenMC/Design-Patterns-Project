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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageAlbumLabel;
            System.Windows.Forms.Label locationLabel;
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchAlbum = new System.Windows.Forms.Button();
            this.panelAlbumDetails = new System.Windows.Forms.Panel();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            countLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageAlbumLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.panelAlbumDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(37, 67);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(44, 16);
            countLabel.TabIndex = 0;
            countLabel.Text = "Count:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(37, 96);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(92, 16);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(37, 123);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // imageAlbumLabel
            // 
            imageAlbumLabel.AutoSize = true;
            imageAlbumLabel.Location = new System.Drawing.Point(37, 148);
            imageAlbumLabel.Name = "imageAlbumLabel";
            imageAlbumLabel.Size = new System.Drawing.Size(89, 16);
            imageAlbumLabel.TabIndex = 6;
            imageAlbumLabel.Text = "Image Album:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(37, 207);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(61, 16);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 25;
            this.listBoxAlbums.Location = new System.Drawing.Point(12, 74);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(452, 329);
            this.listBoxAlbums.TabIndex = 60;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
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
            this.buttonFetchAlbum.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // panelAlbumDetails
            // 
            this.panelAlbumDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelAlbumDetails.Controls.Add(countLabel);
            this.panelAlbumDetails.Controls.Add(this.countTextBox);
            this.panelAlbumDetails.Controls.Add(createdTimeLabel);
            this.panelAlbumDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelAlbumDetails.Controls.Add(descriptionLabel);
            this.panelAlbumDetails.Controls.Add(this.descriptionTextBox);
            this.panelAlbumDetails.Controls.Add(imageAlbumLabel);
            this.panelAlbumDetails.Controls.Add(this.imageAlbumPictureBox);
            this.panelAlbumDetails.Controls.Add(locationLabel);
            this.panelAlbumDetails.Controls.Add(this.locationTextBox);
            this.panelAlbumDetails.Location = new System.Drawing.Point(501, 74);
            this.panelAlbumDetails.Name = "panelAlbumDetails";
            this.panelAlbumDetails.Size = new System.Drawing.Size(832, 328);
            this.panelAlbumDetails.TabIndex = 61;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(135, 64);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 22);
            this.countTextBox.TabIndex = 1;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(135, 92);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(135, 120);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(135, 148);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(200, 50);
            this.imageAlbumPictureBox.TabIndex = 7;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(135, 204);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 22);
            this.locationTextBox.TabIndex = 9;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelAlbumDetails);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonFetchAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.panelAlbumDetails.ResumeLayout(false);
            this.panelAlbumDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonFetchAlbum;
        private System.Windows.Forms.Panel panelAlbumDetails;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.TextBox locationTextBox;
    }
}