namespace FacebookApp.UI.Forms
{
    partial class RandomMemoryForm
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
            this.buttonFetchMemory = new System.Windows.Forms.Button();
            this.pictureBoxMemory = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDateCreated = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchMemory
            // 
            this.buttonFetchMemory.Location = new System.Drawing.Point(88, 107);
            this.buttonFetchMemory.Name = "buttonFetchMemory";
            this.buttonFetchMemory.Size = new System.Drawing.Size(138, 42);
            this.buttonFetchMemory.TabIndex = 0;
            this.buttonFetchMemory.Text = "Fetch Random Memory";
            this.buttonFetchMemory.UseVisualStyleBackColor = true;
            this.buttonFetchMemory.Click += new System.EventHandler(this.buttonFetchMemory_Click);
            // 
            // pictureBoxMemory
            // 
            this.pictureBoxMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMemory.Location = new System.Drawing.Point(385, 40);
            this.pictureBoxMemory.Name = "pictureBoxMemory";
            this.pictureBoxMemory.Size = new System.Drawing.Size(242, 183);
            this.pictureBoxMemory.TabIndex = 1;
            this.pictureBoxMemory.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "date updated:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDateCreated
            // 
            this.textBoxDateCreated.Location = new System.Drawing.Point(385, 245);
            this.textBoxDateCreated.Name = "textBoxDateCreated";
            this.textBoxDateCreated.Size = new System.Drawing.Size(242, 22);
            this.textBoxDateCreated.TabIndex = 3;
            this.textBoxDateCreated.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RandomMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDateCreated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMemory);
            this.Controls.Add(this.buttonFetchMemory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomMemoryForm";
            this.Text = "RandomMemoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchMemory;
        private System.Windows.Forms.PictureBox pictureBoxMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDateCreated;
    }
}