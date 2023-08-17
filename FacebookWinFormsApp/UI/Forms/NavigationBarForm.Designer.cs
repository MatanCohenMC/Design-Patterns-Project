namespace FacebookApp.UI.Forms
{
    partial class NavigationBarForm
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
            this.tableLayoutNavBar = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEventByLocation = new System.Windows.Forms.Button();
            this.buttonPostsByDateRange = new System.Windows.Forms.Button();
            this.ButtonAlbums = new System.Windows.Forms.Button();
            this.ButtonEvents = new System.Windows.Forms.Button();
            this.ButtonGroups = new System.Windows.Forms.Button();
            this.ButtonLikedPages = new System.Windows.Forms.Button();
            this.ButtonPosts = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonRandomMemory = new System.Windows.Forms.Button();
            this.buttonFriendsInMyAgeRange = new System.Windows.Forms.Button();
            this.tableLayoutNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutNavBar
            // 
            this.tableLayoutNavBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutNavBar.ColumnCount = 9;
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutNavBar.Controls.Add(this.buttonRandomMemory, 0, 0);
            this.tableLayoutNavBar.Controls.Add(this.buttonEventByLocation, 0, 0);
            this.tableLayoutNavBar.Controls.Add(this.ButtonAlbums, 0, 0);
            this.tableLayoutNavBar.Controls.Add(this.ButtonEvents, 0, 0);
            this.tableLayoutNavBar.Controls.Add(this.ButtonGroups, 0, 0);
            this.tableLayoutNavBar.Controls.Add(this.ButtonLikedPages, 0, 0);
            this.tableLayoutNavBar.Controls.Add(this.ButtonPosts, 0, 0);
            this.tableLayoutNavBar.Controls.Add(this.buttonFriendsInMyAgeRange, 6, 0);
            this.tableLayoutNavBar.Controls.Add(this.buttonPostsByDateRange, 7, 0);
            this.tableLayoutNavBar.ForeColor = System.Drawing.SystemColors.Control;
            this.tableLayoutNavBar.Location = new System.Drawing.Point(2, 96);
            this.tableLayoutNavBar.Name = "tableLayoutNavBar";
            this.tableLayoutNavBar.RowCount = 1;
            this.tableLayoutNavBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutNavBar.Size = new System.Drawing.Size(1340, 77);
            this.tableLayoutNavBar.TabIndex = 5;
            // 
            // buttonEventByLocation
            // 
            this.buttonEventByLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEventByLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEventByLocation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEventByLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEventByLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEventByLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEventByLocation.Location = new System.Drawing.Point(740, 0);
            this.buttonEventByLocation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEventByLocation.Name = "buttonEventByLocation";
            this.buttonEventByLocation.Size = new System.Drawing.Size(148, 77);
            this.buttonEventByLocation.TabIndex = 9;
            this.buttonEventByLocation.Text = "Events By Location";
            this.buttonEventByLocation.UseVisualStyleBackColor = true;
            this.buttonEventByLocation.Click += new System.EventHandler(this.buttonEventByLocation_Click);
            // 
            // buttonPostsByDateRange
            // 
            this.buttonPostsByDateRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPostsByDateRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPostsByDateRange.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPostsByDateRange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPostsByDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostsByDateRange.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPostsByDateRange.Location = new System.Drawing.Point(1184, 0);
            this.buttonPostsByDateRange.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPostsByDateRange.Name = "buttonPostsByDateRange";
            this.buttonPostsByDateRange.Size = new System.Drawing.Size(156, 77);
            this.buttonPostsByDateRange.TabIndex = 8;
            this.buttonPostsByDateRange.Text = "Posts By Date Range";
            this.buttonPostsByDateRange.UseVisualStyleBackColor = true;
            this.buttonPostsByDateRange.Click += new System.EventHandler(this.buttonPostsByDateRange_Click);
            // 
            // ButtonAlbums
            // 
            this.ButtonAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAlbums.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAlbums.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonAlbums.Location = new System.Drawing.Point(888, 0);
            this.ButtonAlbums.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAlbums.Name = "ButtonAlbums";
            this.ButtonAlbums.Size = new System.Drawing.Size(148, 77);
            this.ButtonAlbums.TabIndex = 5;
            this.ButtonAlbums.Text = "Albums";
            this.ButtonAlbums.UseVisualStyleBackColor = true;
            this.ButtonAlbums.Click += new System.EventHandler(this.ButtonAlbums_Click);
            // 
            // ButtonEvents
            // 
            this.ButtonEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEvents.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEvents.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonEvents.Location = new System.Drawing.Point(444, 0);
            this.ButtonEvents.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonEvents.Name = "ButtonEvents";
            this.ButtonEvents.Size = new System.Drawing.Size(148, 77);
            this.ButtonEvents.TabIndex = 2;
            this.ButtonEvents.Text = "Events";
            this.ButtonEvents.UseVisualStyleBackColor = true;
            this.ButtonEvents.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // ButtonGroups
            // 
            this.ButtonGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonGroups.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGroups.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonGroups.Location = new System.Drawing.Point(0, 0);
            this.ButtonGroups.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonGroups.Name = "ButtonGroups";
            this.ButtonGroups.Size = new System.Drawing.Size(148, 77);
            this.ButtonGroups.TabIndex = 1;
            this.ButtonGroups.Text = "Groups";
            this.ButtonGroups.UseVisualStyleBackColor = true;
            this.ButtonGroups.Click += new System.EventHandler(this.ButtonGroups_Click);
            // 
            // ButtonLikedPages
            // 
            this.ButtonLikedPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLikedPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLikedPages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLikedPages.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonLikedPages.Location = new System.Drawing.Point(148, 0);
            this.ButtonLikedPages.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonLikedPages.Name = "ButtonLikedPages";
            this.ButtonLikedPages.Size = new System.Drawing.Size(148, 77);
            this.ButtonLikedPages.TabIndex = 4;
            this.ButtonLikedPages.Text = "Liked Pages";
            this.ButtonLikedPages.UseVisualStyleBackColor = true;
            this.ButtonLikedPages.Click += new System.EventHandler(this.ButtonLikedPages_Click);
            // 
            // ButtonPosts
            // 
            this.ButtonPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPosts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPosts.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonPosts.Location = new System.Drawing.Point(296, 0);
            this.ButtonPosts.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPosts.Name = "ButtonPosts";
            this.ButtonPosts.Size = new System.Drawing.Size(148, 77);
            this.ButtonPosts.TabIndex = 3;
            this.ButtonPosts.Text = "Posts";
            this.ButtonPosts.UseVisualStyleBackColor = true;
            this.ButtonPosts.Click += new System.EventHandler(this.ButtonPosts_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = global::FacebookApp.Properties.Resources.FacebookLogo;
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(1345, 79);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonRandomMemory
            // 
            this.buttonRandomMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRandomMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRandomMemory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRandomMemory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRandomMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomMemory.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRandomMemory.Location = new System.Drawing.Point(592, 0);
            this.buttonRandomMemory.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRandomMemory.Name = "buttonRandomMemory";
            this.buttonRandomMemory.Size = new System.Drawing.Size(148, 77);
            this.buttonRandomMemory.TabIndex = 6;
            this.buttonRandomMemory.Text = "Random Memory";
            this.buttonRandomMemory.UseVisualStyleBackColor = true;
            this.buttonRandomMemory.Click += new System.EventHandler(this.buttonRandomMemory_Click);
            // 
            // buttonFriendsInMyAgeRange
            // 
            this.buttonFriendsInMyAgeRange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriendsInMyAgeRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFriendsInMyAgeRange.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFriendsInMyAgeRange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFriendsInMyAgeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendsInMyAgeRange.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFriendsInMyAgeRange.Location = new System.Drawing.Point(1036, 0);
            this.buttonFriendsInMyAgeRange.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFriendsInMyAgeRange.Name = "buttonFriendsInMyAgeRange";
            this.buttonFriendsInMyAgeRange.Size = new System.Drawing.Size(148, 77);
            this.buttonFriendsInMyAgeRange.TabIndex = 7;
            this.buttonFriendsInMyAgeRange.Text = "Friends In My Age Range";
            this.buttonFriendsInMyAgeRange.UseVisualStyleBackColor = true;
            this.buttonFriendsInMyAgeRange.Click += new System.EventHandler(this.buttonFriendsInMyAgeRange_Click);
            // 
            // NavigationBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 174);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.tableLayoutNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NavigationBarForm";
            this.Text = "NavigationBarForm";
            this.tableLayoutNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutNavBar;
        private System.Windows.Forms.Button buttonEventByLocation;
        private System.Windows.Forms.Button buttonPostsByDateRange;
        private System.Windows.Forms.Button ButtonAlbums;
        private System.Windows.Forms.Button ButtonEvents;
        private System.Windows.Forms.Button ButtonGroups;
        private System.Windows.Forms.Button ButtonLikedPages;
        private System.Windows.Forms.Button ButtonPosts;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonRandomMemory;
        private System.Windows.Forms.Button buttonFriendsInMyAgeRange;
    }
}