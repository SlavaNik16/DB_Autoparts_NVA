﻿namespace DB_Autoparts_NVA
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpgradeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBDUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDBUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDBAutoparts = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolEdit = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolAddProduct = new System.Windows.Forms.ToolStripButton();
            this.toolEditProduct = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteProduct = new System.Windows.Forms.ToolStripButton();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сolumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.columnIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CountUsersStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.MoneyUserStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.AllMoneyStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаToolStripMenuItem,
            this.menuBDUsers,
            this.помощьToolStripMenuItem,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фаToolStripMenuItem
            // 
            this.фаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpgradeStatus,
            this.menuExport});
            this.фаToolStripMenuItem.Name = "фаToolStripMenuItem";
            this.фаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.фаToolStripMenuItem.Text = "Экспорт";
            // 
            // menuUpgradeStatus
            // 
            this.menuUpgradeStatus.Name = "menuUpgradeStatus";
            this.menuUpgradeStatus.Size = new System.Drawing.Size(197, 22);
            this.menuUpgradeStatus.Text = "Повысить статус";
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(197, 22);
            this.menuExport.Text = "Экспорт пользователя";
            // 
            // menuBDUsers
            // 
            this.menuBDUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDBUsers,
            this.menuDBAutoparts});
            this.menuBDUsers.Name = "menuBDUsers";
            this.menuBDUsers.Size = new System.Drawing.Size(87, 20);
            this.menuBDUsers.Text = "База данных";
            // 
            // menuDBUsers
            // 
            this.menuDBUsers.Name = "menuDBUsers";
            this.menuDBUsers.Size = new System.Drawing.Size(158, 22);
            this.menuDBUsers.Text = "Пользователей";
            this.menuDBUsers.Click += new System.EventHandler(this.menuDBUsers_Click);
            // 
            // menuDBAutoparts
            // 
            this.menuDBAutoparts.Name = "menuDBAutoparts";
            this.menuDBAutoparts.Size = new System.Drawing.Size(158, 22);
            this.menuDBAutoparts.Text = "Автозапчастей";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(54, 20);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridUsers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridProduct, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 383F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 408);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEdit,
            this.toolDelete,
            this.toolStripLabel1,
            this.toolSearchBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolEdit
            // 
            this.toolEdit.Image = global::DB_Autoparts_NVA.Properties.Resources.editIcon;
            this.toolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(107, 22);
            this.toolEdit.Text = "Редактировать";
            // 
            // toolDelete
            // 
            this.toolDelete.Image = global::DB_Autoparts_NVA.Properties.Resources.deleteIcon;
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(71, 22);
            this.toolDelete.Text = "Удалить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel1.Text = "Поиск по фамилии";
            // 
            // toolSearchBox
            // 
            this.toolSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolSearchBox.Name = "toolSearchBox";
            this.toolSearchBox.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddProduct,
            this.toolEditProduct,
            this.toolDeleteProduct});
            this.toolStrip2.Location = new System.Drawing.Point(616, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(412, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolAddProduct
            // 
            this.toolAddProduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolAddProduct.Image = global::DB_Autoparts_NVA.Properties.Resources.addProductIcon;
            this.toolAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddProduct.Name = "toolAddProduct";
            this.toolAddProduct.Size = new System.Drawing.Size(66, 22);
            this.toolAddProduct.Text = "Купить";
            // 
            // toolEditProduct
            // 
            this.toolEditProduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolEditProduct.Image = global::DB_Autoparts_NVA.Properties.Resources.editProductIconIcon;
            this.toolEditProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditProduct.Name = "toolEditProduct";
            this.toolEditProduct.Size = new System.Drawing.Size(81, 22);
            this.toolEditProduct.Text = "Изменить";
            // 
            // toolDeleteProduct
            // 
            this.toolDeleteProduct.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolDeleteProduct.Image = global::DB_Autoparts_NVA.Properties.Resources.deleteProductIcon;
            this.toolDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteProduct.Name = "toolDeleteProduct";
            this.toolDeleteProduct.Size = new System.Drawing.Size(70, 22);
            this.toolDeleteProduct.Text = "Удалить";
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeColumns = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnSurname,
            this.columnName,
            this.columnGender,
            this.columnBirthday,
            this.сolumnEmail,
            this.columnPhone,
            this.columnStatus,
            this.columnPassword});
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsers.Location = new System.Drawing.Point(3, 28);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsers.Size = new System.Drawing.Size(610, 377);
            this.dataGridUsers.TabIndex = 2;
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnId.DataPropertyName = "user_id";
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 41;
            // 
            // columnSurname
            // 
            this.columnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSurname.DataPropertyName = "surname";
            this.columnSurname.HeaderText = "Фамилия";
            this.columnSurname.Name = "columnSurname";
            this.columnSurname.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.DataPropertyName = "name";
            this.columnName.HeaderText = "Имя";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnGender
            // 
            this.columnGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnGender.DataPropertyName = "gender";
            this.columnGender.HeaderText = "Пол";
            this.columnGender.Name = "columnGender";
            this.columnGender.ReadOnly = true;
            // 
            // columnBirthday
            // 
            this.columnBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnBirthday.DataPropertyName = "birthday";
            this.columnBirthday.HeaderText = "День рождение";
            this.columnBirthday.Name = "columnBirthday";
            this.columnBirthday.ReadOnly = true;
            // 
            // сolumnEmail
            // 
            this.сolumnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сolumnEmail.DataPropertyName = "email";
            this.сolumnEmail.HeaderText = "Почта";
            this.сolumnEmail.Name = "сolumnEmail";
            this.сolumnEmail.ReadOnly = true;
            // 
            // columnPhone
            // 
            this.columnPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPhone.DataPropertyName = "phone";
            this.columnPhone.HeaderText = "Телефон";
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.ReadOnly = true;
            // 
            // columnStatus
            // 
            this.columnStatus.DataPropertyName = "status";
            this.columnStatus.HeaderText = "Статус";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.ReadOnly = true;
            this.columnStatus.Visible = false;
            // 
            // columnPassword
            // 
            this.columnPassword.DataPropertyName = "password";
            this.columnPassword.HeaderText = "Пароль";
            this.columnPassword.Name = "columnPassword";
            this.columnPassword.ReadOnly = true;
            this.columnPassword.Visible = false;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToResizeColumns = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdProduct,
            this.columnIdProducts,
            this.columnPrice,
            this.columnIdUser,
            this.columnCount});
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProduct.Location = new System.Drawing.Point(619, 28);
            this.dataGridProduct.MultiSelect = false;
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.Size = new System.Drawing.Size(406, 377);
            this.dataGridProduct.TabIndex = 3;
            this.dataGridProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridProduct_CellFormatting);
            this.dataGridProduct.SelectionChanged += new System.EventHandler(this.dataGridProduct_SelectionChanged);
            // 
            // columnIdProduct
            // 
            this.columnIdProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdProduct.DataPropertyName = "parts_id";
            this.columnIdProduct.HeaderText = "Id";
            this.columnIdProduct.Name = "columnIdProduct";
            this.columnIdProduct.ReadOnly = true;
            this.columnIdProduct.Width = 41;
            // 
            // columnIdProducts
            // 
            this.columnIdProducts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnIdProducts.DataPropertyName = "product";
            this.columnIdProducts.HeaderText = "Продукт";
            this.columnIdProducts.Name = "columnIdProducts";
            this.columnIdProducts.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "0";
            this.columnPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnPrice.HeaderText = "Цена";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnIdUser
            // 
            this.columnIdUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdUser.DataPropertyName = "id_user";
            this.columnIdUser.HeaderText = "Пользователь";
            this.columnIdUser.Name = "columnIdUser";
            this.columnIdUser.ReadOnly = true;
            this.columnIdUser.Visible = false;
            // 
            // columnCount
            // 
            this.columnCount.DataPropertyName = "count";
            dataGridViewCellStyle2.NullValue = "0";
            this.columnCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnCount.HeaderText = "Кол-во";
            this.columnCount.Name = "columnCount";
            this.columnCount.ReadOnly = true;
            this.columnCount.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountUsersStatusStrip,
            this.MoneyUserStatusStrip,
            this.AllMoneyStatusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CountUsersStatusStrip
            // 
            this.CountUsersStatusStrip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountUsersStatusStrip.Name = "CountUsersStatusStrip";
            this.CountUsersStatusStrip.Size = new System.Drawing.Size(139, 17);
            this.CountUsersStatusStrip.Text = "Кол-во пользователей: 0";
            // 
            // MoneyUserStatusStrip
            // 
            this.MoneyUserStatusStrip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyUserStatusStrip.Name = "MoneyUserStatusStrip";
            this.MoneyUserStatusStrip.Size = new System.Drawing.Size(204, 17);
            this.MoneyUserStatusStrip.Text = "Прибыль у данного пользователя: 0";
            // 
            // AllMoneyStatusStrip
            // 
            this.AllMoneyStatusStrip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMoneyStatusStrip.Name = "AllMoneyStatusStrip";
            this.AllMoneyStatusStrip.Size = new System.Drawing.Size(109, 17);
            this.AllMoneyStatusStrip.Text = "Общая прибыль: 0";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 408);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 457);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж автозапчастей";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuUpgradeStatus;
        private System.Windows.Forms.ToolStripMenuItem menuBDUsers;
        private System.Windows.Forms.ToolStripMenuItem menuDBUsers;
        private System.Windows.Forms.ToolStripMenuItem menuDBAutoparts;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolEdit;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CountUsersStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MoneyUserStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel AllMoneyStatusStrip;
        private System.Windows.Forms.ToolStripButton toolAddProduct;
        private System.Windows.Forms.ToolStripButton toolEditProduct;
        private System.Windows.Forms.ToolStripButton toolDeleteProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn сolumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCount;
    }
}

