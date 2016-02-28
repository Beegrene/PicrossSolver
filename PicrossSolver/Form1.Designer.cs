namespace PicrossSolver
{
    partial class Form1
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
            this.createNonogramButton = new System.Windows.Forms.Button();
            this.numRowsLabel = new System.Windows.Forms.Label();
            this.numColumnsLabel = new System.Windows.Forms.Label();
            this.columnUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.columnUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // createNonogramButton
            // 
            this.createNonogramButton.Location = new System.Drawing.Point(12, 120);
            this.createNonogramButton.Name = "createNonogramButton";
            this.createNonogramButton.Size = new System.Drawing.Size(168, 23);
            this.createNonogramButton.TabIndex = 0;
            this.createNonogramButton.Text = "Create Picross Puzzle";
            this.createNonogramButton.UseVisualStyleBackColor = true;
            this.createNonogramButton.Click += new System.EventHandler(this.createNonogramButton_Click);
            // 
            // numRowsLabel
            // 
            this.numRowsLabel.AutoSize = true;
            this.numRowsLabel.Location = new System.Drawing.Point(44, 69);
            this.numRowsLabel.Name = "numRowsLabel";
            this.numRowsLabel.Size = new System.Drawing.Size(81, 13);
            this.numRowsLabel.TabIndex = 2;
            this.numRowsLabel.Text = "Number of rows";
            // 
            // numColumnsLabel
            // 
            this.numColumnsLabel.AutoSize = true;
            this.numColumnsLabel.Location = new System.Drawing.Point(44, 9);
            this.numColumnsLabel.Name = "numColumnsLabel";
            this.numColumnsLabel.Size = new System.Drawing.Size(98, 13);
            this.numColumnsLabel.TabIndex = 4;
            this.numColumnsLabel.Text = "Number of columns";
            // 
            // columnUpDown
            // 
            this.columnUpDown.Location = new System.Drawing.Point(47, 26);
            this.columnUpDown.Name = "columnUpDown";
            this.columnUpDown.Size = new System.Drawing.Size(95, 20);
            this.columnUpDown.TabIndex = 5;
            // 
            // rowUpDown
            // 
            this.rowUpDown.Location = new System.Drawing.Point(47, 86);
            this.rowUpDown.Name = "rowUpDown";
            this.rowUpDown.Size = new System.Drawing.Size(95, 20);
            this.rowUpDown.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 155);
            this.Controls.Add(this.rowUpDown);
            this.Controls.Add(this.columnUpDown);
            this.Controls.Add(this.createNonogramButton);
            this.Controls.Add(this.numColumnsLabel);
            this.Controls.Add(this.numRowsLabel);
            this.Name = "Form1";
            this.Text = "Picross Solver";
            ((System.ComponentModel.ISupportInitialize)(this.columnUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNonogramButton;
        private System.Windows.Forms.Label numRowsLabel;
        private System.Windows.Forms.Label numColumnsLabel;
        private System.Windows.Forms.NumericUpDown columnUpDown;
        private System.Windows.Forms.NumericUpDown rowUpDown;
    }
}

