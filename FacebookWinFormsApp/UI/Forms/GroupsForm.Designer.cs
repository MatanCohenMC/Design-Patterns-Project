namespace FacebookApp.UI.Forms
{
    partial class GroupsForm
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
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label emailLabel;
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            imageLargeLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.panelGroupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DataSource = this.groupBindingSource;
            this.listBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 25;
            this.listBoxGroups.Location = new System.Drawing.Point(12, 74);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(318, 329);
            this.listBoxGroups.TabIndex = 0;
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFetchGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchGroups.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFetchGroups.Location = new System.Drawing.Point(12, 11);
            this.buttonFetchGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(139, 40);
            this.buttonFetchGroups.TabIndex = 3;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // panelGroupDetails
            // 
            this.panelGroupDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelGroupDetails.Controls.Add(emailLabel);
            this.panelGroupDetails.Controls.Add(this.emailTextBox);
            this.panelGroupDetails.Controls.Add(nameLabel1);
            this.panelGroupDetails.Controls.Add(this.nameLabel2);
            this.panelGroupDetails.Controls.Add(descriptionLabel);
            this.panelGroupDetails.Controls.Add(this.descriptionTextBox);
            this.panelGroupDetails.Controls.Add(imageLargeLabel);
            this.panelGroupDetails.Controls.Add(this.imageLargePictureBox);
            this.panelGroupDetails.Location = new System.Drawing.Point(364, 74);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(969, 328);
            this.panelGroupDetails.TabIndex = 4;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(212, 121);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(304, 118);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageLargeLabel
            // 
            imageLargeLabel.AutoSize = true;
            imageLargeLabel.Location = new System.Drawing.Point(212, 146);
            imageLargeLabel.Name = "imageLargeLabel";
            imageLargeLabel.Size = new System.Drawing.Size(86, 16);
            imageLargeLabel.TabIndex = 2;
            imageLargeLabel.Text = "Image Large:";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(304, 146);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageLargePictureBox.TabIndex = 3;
            this.imageLargePictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(242, 59);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(48, 16);
            nameLabel1.TabIndex = 6;
            nameLabel1.Text = "Owner:";
            // 
            // nameLabel2
            // 
            this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Owner.Name", true));
            this.nameLabel2.Location = new System.Drawing.Point(304, 59);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(100, 23);
            this.nameLabel2.TabIndex = 7;
            this.nameLabel2.Text = "labelOwnerName";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(254, 93);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Owner.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(304, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1345, 414);
            this.Controls.Add(this.panelGroupDetails);
            this.Controls.Add(this.buttonFetchGroups);
            this.Controls.Add(this.listBoxGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.panelGroupDetails.ResumeLayout(false);
            this.panelGroupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Panel panelGroupDetails;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}