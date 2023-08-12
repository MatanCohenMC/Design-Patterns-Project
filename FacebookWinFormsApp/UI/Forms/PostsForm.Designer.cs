namespace FacebookApp.UI.Forms
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
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.fetch_posts_button = new System.Windows.Forms.Button();
            this.totalLikesLable = new System.Windows.Forms.Label();
            this.textBoxLikes = new System.Windows.Forms.TextBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.commentsLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCreatedDate = new System.Windows.Forms.TextBox();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPostLocation = new System.Windows.Forms.TextBox();
            this.textBoxPostsCaption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 25;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 74);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(318, 329);
            this.listBoxPosts.TabIndex = 0;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
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
            this.fetch_posts_button.Click += new System.EventHandler(this.fetch_posts_button_Click);
            // 
            // totalLikesLable
            // 
            this.totalLikesLable.AutoSize = true;
            this.totalLikesLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLikesLable.ForeColor = System.Drawing.SystemColors.Control;
            this.totalLikesLable.Location = new System.Drawing.Point(664, 367);
            this.totalLikesLable.Name = "totalLikesLable";
            this.totalLikesLable.Size = new System.Drawing.Size(113, 25);
            this.totalLikesLable.TabIndex = 2;
            this.totalLikesLable.Text = "Total Likes:";
            // 
            // textBoxLikes
            // 
            this.textBoxLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLikes.Location = new System.Drawing.Point(783, 364);
            this.textBoxLikes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLikes.Name = "textBoxLikes";
            this.textBoxLikes.Size = new System.Drawing.Size(220, 30);
            this.textBoxLikes.TabIndex = 3;
            // 
            // listBoxComments
            // 
            this.listBoxComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 25;
            this.listBoxComments.Location = new System.Drawing.Point(455, 155);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(306, 129);
            this.listBoxComments.TabIndex = 4;
            // 
            // commentsLable
            // 
            this.commentsLable.AutoSize = true;
            this.commentsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLable.ForeColor = System.Drawing.SystemColors.Control;
            this.commentsLable.Location = new System.Drawing.Point(342, 155);
            this.commentsLable.Name = "commentsLable";
            this.commentsLable.Size = new System.Drawing.Size(113, 25);
            this.commentsLable.TabIndex = 5;
            this.commentsLable.Text = "Comments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(643, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Created Date:";
            // 
            // textBoxCreatedDate
            // 
            this.textBoxCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreatedDate.Location = new System.Drawing.Point(783, 312);
            this.textBoxCreatedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreatedDate.Name = "textBoxCreatedDate";
            this.textBoxCreatedDate.Size = new System.Drawing.Size(220, 30);
            this.textBoxCreatedDate.TabIndex = 7;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPosts.Location = new System.Drawing.Point(783, 74);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(220, 210);
            this.pictureBoxPosts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPosts.TabIndex = 62;
            this.pictureBoxPosts.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(357, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Location:";
            // 
            // textBoxPostLocation
            // 
            this.textBoxPostLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostLocation.Location = new System.Drawing.Point(455, 314);
            this.textBoxPostLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostLocation.Multiline = true;
            this.textBoxPostLocation.Name = "textBoxPostLocation";
            this.textBoxPostLocation.Size = new System.Drawing.Size(177, 78);
            this.textBoxPostLocation.TabIndex = 64;
            // 
            // textBoxPostsCaption
            // 
            this.textBoxPostsCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostsCaption.Location = new System.Drawing.Point(455, 74);
            this.textBoxPostsCaption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostsCaption.Multiline = true;
            this.textBoxPostsCaption.Name = "textBoxPostsCaption";
            this.textBoxPostsCaption.Size = new System.Drawing.Size(306, 59);
            this.textBoxPostsCaption.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(363, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Caption:";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1045, 414);
            this.Controls.Add(this.textBoxPostsCaption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPostLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPosts);
            this.Controls.Add(this.textBoxCreatedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentsLable);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.textBoxLikes);
            this.Controls.Add(this.totalLikesLable);
            this.Controls.Add(this.fetch_posts_button);
            this.Controls.Add(this.listBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button fetch_posts_button;
        private System.Windows.Forms.Label totalLikesLable;
        private System.Windows.Forms.TextBox textBoxLikes;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label commentsLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCreatedDate;
        private System.Windows.Forms.PictureBox pictureBoxPosts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPostLocation;
        private System.Windows.Forms.TextBox textBoxPostsCaption;
        private System.Windows.Forms.Label label3;
    }
}