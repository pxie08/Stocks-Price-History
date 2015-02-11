namespace q519
{
    partial class q519
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
            this.webAddyTextBox = new System.Windows.Forms.TextBox();
            this.dataButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceMaxLabel = new System.Windows.Forms.Label();
            this.priceMaxMidLabel = new System.Windows.Forms.Label();
            this.priceMinMidLabel = new System.Windows.Forms.Label();
            this.priceMinLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.yearMinLabel = new System.Windows.Forms.Label();
            this.yearMinMidLabel = new System.Windows.Forms.Label();
            this.yearMaxMidLabel = new System.Windows.Forms.Label();
            this.yearMaxLabel = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webAddyTextBox
            // 
            this.webAddyTextBox.Location = new System.Drawing.Point(12, 376);
            this.webAddyTextBox.Name = "webAddyTextBox";
            this.webAddyTextBox.Size = new System.Drawing.Size(326, 20);
            this.webAddyTextBox.TabIndex = 0;
            // 
            // dataButton
            // 
            this.dataButton.Location = new System.Drawing.Point(344, 376);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(132, 23);
            this.dataButton.TabIndex = 1;
            this.dataButton.Text = "Look Up Data + Graph";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.titleLabel.Location = new System.Drawing.Point(213, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 18);
            this.titleLabel.TabIndex = 2;
            // 
            // priceMaxLabel
            // 
            this.priceMaxLabel.AutoSize = true;
            this.priceMaxLabel.Location = new System.Drawing.Point(4, 25);
            this.priceMaxLabel.Name = "priceMaxLabel";
            this.priceMaxLabel.Size = new System.Drawing.Size(0, 13);
            this.priceMaxLabel.TabIndex = 3;
            // 
            // priceMaxMidLabel
            // 
            this.priceMaxMidLabel.AutoSize = true;
            this.priceMaxMidLabel.Location = new System.Drawing.Point(4, 125);
            this.priceMaxMidLabel.Name = "priceMaxMidLabel";
            this.priceMaxMidLabel.Size = new System.Drawing.Size(0, 13);
            this.priceMaxMidLabel.TabIndex = 4;
            // 
            // priceMinMidLabel
            // 
            this.priceMinMidLabel.AutoSize = true;
            this.priceMinMidLabel.Location = new System.Drawing.Point(4, 225);
            this.priceMinMidLabel.Name = "priceMinMidLabel";
            this.priceMinMidLabel.Size = new System.Drawing.Size(0, 13);
            this.priceMinMidLabel.TabIndex = 5;
            // 
            // priceMinLabel
            // 
            this.priceMinLabel.AutoSize = true;
            this.priceMinLabel.Location = new System.Drawing.Point(4, 325);
            this.priceMinLabel.Name = "priceMinLabel";
            this.priceMinLabel.Size = new System.Drawing.Size(0, 13);
            this.priceMinLabel.TabIndex = 6;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(4, 9);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 7;
            this.price.Text = "Price";
            // 
            // yearMinLabel
            // 
            this.yearMinLabel.AutoSize = true;
            this.yearMinLabel.Location = new System.Drawing.Point(50, 330);
            this.yearMinLabel.Name = "yearMinLabel";
            this.yearMinLabel.Size = new System.Drawing.Size(0, 13);
            this.yearMinLabel.TabIndex = 8;
            // 
            // yearMinMidLabel
            // 
            this.yearMinMidLabel.AutoSize = true;
            this.yearMinMidLabel.Location = new System.Drawing.Point(213, 330);
            this.yearMinMidLabel.Name = "yearMinMidLabel";
            this.yearMinMidLabel.Size = new System.Drawing.Size(0, 13);
            this.yearMinMidLabel.TabIndex = 9;
            // 
            // yearMaxMidLabel
            // 
            this.yearMaxMidLabel.AutoSize = true;
            this.yearMaxMidLabel.Location = new System.Drawing.Point(382, 330);
            this.yearMaxMidLabel.Name = "yearMaxMidLabel";
            this.yearMaxMidLabel.Size = new System.Drawing.Size(0, 13);
            this.yearMaxMidLabel.TabIndex = 10;
            // 
            // yearMaxLabel
            // 
            this.yearMaxLabel.AutoSize = true;
            this.yearMaxLabel.Location = new System.Drawing.Point(525, 330);
            this.yearMaxLabel.Name = "yearMaxLabel";
            this.yearMaxLabel.Size = new System.Drawing.Size(0, 13);
            this.yearMaxLabel.TabIndex = 11;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(531, 354);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 12;
            this.Year.Text = "Year";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(482, 376);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // q519
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 408);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.yearMaxLabel);
            this.Controls.Add(this.yearMaxMidLabel);
            this.Controls.Add(this.yearMinMidLabel);
            this.Controls.Add(this.yearMinLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceMinLabel);
            this.Controls.Add(this.priceMinMidLabel);
            this.Controls.Add(this.priceMaxMidLabel);
            this.Controls.Add(this.priceMaxLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dataButton);
            this.Controls.Add(this.webAddyTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "q519";
            this.Text = "Quest 519 -- Patrick Xie";
            this.Load += new System.EventHandler(this.q519_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.q519_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox webAddyTextBox;
        private System.Windows.Forms.Button dataButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label priceMaxLabel;
        private System.Windows.Forms.Label priceMaxMidLabel;
        private System.Windows.Forms.Label priceMinMidLabel;
        private System.Windows.Forms.Label priceMinLabel;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label yearMinLabel;
        private System.Windows.Forms.Label yearMinMidLabel;
        private System.Windows.Forms.Label yearMaxMidLabel;
        private System.Windows.Forms.Label yearMaxLabel;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Button clearButton;
    }
}

