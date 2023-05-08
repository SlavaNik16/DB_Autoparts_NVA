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
        private bool cellFormat = false;
        private List<Product> listProducts = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
        }
        public MainForm(Users users) : this()
        {
            statusUser = ReturnStatusUser(options, users); 
            if (statusUser == "User")
            {
                menuBDUsers.Enabled = false;
                menuDBAutoparts.Enabled = false;
                toolEdit.Visible = false;
                toolDelete.Visible = false;
                toolEditProduct.Visible = false;
                toolDeleteProduct.Visible = false;
                dataGridUsers.DataSource = ReadUser(options, users);
                var autoparts = ReadUserProducts(options, users);
                dataGridProduct.DataSource = autoparts;
                for(int i = 0; i < dataGridProduct.RowCount; i++)
                    listProducts.Add(ReturnProduct(options, autoparts[i]));
            }
        }

        #region DBRequests
        private static string ReturnStatusUser(DbContextOptions<ApplicationContext> options, Users users)
        {
            using (var db = new ApplicationContext(options))
            {
                var user = db.UserDB.FirstOrDefault(u => u.phone == users.phone);
                return user.status;
            }
        }
        private static List<Users> ReadUser(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.UserDB.Where(x => x.user_id == user.user_id).ToList();
            }
        }
        private static List<Autoparts> ReadUserProducts(DbContextOptions<ApplicationContext> options, Users user)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.AutopartDB.Where(x => x.id_user == user.user_id).ToList();
            }
        }
        private static Product ReturnProduct(DbContextOptions<ApplicationContext> options, Autoparts autoparts)
        {
            using (var db = new ApplicationContext(options))
            {
                return db.ProductDB.Find(autoparts.product);
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


            var data = (Autoparts)dataGridProduct.Rows[e.RowIndex].DataBoundItem;
            if (dataGridProduct.Columns[e.ColumnIndex].Name == "columnIdProducts")
            {
                using (var db = new ApplicationContext(options))
                {
                    e.Value = listProducts[e.RowIndex].title;
                }
            }

            if (dataGridProduct.Columns[e.ColumnIndex].Name == "columnPrice")
            {
                e.Value = listProducts[e.RowIndex].price * data.count;
            }

        }
       
 
    }
}
