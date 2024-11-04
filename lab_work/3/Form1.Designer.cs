namespace SimpleSignal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox outputTextBox;
        private StatusStrip statusStrip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450); // Измените размер формы на 600x400 (или меньше)
            this.Name = "Form1";
            this.Text = "Графики функций f и производной";
            this.ResumeLayout(false);


            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();

            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 350);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(400, 100);
            this.outputTextBox.TabIndex = 1;

            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 450);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";

            // 
            // Form1
            // 
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.statusStrip);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
