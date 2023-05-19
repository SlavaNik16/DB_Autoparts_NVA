namespace DB_Autoparts_NVA.Forms
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.label1 = new System.Windows.Forms.Label();
            this.butСancel = new System.Windows.Forms.Button();
            this.butAddProduct = new System.Windows.Forms.Button();
            this.txtBoxPriceOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxBack = new System.Windows.Forms.GroupBox();
            this.groupBoxBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление продукта";
            // 
            // butСancel
            // 
            this.butСancel.BackColor = System.Drawing.Color.Silver;
            this.butСancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butСancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butСancel.Location = new System.Drawing.Point(306, 168);
            this.butСancel.Name = "butСancel";
            this.butСancel.Size = new System.Drawing.Size(153, 40);
            this.butСancel.TabIndex = 6;
            this.butСancel.Text = "Отменить";
            this.butСancel.UseVisualStyleBackColor = false;
            this.butСancel.Click += new System.EventHandler(this.butСancel_Click);
            // 
            // butAddProduct
            // 
            this.butAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butAddProduct.Enabled = false;
            this.butAddProduct.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAddProduct.Location = new System.Drawing.Point(12, 168);
            this.butAddProduct.Name = "butAddProduct";
            this.butAddProduct.Size = new System.Drawing.Size(153, 40);
            this.butAddProduct.TabIndex = 5;
            this.butAddProduct.Text = "Добавить";
            this.butAddProduct.UseVisualStyleBackColor = false;
            this.butAddProduct.Click += new System.EventHandler(this.butAddProduct_Click);
            // 
            // txtBoxPriceOne
            // 
            this.txtBoxPriceOne.Location = new System.Drawing.Point(163, 55);
            this.txtBoxPriceOne.Name = "txtBoxPriceOne";
            this.txtBoxPriceOne.Size = new System.Drawing.Size(274, 20);
            this.txtBoxPriceOne.TabIndex = 4;
            this.txtBoxPriceOne.TextChanged += new System.EventHandler(this.txtBoxPriceOne_TextChanged);
            this.txtBoxPriceOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPriceOne_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена за 1 шт";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(163, 19);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(274, 20);
            this.txtBoxName.TabIndex = 2;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название продукта";
            // 
            // groupBoxBack
            // 
            this.groupBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBack.Controls.Add(this.txtBoxName);
            this.groupBoxBack.Controls.Add(this.label2);
            this.groupBoxBack.Controls.Add(this.label3);
            this.groupBoxBack.Controls.Add(this.txtBoxPriceOne);
            this.groupBoxBack.Location = new System.Drawing.Point(12, 61);
            this.groupBoxBack.Name = "groupBoxBack";
            this.groupBoxBack.Size = new System.Drawing.Size(443, 92);
            this.groupBoxBack.TabIndex = 7;
            this.groupBoxBack.TabStop = false;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 216);
            this.Controls.Add(this.groupBoxBack);
            this.Controls.Add(this.butСancel);
            this.Controls.Add(this.butAddProduct);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление продукта";
            this.groupBoxBack.ResumeLayout(false);
            this.groupBoxBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butСancel;
        private System.Windows.Forms.Button butAddProduct;
        private System.Windows.Forms.TextBox txtBoxPriceOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxBack;
    }
}