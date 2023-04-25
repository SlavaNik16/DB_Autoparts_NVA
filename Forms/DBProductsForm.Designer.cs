namespace DB_Autoparts_NVA.Forms
{
    partial class DBProductsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSort = new System.Windows.Forms.Button();
            this.radioDeOrder = new System.Windows.Forms.RadioButton();
            this.radioOrder = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butViewAll = new System.Windows.Forms.Button();
            this.butFiltr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSort);
            this.groupBox1.Controls.Add(this.radioDeOrder);
            this.groupBox1.Controls.Add(this.radioOrder);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(587, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 287);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // butSort
            // 
            this.butSort.BackColor = System.Drawing.Color.Yellow;
            this.butSort.Enabled = false;
            this.butSort.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSort.Location = new System.Drawing.Point(9, 250);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(192, 25);
            this.butSort.TabIndex = 4;
            this.butSort.Text = "Сортировать";
            this.butSort.UseVisualStyleBackColor = false;
            // 
            // radioDeOrder
            // 
            this.radioDeOrder.AutoSize = true;
            this.radioDeOrder.Location = new System.Drawing.Point(9, 221);
            this.radioDeOrder.Name = "radioDeOrder";
            this.radioDeOrder.Size = new System.Drawing.Size(154, 17);
            this.radioDeOrder.TabIndex = 3;
            this.radioDeOrder.Text = "Сортировка по убыванию";
            this.radioDeOrder.UseVisualStyleBackColor = true;
            // 
            // radioOrder
            // 
            this.radioOrder.AutoSize = true;
            this.radioOrder.Checked = true;
            this.radioOrder.Location = new System.Drawing.Point(9, 198);
            this.radioOrder.Name = "radioOrder";
            this.radioOrder.Size = new System.Drawing.Size(170, 17);
            this.radioOrder.TabIndex = 2;
            this.radioOrder.TabStop = true;
            this.radioOrder.Text = "Сортировка по возрастанию";
            this.radioOrder.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "Наименование",
            "Цена",
            "Количество",
            "Оценка",
            "Описание"});
            this.listBox.Location = new System.Drawing.Point(9, 32);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(192, 160);
            this.listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поле для сортировки";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(-1, 1);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.Size = new System.Drawing.Size(588, 287);
            this.dataGridViewProduct.TabIndex = 14;
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(121, 325);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(328, 21);
            this.comboName.TabIndex = 23;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(121, 368);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(328, 20);
            this.searchBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Назначение";
            // 
            // butClose
            // 
            this.butClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClose.Location = new System.Drawing.Point(587, 359);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(196, 36);
            this.butClose.TabIndex = 20;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSearch.Location = new System.Drawing.Point(455, 359);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(97, 36);
            this.butSearch.TabIndex = 19;
            this.butSearch.Text = "Найти";
            this.butSearch.UseVisualStyleBackColor = false;
            // 
            // butViewAll
            // 
            this.butViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butViewAll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butViewAll.Location = new System.Drawing.Point(587, 316);
            this.butViewAll.Name = "butViewAll";
            this.butViewAll.Size = new System.Drawing.Size(196, 36);
            this.butViewAll.TabIndex = 18;
            this.butViewAll.Text = "Показать все";
            this.butViewAll.UseVisualStyleBackColor = false;
            // 
            // butFiltr
            // 
            this.butFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butFiltr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butFiltr.Location = new System.Drawing.Point(455, 316);
            this.butFiltr.Name = "butFiltr";
            this.butFiltr.Size = new System.Drawing.Size(97, 36);
            this.butFiltr.TabIndex = 17;
            this.butFiltr.Text = "Фильтровать";
            this.butFiltr.UseVisualStyleBackColor = false;
            // 
            // DBProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 398);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butViewAll);
            this.Controls.Add(this.butFiltr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DBProductsForm";
            this.Text = "Полозователи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.RadioButton radioDeOrder;
        private System.Windows.Forms.RadioButton radioOrder;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butViewAll;
        private System.Windows.Forms.Button butFiltr;
    }
}