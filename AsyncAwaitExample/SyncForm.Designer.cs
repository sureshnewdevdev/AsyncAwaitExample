namespace AsyncAwaitExample
{
    partial class SyncForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button fetchDataButton;
        private System.Windows.Forms.TextBox resultTextBox;

        private void InitializeComponent()
        {
            this.fetchDataButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fetchDataButton
            // 
            this.fetchDataButton.Location = new System.Drawing.Point(12, 12);
            this.fetchDataButton.Name = "fetchDataButton";
            this.fetchDataButton.Size = new System.Drawing.Size(75, 23);
            this.fetchDataButton.TabIndex = 0;
            this.fetchDataButton.Text = "Fetch Data";
            this.fetchDataButton.UseVisualStyleBackColor = true;
            this.fetchDataButton.Click += new System.EventHandler(this.fetchDataButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 41);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(776, 397);
            this.resultTextBox.TabIndex = 1;
            // 
            // SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.fetchDataButton);
            this.Name = "SyncForm";
            this.Text = "SyncForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
