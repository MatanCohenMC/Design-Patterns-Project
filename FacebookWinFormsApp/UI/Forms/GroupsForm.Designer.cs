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
            System.Windows.Forms.Label nameLabel;
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.panelGroupDetails = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.labelLoading = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.panelGroupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            descriptionLabel.Location = new System.Drawing.Point(36, 103);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(115, 25);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(75, 43);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 25);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Owner:";
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
            this.listBoxGroups.Size = new System.Drawing.Size(465, 329);
            this.listBoxGroups.TabIndex = 0;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
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
            this.panelGroupDetails.Controls.Add(nameLabel);
            this.panelGroupDetails.Controls.Add(this.nameTextBox);
            this.panelGroupDetails.Controls.Add(descriptionLabel);
            this.panelGroupDetails.Controls.Add(this.descriptionTextBox);
            this.panelGroupDetails.Controls.Add(this.imageLargePictureBox);
            this.panelGroupDetails.Location = new System.Drawing.Point(507, 74);
            this.panelGroupDetails.Name = "panelGroupDetails";
            this.panelGroupDetails.Size = new System.Drawing.Size(900, 329);
            this.panelGroupDetails.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Owner.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No name]"));
            this.nameTextBox.Location = new System.Drawing.Point(157, 43);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(380, 47);
            this.nameTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No description]"));
            this.descriptionTextBox.Location = new System.Drawing.Point(157, 107);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(380, 50);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(630, 40);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(250, 250);
            this.imageLargePictureBox.TabIndex = 3;
            this.imageLargePictureBox.TabStop = false;
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
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1453, 414);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.panelGroupDetails);
            this.Controls.Add(this.buttonFetchGroups);
            this.Controls.Add(this.listBoxGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.panelGroupDetails.ResumeLayout(false);
            this.panelGroupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Panel panelGroupDetails;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}