using DB_Autoparts_NVA.Colors;
using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Forms;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;
namespace DB_Autoparts_NVA
{
    public partial class MainForm : Form
    {
        public DbContextOptions<ApplicationContext> options; // Подключение базы данных через строку подкючения
        public string statusUser = "";
        private static Users userMy = null;//Пользователь
        private static Users userSelected = null;//Выделенные пользователи
        private bool exit = false;//разрешаем ли мы закрыть форму или нет
        private bool statusChange = false; //обновляем статус только в том случае когда мы что-то меняем

        //Конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();//Инициализирование через строку подключения, которая находится в appsetings.json

        }
        //Конструктор, который принимает 1 параметр нашего пользователя
        public MainForm(Users users) : this()//this() мы вызываем конструктор по умолчанию
        {
            userMy = users; //делаем статическую, глобальную переменную пользователя
            statusUser = userMy.status; // для удобства запоминаем его статус (User - пользователь, Admin-Администратор)
            contextMenuStrip2.Enabled = false; 
            updateData.Visible = false;
            //Если статус - Пользователь
            if (statusUser == "User")
            {
                //Убираем и выключаем ему ненужные функции из-за недостатка прав
                this.Text = "Магазин автозапчастей";
                statusStripUserStatus.Text = "Статус: Пользователь";
                menuDB.Enabled = false;
                menuDBAutoparts.Enabled = false;
                toolEdit.Visible = false;
                toolDelete.Visible = false;
                toolDeleteProduct.Text = "Oтменить покупку";
                countUsersStatusStrip.Visible = false;
                moneyUserStatusStrip.Visible = false;
                dataGridProduct.Columns["columnIdUser"].Visible = false;
                dataGridUsers.Columns["columnId"].Visible = false;
                //Сдесь мы привязываем данные к нашим DataGridView
                dataGridUsers.DataSource = ReadUser(options);
                dataGridProduct.DataSource = FormatDataGridUser(options, userMy);

            }
            else if (statusUser == "Admin")
            {
                this.Text = "Учет продаж автозапчастей";
                statusStripUserStatus.Text = "Статус: Админ";
                contextMenuStrip2.Enabled = true;
                updateData.Visible = true;
                dataGridProduct.Columns["columnIdUser"].Visible = true;
                dataGridProduct.Columns["columnIdUser"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridUsers.Columns["columnId"].Visible = true;
                dataGridUsers.Columns["columnId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridUsers.DataSource = ReadUserAll(options);
                dataGridProduct.DataSource = FormatDataGridAdmin(options);
            }

            //Обновляем статус
            Status();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //При загрузке формы подключаем все стили и цвета используя класс ColorsHelp в папке Colors
            dataGridProduct.EnableHeadersVisualStyles = false;
            dataGridUsers.EnableHeadersVisualStyles = false;
            dataGridUsers.BackgroundColor = ColorsHelp.ColorBackground;
            dataGridProduct.BackgroundColor = ColorsHelp.ColorBackground;
            statusStrip1.BackColor = ColorsHelp.ColorBackgroundPanelBack;
            toolStripDataUser.BackColor = ColorsHelp.ColorBackgroundPanelBack;
            toolStripDataProduct.BackColor = ColorsHelp.ColorBackgroundPanelBack;
            menuStrip.BackColor = ColorsHelp.ColorBackground;
            //Подключаем событие для ToolStripMenuItem для смены ForeColor
            EventHandlerMenu(ExportMenuItem);
            EventHandlerMenu(menuDB);
            EventHandlerMenu(helpMenuItem);
            EventHandlerMenu(menuExit);
            //ProgressBar - для отоброжение видимости что идет загрузка данных
            toolStripProgressBar1.Value = 0;
        }
        private void EventHandlerMenu(ToolStripMenuItem menuItem)
        {
            menuItem.DropDownOpened += MenuItem_DropDownOpened;
            menuItem.DropDownClosed += MenuItem_DropDownClosed;
        }


        private void MenuItem_DropDownClosed(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            menuItem.ForeColor = Color.White;
        }

        private void MenuItem_DropDownOpened(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            menuItem.ForeColor = Color.Black;
        }

        #region DBRequests

        //Формат для представление ифнормации для одного пользователя и его товаров
        public static List<AutopartsFormat> FormatDataGridUser(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = ReadUserAutoparts(options, user);
                var format = tovar.Select(x => new AutopartsFormat()
                {
                    Id_user = x.id_user,
                    UserSurname = db.UserDB.Find(x.id_user).surname,
                    Parts_id = x.parts_id,
                    NameProduct = db.ProductDB.Find(x.product).title,
                    Count = x.count,
                    PriceAll = $"{x.count * db.ProductDB.Find(x.product).price:C2}",
                    DateBy = x.dateBy
                }
                ).ToList();
                return format;
            }
        }
        //Формат для представление ифнормации для всех пользователей и их товаров
        public static List<AutopartsFormat> FormatDataGridAdmin(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = ReadAutoparts(options);
                var format = tovar.Select(x => new AutopartsFormat()
                {
                    Id_user = x.id_user,
                    UserSurname = db.UserDB.Find(x.id_user).surname,
                    Parts_id = x.parts_id,
                    NameProduct = db.ProductDB.Find(x.product).title,
                    Count = x.count,
                    PriceAll = $"{x.count * db.ProductDB.Find(x.product).price:C2}",
                    DateBy = x.dateBy
                }
                ).ToList();
                return format;
            }
        }
        //Фильтр для телефона и пола для пользователей
        public static List<Users> FiltrPhoneAndGender(DbContextOptions<ApplicationContext> options,
            DateTime birthday, String gender, bool birthdayIsEnabled, bool genderIsEnabled)
        {
            using (var db = new ApplicationContext(options))
            {
                if (birthdayIsEnabled && genderIsEnabled)
                {
                    return db.UserDB.Where(u => u.birthday == birthday && u.gender == gender).ToList();

                }
                else if (birthdayIsEnabled)
                {
                    return db.UserDB.Where(u => u.birthday == birthday).ToList();
                }
                else if (genderIsEnabled)
                {
                    return db.UserDB.Where(u => u.gender == gender).ToList();
                }
                return null;
            }
        }
        //Фильтр для названий продукта
        public static List<AutopartsFormat> FiltrProductTitle(DbContextOptions<ApplicationContext> options, String productName)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = db.AutopartDB.Where(x =>
                db.ProductDB.FirstOrDefault(f => f.id_product == x.product).title == productName).ToList();
                var format = tovar.Select(x => new AutopartsFormat()
                {
                    Id_user = x.id_user,
                    UserSurname = db.UserDB.Find(x.id_user).surname,
                    Parts_id = x.parts_id,
                    NameProduct = db.ProductDB.Find(x.product).title,
                    Count = x.count,
                    PriceAll = $"{x.count * db.ProductDB.Find(x.product).price:C2}",
                    DateBy = x.dateBy
                }
                ).ToList();
                return format;
            }
        }
        //Сортировка
        public static List<Users> SortUsersOrderBy(DbContextOptions<ApplicationContext> options, string columnName)
        {
            using (var db = new ApplicationContext(options))
            {
                switch (columnName)
                {
                    case "user_id":
                        return db.UserDB.OrderBy(x => x.user_id).ToList();
                    case "surname":
                        return db.UserDB.OrderBy(x => x.surname).ToList();
                    case "name":
                        return db.UserDB.OrderBy(x => x.name).ToList();
                    case "birthday":
                        return db.UserDB.OrderBy(x => x.birthday).ToList();
                    case "email":
                        return db.UserDB.OrderBy(x => x.email).ToList();
                    case "phone":
                        return db.UserDB.OrderBy(x => x.phone).ToList();
                    case "status":
                        return db.UserDB.OrderBy(x => x.status).ToList();
                }
            }
            return null;
        }
        public static List<Users> SortUsersOrderByDescending(DbContextOptions<ApplicationContext> options, string columnName)
        {
            using (var db = new ApplicationContext(options))
            {
                switch (columnName)
                {
                    case "user_id":
                        return db.UserDB.OrderByDescending(x => x.user_id).ToList();
                    case "surname":
                        return db.UserDB.OrderByDescending(x => x.surname).ToList();
                    case "name":
                        return db.UserDB.OrderByDescending(x => x.name).ToList();
                    case "birthday":
                        return db.UserDB.OrderByDescending(x => x.birthday).ToList();
                    case "email":
                        return db.UserDB.OrderByDescending(x => x.email).ToList();
                    case "phone":
                        return db.UserDB.OrderByDescending(x => x.phone).ToList();
                    case "status":
                        return db.UserDB.OrderByDescending(x => x.status).ToList();
                }
            }
            return null;
        }

        public static List<AutopartsFormat> SortProductOrderBy(DbContextOptions<ApplicationContext> options, string columnName)
        {
            using (var db = new ApplicationContext(options))
            {
                var format = FormatDataGridAdmin(options);
                switch (columnName)
                {
                    case "parts_id":
                        return format.OrderBy(x => x.Parts_id).ToList();
                    case "UserSurname":
                        return format.OrderBy(x => x.UserSurname).ToList();
                    case "NameProduct":
                        return format.OrderBy(x => x.NameProduct).ToList();
                    case "count":
                        return format.OrderBy(x => x.Count).ToList();
                    case "PriceAll":
                        return format.OrderBy(x => x.PriceAll).ToList();
                    case "dateBy":
                        return format.OrderBy(x => x.DateBy).ToList();
                }
                return null;
            }
        }
        public static List<AutopartsFormat> SortProductOrderByDescending(DbContextOptions<ApplicationContext> options, string columnName)
        {
            using (var db = new ApplicationContext(options))
            {
                var format = FormatDataGridAdmin(options);
                switch (columnName)
                {
                    case "parts_id":
                        return format.OrderByDescending(x => x.Parts_id).ToList();
                    case "UserSurname":
                        return format.OrderByDescending(x => x.UserSurname).ToList();
                    case "NameProduct":
                        return format.OrderByDescending(x => x.NameProduct).ToList();
                    case "count":
                        return format.OrderByDescending(x => x.Count).ToList();
                    case "PriceAll":
                        return format.OrderByDescending(x => x.PriceAll).ToList();
                    case "dateBy":
                        return format.OrderByDescending(x => x.DateBy).ToList();
                }
                return null;
            }
        }
        //Запросы для взятие данных из базы данных
        private static List<Users> ReadUser(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.UserDB.Where(x => x.user_id == userMy.user_id).ToList();
            }
        }

        private static List<Autoparts> ReadUserAutoparts(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.AutopartDB.Where(x => x.id_user == user.user_id).OrderByDescending(i => i.parts_id).ToList();
            }
        }
        public static List<Users> ReadUserAll(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                var userList = db.UserDB.Where(x => x.user_id != userMy.user_id).OrderByDescending(x => x.user_id).ToList();
                userList.Insert(0, userMy);
                return userList;
            }
        }

        private static List<Autoparts> ReadAutoparts(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.AutopartDB.OrderByDescending(x => x.parts_id).ToList();
            }
        }
        private static void ByTovarDB(DbContextOptions<ApplicationContext> options, Autoparts autoparts)
        {
            using (var db = new ApplicationContext(options))
            {
                autoparts.id_user = userMy.user_id;
                autoparts.dateBy = DateTime.Now;
                db.AutopartDB.Add(autoparts);
                db.SaveChanges();
            }
        }
        private static void RemoveTovarDB(DbContextOptions<ApplicationContext> options, int autopartsId)
        {
            using (var db = new ApplicationContext(options))
            {
                var product = db.AutopartDB.FirstOrDefault(u => u.parts_id == autopartsId);
                if (product != null)
                {
                    db.AutopartDB.Remove(product);
                    db.SaveChanges();
                }
            }

        }
        //При удаление пользователя мы также удаляем все его покупки(история)
        public static void RemoveUsersDB(DbContextOptions<ApplicationContext> options, int usersId)
        {
            using (var db = new ApplicationContext(options))
            {
                var user = db.UserDB.FirstOrDefault(u => u.user_id == usersId);

                if (user != null)
                {
                    var tovars = db.AutopartDB.Where(x => x.id_user == user.user_id).ToList();
                    db.AutopartDB.RemoveRange(tovars);
                    db.UserDB.Remove(user);
                    db.SaveChanges();
                }
            }

        }
        public static void UpdateUsersDB(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                db.UserDB.Update(user);
                db.SaveChanges();
            }

        }
        #endregion

        private void menuExit_Click(object sender, EventArgs e)
        {
            
            exit = true;
            Close();
            var authForm = new AuthorizationForm();
            authForm.Visible = true;
        }


        private void toolAddProduct_Click(object sender, EventArgs e)
        {
            var byProductForm = new ByAutopartsForm();
            if (byProductForm.ShowDialog() == DialogResult.OK)
            {
                toolStripProgressBar1.Value = 0;
                ByTovarDB(options, byProductForm.Autoparts);
                toolStripProgressBar1.Value = 75;
                dataGridProduct.DataSource = FormatDataGridUser(options, userMy);
                toolStripProgressBar1.Value = 100;
                statusChange = false;
                Status();
                toolStripProgressBar1.Value = 0;
            }
        }

       

        private void toolDeleteProduct_Click(object sender, EventArgs e)
        {
            //Читаем выделенную строку  dataGridView и берем оттуда данных, в тип нашего Класса
            var autopart = (AutopartsFormat)dataGridProduct.Rows[dataGridProduct.SelectedRows[0].Index].DataBoundItem;
            if (autopart.Id_user != userMy.user_id)
            {
                MessageBox.Show($"Вы не можете удалить чужую покупку!");
                return;
            }
            if (MessageBox.Show($"Вы действительно хотите отменить покупку с \n\rN: {autopart.Parts_id}",
               "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                toolStripProgressBar1.Value = 0;
                RemoveTovarDB(options, autopart.Parts_id);//Удаляем из базы данных
                toolStripProgressBar1.Value = 75;
                dataGridProduct.DataSource = FormatDataGridUser(options, userMy);//обвновляем dataGridView
                statusChange = false;
                Status();//Обновляем статус
                toolStripProgressBar1.Value = 0;
            }

        }

        private void Status()
        {
            if (!statusChange)
            {
                var allMoney = AllMoney();
                allMoneyStatusStrip.Text = $"Общая сумма: {allMoney:C2}";
                if (statusUser == "Admin")
                {
                    countUsersStatusStrip.Text = $"Кол-во пользователей: {dataGridUsers.RowCount}";
                    if (dataGridUsers.SelectedRows.Count > 0)
                    {
                        userSelected = (Users)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;

                        moneyUserStatusStrip.Text = $"Прибыль у данного пользователя: {MoneyUser(userSelected)}";
                    }
                    else
                    {
                        moneyUserStatusStrip.Text = $"Прибыль у данного пользователя: 0";
                    }
                }
                statusChange = true;
            }
        }

        public decimal MoneyUser(Users userSelect)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = db.AutopartDB.Where(x => x.id_user == userSelect.user_id).ToList();
                return tovar.Sum(f => f.count * db.ProductDB.Find(f.product).price);
            }
        }
        public decimal AllMoney()
        {
            using (var db = new ApplicationContext(options))
            {
                decimal allMoney = 0;
                if (statusUser == "User")
                {
                    allMoney = MoneyUser(userMy);
                }
                else if (statusUser == "Admin")
                {
                    var tovar = db.AutopartDB.ToList();
                    allMoney = tovar.Sum(f => f.count * db.ProductDB.Find(f.product).price);

                }
                return allMoney;
            }

        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 30;
            //Работа в отдельном потоке для визуальной простоты для пользователя
            var thead = new Thread(() =>
            {
                ExportUserForm exportForm = null;
                if (statusUser == "User")
                {
                    exportForm = new ExportUserForm(userMy);
                    
                }
                else if (statusUser == "Admin")
                {
                    exportForm = new ExportUserForm(userSelected); 
                   
                }
                this.Invoke(new Action(() =>//Invoke функция которая позволяет работать в основном потоке, в котором объект был создан
                {
                    toolStripProgressBar1.Value = 50;
                    this.Visible = false;
                }));
                if (exportForm.ShowDialog() == DialogResult.Yes)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Visible = true;
                        toolStripProgressBar1.Value = 0;
                    }));
                }

            });
            thead.SetApartmentState(ApartmentState.STA);//Подключаем STA для работы с SaveFileDialog() которая работает с PDf файлом
            thead.Start();
        }

        private void menuUpgradeStatus_Click(object sender, EventArgs e)
        {
            if (statusUser == "User")
            {
                exit = true;
                var upgradeStatus = new UpgradeStatusForm(userMy);
                this.Close();
                upgradeStatus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы уже повысили доступ!");
            }

        }

        private void addKeyAdmin_Click(object sender, EventArgs e)
        {
            var keyForm = new UpgradeStatusForm();
            keyForm.Show();

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void dataGridUsers_SelectionChanged(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 30;
            if (statusUser == "Admin")
            {
                menuExport.Enabled =
                toolEdit.Enabled =
                toolDelete.Enabled =
                     dataGridUsers.SelectedRows.Count > 0;

                if (dataGridUsers.SelectedRows.Count > 0)
                {
                    statusChange = false;
                    toolStripProgressBar1.Value = 50;
                    userSelected = (Users)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;
                    dataGridProduct.DataSource = FormatDataGridUser(options, userSelected);
                    toolStripProgressBar1.Value = 75;

                }
            }
            Status();
            toolStripProgressBar1.Value = 0;

        }
        private void dataGridProduct_SelectionChanged(object sender, EventArgs e)
        {
            toolDeleteProduct.Enabled =
            dataGridProduct.SelectedRows.Count > 0;//Проверяем выделен ли заказ, если да то даем пользователю возможность отмены покупки
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            userSelected = (Users)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;
            if (userSelected.status == "Admin")
            {
                MessageBox.Show("Вы не можете заблокировать другого Админа или себя!");
                return;
            }
            if (MessageBox.Show($"Вы действительно хотите заблокировать пользователя с \n\rId: {userSelected.user_id}" +
                $"\n\rФамилия,Имя: {userSelected.surname},{userSelected.name}\n\rТелефон: {userSelected.phone}",
               "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                toolStripProgressBar1.Value = 25;
                RemoveUsersDB(options, userSelected.user_id);
                toolStripProgressBar1.Value = 50;
                dataGridUsers.DataSource = ReadUserAll(options);
                toolStripProgressBar1.Value = 75;
                statusChange = false;
                Status();
                toolStripProgressBar1.Value = 0;
            }
        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            userSelected = (Users)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;


            if (userSelected.status == "Admin" && userSelected.user_id != userMy.user_id)
            {
                MessageBox.Show("Вы не можете редактировать другого Админа!");
                return;
            }
            var usersForm = new UsersForm(userSelected);
            if (usersForm.ShowDialog() == DialogResult.OK)
            {
                toolStripProgressBar1.Value = 25;
                UpdateUsersDB(options, usersForm.Users);
                toolStripProgressBar1.Value = 50;

                dataGridUsers.DataSource = ReadUserAll(options);
                toolStripProgressBar1.Value = 75;
                statusChange = false;
                Status();
                toolStripProgressBar1.Value = 0;
            }
        }

        private void menuDBAutoparts_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 30;
            new Thread(() =>
            {
                DBProductsForm dbProductsForm = new DBProductsForm();
                this.Invoke(new Action(() =>
                {
                    this.Visible = false;
                    if (dbProductsForm.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Visible = true;
                        toolStripProgressBar1.Value = 0;
                    }
                }));
            }).Start();
            Task.Delay(1000).Wait();
            toolStripProgressBar1.Value = 75;
            Task.Delay(1000).Wait();
        }
        private void menuDBUsers_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 30;
            new Thread(() =>
            {
                DBUsersForm dbUsersForm = new DBUsersForm(userMy);
                this.Invoke(new Action(() =>
                {
                    this.Visible = false;
                    if (dbUsersForm.ShowDialog() == DialogResult.Retry)
                    {
                        this.Visible = true;
                        if (MessageBox.Show("Обновить данные?", "Сообщение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            updateData_Click(sender, e);
                        }
                        toolStripProgressBar1.Value = 0;
                    }
                }));
            }).Start();
            Task.Delay(1000).Wait();
            toolStripProgressBar1.Value = 75;
            Task.Delay(1000).Wait();
        }

        private void menuHelpProvider_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider.HelpNamespace);
        }

        private void menuAboutProgram_Click(object sender, EventArgs e)
        {
            var aboutProgram = new AboutProgramForm();
            aboutProgram.ShowDialog();
        }


        private void updateData_Click(object sender, EventArgs e)
        {
            //Обновление всех данных с использование дополнительной формой загрузки данных
            //Для того чтобы пользователь
            var loadForm = new LoadForm();
            loadForm.Show();
            loadForm.EditTextProgress("Идет обновление данных", 45);
            new Task(() =>
            {
                this.Invoke(new Action(() =>
                {
                    dataGridUsers.DataSource = ReadUserAll(options);
                    dataGridProduct.DataSource = FormatDataGridAdmin(options);
                    loadForm.Close();
                    statusChange = false;
                    Status();
                   
                }));
                
            }).Start();
            Task.Delay(1000).Wait();
            loadForm.EditTextProgress("Обновление всех клиентов ...", 65);
            Task.Delay(1000).Wait();
            loadForm.EditTextProgress("Обновление всех заказов ...", 75);
            Task.Delay(1000).Wait();
            loadForm.EditTextProgress("Загрузка почти завершена ...", 95);
            Task.Delay(1000).Wait();
           
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exit) Application.Exit();
        }
    }
}
