namespace DB_Autoparts_NVA.Forms
{
    partial class DBUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBUsersForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSort = new System.Windows.Forms.Button();
            this.radioDeOrder = new System.Windows.Forms.RadioButton();
            this.radioOrder = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butViewAll = new System.Windows.Forms.Button();
            this.butFiltr = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.butEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.butDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridUsersDB = new System.Windows.Forms.DataGridView();
            this.columnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сolumnEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBirthday = new System.Windows.Forms.ComboBox();
            this.checkBoxGender = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.textTrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersDB)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butSort);
            this.groupBox1.Controls.Add(this.radioDeOrder);
            this.groupBox1.Controls.Add(this.radioOrder);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(588, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 296);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // butSort
            // 
            this.butSort.BackColor = System.Drawing.Color.Yellow;
            this.butSort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSort.ForeColor = System.Drawing.Color.Black;
            this.butSort.Location = new System.Drawing.Point(9, 248);
            this.butSort.Name = "butSort";
            this.butSort.Size = new System.Drawing.Size(192, 42);
            this.butSort.TabIndex = 4;
            this.butSort.Text = "Сортировать";
            this.butSort.UseVisualStyleBackColor = false;
            this.butSort.Click += new System.EventHandler(this.butSort_Click);
            // 
            // radioDeOrder
            // 
            this.radioDeOrder.AutoSize = true;
            this.radioDeOrder.Location = new System.Drawing.Point(9, 221);
            this.radioDeOrder.Name = "radioDeOrder";
            this.radioDeOrder.Size = new System.Drawing.Size(180, 21);
            this.radioDeOrder.TabIndex = 3;
            this.radioDeOrder.Text = "Сортировка по убыванию";
            this.radioDeOrder.UseVisualStyleBackColor = true;
            // 
            // radioOrder
            // 
            this.radioOrder.AutoSize = true;
            this.radioOrder.Checked = true;
            this.radioOrder.Location = new System.Drawing.Point(9, 198);
            this.radioOrder.Name = "radioOrder";
            this.radioOrder.Size = new System.Drawing.Size(200, 21);
            this.radioOrder.TabIndex = 2;
            this.radioOrder.TabStop = true;
            this.radioOrder.Text = "Сортировка по возрастанию";
            this.radioOrder.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 19;
            this.listBox.Items.AddRange(new object[] {
            "Id",
            "Фамилия",
            "Имя",
            "День рождения",
            "Почта",
            "Телефон",
            "Статус"});
            this.listBox.Location = new System.Drawing.Point(9, 32);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(192, 156);
            this.listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поле для сортировки";
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.Enabled = false;
            this.comboGender.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(134, 355);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(149, 27);
            this.comboGender.TabIndex = 23;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.searchBox.Location = new System.Drawing.Point(212, 394);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(238, 22);
            this.searchBox.TabIndex = 22;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Поиск по фамилии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Фильтрация";
            // 
            // butClose
            // 
            this.butClose.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.butClose.Location = new System.Drawing.Point(596, 387);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(196, 36);
            this.butClose.TabIndex = 20;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butSearch.Enabled = false;
            this.butSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.butSearch.Location = new System.Drawing.Point(456, 387);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(126, 36);
            this.butSearch.TabIndex = 19;
            this.butSearch.Text = "Найти";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butViewAll
            // 
            this.butViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.butViewAll.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.butViewAll.Location = new System.Drawing.Point(596, 349);
            this.butViewAll.Name = "butViewAll";
            this.butViewAll.Size = new System.Drawing.Size(196, 36);
            this.butViewAll.TabIndex = 18;
            this.butViewAll.Text = "Показать все";
            this.butViewAll.UseVisualStyleBackColor = false;
            this.butViewAll.Click += new System.EventHandler(this.butViewAll_Click);
            // 
            // butFiltr
            // 
            this.butFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butFiltr.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.butFiltr.Location = new System.Drawing.Point(456, 349);
            this.butFiltr.Name = "butFiltr";
            this.butFiltr.Size = new System.Drawing.Size(126, 36);
            this.butFiltr.TabIndex = 17;
            this.butFiltr.Text = "Фильтровать";
            this.butFiltr.UseVisualStyleBackColor = false;
            this.butFiltr.Click += new System.EventHandler(this.butFiltr_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport,
            this.butEdit,
            this.butDelete});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(804, 25);
            this.menuStrip.TabIndex = 24;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuExport
            // 
            this.menuExport.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.menuExport.ForeColor = System.Drawing.Color.White;
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(167, 21);
            this.menuExport.Text = "Экспорт пользователя";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // butEdit
            // 
            this.butEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.butEdit.ForeColor = System.Drawing.Color.White;
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(82, 21);
            this.butEdit.Text = "Изменить";
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.butDelete.ForeColor = System.Drawing.Color.White;
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(102, 21);
            this.butDelete.Text = "Блокировать";
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // dataGridUsersDB
            // 
            this.dataGridUsersDB.AllowUserToAddRows = false;
            this.dataGridUsersDB.AllowUserToDeleteRows = false;
            this.dataGridUsersDB.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsersDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsersDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsersDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdDataGridViewTextBoxColumn,
            this.columnSurnameDataGridViewTextBoxColumn,
            this.columnNameDataGridViewTextBoxColumn,
            this.columnGenderDataGridViewTextBoxColumn,
            this.columnBirthdayDataGridViewTextBoxColumn,
            this.сolumnEmailDataGridViewTextBoxColumn,
            this.columnPhoneDataGridViewTextBoxColumn,
            this.columnStatusDataGridViewTextBoxColumn,
            this.columnPasswordDataGridViewTextBoxColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsersDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsersDB.Location = new System.Drawing.Point(8, 27);
            this.dataGridUsersDB.MultiSelect = false;
            this.dataGridUsersDB.Name = "dataGridUsersDB";
            this.dataGridUsersDB.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsersDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsersDB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsersDB.Size = new System.Drawing.Size(574, 296);
            this.dataGridUsersDB.TabIndex = 25;
            this.dataGridUsersDB.SelectionChanged += new System.EventHandler(this.dataGridUsersDB_SelectionChanged);
            // 
            // columnIdDataGridViewTextBoxColumn
            // 
            this.columnIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.columnIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.columnIdDataGridViewTextBoxColumn.Name = "columnIdDataGridViewTextBoxColumn";
            this.columnIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnIdDataGridViewTextBoxColumn.Width = 41;
            // 
            // columnSurnameDataGridViewTextBoxColumn
            // 
            this.columnSurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSurnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.columnSurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.columnSurnameDataGridViewTextBoxColumn.Name = "columnSurnameDataGridViewTextBoxColumn";
            this.columnSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnNameDataGridViewTextBoxColumn
            // 
            this.columnNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.columnNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.columnNameDataGridViewTextBoxColumn.Name = "columnNameDataGridViewTextBoxColumn";
            this.columnNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnGenderDataGridViewTextBoxColumn
            // 
            this.columnGenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGenderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.columnGenderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.columnGenderDataGridViewTextBoxColumn.Name = "columnGenderDataGridViewTextBoxColumn";
            this.columnGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnBirthdayDataGridViewTextBoxColumn
            // 
            this.columnBirthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnBirthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.columnBirthdayDataGridViewTextBoxColumn.HeaderText = "День рождение";
            this.columnBirthdayDataGridViewTextBoxColumn.Name = "columnBirthdayDataGridViewTextBoxColumn";
            this.columnBirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сolumnEmailDataGridViewTextBoxColumn
            // 
            this.сolumnEmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сolumnEmailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.сolumnEmailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.сolumnEmailDataGridViewTextBoxColumn.Name = "сolumnEmailDataGridViewTextBoxColumn";
            this.сolumnEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnPhoneDataGridViewTextBoxColumn
            // 
            this.columnPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPhoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.columnPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.columnPhoneDataGridViewTextBoxColumn.Name = "columnPhoneDataGridViewTextBoxColumn";
            this.columnPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnStatusDataGridViewTextBoxColumn
            // 
            this.columnStatusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.columnStatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.columnStatusDataGridViewTextBoxColumn.Name = "columnStatusDataGridViewTextBoxColumn";
            this.columnStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // columnPasswordDataGridViewTextBoxColumn
            // 
            this.columnPasswordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.columnPasswordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.columnPasswordDataGridViewTextBoxColumn.Name = "columnPasswordDataGridViewTextBoxColumn";
            this.columnPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnPasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // comboBirthday
            // 
            this.comboBirthday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBirthday.Enabled = false;
            this.comboBirthday.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBirthday.FormattingEnabled = true;
            this.comboBirthday.Location = new System.Drawing.Point(291, 355);
            this.comboBirthday.Name = "comboBirthday";
            this.comboBirthday.Size = new System.Drawing.Size(149, 27);
            this.comboBirthday.TabIndex = 26;
            // 
            // checkBoxGender
            // 
            this.checkBoxGender.AutoSize = true;
            this.checkBoxGender.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.checkBoxGender.ForeColor = System.Drawing.Color.White;
            this.checkBoxGender.Location = new System.Drawing.Point(170, 327);
            this.checkBoxGender.Name = "checkBoxGender";
            this.checkBoxGender.Size = new System.Drawing.Size(77, 26);
            this.checkBoxGender.TabIndex = 29;
            this.checkBoxGender.Text = "Пола";
            this.checkBoxGender.UseVisualStyleBackColor = true;
            this.checkBoxGender.CheckedChanged += new System.EventHandler(this.checkBoxGender_CheckedChanged);
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.checkBoxPhone.ForeColor = System.Drawing.Color.White;
            this.checkBoxPhone.Location = new System.Drawing.Point(291, 327);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(162, 26);
            this.checkBoxPhone.TabIndex = 30;
            this.checkBoxPhone.Text = "Дня рождения";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            this.checkBoxPhone.CheckedChanged += new System.EventHandler(this.checkBoxPhone_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textTrip,
            this.ProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 429);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(804, 26);
            this.statusStrip.TabIndex = 31;
            this.statusStrip.Text = "statusStrip1";
            // 
            // textTrip
            // 
            this.textTrip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTrip.ForeColor = System.Drawing.Color.Black;
            this.textTrip.Name = "textTrip";
            this.textTrip.Size = new System.Drawing.Size(85, 21);
            this.textTrip.Text = "Действие";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(300, 20);
            // 
            // DBUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 455);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.checkBoxPhone);
            this.Controls.Add(this.checkBoxGender);
            this.Controls.Add(this.comboBirthday);
            this.Controls.Add(this.dataGridUsersDB);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butViewAll);
            this.Controls.Add(this.butFiltr);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBUsersForm_FormClosed);
            this.Load += new System.EventHandler(this.DBUsersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsersDB)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butSort;
        private System.Windows.Forms.RadioButton radioDeOrder;
        private System.Windows.Forms.RadioButton radioOrder;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butViewAll;
        private System.Windows.Forms.Button butFiltr;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripMenuItem butEdit;
        private System.Windows.Forms.ToolStripMenuItem butDelete;
        private System.Windows.Forms.DataGridView dataGridUsersDB;
        private System.Windows.Forms.ComboBox comboBirthday;
        private System.Windows.Forms.CheckBox checkBoxGender;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сolumnEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel textTrip;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
    }
}