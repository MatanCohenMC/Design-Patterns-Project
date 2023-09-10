namespace FacebookApp.UI.Forms
{
    partial class LikedPagesForm
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label likesCountLabel;
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelLikedPageDetails = new System.Windows.Forms.Panel();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.labelLoading = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.panelLikedPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            descriptionLabel.Location = new System.Drawing.Point(36, 43);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(115, 25);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.ForeColor = System.Drawing.SystemColors.Control;
            cityLabel.Location = new System.Drawing.Point(99, 107);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(52, 25);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            likesCountLabel.ForeColor = System.Drawing.SystemColors.Control;
            likesCountLabel.Location = new System.Drawing.Point(29, 172);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(122, 25);
            likesCountLabel.TabIndex = 4;
            likesCountLabel.Text = "Likes Count:";
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchPages.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchPages.Location = new System.Drawing.Point(12, 11);
            this.buttonFetchPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(130, 40);
            this.buttonFetchPages.TabIndex = 7;
            this.buttonFetchPages.Text = "Fetch Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 25;
            this.listBoxLikedPages.Location = new System.Drawing.Point(12, 74);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(465, 329);
            this.listBoxLikedPages.TabIndex = 4;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // panelLikedPageDetails
            // 
            this.panelLikedPageDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelLikedPageDetails.Controls.Add(cityLabel);
            this.panelLikedPageDetails.Controls.Add(this.cityTextBox);
            this.panelLikedPageDetails.Controls.Add(descriptionLabel);
            this.panelLikedPageDetails.Controls.Add(this.descriptionTextBox);
            this.panelLikedPageDetails.Controls.Add(this.imageLargePictureBox);
            this.panelLikedPageDetails.Controls.Add(likesCountLabel);
            this.panelLikedPageDetails.Controls.Add(this.likesCountTextBox);
            this.panelLikedPageDetails.Location = new System.Drawing.Point(507, 74);
            this.panelLikedPageDetails.Name = "panelLikedPageDetails";
            this.panelLikedPageDetails.Size = new System.Drawing.Size(900, 329);
            this.panelLikedPageDetails.TabIndex = 22;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Location.City", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No city]"));
            this.cityTextBox.Location = new System.Drawing.Point(157, 107);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(380, 50);
            this.cityTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No description]"));
            this.descriptionTextBox.Location = new System.Drawing.Point(157, 40);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(380, 50);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(559, 40);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(250, 250);
            this.imageLargePictureBox.TabIndex = 3;
            this.imageLargePictureBox.TabStop = false;
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(157, 172);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(100, 22);
            this.likesCountTextBox.TabIndex = 5;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.White;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(20, 80);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(97, 25);
            this.labelLoading.TabIndex = 64;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // LikedPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panelLikedPageDetails);
            this.Controls.Add(this.buttonFetchPages);
            this.Controls.Add(this.listBoxLikedPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LikedPagesForm";
            this.Text = "FormPages";
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            this.panelLikedPageDetails.ResumeLayout(false);
            this.panelLikedPageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panelLikedPageDetails;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox likesCountTextBox;
        private System.Windows.Forms.Label labelLoading;
    }
}