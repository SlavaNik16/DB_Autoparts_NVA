namespace DB_Autoparts_NVA.Forms
{
    partial class LoadForm
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
        public void InitializeComponent()
        {
            this.textLoad = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLoad
            // 
            this.textLoad.AutoSize = true;
            this.textLoad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLoad.Location = new System.Drawing.Point(18, 0);
            this.textLoad.Name = "textLoad";
            this.textLoad.Size = new System.Drawing.Size(97, 21);
            this.textLoad.TabIndex = 1;
            this.textLoad.Text = "Загрузка ...";
            this.textLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(251)))), ((int)(((byte)(236)))));
            this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHead.Controls.Add(this.progressBarLoad);
            this.panelHead.Controls.Add(this.textLoad);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(278, 80);
            this.panelHead.TabIndex = 2;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(22, 38);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(233, 23);
            this.progressBarLoad.TabIndex = 2;
            this.progressBarLoad.Value = 20;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 80);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label textLoad;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.ProgressBar progressBarLoad;
    }
}