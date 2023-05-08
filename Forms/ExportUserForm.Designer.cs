namespace DB_Autoparts_NVA.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeExport = new System.Windows.Forms.ComboBox();
            this.dataGridProductExport = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.columnIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.comboBoxTypeExport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 104);
            this.panel1.TabIndex = 4;
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
            // comboBoxTypeExport
            // 
            this.comboBoxTypeExport.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeExport.FormattingEnabled = true;
            this.comboBoxTypeExport.Location = new System.Drawing.Point(463, 48);
            this.comboBoxTypeExport.Name = "comboBoxTypeExport";
            this.comboBoxTypeExport.Size = new System.Drawing.Size(313, 48);
            this.comboBoxTypeExport.TabIndex = 5;
            // 
            // dataGridProductExport
            // 
            this.dataGridProductExport.AllowUserToAddRows = false;
            this.dataGridProductExport.AllowUserToDeleteRows = false;
            this.dataGridProductExport.AllowUserToResizeRows = false;
            this.dataGridProductExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdProduct,
            this.columnIdProducts,
            this.columnCount,
            this.columnPrice,
            this.columnDate,
            this.columnIdUser});
            this.dataGridProductExport.Location = new System.Drawing.Point(0, 147);
            this.dataGridProductExport.MultiSelect = false;
            this.dataGridProductExport.Name = "dataGridProductExport";
            this.dataGridProductExport.ReadOnly = true;
            this.dataGridProductExport.Size = new System.Drawing.Size(803, 142);
            this.dataGridProductExport.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(106, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(602, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Экспортировать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // columnIdProduct
            // 
            this.columnIdProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdProduct.DataPropertyName = "parts_id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.columnIdProduct.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.NullValue = "0";
            this.columnCount.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnCount.HeaderText = "Кол-во";
            this.columnCount.Name = "columnCount";
            this.columnCount.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPrice.DataPropertyName = "priceAll";
            dataGridViewCellStyle6.NullValue = "0";
            this.columnPrice.DefaultCellStyle = dataGridViewCellStyle6;
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
            // ExportUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.dataGridProductExport);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdUser;
    }
}