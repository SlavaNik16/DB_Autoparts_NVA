using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Forms;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private static Users user = null;
        private List<Product> listProducts = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            dataGridProduct.EnableHeadersVisualStyles = false;
            dataGridUsers.EnableHeadersVisualStyles = false;
        }
        public MainForm(Users users) : this()
        {
          
            statusUser = ReturnStatusUser(options, users); 
            if (statusUser == "User")
            { 
                user = users;
                menuBDUsers.Enabled = false;
                menuDBAutoparts.Enabled = false;
                toolEdit.Visible = false;
                toolDelete.Visible = false;
                toolEditProduct.Visible = false;
                toolDeleteProduct.Text = "Oтменить покупку";
                CountUsersStatusStrip.Visible = false;
                MoneyUserStatusStrip.Visible = false;
                toolSearchBox.Visible = false;
                dataGridUsers.DataSource = ReadUser(options, users);
                FormatDataGrid(options,dataGridProduct, user);
                Status();
            }
        }


        #region DBRequests

        public void FormatDataGrid(DbContextOptions<ApplicationContext> options,DataGridView datagridView,Users users)
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = ReadUserAutoparts(options,user);
                var format = tovar.Select(x => new
                {
                    x.parts_id,
                    NameProduct = db.ProductDB.Find(x.product).title,
                    x.count,
                    priceAll = $"{x.count * db.ProductDB.Find(x.product).price:C2}",
                    x.dateBy
                }
                ).ToList();
                datagridView.DataSource = format;
            }
        } 
        private static string ReturnStatusUser(DbContextOptions<ApplicationContext> options, Users users)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.UserDB.FirstOrDefault(u => u.phone == users.phone).status;
            }
        }
        private static List<Users> ReadUser(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.UserDB.Where(x => x.user_id == user.user_id).ToList();
            }
        }

        private static List<Autoparts> ReadUserAutoparts(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.AutopartDB.Where(x => x.id_user == user.user_id).OrderByDescending(i=>i.parts_id).ToList();
            }
        }
        private static Product ReturnProduct(DbContextOptions<ApplicationContext> options, Autoparts autoparts)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.ProductDB.Find(autoparts.product);
            }
        }
        private static void ByTovarDB(DbContextOptions<ApplicationContext> options, Autoparts autoparts)
        {
            using (var db = new ApplicationContext(options))
            {
                autoparts.id_user = user.user_id;
                autoparts.dateBy = DateTime.Now;
                db.AutopartDB.Add(autoparts);
                db.SaveChanges();
            }
        }
        private static void RemoveTovarDB(DbContextOptions<ApplicationContext> options, Autoparts autoparts)
        {
            using (var db = new ApplicationContext(options))
            {
                var product  = db.AutopartDB.FirstOrDefault(u => u.parts_id == autoparts.parts_id);
                if (product != null)
                {
                    db.AutopartDB.Remove(product);
                    db.SaveChanges();
                }
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

        private void dataGridProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }

        private void toolAddProduct_Click(object sender, EventArgs e)
        {
            var byProductForm = new ByAutopartsForm();
            if(byProductForm.ShowDialog() == DialogResult.OK)
            {
                ByTovarDB(options, byProductForm.Autoparts);
                FormatDataGrid(options,dataGridProduct,user);
                Status();
            }
        }

        private void dataGridProduct_SelectionChanged(object sender, EventArgs e)
        {
            toolDeleteProduct.Enabled =
            dataGridProduct.SelectedRows.Count > 0;
        }

        private void toolDeleteProduct_Click(object sender, EventArgs e)
        {
            var autopart = (Autoparts)dataGridProduct.Rows[dataGridProduct.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите отменить покупку \n\rId: {autopart.parts_id}",
               "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveTovarDB(options, autopart);
                FormatDataGrid(options, dataGridProduct, user);
                Status();
            }
        }

        private void Status()
        {
            using (var db = new ApplicationContext(options))
            {

                var allMoney = AllMoney();
                AllMoneyStatusStrip.Text = $"Общая сумма: {allMoney:C2}";
            }
        }

        public decimal AllMoney()
        {
            using (var db = new ApplicationContext(options))
            {
                var tovar = db.AutopartDB.Where(x => x.id_user == user.user_id).ToList();
                var allMoney = tovar.Sum(f => f.count * db.ProductDB.Find(f.product).price);
                return allMoney;
            }
        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            var exportForm = new ExportUserForm(user);
            exportForm.ShowDialog();
        }
    }
}
