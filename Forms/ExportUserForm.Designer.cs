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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTypeExport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butExport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(223, 3);
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
            this.comboBoxTypeExport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeExport.FormattingEnabled = true;
            this.comboBoxTypeExport.Location = new System.Drawing.Point(462, 57);
            this.comboBoxTypeExport.Name = "comboBoxTypeExport";
            this.comboBoxTypeExport.Size = new System.Drawing.Size(313, 31);
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
            // butExport
            // 
            this.butExport.BackColor = System.Drawing.Color.Goldenrod;
            this.butExport.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExport.Location = new System.Drawing.Point(99, 12);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(602, 63);
            this.butExport.TabIndex = 6;
            this.butExport.Text = "Экспортировать";
            this.butExport.UseVisualStyleBackColor = false;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Controls.Add(this.butExport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 85);
            this.panel3.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-3, 147);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 150);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Продукт";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Кол-во";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Общая цена";
            this.columnHeader4.Width = 176;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата покупки";
            this.columnHeader5.Width = 178;
            // 
            // ExportUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ExportUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспорт товаров пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExportUserForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxTypeExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}