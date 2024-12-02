namespace lab4
{
    partial class Form1
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
            this.passengerTrainsTable = new System.Windows.Forms.DataGridView();
            this.FreightTrainsTable = new System.Windows.Forms.DataGridView();
            this.buttonAddd = new System.Windows.Forms.Button();
            this.buttonPrimeDel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.passengerTrainsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreightTrainsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.passengerTrainsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.passengerTrainsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengerTrainsTable.Location = new System.Drawing.Point(170, 40);
            this.passengerTrainsTable.Name = "dataGridView1";
            this.passengerTrainsTable.RowTemplate.Height = 28;
            this.passengerTrainsTable.Size = new System.Drawing.Size(670, 382);
            this.passengerTrainsTable.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.FreightTrainsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.FreightTrainsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreightTrainsTable.Location = new System.Drawing.Point(850, 40);
            this.FreightTrainsTable.Name = "dataGridView2";
            this.FreightTrainsTable.RowTemplate.Height = 28;
            this.FreightTrainsTable.Size = new System.Drawing.Size(670, 382);
            this.FreightTrainsTable.TabIndex = 1;
 
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пассажирские поезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(850, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Грузовые поезда";
            // 
            // button1
            // 
            this.buttonAddd.Location = new System.Drawing.Point(15, 5);
            this.buttonAddd.Name = "button1";
            this.buttonAddd.Size = new System.Drawing.Size(126, 50);
            this.buttonAddd.TabIndex = 2;
            this.buttonAddd.Text = "Добавить";
            this.buttonAddd.UseVisualStyleBackColor = true;
            this.buttonAddd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.buttonPrimeDel.Location = new System.Drawing.Point(15, 60);
            this.buttonPrimeDel.Name = "button3";
            this.buttonPrimeDel.Size = new System.Drawing.Size(126, 50);
            this.buttonPrimeDel.TabIndex = 4;
            this.buttonPrimeDel.Text = "Удалить";
            this.buttonPrimeDel.UseVisualStyleBackColor = true;
            this.buttonPrimeDel.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.buttonSearch.Location = new System.Drawing.Point(15, 115);
            this.buttonSearch.Name = "button4";
            this.buttonSearch.Size = new System.Drawing.Size(126, 50);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.buttonFilter.Location = new System.Drawing.Point(15, 170);
            this.buttonFilter.Name = "button5";
            this.buttonFilter.Size = new System.Drawing.Size(126, 50);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Фильтрация";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(16000, 450);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPrimeDel);
            this.Controls.Add(this.buttonAddd);
            this.Controls.Add(this.FreightTrainsTable);
            this.Controls.Add(this.passengerTrainsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengerTrainsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreightTrainsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView passengerTrainsTable;
        private System.Windows.Forms.DataGridView FreightTrainsTable;
        private System.Windows.Forms.Button buttonAddd;
        private System.Windows.Forms.Button buttonPrimeDel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

