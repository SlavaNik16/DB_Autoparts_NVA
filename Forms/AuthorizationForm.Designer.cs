﻿namespace DB_Autoparts_NVA.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.butEnter = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.butTest = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butEnter
            // 
            this.butEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(163)))), ((int)(((byte)(208)))));
            this.butEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.butEnter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEnter.Location = new System.Drawing.Point(42, 28);
            this.butEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(312, 66);
            this.butEnter.TabIndex = 0;
            this.butEnter.Text = "Войти";
            this.butEnter.UseVisualStyleBackColor = false;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // butReg
            // 
            this.butReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(163)))), ((int)(((byte)(208)))));
            this.butReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.butReg.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.butReg.Location = new System.Drawing.Point(42, 103);
            this.butReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(312, 66);
            this.butReg.TabIndex = 1;
            this.butReg.Text = "Регистрация";
            this.butReg.UseVisualStyleBackColor = false;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.butClose.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.butClose.Location = new System.Drawing.Point(81, 178);
            this.butClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(243, 66);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Выйти";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarLoad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 245);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(393, 34);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(225, 26);
            this.progressBarLoad.Visible = false;
            // 
            // butTest
            // 
            this.butTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(163)))), ((int)(((byte)(208)))));
            this.butTest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTest.Location = new System.Drawing.Point(1, 177);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(73, 72);
            this.butTest.TabIndex = 4;
            this.butTest.Text = "Test";
            this.butTest.UseVisualStyleBackColor = false;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(74)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(393, 262);
            this.Controls.Add(this.butTest);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button butTest;
    }
}