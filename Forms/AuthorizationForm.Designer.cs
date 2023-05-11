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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butEnter
            // 
            this.butEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butEnter.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.butEnter.Location = new System.Drawing.Point(83, 19);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(121, 43);
            this.butEnter.TabIndex = 0;
            this.butEnter.Text = "Войти";
            this.butEnter.UseVisualStyleBackColor = false;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // butReg
            // 
            this.butReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butReg.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.butReg.Location = new System.Drawing.Point(47, 68);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(199, 43);
            this.butReg.TabIndex = 1;
            this.butReg.Text = "Зарегистрироваться";
            this.butReg.UseVisualStyleBackColor = false;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butClose.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.butClose.Location = new System.Drawing.Point(68, 117);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(162, 43);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Выйти";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarLoad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(293, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(100, 16);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 205);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butEnter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBarLoad;
    }
}