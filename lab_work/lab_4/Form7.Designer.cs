namespace lab4
{
    partial class Form7
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
            this.labelTrainNumber = new System.Windows.Forms.Label();
            this.textBoxTrainNumber = new System.Windows.Forms.TextBox();

            this.labelCapacity = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();

            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();

            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // labelTrainNumber
            // 
            this.labelTrainNumber.AutoSize = true;
            this.labelTrainNumber.Location = new System.Drawing.Point(12, 15);
            this.labelTrainNumber.Name = "labelTrainNumber";
            this.labelTrainNumber.Size = new System.Drawing.Size(80, 15);
            this.labelTrainNumber.TabIndex = 0;
            this.labelTrainNumber.Text = "Номер поезда:";

            // 
            // textBoxTrainNumber
            // 
            this.textBoxTrainNumber.Location = new System.Drawing.Point(150, 12);
            this.textBoxTrainNumber.Name = "textBoxTrainNumber";
            this.textBoxTrainNumber.Size = new System.Drawing.Size(200, 23);
            this.textBoxTrainNumber.TabIndex = 1;

            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(12, 48);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(66, 15);
            this.labelCapacity.TabIndex = 8;
            this.labelCapacity.Text = "Вместимость:";

            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(150, 45);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(200, 23);
            this.textBoxCapacity.TabIndex = 9;

            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 81);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(78, 15);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Год выпуска:";

            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(150, 78);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 23);
            this.textBoxYear.TabIndex = 11;

            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 114);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(37, 15);
            this.labelColor.TabIndex = 12;
            this.labelColor.Text = "Цвет:";

            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(150, 111);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(200, 23);
            this.textBoxColor.TabIndex = 13;

            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(15, 144);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(105, 19);
            this.checkBoxDelete.TabIndex = 16;
            this.checkBoxDelete.Text = "Удалить поезд";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);

            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(150, 177);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 17;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);

            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 210);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.labelCapacity);

            this.Controls.Add(this.textBoxTrainNumber);
            this.Controls.Add(this.labelTrainNumber);
            this.Name = "Form7";
            this.Text = "Редактирование поезда";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTrainNumber;
        private System.Windows.Forms.TextBox textBoxTrainNumber;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Button buttonConfirm;
    }
}
