namespace FacebookApp.UI.Forms
{
    partial class AppMainForm
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
            this.NavBarPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NavBarPanel
            // 
            this.NavBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavBarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NavBarPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NavBarPanel.Location = new System.Drawing.Point(193, 21);
            this.NavBarPanel.Name = "NavBarPanel";
            this.NavBarPanel.Size = new System.Drawing.Size(1345, 174);
            this.NavBarPanel.TabIndex = 3;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginPanel.Location = new System.Drawing.Point(12, 21);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(175, 594);
            this.LoginPanel.TabIndex = 4;
            // 
            // panelDisplay
            // 
            this.panelDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(153)))));
            this.panelDisplay.Location = new System.Drawing.Point(193, 201);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1345, 414);
            this.panelDisplay.TabIndex = 5;
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1550, 627);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.NavBarPanel);
            this.Name = "AppMainForm";
            this.Text = "AppMainForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel NavBarPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel panelDisplay;
    }
}