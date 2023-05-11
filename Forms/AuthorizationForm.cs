using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class AuthorizationForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        public AuthorizationForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            progressBarLoad.Value = 0;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            progressBarLoad.Value = 0;
            using (var db = new ApplicationContext(options))
            {
                var addForm = new UsersForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    progressBarLoad.Value = 75;
                    Users unic = db.UserDB.FirstOrDefault(x => x.phone == addForm.Users.phone);
                    if (unic != null)
                    {
                        MessageBox.Show("Номер уже существует. Регистрация не подтверждена!");
                        progressBarLoad.Value = 0;
                        return;
                    }
                    addForm.Users.password = getHashSha256(addForm.Users.password);
                    db.UserDB.Add(addForm.Users);
                    db.SaveChanges();
                    progressBarLoad.Value = 100;
                }
            }

        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            progressBarLoad.Value = 0;
            using (var db = new ApplicationContext(options))
            {
                var enterUser = new EnterUserForm();
                if (enterUser.ShowDialog() == DialogResult.OK)
                {
                    progressBarLoad.Value = 75;
                    Users unic = db.UserDB.FirstOrDefault(x => x.phone == enterUser.Users.phone &&
                                                            x.password == getHashSha256(enterUser.Users.password));
                    if (unic == null)
                    {
                       
                        MessageBox.Show("Пользователь не найден!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        progressBarLoad.Value = 0;
                        return;
                    }
                    progressBarLoad.Value = 100;
                    var mainForm = new MainForm(unic) ;
                    mainForm.Owner = this;
                    mainForm.Owner = this;
                    this.Hide();
                    mainForm.Show();
                }
            }
        }

        public static string getHashSha256(string text)
        {
            using (SHA256 hashString = SHA256.Create())
            {
                byte[] bytes = Encoding.Unicode.GetBytes(text);
                byte[] hash = hashString.ComputeHash(bytes);
                string hashstring = "";
                foreach (byte x in hash)
                {
                    hashstring += String.Format("{0:x2}", x);
                }
                return hashstring;
            }

        }
    }
}
