namespace FacebookApp.UI.Forms
{
    partial class FormPages
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
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.Pagelabel = new System.Windows.Forms.Label();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.Location = new System.Drawing.Point(139, 309);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(132, 34);
            this.buttonFetchPages.TabIndex = 7;
            this.buttonFetchPages.Text = "Fetch Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // Pagelabel
            // 
            this.Pagelabel.AutoSize = true;
            this.Pagelabel.Location = new System.Drawing.Point(447, 76);
            this.Pagelabel.Name = "Pagelabel";
            this.Pagelabel.Size = new System.Drawing.Size(92, 20);
            this.Pagelabel.TabIndex = 6;
            this.Pagelabel.Text = "Page Photo";
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage.Location = new System.Drawing.Point(417, 104);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(161, 125);
            this.pictureBoxPage.TabIndex = 5;
            this.pictureBoxPage.TabStop = false;
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 20;
            this.listBoxPages.Location = new System.Drawing.Point(76, 76);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(269, 204);
            this.listBoxPages.TabIndex = 4;
            // 
            // FormPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFetchPages);
            this.Controls.Add(this.Pagelabel);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.listBoxPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPages";
            this.Text = "FormPages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchPages;
        private System.Windows.Forms.Label Pagelabel;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.ListBox listBoxPages;
    }
}