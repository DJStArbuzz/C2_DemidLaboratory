namespace lab4
{
    partial class FormSort
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonAuthor;
        private System.Windows.Forms.RadioButton radioButtonPrice;
        private System.Windows.Forms.RadioButton radioButtonYear;
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
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonAuthor = new System.Windows.Forms.RadioButton();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(16, 15);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(202, 20);
            this.radioButtonName.TabIndex = 0;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Сортировать по названию";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuthor
            // 
            this.radioButtonAuthor.AutoSize = true;
            this.radioButtonAuthor.Location = new System.Drawing.Point(16, 45);
            this.radioButtonAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAuthor.Name = "radioButtonAuthor";
            this.radioButtonAuthor.Size = new System.Drawing.Size(192, 20);
            this.radioButtonAuthor.TabIndex = 1;
            this.radioButtonAuthor.TabStop = true;
            this.radioButtonAuthor.Text = "Сортировать по авторам";
            this.radioButtonAuthor.UseVisualStyleBackColor = true;

            this.radioButtonPrice.AutoSize = true;
            this.radioButtonPrice.Location = new System.Drawing.Point(16, 75);
            this.radioButtonPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPrice.Name = "radioButtonName";
            this.radioButtonPrice.Size = new System.Drawing.Size(202, 20);
            this.radioButtonPrice.TabIndex = 2;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "Сортировать по цене";
            this.radioButtonPrice.UseVisualStyleBackColor = true;

            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Location = new System.Drawing.Point(16, 105);
            this.radioButtonYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonYear.Name = "radioButtonAuthor";
            this.radioButtonYear.Size = new System.Drawing.Size(192, 20);
            this.radioButtonYear.TabIndex = 3;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "Сортировать по году издания";
            this.radioButtonYear.UseVisualStyleBackColor = true;

            this.radioButtonPrice.Location = new System.Drawing.Point(16, 71);
            this.radioButtonPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(139, 30);
            this.radioButtonPrice.TabIndex = 4;

            this.radioButtonYear.Location = new System.Drawing.Point(16, 98);
            this.radioButtonYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(139, 30);
            this.radioButtonYear.TabIndex = 5;

            this.buttonSort.Location = new System.Drawing.Point(16, 136);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(100, 28);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 177);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.radioButtonAuthor);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.radioButtonPrice);
            this.Controls.Add(this.radioButtonYear);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Сортировка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}