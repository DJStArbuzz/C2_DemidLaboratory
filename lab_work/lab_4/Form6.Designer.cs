namespace lab4
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton radioButtonNum;
        private System.Windows.Forms.RadioButton radioButtonSize;
        private System.Windows.Forms.Button buttonSort;

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
            this.radioButtonNum = new System.Windows.Forms.RadioButton();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonNum
            // 
            this.radioButtonNum.AutoSize = true;
            this.radioButtonNum.Location = new System.Drawing.Point(12, 12);
            this.radioButtonNum.Name = "radioButtonNum";
            this.radioButtonNum.Size = new System.Drawing.Size(135, 17);
            this.radioButtonNum.TabIndex = 0;
            this.radioButtonNum.TabStop = true;
            this.radioButtonNum.Text = "Сортировать по номеру";
            this.radioButtonNum.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.AutoSize = true;
            this.radioButtonSize.Location = new System.Drawing.Point(12, 35);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(132, 17);
            this.radioButtonSize.TabIndex = 1;
            this.radioButtonSize.TabStop = true;
            this.radioButtonSize.Text = "Сортировать по размеру";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(12, 58);


            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 111);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonNum);
            this.Name = "Form6";
            this.Text = "Сортировка";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}