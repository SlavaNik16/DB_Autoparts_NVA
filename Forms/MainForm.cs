using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Forms;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;
namespace DB_Autoparts_NVA
{
    public partial class MainForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        public string statusUser = "";
        private static Users userMy = null;//Пользователь
        private static Users userSelected = null;//Выделенные пользователи
        public MainForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            dataGridProduct.EnableHeadersVisualStyles = false;
            dataGridUsers.EnableHeadersVisualStyles = false;
            toolStripProgressBar1.Value = 0;
        }
        public MainForm(Users users) : this()
        {
            userMy = users;
            statusUser = ReturnStatusUser(options, users);
            contextMenuStrip2.Enabled = false;
            if (statusUser == "User")
            { 
                statusStripUserLabel.Text = "Статус: Пользователь";
                menuBDUsers.Enabled = false;
                menuDBAutoparts.Enabled = false;
                toolEdit.Visible = false;
                toolDelete.Visible = false;
                toolDeleteProduct.Text = "Oтменить покупку";
                CountUsersStatusStrip.Visible = false;
                MoneyUserStatusStrip.Visible = false;
                toolSearchBox.Visible = false;
                dataGridProduct.Columns["columnIdUser"].Visible = false;
                dataGridUsers.DataSource = ReadUser(options);
                dataGridProduct.DataSource = FormatDataGridUser(options, userMy);
                Status();
            }else if(statusUser == "Admin")
            {
                statusStripUserLabel.Text = "Статус: Админ";
                contextMenuStrip2.Enabled = true;
                dataGridProduct.Columns["columnIdUser"].Visible = true;
                dataGridProduct.Columns["columnIdUser"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridUsers.DataSource = ReadUserAll(options);
                dataGridProduct.DataSource = FormatDataGridAdmin(options);
                Status();
            }
        }


        #region DBRequests

        public List<AutopartsFormat> FormatDataGridUser(DbContextOptions<ApplicationContext> options,Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = ReadUserAutoparts(options, user);
                var format = tovar.Select(x => new AutopartsFormat()
                {
                    Id_user = x.id_user,
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
        public List<AutopartsFormat> FormatDataGridAdmin(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = ReadAutoparts(options);
                var format = tovar.Select(x => new AutopartsFormat()
                {
                    Id_user = x.id_user,
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
        private static string ReturnStatusUser(DbContextOptions<ApplicationContext> options, Users users)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.UserDB.FirstOrDefault(u => u.phone == users.phone).status;
            }
        }
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
                return db.AutopartDB.Where(x => x.id_user == user.user_id).OrderByDescending(i=>i.parts_id).ToList();
            }
        }
        private static List<Users> ReadUserAll(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                var userList = db.UserDB.Where(x=>x.user_id != userMy.user_id).OrderByDescending(x => x.user_id).ToList();
                userList.Insert(0, userMy);
                return userList;
            }
        }

        private static List<Autoparts> ReadAutoparts(DbContextOptions<ApplicationContext> options)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.AutopartDB.OrderByDescending(x=>x.parts_id).ToList();
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
                var product  = db.AutopartDB.FirstOrDefault(u => u.parts_id == autopartsId);
                if (product != null)
                {
                    db.AutopartDB.Remove(product);
                    db.SaveChanges();
                }
            }

        }
        private static void RemoveUsersDB(DbContextOptions<ApplicationContext> options, int usersId)
        {
            using (var db = new ApplicationContext(options))
            {
                var user  = db.UserDB.FirstOrDefault(u => u.user_id == usersId);
                
                if (user != null)
                {
                    var tovars = db.AutopartDB.Where(x => x.id_user == user.user_id).ToList();
                    db.AutopartDB.RemoveRange(tovars);
                    db.UserDB.Remove(user);
                    db.SaveChanges();
                }
            }

        }
        private static void UpdateUsersDB(DbContextOptions<ApplicationContext> options, Users user)
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
            Close();
            var authForm = new AuthorizationForm();
            authForm.Visible = true;
        }

        private void menuDBUsers_Click(object sender, EventArgs e)
        {
            DBUsersForm dbUsersForm = new DBUsersForm();
            dbUsersForm.ShowDialog();
        }


        private void toolAddProduct_Click(object sender, EventArgs e)
        {
            var byProductForm = new ByAutopartsForm();
            if(byProductForm.ShowDialog() == DialogResult.OK)
            {
                toolStripProgressBar1.Value = 0;
                ByTovarDB(options, byProductForm.Autoparts);
                toolStripProgressBar1.Value = 75;
                dataGridProduct.DataSource = FormatDataGridUser(options,userMy);
                toolStripProgressBar1.Value = 100;
                Status();
                toolStripProgressBar1.Value = 0;
            }
        }

        private void dataGridProduct_SelectionChanged(object sender, EventArgs e)
        {
            toolDeleteProduct.Enabled =
            dataGridProduct.SelectedRows.Count > 0;
        }

        private void toolDeleteProduct_Click(object sender, EventArgs e)
        {
            var autopart = (AutopartsFormat)dataGridProduct.Rows[dataGridProduct.SelectedRows[0].Index].DataBoundItem;
            if (autopart.Id_user != userMy.user_id)
            {
                MessageBox.Show($"Вы не можете удалить чужую покупку!");
                return;
            }
            if (MessageBox.Show($"Вы действительно хотите отменить покупку с \n\rId: {autopart.Parts_id}",
               "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                toolStripProgressBar1.Value = 0;
                RemoveTovarDB(options, autopart.Parts_id);
                toolStripProgressBar1.Value = 75;
                dataGridProduct.DataSource = FormatDataGridUser(options, userMy);
                Status();
                toolStripProgressBar1.Value = 0;
            }
            
        }

        private void Status()
        {
            var allMoney = AllMoney();
            AllMoneyStatusStrip.Text = $"Общая сумма: {allMoney:C2}";
            CountUsersStatusStrip.Text = $"Кол-во пользователей: {ReadUserAll(options).Count}";
            if (dataGridUsers.SelectedRows.Count > 0)
            {
                userSelected = (Users)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;
               
                MoneyUserStatusStrip.Text = $"Прибыль у данного пользователя: { MoneyUser(userSelected)}";
            }
            else
            {
                MoneyUserStatusStrip.Text = $"Прибыль у данного пользователя: 0";
            }
        }

        public decimal MoneyUser(Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = db.AutopartDB.Where(x => x.id_user == userSelected.user_id).ToList();
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
                    var tovar = db.AutopartDB.Where(x => x.id_user == userMy.user_id).ToList();
                    allMoney = tovar.Sum(f => f.count * db.ProductDB.Find(f.product).price);
                }
                else if(statusUser == "Admin")
                {
                    var tovar = db.AutopartDB.ToList();
                    allMoney = tovar.Sum(f => f.count * db.ProductDB.Find(f.product).price);

                }
                return allMoney;
            }
           
        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 60;
            ExportUserForm exportForm = null;
            if (statusUser == "User")
            {
                exportForm = new ExportUserForm(userMy);
            }
            else if(statusUser == "Admin")
            {
                exportForm = new ExportUserForm(userSelected);
            }
            toolStripProgressBar1.Value = 75;
            this.Visible = false;
            toolStripProgressBar1.Value = 100;
            if (exportForm.ShowDialog() == DialogResult.Yes)
            {
                this.Visible = true;
            }
            toolStripProgressBar1.Value = 0;
        }

        private void menuUpgradeStatus_Click(object sender, EventArgs e)
        {
            if (userMy.status == "User")
            {
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
            var keyForm = new UpgradeStatusForm(statusUser);
            keyForm.Show();

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void dataGridUsers_SelectionChanged(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            if (statusUser == "Admin")
            {
                menuExport.Enabled =
                toolEdit.Enabled =
                toolDelete.Enabled =
                     dataGridUsers.SelectedRows.Count > 0;
               
                if (dataGridUsers.SelectedRows.Count > 0)
                { 
                    toolStripProgressBar1.Value = 50;
                    userSelected = (Users)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;
                    dataGridProduct.DataSource = FormatDataGridUser(options, userSelected);
                    toolStripProgressBar1.Value = 75;

                }
                else
                {
                    toolStripProgressBar1.Value = 75;
                    dataGridProduct.DataSource = FormatDataGridAdmin(options);
                }
            }
            toolStripProgressBar1.Value = 100;
            Status();
            toolStripProgressBar1.Value = 0;

        }

        private void dataGridUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex == 0 && userMy.status == "Admin") {
                if (dataGridUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == userMy.user_id.ToString())
                {
                    dataGridUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            userSelected = (Users)dataGridUsers.Rows[dataGridUsers.SelectedRows[0].Index].DataBoundItem;
            if(userSelected.status == "Admin" && userSelected.user_id != userMy.user_id)
            {
                MessageBox.Show("Вы не можете заблокировать другого Админа!");
                return;
            }
            if (MessageBox.Show($"Вы действительно хотите заблокировать пользователя с \n\rId: {userSelected.user_id}" +
                $"\n\rФамилия,Имя: {userSelected.surname},{userSelected.name}\n\rТелефон: {userSelected.phone}",
               "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                toolStripProgressBar1.Value = 0;
                RemoveUsersDB(options, userSelected.user_id);
                toolStripProgressBar1.Value = 75;
                dataGridUsers.DataSource = ReadUserAll(options);
                Status();
                toolStripProgressBar1.Value = 100;
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
                toolStripProgressBar1.Value = 0;
                UpdateUsersDB(options, usersForm.Users);
                toolStripProgressBar1.Value = 75;
                dataGridUsers.DataSource = ReadUserAll(options);
                toolStripProgressBar1.Value = 100;
                Status();
                toolStripProgressBar1.Value = 0;
            }
        }
    }
}
