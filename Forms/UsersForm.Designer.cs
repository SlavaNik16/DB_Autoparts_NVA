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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butSave = new System.Windows.Forms.Button();
            this.butCansel = new System.Windows.Forms.Button();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Salmon;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.logoCollegePictureBox);
            this.panelHeader.Location = new System.Drawing.Point(1, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(480, 81);
            this.panelHeader.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(133, 25);
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
            this.logoCollegePictureBox.Location = new System.Drawing.Point(13, 6);
            this.logoCollegePictureBox.Name = "logoCollegePictureBox";
            this.logoCollegePictureBox.Size = new System.Drawing.Size(106, 67);
            this.logoCollegePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoCollegePictureBox.TabIndex = 0;
            this.logoCollegePictureBox.TabStop = false;
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.CalendarFont = new System.Drawing.Font("Times New Roman", 24F);
            this.dateTimeBirthday.Location = new System.Drawing.Point(170, 228);
            this.dateTimeBirthday.MaxDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            this.dateTimeBirthday.MinDate = new System.DateTime(1972, 1, 1, 0, 0, 0, 0);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(302, 20);
            this.dateTimeBirthday.TabIndex = 7;
            this.dateTimeBirthday.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.dateTimeBirthday.ValueChanged += new System.EventHandler(this.dateTimeBirthday_ValueChanged);
            // 
            // labelBirrthDate
            // 
            this.labelBirrthDate.AutoSize = true;
            this.labelBirrthDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelBirrthDate.Location = new System.Drawing.Point(12, 226);
            this.labelBirrthDate.Name = "labelBirrthDate";
            this.labelBirrthDate.Size = new System.Drawing.Size(141, 22);
            this.labelBirrthDate.TabIndex = 6;
            this.labelBirrthDate.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(331, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxSurname.Location = new System.Drawing.Point(14, 130);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(213, 26);
            this.txtBoxSurname.TabIndex = 10;
            this.txtBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSurname.TextChanged += new System.EventHandler(this.txtBoxSurname_TextChanged);
            this.txtBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEnglishAndRussiaSim_KeyPress);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxName.Location = new System.Drawing.Point(258, 130);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(213, 26);
            this.txtBoxName.TabIndex = 11;
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            this.txtBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEnglishAndRussiaSim_KeyPress);
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboGender.Location = new System.Drawing.Point(212, 179);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(121, 27);
            this.comboGender.TabIndex = 12;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(135, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Почта";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxEmail.Location = new System.Drawing.Point(126, 262);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(302, 26);
            this.txtBoxEmail.TabIndex = 15;
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Телефон";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxPhone.Location = new System.Drawing.Point(125, 10);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(302, 26);
            this.txtBoxPhone.TabIndex = 17;
            this.txtBoxPhone.TextChanged += new System.EventHandler(this.txtBoxPhone_TextChanged);
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumber_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtBoxPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBoxPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 81);
            this.panel1.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBoxPassword.Location = new System.Drawing.Point(125, 49);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(302, 26);
            this.txtBoxPassword.TabIndex = 21;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Пароль";
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Lime;
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.butSave.Location = new System.Drawing.Point(29, 387);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(135, 45);
            this.butSave.TabIndex = 18;
            this.butSave.Text = "Создать";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // butCansel
            // 
            this.butCansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCansel.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.butCansel.Location = new System.Drawing.Point(308, 387);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(135, 45);
            this.butCansel.TabIndex = 19;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.butCansel);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeBirthday);
            this.Controls.Add(this.labelBirrthDate);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового пользователя";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoCollegePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCansel;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
    }
}