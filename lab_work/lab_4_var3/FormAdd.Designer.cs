namespace lab4
{
    partial class FormAdd
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelCirculation = new System.Windows.Forms.Label();
            this.labelNumOfPages = new System.Windows.Forms.Label();
            this.radioButtonPicture = new System.Windows.Forms.RadioButton();
            this.radioButtonBook = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaterial_NumOfPages = new System.Windows.Forms.TextBox();
            this.textBoxCirculation = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(30, 100);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 16);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Автор";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(30, 130);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 16);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(30, 160);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(88, 16);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Год выпуска";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(30, 190);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(73, 16);
            this.labelMaterial.TabIndex = 4;
            this.labelMaterial.Text = "Материал";
            // 
            // labelCirculation
            // 
            this.labelCirculation.AutoSize = true;
            this.labelCirculation.Location = new System.Drawing.Point(30, 220);
            this.labelCirculation.Name = "labelCirculation";
            this.labelCirculation.Size = new System.Drawing.Size(49, 16);
            this.labelCirculation.TabIndex = 5;
            this.labelCirculation.Text = "Тираж";
            // 
            // labelNumOfPages
            // 
            this.labelNumOfPages.AutoSize = true;
            this.labelNumOfPages.Location = new System.Drawing.Point(30, 190);
            this.labelNumOfPages.Name = "labelNumOfPages";
            this.labelNumOfPages.Size = new System.Drawing.Size(76, 16);
            this.labelNumOfPages.TabIndex = 5;
            this.labelNumOfPages.Text = "Кол-во стр";
            // 
            // radioButtonPicture
            // 
            this.radioButtonPicture.AutoSize = true;
            this.radioButtonPicture.Location = new System.Drawing.Point(160, 30);
            this.radioButtonPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPicture.Name = "radioButtonPicture";
            this.radioButtonPicture.Size = new System.Drawing.Size(83, 20);
            this.radioButtonPicture.TabIndex = 8;
            this.radioButtonPicture.TabStop = true;
            this.radioButtonPicture.Text = "Картина";
            this.radioButtonPicture.UseVisualStyleBackColor = true;
            this.radioButtonPicture.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonBook
            // 
            this.radioButtonBook.AutoSize = true;
            this.radioButtonBook.Location = new System.Drawing.Point(249, 30);
            this.radioButtonBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBook.Name = "radioButtonBook";
            this.radioButtonBook.Size = new System.Drawing.Size(66, 20);
            this.radioButtonBook.TabIndex = 9;
            this.radioButtonBook.TabStop = true;
            this.radioButtonBook.Text = "Книга";
            this.radioButtonBook.UseVisualStyleBackColor = true;
            this.radioButtonBook.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Тип произведения";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(145, 70);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(89, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(145, 100);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(89, 22);
            this.textBoxAuthor.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(145, 130);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(89, 22);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxMaterial_NumOfPages
            // 
            this.textBoxMaterial_NumOfPages.Location = new System.Drawing.Point(145, 190);
            this.textBoxMaterial_NumOfPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaterial_NumOfPages.Name = "textBoxMaterial_NumOfPages";
            this.textBoxMaterial_NumOfPages.Size = new System.Drawing.Size(89, 22);
            this.textBoxMaterial_NumOfPages.TabIndex = 15;
            // 
            // textBoxCirculation
            // 
            this.textBoxCirculation.Location = new System.Drawing.Point(145, 220);
            this.textBoxCirculation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCirculation.Name = "textBoxCirculation";
            this.textBoxCirculation.Size = new System.Drawing.Size(89, 22);
            this.textBoxCirculation.TabIndex = 16;
            this.textBoxCirculation.Text = "0";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(145, 160);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(89, 22);
            this.textBoxYear.TabIndex = 14;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(33, 254);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 45);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 311);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxMaterial_NumOfPages);
            this.Controls.Add(this.textBoxCirculation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButtonBook);
            this.Controls.Add(this.radioButtonPicture);
            this.Controls.Add(this.labelNumOfPages);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelCirculation);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAdd";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelNumOfPages;
        private System.Windows.Forms.Label labelCirculation;

        private System.Windows.Forms.RadioButton radioButtonPicture;
        private System.Windows.Forms.RadioButton radioButtonBook;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMaterial_NumOfPages;
        private System.Windows.Forms.TextBox textBoxCirculation;

        private System.Windows.Forms.Button buttonAdd;
    }
}