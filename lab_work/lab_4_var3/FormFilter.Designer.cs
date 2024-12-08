namespace lab4
{
    partial class FormFilter
    {
        private System.ComponentModel.IContainer components = null;

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
            this.checkBoxBooks = new System.Windows.Forms.CheckBox();
            this.checkBoxPictures = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.radioButtonByName = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.radioButtonByAuthor = new System.Windows.Forms.RadioButton();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.checkBoxPictures.AutoSize = true;
            this.checkBoxPictures.Location = new System.Drawing.Point(15, 15);
            this.checkBoxPictures.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPictures.Name = "checkBoxPictures";
            this.checkBoxPictures.Size = new System.Drawing.Size(85, 20);
            this.checkBoxPictures.TabIndex = 1;
            this.checkBoxPictures.Text = "Картины";
            this.checkBoxPictures.UseVisualStyleBackColor = true;

            this.checkBoxBooks.AutoSize = true;
            this.checkBoxBooks.Location = new System.Drawing.Point(15, 45);
            this.checkBoxBooks.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxBooks.Name = "checkBoxBooks";
            this.checkBoxBooks.Size = new System.Drawing.Size(67, 20);
            this.checkBoxBooks.TabIndex = 0;
            this.checkBoxBooks.Text = "Книги";
            this.checkBoxBooks.UseVisualStyleBackColor = true;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите значение:";

            this.textBoxInput.Location = new System.Drawing.Point(15, 115);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(238, 22);
            this.textBoxInput.TabIndex = 3;

            this.radioButtonByName.AutoSize = true;
            this.radioButtonByName.Location = new System.Drawing.Point(15, 150);
            this.radioButtonByName.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonByName.Name = "radioButtonByName";
            this.radioButtonByName.Size = new System.Drawing.Size(115, 20);
            this.radioButtonByName.TabIndex = 4;
            this.radioButtonByName.Text = "По названию";
            this.radioButtonByName.UseVisualStyleBackColor = true;

            this.buttonReset.Location = new System.Drawing.Point(140, 200);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(119, 26);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
 
            this.radioButtonByAuthor.AutoSize = true;
            this.radioButtonByAuthor.Location = new System.Drawing.Point(15, 175);
            this.radioButtonByAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonByAuthor.Name = "radioButtonByAuthor";
            this.radioButtonByAuthor.Size = new System.Drawing.Size(96, 20);
            this.radioButtonByAuthor.TabIndex = 5;
            this.radioButtonByAuthor.Text = "По автору";
            this.radioButtonByAuthor.UseVisualStyleBackColor = true;
            
            this.buttonFilter.Location = new System.Drawing.Point(15, 200);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(119, 28);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Фильтровать";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 237);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.radioButtonByAuthor);
            this.Controls.Add(this.radioButtonByName);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPictures);
            this.Controls.Add(this.checkBoxBooks);
            this.Controls.Add(this.buttonReset);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFilter";
            this.Text = "Формирование списка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox checkBoxBooks;
        private System.Windows.Forms.CheckBox checkBoxPictures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.RadioButton radioButtonByName;
        private System.Windows.Forms.RadioButton radioButtonByAuthor;
        private System.Windows.Forms.Button buttonFilter;
    }
}
