namespace lab4
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicturesTable = new System.Windows.Forms.DataGridView();
            this.BooksTable = new System.Windows.Forms.DataGridView();
            this.buttonAddd = new System.Windows.Forms.Button();
            this.buttonPrimeDel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicturesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PicturesTable
            // 
            this.PicturesTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PicturesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PicturesTable.Location = new System.Drawing.Point(151, 32);
            this.PicturesTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicturesTable.Name = "PicturesTable";
            this.PicturesTable.RowHeadersWidth = 51;
            this.PicturesTable.RowTemplate.Height = 28;
            this.PicturesTable.Size = new System.Drawing.Size(744, 306);
            this.PicturesTable.TabIndex = 0;
            // 
            // BooksTable
            // 
            this.BooksTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.BooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksTable.Location = new System.Drawing.Point(151, 380);
            this.BooksTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BooksTable.Name = "BooksTable";
            this.BooksTable.RowHeadersWidth = 51;
            this.BooksTable.RowTemplate.Height = 28;
            this.BooksTable.Size = new System.Drawing.Size(744, 306);
            this.BooksTable.TabIndex = 1;
            // 
            // buttonAddd
            // 
            this.buttonAddd.Location = new System.Drawing.Point(12, 32);
            this.buttonAddd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddd.Name = "buttonAddd";
            this.buttonAddd.Size = new System.Drawing.Size(133, 73);
            this.buttonAddd.TabIndex = 2;
            this.buttonAddd.Text = "Добавить";
            this.buttonAddd.UseVisualStyleBackColor = true;
            this.buttonAddd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPrimeDel
            // 
            this.buttonPrimeDel.Location = new System.Drawing.Point(12, 117);
            this.buttonPrimeDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrimeDel.Name = "buttonPrimeDel";
            this.buttonPrimeDel.Size = new System.Drawing.Size(133, 73);
            this.buttonPrimeDel.TabIndex = 4;
            this.buttonPrimeDel.Text = "Удалить";
            this.buttonPrimeDel.UseVisualStyleBackColor = true;
            this.buttonPrimeDel.Click += new System.EventHandler(this.buttonPrimeDel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 204);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(133, 73);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(12, 295);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(133, 73);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Сортировка";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Картины";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 697);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPrimeDel);
            this.Controls.Add(this.buttonAddd);
            this.Controls.Add(this.BooksTable);
            this.Controls.Add(this.PicturesTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicturesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PicturesTable;
        private System.Windows.Forms.DataGridView BooksTable;
        private System.Windows.Forms.Button buttonAddd;
        private System.Windows.Forms.Button buttonPrimeDel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

