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
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.Photolabel = new System.Windows.Forms.Label();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 20;
            this.listBoxGroup.Location = new System.Drawing.Point(68, 98);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(269, 204);
            this.listBoxGroup.TabIndex = 0;
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGroup.Location = new System.Drawing.Point(409, 126);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(161, 125);
            this.pictureBoxGroup.TabIndex = 1;
            this.pictureBoxGroup.TabStop = false;
            // 
            // Photolabel
            // 
            this.Photolabel.AutoSize = true;
            this.Photolabel.Location = new System.Drawing.Point(439, 98);
            this.Photolabel.Name = "Photolabel";
            this.Photolabel.Size = new System.Drawing.Size(100, 20);
            this.Photolabel.TabIndex = 2;
            this.Photolabel.Text = "Group Photo";
            this.Photolabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(131, 331);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(132, 34);
            this.buttonFetchGroups.TabIndex = 3;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.fetch_groups_button_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFetchGroups);
            this.Controls.Add(this.Photolabel);
            this.Controls.Add(this.pictureBoxGroup);
            this.Controls.Add(this.listBoxGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}