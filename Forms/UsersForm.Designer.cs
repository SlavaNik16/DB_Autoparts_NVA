namespace DB_Autoparts_NVA.Forms
{
    partial class UsersForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.logoCollegePictureBox = new System.Windows.Forms.PictureBox();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirrthDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butCansel = new System.Windows.Forms.Button();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).BeginInit();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Salmon;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.logoCollegePictureBox);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(534, 100);
            this.panelHeader.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(155, 30);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(337, 25);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Информация об пользователе";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoCollegePictureBox
            // 
            this.logoCollegePictureBox.BackgroundImage = global::DB_Autoparts_NVA.Properties.Resources.usersIcon;
            this.logoCollegePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoCollegePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoCollegePictureBox.Location = new System.Drawing.Point(15, 8);
            this.logoCollegePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoCollegePictureBox.Name = "logoCollegePictureBox";
            this.logoCollegePictureBox.Size = new System.Drawing.Size(123, 82);
            this.logoCollegePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoCollegePictureBox.TabIndex = 0;
            this.logoCollegePictureBox.TabStop = false;
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.CalendarFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeBirthday.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimeBirthday.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimeBirthday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeBirthday.Location = new System.Drawing.Point(191, 279);
            this.dateTimeBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBirthday.MaxDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            this.dateTimeBirthday.MinDate = new System.DateTime(1972, 1, 1, 0, 0, 0, 0);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(308, 27);
            this.dateTimeBirthday.TabIndex = 7;
            this.dateTimeBirthday.TabStop = false;
            this.dateTimeBirthday.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dateTimeBirthday.ValueChanged += new System.EventHandler(this.dateTimeBirthday_ValueChanged);
            // 
            // labelBirrthDate
            // 
            this.labelBirrthDate.AutoSize = true;
            this.labelBirrthDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelBirrthDate.ForeColor = System.Drawing.Color.White;
            this.labelBirrthDate.Location = new System.Drawing.Point(14, 278);
            this.labelBirrthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirrthDate.Name = "labelBirrthDate";
            this.labelBirrthDate.Size = new System.Drawing.Size(162, 23);
            this.labelBirrthDate.TabIndex = 6;
            this.labelBirrthDate.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(392, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxSurname.Location = new System.Drawing.Point(16, 160);
            this.txtBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSurname.MaxLength = 48;
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(237, 26);
            this.txtBoxSurname.TabIndex = 0;
            this.txtBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSurname.TextChanged += new System.EventHandler(this.txtBoxSurname_TextChanged);
            this.txtBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEnglishAndRussiaSim_KeyPress);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxName.Location = new System.Drawing.Point(301, 160);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxName.MaxLength = 28;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(223, 26);
            this.txtBoxName.TabIndex = 1;
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            this.txtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEnglishAndRussiaSim_KeyPress);
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboGender.Location = new System.Drawing.Point(236, 218);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(140, 30);
            this.comboGender.TabIndex = 34;
            this.comboGender.TabStop = false;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Почта";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxEmail.Location = new System.Drawing.Point(147, 322);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(352, 26);
            this.txtBoxEmail.TabIndex = 2;
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Телефон";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxPhone.Location = new System.Drawing.Point(146, 12);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPhone.MaxLength = 14;
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(352, 26);
            this.txtBoxPhone.TabIndex = 3;
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.txtBoxPhone_TextChanged);
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumber_KeyPress);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelBack.Controls.Add(this.txtBoxPassword);
            this.panelBack.Controls.Add(this.label6);
            this.panelBack.Controls.Add(this.txtBoxPhone);
            this.panelBack.Controls.Add(this.label5);
            this.panelBack.Location = new System.Drawing.Point(1, 366);
            this.panelBack.Margin = new System.Windows.Forms.Padding(4);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(533, 100);
            this.panelBack.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxPassword.Location = new System.Drawing.Point(146, 60);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(352, 26);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Пароль";
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Lime;
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.butSave.Location = new System.Drawing.Point(34, 476);
            this.butSave.Margin = new System.Windows.Forms.Padding(4);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(158, 56);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Создать";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // butCansel
            // 
            this.butCansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCansel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.butCansel.Location = new System.Drawing.Point(341, 476);
            this.butCansel.Margin = new System.Windows.Forms.Padding(4);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(158, 56);
            this.butCansel.TabIndex = 6;
            this.butCansel.Text = "Отменить";
            this.butCansel.UseVisualStyleBackColor = false;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(534, 541);
            this.Controls.Add(this.butCansel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeBirthday);
            this.Controls.Add(this.labelBirrthDate);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового пользователя";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox logoCollegePictureBox;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.Label labelBirrthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCansel;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
    }
}