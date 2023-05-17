using DB_Autoparts_NVA.Colors;
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
using Keys = DB_Autoparts_NVA.Models.Keys;

namespace DB_Autoparts_NVA.Forms
{
    public partial class UpgradeStatusForm : Form
    {
        public DbContextOptions<ApplicationContext> options = DataBaseHelper.Option();
        private Users users;
        private String status;
        public UpgradeStatusForm()
        {
            InitializeComponent();
            butConfirm.Text = "Добавить";
            this.Text = "Добавление ключа";
            this.BackColor = ColorsHelp.ColorBackground;
            ColorsHelp.ButtonSubmit(butConfirm);
            ColorsHelp.ButtonCancel(butCancel);
            panelHeader.BackColor = ColorsHelp.ColorBackgroundPanelBack;

        }
        public UpgradeStatusForm(Users user):this()
        { 
            users = user;
            this.Text = "Повышение статуса";
            butConfirm.Text = "Подтвердить";
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
                if (users!=null)
                {
                    var key = db.KeyDB.FirstOrDefault(x => x.keys == maskedTextBox1.Text.ToString());
                    if (key == null)
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
                else
                {
                    var key = new Keys();
                    key.keys = maskedTextBox1.Text.ToString();
                    db.KeyDB.Add(key);
                    db.SaveChanges();
                    Close();
                }
            }

        }
        private void returnMain()
        {
            var mainForm = new MainForm(users);
            this.Close();
            mainForm.Show();
        }


        private void butCancel_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void UpgradeStatusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (users != null) returnMain();
        }
    }
}
