﻿namespace FacebookApp.UI.Forms
{
    partial class PostsForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label messageLabel;
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fetch_posts_button = new System.Windows.Forms.Button();
            this.panelPostDetails = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelLoading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panelPostDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            createdTimeLabel.Location = new System.Drawing.Point(13, 183);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(137, 25);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(58, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(92, 25);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Location:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.ForeColor = System.Drawing.SystemColors.Control;
            messageLabel.Location = new System.Drawing.Point(51, 41);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(99, 25);
            messageLabel.TabIndex = 15;
            messageLabel.Text = "Message:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 25;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 74);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(465, 329);
            this.listBoxPosts.TabIndex = 0;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // fetch_posts_button
            // 
            this.fetch_posts_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fetch_posts_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fetch_posts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetch_posts_button.ForeColor = System.Drawing.SystemColors.Control;
            this.fetch_posts_button.Location = new System.Drawing.Point(12, 11);
            this.fetch_posts_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fetch_posts_button.Name = "fetch_posts_button";
            this.fetch_posts_button.Size = new System.Drawing.Size(130, 40);
            this.fetch_posts_button.TabIndex = 1;
            this.fetch_posts_button.Text = "Fetch Posts";
            this.fetch_posts_button.UseVisualStyleBackColor = true;
            this.fetch_posts_button.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // panelPostDetails
            // 
            this.panelPostDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelPostDetails.Controls.Add(messageLabel);
            this.panelPostDetails.Controls.Add(this.messageTextBox);
            this.panelPostDetails.Controls.Add(nameLabel);
            this.panelPostDetails.Controls.Add(this.nameTextBox);
            this.panelPostDetails.Controls.Add(createdTimeLabel);
            this.panelPostDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelPostDetails.Location = new System.Drawing.Point(507, 74);
            this.panelPostDetails.Name = "panelPostDetails";
            this.panelPostDetails.Size = new System.Drawing.Size(900, 329);
            this.panelPostDetails.TabIndex = 78;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No message]"));
            this.messageTextBox.Location = new System.Drawing.Point(156, 41);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(380, 50);
            this.messageTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Place.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No location]"));
            this.nameTextBox.Location = new System.Drawing.Point(156, 113);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(380, 50);
            this.nameTextBox.TabIndex = 15;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(156, 186);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.White;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(20, 80);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(97, 25);
            this.labelLoading.TabIndex = 79;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1133, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Post picture";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panelPostDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fetch_posts_button);
            this.Controls.Add(this.listBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panelPostDetails.ResumeLayout(false);
            this.panelPostDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button fetch_posts_button;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel panelPostDetails;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label label1;
    }
}