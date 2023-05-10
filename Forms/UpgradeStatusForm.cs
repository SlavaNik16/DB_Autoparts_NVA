using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class UpgradeStatusForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        private Users users;
        public UpgradeStatusForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
        }
        public UpgradeStatusForm(Users user):this()
        {
            if(user.status == "Admin")
            {
                MessageBox.Show("Вы уже повысили доступ!");
                returnMain();
            }
            users = user;
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull == false)
            {
                MessageBox.Show("Ключ не соответствует маске!!!");
                return;
            }
            using(var db = new ApplicationContext(options))
            {
                var key = db.KeyDB.FirstOrDefault(x=>x.keys == maskedTextBox1.Text.ToString());
                if(key == null)
                {
                    MessageBox.Show("Ключ не найден!!!");
                    return;
                }
                users.status = "Admin";
                db.UserDB.Update(users);
                db.KeyDB.Remove(key);
                db.SaveChanges();
                returnMain();
            }

        }
        private void returnMain()
        {
            var mainForm = new MainForm(users);
            this.Close();
            mainForm.Show();
        }
    }
}
