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
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.Photolabel = new System.Windows.Forms.Label();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            this.descriptionLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 25;
            this.listBoxGroup.Location = new System.Drawing.Point(12, 74);
            this.listBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(318, 329);
            this.listBoxGroup.TabIndex = 0;
            // 
            // Photolabel
            // 
            this.Photolabel.AutoSize = true;
            this.Photolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Photolabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Photolabel.Location = new System.Drawing.Point(821, 70);
            this.Photolabel.Name = "Photolabel";
            this.Photolabel.Size = new System.Drawing.Size(122, 25);
            this.Photolabel.TabIndex = 2;
            this.Photolabel.Text = "Group Photo";
            this.Photolabel.Click += new System.EventHandler(this.label1_Click);
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
            this.buttonFetchGroups.Click += new System.EventHandler(this.fetch_groups_button_Click);
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGroup.Location = new System.Drawing.Point(773, 109);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(220, 210);
            this.pictureBoxGroup.TabIndex = 1;
            this.pictureBoxGroup.TabStop = false;
            // 
            // textBoxEventDescription
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(486, 74);
            this.textBoxEventDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "textBoxEventDescription";
            this.textBoxEventDescription.Size = new System.Drawing.Size(230, 123);
            this.textBoxEventDescription.TabIndex = 19;
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLable.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionLable.Location = new System.Drawing.Point(365, 76);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(115, 25);
            this.descriptionLable.TabIndex = 18;
            this.descriptionLable.Text = "Description:";
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1045, 414);
            this.Controls.Add(this.textBoxEventDescription);
            this.Controls.Add(this.descriptionLable);
            this.Controls.Add(this.buttonFetchGroups);
            this.Controls.Add(this.Photolabel);
            this.Controls.Add(this.pictureBoxGroup);
            this.Controls.Add(this.listBoxGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.Label Photolabel;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.TextBox textBoxEventDescription;
        private System.Windows.Forms.Label descriptionLable;
    }
}