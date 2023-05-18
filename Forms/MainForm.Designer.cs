namespace DB_Autoparts_NVA
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpgradeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDBUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDBAutoparts = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.columnIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdUserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripDataUser = new System.Windows.Forms.ToolStrip();
            this.toolEdit = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.updateData = new System.Windows.Forms.ToolStripButton();
            this.toolStripDataProduct = new System.Windows.Forms.ToolStrip();
            this.toolAddProduct = new System.Windows.Forms.ToolStripButton();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CountUsersStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.MoneyUserStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.AllMoneyStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripUserStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKeyAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.addProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.toolStripDataUser.SuspendLayout();
            this.toolStripDataProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportMenuItem,
            this.menuDB,
            this.helpMenuItem,
            this.menuExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1082, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ExportMenuItem
            // 
            this.ExportMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ExportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpgradeStatus,
            this.menuExport});
            this.ExportMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExportMenuItem.Name = "ExportMenuItem";
            this.ExportMenuItem.Size = new System.Drawing.Size(77, 21);
            this.ExportMenuItem.Text = "Экспорт";
            this.ExportMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // menuUpgradeStatus
            // 
            this.menuUpgradeStatus.Name = "menuUpgradeStatus";
            this.menuUpgradeStatus.Size = new System.Drawing.Size(223, 22);
            this.menuUpgradeStatus.Text = "Повысить статус";
            this.menuUpgradeStatus.Click += new System.EventHandler(this.menuUpgradeStatus_Click);
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(223, 22);
            this.menuExport.Text = "Экспорт пользователя";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // menuDB
            // 
            this.menuDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDBUsers,
            this.menuDBAutoparts});
            this.menuDB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.menuDB.ForeColor = System.Drawing.Color.White;
            this.menuDB.Name = "menuDB";
            this.menuDB.Size = new System.Drawing.Size(103, 21);
            this.menuDB.Text = "База данных";
            // 
            // menuDBUsers
            // 
            this.menuDBUsers.Name = "menuDBUsers";
            this.menuDBUsers.Size = new System.Drawing.Size(173, 22);
            this.menuDBUsers.Text = "Пользователей";
            this.menuDBUsers.Click += new System.EventHandler(this.menuDBUsers_Click);
            // 
            // menuDBAutoparts
            // 
            this.menuDBAutoparts.Name = "menuDBAutoparts";
            this.menuDBAutoparts.Size = new System.Drawing.Size(173, 22);
            this.menuDBAutoparts.Text = "Автозапчастей";
            this.menuDBAutoparts.Click += new System.EventHandler(this.menuDBAutoparts_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpProvider,
            this.menuAboutProgram});
            this.helpMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.helpMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(77, 21);
            this.helpMenuItem.Text = "Помощь";
            // 
            // menuHelpProvider
            // 
            this.menuHelpProvider.Name = "menuHelpProvider";
            this.menuHelpProvider.Size = new System.Drawing.Size(170, 22);
            this.menuHelpProvider.Text = "Справка";
            this.menuHelpProvider.Click += new System.EventHandler(this.menuHelpProvider_Click);
            // 
            // menuAboutProgram
            // 
            this.menuAboutProgram.Name = "menuAboutProgram";
            this.menuAboutProgram.Size = new System.Drawing.Size(170, 22);
            this.menuAboutProgram.Text = "О программе";
            this.menuAboutProgram.Click += new System.EventHandler(this.menuAboutProgram_Click);
            // 
            // menuExit
            // 
            this.menuExit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.menuExit.ForeColor = System.Drawing.Color.White;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(59, 21);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.89834F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.10166F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridProduct, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStripDataUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStripDataProduct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridUsers, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 383F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 408);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdProduct,
            this.columnIdUser,
            this.columnIdProducts,
            this.columnCount,
            this.columnPrice,
            this.columnDate,
            this.columnIdUserSurname});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProduct.Location = new System.Drawing.Point(597, 28);
            this.dataGridProduct.MultiSelect = false;
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridProduct.Size = new System.Drawing.Size(482, 377);
            this.dataGridProduct.TabIndex = 3;
            this.dataGridProduct.SelectionChanged += new System.EventHandler(this.dataGridProduct_SelectionChanged);
            // 
            // columnIdProduct
            // 
            this.columnIdProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdProduct.DataPropertyName = "parts_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.columnIdProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnIdProduct.HeaderText = "№";
            this.columnIdProduct.Name = "columnIdProduct";
            this.columnIdProduct.ReadOnly = true;
            this.columnIdProduct.Width = 43;
            // 
            // columnIdUser
            // 
            this.columnIdUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnIdUser.DataPropertyName = "Id_user";
            this.columnIdUser.HeaderText = "User";
            this.columnIdUser.Name = "columnIdUser";
            this.columnIdUser.ReadOnly = true;
            this.columnIdUser.Visible = false;
            // 
            // columnIdProducts
            // 
            this.columnIdProducts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnIdProducts.DataPropertyName = "NameProduct";
            this.columnIdProducts.HeaderText = "Продукт";
            this.columnIdProducts.Name = "columnIdProducts";
            this.columnIdProducts.ReadOnly = true;
            // 
            // columnCount
            // 
            this.columnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnCount.DataPropertyName = "count";
            dataGridViewCellStyle3.NullValue = "0";
            this.columnCount.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnCount.HeaderText = "Кол-во";
            this.columnCount.Name = "columnCount";
            this.columnCount.ReadOnly = true;
            this.columnCount.Width = 66;
            // 
            // columnPrice
            // 
            this.columnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.columnPrice.DataPropertyName = "PriceAll";
            dataGridViewCellStyle4.NullValue = "0";
            this.columnPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnPrice.HeaderText = "Общая цена";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            this.columnPrice.Width = 94;
            // 
            // columnDate
            // 
            this.columnDate.DataPropertyName = "dateBy";
            this.columnDate.HeaderText = "Дата покупки";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            this.columnDate.Width = 119;
            // 
            // columnIdUserSurname
            // 
            this.columnIdUserSurname.DataPropertyName = "UserSurname";
            this.columnIdUserSurname.HeaderText = "Фамилия";
            this.columnIdUserSurname.Name = "columnIdUserSurname";
            this.columnIdUserSurname.ReadOnly = true;
            this.columnIdUserSurname.Visible = false;
            // 
            // toolStripDataUser
            // 
            this.toolStripDataUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.toolStripDataUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEdit,
            this.toolDelete,
            this.updateData});
            this.toolStripDataUser.Location = new System.Drawing.Point(0, 0);
            this.toolStripDataUser.Name = "toolStripDataUser";
            this.toolStripDataUser.Size = new System.Drawing.Size(594, 25);
            this.toolStripDataUser.TabIndex = 0;
            this.toolStripDataUser.Text = "toolStrip1";
            // 
            // toolEdit
            // 
            this.toolEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolEdit.ForeColor = System.Drawing.Color.Black;
            this.toolEdit.Image = global::DB_Autoparts_NVA.Properties.Resources.editIcon;
            this.toolEdit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(125, 22);
            this.toolEdit.Text = "Редактировать";
            this.toolEdit.Click += new System.EventHandler(this.toolEdit_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolDelete.ForeColor = System.Drawing.Color.Black;
            this.toolDelete.Image = global::DB_Autoparts_NVA.Properties.Resources.deleteIcon;
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(110, 22);
            this.toolDelete.Text = "Блокировать";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // updateData
            // 
            this.updateData.Image = global::DB_Autoparts_NVA.Properties.Resources.refresh;
            this.updateData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(144, 22);
            this.updateData.Text = "Обновить данные";
            this.updateData.Click += new System.EventHandler(this.updateData_Click);
            // 
            // toolStripDataProduct
            // 
            this.toolStripDataProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.toolStripDataProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddProduct,
            this.toolDeleteProduct});
            this.toolStripDataProduct.Location = new System.Drawing.Point(594, 0);
            this.toolStripDataProduct.Name = "toolStripDataProduct";
            this.toolStripDataProduct.Size = new System.Drawing.Size(488, 25);
            this.toolStripDataProduct.TabIndex = 1;
            this.toolStripDataProduct.Text = "toolStrip2";
            // 
            // toolAddProduct
            // 
            this.toolAddProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.toolAddProduct.ForeColor = System.Drawing.Color.Black;
            this.toolAddProduct.Image = global::DB_Autoparts_NVA.Properties.Resources.addProductIcon;
            this.toolAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddProduct.Name = "toolAddProduct";
            this.toolAddProduct.Size = new System.Drawing.Size(69, 22);
            this.toolAddProduct.Text = "Купить";
            this.toolAddProduct.Click += new System.EventHandler(this.toolAddProduct_Click);
            // 
            // toolDeleteProduct
            // 
            this.toolDeleteProduct.Enabled = false;
            this.toolDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.toolDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.toolDeleteProduct.Image = global::DB_Autoparts_NVA.Properties.Resources.deleteProductIcon;
            this.toolDeleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteProduct.Name = "toolDeleteProduct";
            this.toolDeleteProduct.Size = new System.Drawing.Size(79, 22);
            this.toolDeleteProduct.Text = "Удалить";
            this.toolDeleteProduct.Click += new System.EventHandler(this.toolDeleteProduct_Click);
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.AllowUserToResizeRows = false;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsers.Location = new System.Drawing.Point(3, 28);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsers.Size = new System.Drawing.Size(588, 377);
            this.dataGridUsers.TabIndex = 2;
            this.dataGridUsers.SelectionChanged += new System.EventHandler(this.dataGridUsers_SelectionChanged);
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountUsersStatusStrip,
            this.MoneyUserStatusStrip,
            this.AllMoneyStatusStrip,
            this.statusStripUserStatus,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CountUsersStatusStrip
            // 
            this.CountUsersStatusStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountUsersStatusStrip.ForeColor = System.Drawing.Color.Black;
            this.CountUsersStatusStrip.Name = "CountUsersStatusStrip";
            this.CountUsersStatusStrip.Size = new System.Drawing.Size(166, 17);
            this.CountUsersStatusStrip.Text = "Кол-во пользователей: 0";
            // 
            // MoneyUserStatusStrip
            // 
            this.MoneyUserStatusStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyUserStatusStrip.ForeColor = System.Drawing.Color.Black;
            this.MoneyUserStatusStrip.Name = "MoneyUserStatusStrip";
            this.MoneyUserStatusStrip.Size = new System.Drawing.Size(248, 17);
            this.MoneyUserStatusStrip.Text = "Прибыль от данного пользователя: 0";
            // 
            // AllMoneyStatusStrip
            // 
            this.AllMoneyStatusStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllMoneyStatusStrip.ForeColor = System.Drawing.Color.Black;
            this.AllMoneyStatusStrip.Name = "AllMoneyStatusStrip";
            this.AllMoneyStatusStrip.Size = new System.Drawing.Size(131, 17);
            this.AllMoneyStatusStrip.Text = "Общая прибыль: 0";
            // 
            // statusStripUserStatus
            // 
            this.statusStripUserStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStripUserStatus.ForeColor = System.Drawing.Color.Black;
            this.statusStripUserStatus.Name = "statusStripUserStatus";
            this.statusStripUserStatus.Size = new System.Drawing.Size(147, 17);
            this.statusStripUserStatus.Text = "Статус: Пользователь";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 408);
            this.panel1.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(139, 26);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addKeyAdmin,
            this.addProduct});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // addKeyAdmin
            // 
            this.addKeyAdmin.Name = "addKeyAdmin";
            this.addKeyAdmin.Size = new System.Drawing.Size(165, 22);
            this.addKeyAdmin.Text = "Ключ админа";
            this.addKeyAdmin.Click += new System.EventHandler(this.addKeyAdmin_Click);
            // 
            // addProduct
            // 
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(165, 22);
            this.addProduct.Text = "Продукт";
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "C:\\Users\\nikol\\OneDrive\\Рабочий стол\\Дополнение\\C#\\DB_Autoparts_NVA\\Пользовательс" +
    "кое соглашение.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 454);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж автозапчастей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.toolStripDataUser.ResumeLayout(false);
            this.toolStripDataUser.PerformLayout();
            this.toolStripDataProduct.ResumeLayout(false);
            this.toolStripDataProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuUpgradeStatus;
        private System.Windows.Forms.ToolStripMenuItem menuDB;
        private System.Windows.Forms.ToolStripMenuItem menuDBUsers;
        private System.Windows.Forms.ToolStripMenuItem menuDBAutoparts;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStripDataUser;
        private System.Windows.Forms.ToolStripButton toolEdit;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStrip toolStripDataProduct;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CountUsersStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MoneyUserStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel AllMoneyStatusStrip;
        private System.Windows.Forms.ToolStripButton toolAddProduct;
        private System.Windows.Forms.ToolStripButton toolDeleteProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menuHelpProvider;
        private System.Windows.Forms.ToolStripMenuItem menuAboutProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn сolumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPassword;
        private System.Windows.Forms.ToolStripStatusLabel statusStripUserStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addKeyAdmin;
        private System.Windows.Forms.ToolStripMenuItem addProduct;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdUserSurname;
        private System.Windows.Forms.ToolStripButton updateData;
    }
}

