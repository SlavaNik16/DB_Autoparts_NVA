﻿namespace DB_Autoparts_NVA.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSort = new System.Windows.Forms.Button();
            this.radioDeOrder = new System.Windows.Forms.RadioButton();
            this.radioOrder = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTovar = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butViewAll = new System.Windows.Forms.Button();
            this.butFiltr = new System.Windows.Forms.Button();
            this.dataGridProductDB = new System.Windows.Forms.DataGridView();
            this.columnIdProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdProductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDB)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSort);
            this.groupBox1.Controls.Add(this.radioDeOrder);
            this.groupBox1.Controls.Add(this.radioOrder);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(587, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 276);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // butSort
            // 
            this.butSort.BackColor = System.Drawing.Color.Yellow;
            this.butSort.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSort.Location = new System.Drawing.Point(9, 250);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(192, 25);
            this.butSort.TabIndex = 4;
            this.butSort.Text = "Сортировать";
            this.butSort.UseVisualStyleBackColor = false;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
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
            "Id",
            "Фамилия пользователя",
            "Наименование продукта",
            "Количество",
            "Общая цена",
            "Дата покупки"});
            this.listBox.Location = new System.Drawing.Point(11, 32);
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
            // comboTovar
            // 
            this.comboTovar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTovar.FormattingEnabled = true;
            this.comboTovar.Location = new System.Drawing.Point(205, 303);
            this.comboTovar.Name = "comboTovar";
            this.comboTovar.Size = new System.Drawing.Size(252, 21);
            this.comboTovar.TabIndex = 39;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(205, 346);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(252, 20);
            this.searchBox.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Поиск пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Фильтрация товара";
            // 
            // butClose
            // 
            this.butClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClose.Location = new System.Drawing.Point(595, 337);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(196, 36);
            this.butClose.TabIndex = 36;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click_1);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSearch.Location = new System.Drawing.Point(463, 337);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(97, 36);
            this.butSearch.TabIndex = 35;
            this.butSearch.Text = "Найти";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butViewAll
            // 
            this.butViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butViewAll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butViewAll.Location = new System.Drawing.Point(595, 294);
            this.butViewAll.Name = "butViewAll";
            this.butViewAll.Size = new System.Drawing.Size(196, 36);
            this.butViewAll.TabIndex = 34;
            this.butViewAll.Text = "Показать все";
            this.butViewAll.UseVisualStyleBackColor = false;
            this.butViewAll.Click += new System.EventHandler(this.butViewAll_Click);
            // 
            // butFiltr
            // 
            this.butFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butFiltr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butFiltr.Location = new System.Drawing.Point(463, 294);
            this.butFiltr.Name = "butFiltr";
            this.butFiltr.Size = new System.Drawing.Size(97, 36);
            this.butFiltr.TabIndex = 33;
            this.butFiltr.Text = "Фильтровать";
            this.butFiltr.UseVisualStyleBackColor = false;
            this.butFiltr.Click += new System.EventHandler(this.butFiltr_Click);
            // 
            // dataGridProductDB
            // 
            this.dataGridProductDB.AllowUserToAddRows = false;
            this.dataGridProductDB.AllowUserToDeleteRows = false;
            this.dataGridProductDB.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridProductDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdProductDataGridViewTextBoxColumn,
            this.columnIdUserDataGridViewTextBoxColumn,
            this.columnIdProductsDataGridViewTextBoxColumn,
            this.columnCountDataGridViewTextBoxColumn,
            this.columnPriceDataGridViewTextBoxColumn,
            this.columnDateDataGridViewTextBoxColumn,
            this.columnIdUser});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProductDB.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridProductDB.Location = new System.Drawing.Point(12, 12);
            this.dataGridProductDB.MultiSelect = false;
            this.dataGridProductDB.Name = "dataGridProductDB";
            this.dataGridProductDB.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridProductDB.Size = new System.Drawing.Size(569, 276);
            this.dataGridProductDB.TabIndex = 44;
            // 
            // columnIdProductDataGridViewTextBoxColumn
            // 
            this.columnIdProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdProductDataGridViewTextBoxColumn.DataPropertyName = "parts_id";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.columnIdProductDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.columnIdProductDataGridViewTextBoxColumn.HeaderText = "Id";
            this.columnIdProductDataGridViewTextBoxColumn.Name = "columnIdProductDataGridViewTextBoxColumn";
            this.columnIdProductDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnIdProductDataGridViewTextBoxColumn.Width = 41;
            // 
            // columnIdUserDataGridViewTextBoxColumn
            // 
            this.columnIdUserDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnIdUserDataGridViewTextBoxColumn.DataPropertyName = "UserSurname";
            this.columnIdUserDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.columnIdUserDataGridViewTextBoxColumn.Name = "columnIdUserDataGridViewTextBoxColumn";
            this.columnIdUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnIdProductsDataGridViewTextBoxColumn
            // 
            this.columnIdProductsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnIdProductsDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            this.columnIdProductsDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.columnIdProductsDataGridViewTextBoxColumn.Name = "columnIdProductsDataGridViewTextBoxColumn";
            this.columnIdProductsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnCountDataGridViewTextBoxColumn
            // 
            this.columnCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnCountDataGridViewTextBoxColumn.DataPropertyName = "count";
            dataGridViewCellStyle27.NullValue = "0";
            this.columnCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.columnCountDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.columnCountDataGridViewTextBoxColumn.Name = "columnCountDataGridViewTextBoxColumn";
            this.columnCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnCountDataGridViewTextBoxColumn.Width = 66;
            // 
            // columnPriceDataGridViewTextBoxColumn
            // 
            this.columnPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnPriceDataGridViewTextBoxColumn.DataPropertyName = "PriceAll";
            dataGridViewCellStyle28.NullValue = "0";
            this.columnPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle28;
            this.columnPriceDataGridViewTextBoxColumn.HeaderText = "Общая цена";
            this.columnPriceDataGridViewTextBoxColumn.Name = "columnPriceDataGridViewTextBoxColumn";
            this.columnPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnPriceDataGridViewTextBoxColumn.Width = 94;
            // 
            // columnDateDataGridViewTextBoxColumn
            // 
            this.columnDateDataGridViewTextBoxColumn.DataPropertyName = "dateBy";
            this.columnDateDataGridViewTextBoxColumn.HeaderText = "Дата покупки";
            this.columnDateDataGridViewTextBoxColumn.Name = "columnDateDataGridViewTextBoxColumn";
            this.columnDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnDateDataGridViewTextBoxColumn.Width = 119;
            // 
            // columnIdUser
            // 
            this.columnIdUser.DataPropertyName = "Id_user";
            this.columnIdUser.HeaderText = "Id_user";
            this.columnIdUser.Name = "columnIdUser";
            this.columnIdUser.ReadOnly = true;
            this.columnIdUser.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(550, 16);
            // 
            // DBProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridProductDB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.butFiltr);
            this.Controls.Add(this.comboTovar);
            this.Controls.Add(this.butViewAll);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DBProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукты";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductDB)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboTovar;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butViewAll;
        private System.Windows.Forms.Button butFiltr;
        private System.Windows.Forms.DataGridView dataGridProductDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}