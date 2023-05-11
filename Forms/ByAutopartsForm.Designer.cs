namespace DB_Autoparts_NVA.Forms
{
    partial class ByAutopartsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 48F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DB_Autoparts_NVA.Properties.Resources.AutopartsIconNoBacg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бланк оформления\r\nтовара";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.numCount);
            this.panel2.Controls.Add(this.txtBoxPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboProduct);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 186);
            this.panel2.TabIndex = 1;
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.numCount.Location = new System.Drawing.Point(251, 133);
            this.numCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(230, 35);
            this.numCount.TabIndex = 5;
            this.numCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.ValueChanged += new System.EventHandler(this.numCount_ValueChanged);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txtBoxPrice.Location = new System.Drawing.Point(251, 77);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.ReadOnly = true;
            this.txtBoxPrice.Size = new System.Drawing.Size(230, 35);
            this.txtBoxPrice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена за штуку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во";
            // 
            // comboProduct
            // 
            this.comboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(251, 23);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(230, 27);
            this.comboProduct.TabIndex = 1;
            this.comboProduct.SelectedIndexChanged += new System.EventHandler(this.comboProduct_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вид автозапчасти";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.butCancel);
            this.panel3.Controls.Add(this.butSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 61);
            this.panel3.TabIndex = 2;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Silver;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCancel.Location = new System.Drawing.Point(310, 9);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(171, 44);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Отменить";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(25, 9);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(171, 44);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Купить";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // ByAutopartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 347);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ByAutopartsForm";
            this.Text = "ByAutopartsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSave;
    }
}