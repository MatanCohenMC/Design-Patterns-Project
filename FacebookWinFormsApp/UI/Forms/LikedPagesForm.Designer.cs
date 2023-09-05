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
            System.Windows.Forms.Label imageLargeLabel;
            System.Windows.Forms.Label likesCountLabel;
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.Pagelabel = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.descriptionLable = new System.Windows.Forms.Label();
            this.panelLikedPageDetails = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            this.panelLikedPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(67, 104);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Location = new System.Drawing.Point(67, 129);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(86, 16);
            imageLargeLabel.TabIndex = 2;
            imageLargeLabel.Text = "Image Large:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(67, 188);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(79, 16);
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
            // Pagelabel
            // 
            this.Pagelabel.AutoSize = true;
            this.Pagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pagelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Pagelabel.Location = new System.Drawing.Point(1009, 75);
            this.Pagelabel.Name = "Pagelabel";
            this.Pagelabel.Size = new System.Drawing.Size(114, 25);
            this.Pagelabel.TabIndex = 6;
            this.Pagelabel.Text = "Page Photo";
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
            this.listBoxLikedPages.Size = new System.Drawing.Size(318, 329);
            this.listBoxLikedPages.TabIndex = 4;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            this.pageBindingSource.CurrentChanged += new System.EventHandler(this.pageBindingSource_CurrentChanged);
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLikedPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(945, 112);
            this.pictureBoxLikedPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikedPage.TabIndex = 5;
            this.pictureBoxLikedPage.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(925, 37);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(369, 325);
            this.textBoxDescription.TabIndex = 21;
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLable.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionLable.Location = new System.Drawing.Point(804, 39);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(115, 25);
            this.descriptionLable.TabIndex = 20;
            this.descriptionLable.Text = "Description:";
            // 
            // panelLikedPageDetails
            // 
            this.panelLikedPageDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelLikedPageDetails.Controls.Add(descriptionLabel);
            this.panelLikedPageDetails.Controls.Add(this.descriptionTextBox);
            this.panelLikedPageDetails.Controls.Add(imageLargeLabel);
            this.panelLikedPageDetails.Controls.Add(this.imageLargePictureBox);
            this.panelLikedPageDetails.Controls.Add(likesCountLabel);
            this.panelLikedPageDetails.Controls.Add(this.likesCountTextBox);
            this.panelLikedPageDetails.Location = new System.Drawing.Point(355, 74);
            this.panelLikedPageDetails.Name = "panelLikedPageDetails";
            this.panelLikedPageDetails.Size = new System.Drawing.Size(450, 328);
            this.panelLikedPageDetails.TabIndex = 22;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No description]"));
            this.descriptionTextBox.Location = new System.Drawing.Point(159, 101);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(157, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(159, 129);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageLargePictureBox.TabIndex = 3;
            this.imageLargePictureBox.TabStop = false;
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(159, 185);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(100, 22);
            this.likesCountTextBox.TabIndex = 5;
            // 
            // LikedPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelLikedPageDetails);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.descriptionLable);
            this.Controls.Add(this.buttonFetchPages);
            this.Controls.Add(this.Pagelabel);
            this.Controls.Add(this.pictureBoxLikedPage);
            this.Controls.Add(this.listBoxLikedPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LikedPagesForm";
            this.Text = "FormPages";
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            this.panelLikedPageDetails.ResumeLayout(false);
            this.panelLikedPageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchPages;
        private System.Windows.Forms.Label Pagelabel;
        private System.Windows.Forms.PictureBox pictureBoxLikedPage;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label descriptionLable;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panelLikedPageDetails;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox likesCountTextBox;
    }
}