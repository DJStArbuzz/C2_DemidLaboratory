namespace lab4
{
    partial class FormBookEditDel
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelNumOfPages = new System.Windows.Forms.Label();
            this.textBoxNumOfPages = new System.Windows.Forms.TextBox();
            this.labelCirculation = new System.Windows.Forms.Label();
            this.textBoxCirculation = new System.Windows.Forms.TextBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(170, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(15, 50);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(50, 16);
            this.labelAuthor.TabIndex = 8;
            this.labelAuthor.Text = "Автор:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(170, 50);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(228, 22);
            this.textBoxAuthor.TabIndex = 9;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(15, 85);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 16);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(170, 85);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(228, 22);
            this.textBoxPrice.TabIndex = 11;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(15, 120);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(91, 16);
            this.labelYear.TabIndex = 12;
            this.labelYear.Text = "Год издания:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(170, 120);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(228, 22);
            this.textBoxYear.TabIndex = 13;
            // 
            // labelNumOfPages
            // 
            this.labelNumOfPages.AutoSize = true;
            this.labelNumOfPages.Location = new System.Drawing.Point(15, 155);
            this.labelNumOfPages.Name = "labelNumOfPages";
            this.labelNumOfPages.Size = new System.Drawing.Size(111, 16);
            this.labelNumOfPages.TabIndex = 14;
            this.labelNumOfPages.Text = "Кол-во страниц:";
            // 
            // textBoxNumOfPages
            // 
            this.textBoxNumOfPages.Location = new System.Drawing.Point(170, 155);
            this.textBoxNumOfPages.Name = "textBoxNumOfPages";
            this.textBoxNumOfPages.Size = new System.Drawing.Size(228, 22);
            this.textBoxNumOfPages.TabIndex = 15;
            // 
            // labelCirculation
            // 
            this.labelCirculation.AutoSize = true;
            this.labelCirculation.Location = new System.Drawing.Point(15, 190);
            this.labelCirculation.Name = "labelCirculation";
            this.labelCirculation.Size = new System.Drawing.Size(52, 16);
            this.labelCirculation.TabIndex = 16;
            this.labelCirculation.Text = "Тираж:";
            // 
            // textBoxCirculation
            // 
            this.textBoxCirculation.Location = new System.Drawing.Point(170, 190);
            this.textBoxCirculation.Name = "textBoxCirculation";
            this.textBoxCirculation.Size = new System.Drawing.Size(228, 22);
            this.textBoxCirculation.TabIndex = 17;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(15, 225);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(127, 20);
            this.checkBoxDelete.TabIndex = 18;
            this.checkBoxDelete.Text = "Удалить поезд";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(170, 225);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(86, 25);
            this.buttonConfirm.TabIndex = 19;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormBookEditDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 255);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNumOfPages);
            this.Controls.Add(this.labelNumOfPages);
            this.Controls.Add(this.textBoxCirculation);
            this.Controls.Add(this.labelCirculation);
            this.Name = "FormBookEditDel";
            this.Text = "Редактирование поезда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;

        private System.Windows.Forms.Label labelNumOfPages;
        private System.Windows.Forms.TextBox textBoxNumOfPages;
        private System.Windows.Forms.Label labelCirculation;
        private System.Windows.Forms.TextBox textBoxCirculation;

        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Button buttonConfirm;
    }
}
