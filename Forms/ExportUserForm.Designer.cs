﻿namespace DB_Autoparts_NVA.Forms
{
    partial class ExportUserForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTypeExport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridProductExport = new System.Windows.Forms.DataGridView();
            this.columnIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductExport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Экспорт пользователя";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(35, 8);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(237, 42);
            this.labelFIO.TabIndex = 2;
            this.labelFIO.Text = "Фамилия Имя";
            this.labelFIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(68, 57);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(152, 42);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Телефон";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.comboBoxTypeExport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 104);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxTypeExport
            // 
            this.comboBoxTypeExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeExport.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeExport.FormattingEnabled = true;
            this.comboBoxTypeExport.Location = new System.Drawing.Point(463, 48);
            this.comboBoxTypeExport.Name = "comboBoxTypeExport";
            this.comboBoxTypeExport.Size = new System.Drawing.Size(313, 48);
            this.comboBoxTypeExport.TabIndex = 5;
            this.comboBoxTypeExport.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeExport_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(577, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вид";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridProductExport
            // 
            this.dataGridProductExport.AllowUserToAddRows = false;
            this.dataGridProductExport.AllowUserToDeleteRows = false;
            this.dataGridProductExport.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridProductExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdProduct,
            this.columnIdProducts,
            this.columnCount,
            this.columnPrice,
            this.columnDate,
            this.columnIdUser});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProductExport.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridProductExport.Location = new System.Drawing.Point(0, 147);
            this.dataGridProductExport.MultiSelect = false;
            this.dataGridProductExport.Name = "dataGridProductExport";
            this.dataGridProductExport.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductExport.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridProductExport.Size = new System.Drawing.Size(803, 150);
            this.dataGridProductExport.TabIndex = 5;
            // 
            // columnIdProduct
            // 
            this.columnIdProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdProduct.DataPropertyName = "parts_id";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.columnIdProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnIdProduct.HeaderText = "Id";
            this.columnIdProduct.Name = "columnIdProduct";
            this.columnIdProduct.ReadOnly = true;
            this.columnIdProduct.Width = 41;
            // 
            // columnIdProducts
            // 
            this.columnIdProducts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnIdProducts.DataPropertyName = "NameProduct";
            this.columnIdProducts.HeaderText = "Продукт";
            this.columnIdProducts.Name = "columnIdProducts";
            this.columnIdProducts.ReadOnly = true;
            // 
            // columnCount
            // 
            this.columnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCount.DataPropertyName = "count";
            dataGridViewCellStyle9.NullValue = "0";
            this.columnCount.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnCount.HeaderText = "Кол-во";
            this.columnCount.Name = "columnCount";
            this.columnCount.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPrice.DataPropertyName = "priceAll";
            dataGridViewCellStyle10.NullValue = "0";
            this.columnPrice.DefaultCellStyle = dataGridViewCellStyle10;
            this.columnPrice.HeaderText = "Общая цена";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnDate
            // 
            this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDate.DataPropertyName = "dateBy";
            this.columnDate.HeaderText = "Дата покупки";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // columnIdUser
            // 
            this.columnIdUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnIdUser.DataPropertyName = "id_user";
            this.columnIdUser.HeaderText = "Пользователь";
            this.columnIdUser.Name = "columnIdUser";
            this.columnIdUser.ReadOnly = true;
            this.columnIdUser.Visible = false;
            // 
            // butExport
            // 
            this.butExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butExport.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExport.Location = new System.Drawing.Point(105, 315);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(602, 63);
            this.butExport.TabIndex = 6;
            this.butExport.Text = "Экспортировать";
            this.butExport.UseVisualStyleBackColor = false;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // ExportUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.dataGridProductExport);
            this.Controls.Add(this.butExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ExportUserForm";
            this.Text = "Экспорт товаров пользователя";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxTypeExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridProductExport;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdUser;
    }
}