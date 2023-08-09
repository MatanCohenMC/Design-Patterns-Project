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
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(657, 122);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(179, 139);
            this.pictureBoxAlbum.TabIndex = 61;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.Click += new System.EventHandler(this.pictureBoxAlbum_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 20;
            this.listBoxAlbums.Location = new System.Drawing.Point(102, 98);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(374, 224);
            this.listBoxAlbums.TabIndex = 60;
            // 
            // buttonFetchAlbum
            // 
            this.buttonFetchAlbum.Location = new System.Drawing.Point(102, 330);
            this.buttonFetchAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFetchAlbum.Name = "buttonFetchAlbum";
            this.buttonFetchAlbum.Size = new System.Drawing.Size(154, 49);
            this.buttonFetchAlbum.TabIndex = 59;
            this.buttonFetchAlbum.Text = "Fetch Albums";
            this.buttonFetchAlbum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Latest Picture:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonFetchAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonFetchAlbum;
        private System.Windows.Forms.Label label1;
    }
}