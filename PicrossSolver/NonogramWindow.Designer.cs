namespace PicrossSolver
{
    partial class NonogramWindow
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
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.bottomLeftPanel = new System.Windows.Forms.Panel();
            this.mainPuzzlePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topLeftPanel.BackColor = System.Drawing.Color.Red;
            this.topLeftPanel.Location = new System.Drawing.Point(12, 12);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(45, 44);
            this.topLeftPanel.TabIndex = 0;
            // 
            // topRightPanel
            // 
            this.topRightPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topRightPanel.AutoSize = true;
            this.topRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topRightPanel.Location = new System.Drawing.Point(64, 13);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Size = new System.Drawing.Size(208, 43);
            this.topRightPanel.TabIndex = 1;
            // 
            // bottomLeftPanel
            // 
            this.bottomLeftPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bottomLeftPanel.AutoSize = true;
            this.bottomLeftPanel.BackColor = System.Drawing.Color.Yellow;
            this.bottomLeftPanel.Location = new System.Drawing.Point(12, 62);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Size = new System.Drawing.Size(45, 188);
            this.bottomLeftPanel.TabIndex = 2;
            // 
            // mainPuzzlePanel
            // 
            this.mainPuzzlePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPuzzlePanel.AutoSize = true;
            this.mainPuzzlePanel.BackColor = System.Drawing.Color.Lime;
            this.mainPuzzlePanel.Location = new System.Drawing.Point(64, 63);
            this.mainPuzzlePanel.Name = "mainPuzzlePanel";
            this.mainPuzzlePanel.Size = new System.Drawing.Size(208, 187);
            this.mainPuzzlePanel.TabIndex = 3;
            // 
            // NonogramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bottomLeftPanel);
            this.Controls.Add(this.topRightPanel);
            this.Controls.Add(this.mainPuzzlePanel);
            this.Controls.Add(this.topLeftPanel);
            this.Name = "NonogramWindow";
            this.Text = "NonogramWindow";
            this.Load += new System.EventHandler(this.NonogramWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Panel topRightPanel;
        private System.Windows.Forms.Panel bottomLeftPanel;
        private System.Windows.Forms.Panel mainPuzzlePanel;
    }
}