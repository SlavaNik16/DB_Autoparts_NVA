namespace DB_Autoparts_NVA.Forms
{
    partial class AuthorizationForm
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
            this.butEnter = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butEnter
            // 
            this.butEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butEnter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butEnter.Location = new System.Drawing.Point(97, 22);
            this.butEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(141, 50);
            this.butEnter.TabIndex = 0;
            this.butEnter.Text = "Войти";
            this.butEnter.UseVisualStyleBackColor = false;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // butReg
            // 
            this.butReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butReg.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butReg.Location = new System.Drawing.Point(55, 78);
            this.butReg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(232, 50);
            this.butReg.TabIndex = 1;
            this.butReg.Text = "Зарегистрироваться";
            this.butReg.UseVisualStyleBackColor = false;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butClose.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butClose.Location = new System.Drawing.Point(79, 135);
            this.butClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(189, 50);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Выйти";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 201);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butEnter);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.Button butClose;
    }
}