using DB_Autoparts_NVA.Colors;
using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
            this.BackColor = ColorsHelp.ColorBackground;
            ColorsHelp.ButtonSubmit(butReg);   
            ColorsHelp.ButtonSubmit(butEnter);
            ColorsHelp.ButtonCancel(butClose);

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butReg_Click(object sender, EventArgs e)
        {
            var addForm = new UsersForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                progressBarLoad.Value = 75;
                using (var db = new ApplicationContext(options))
                {
                    Users unic = db.UserDB.FirstOrDefault(x => x.phone == addForm.Users.phone);

                    if (unic != null)
                    {
                        MessageBox.Show("Номер уже существует. Регистрация не подтверждена!");
                        progressBarLoad.Value = 0;
                        return;
                    }
                }
                var loadForm = new LoadForm();
                loadForm.Show();
                loadForm.EditTextProgress("Регистрация пользователя ...", 45);
                new Task(() =>
                {
                    this.Invoke(new Action(() =>
                    {
                        using (var dbs = new ApplicationContext(options))
                        {
                            addForm.Users.password = getHashSha256(addForm.Users.password);
                            dbs.UserDB.Add(addForm.Users);
                            dbs.SaveChanges();
                        }
                        loadForm.Close();
                    }));
                }).Start();
                Task.Delay(1000).Wait();
                loadForm.EditTextProgress("Регистрация почти завершена ...", 85);
                Task.Delay(1000).Wait();
            }
        }

        private async void butEnter_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext(options))
            {
                var enterUser = new EnterUserForm();
                if (enterUser.ShowDialog() == DialogResult.OK)
                {

                    var hesh = getHashSha256(enterUser.Users.password);

                    var unic = db.UserDB.Where(x => x.phone.StartsWith(enterUser.Users.phone)).FirstOrDefault(x => x.password == hesh);
                    if (unic == null)
                    {

                        MessageBox.Show("Пользователь не найден!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var loadForm = new LoadForm();
                    loadForm.Show();
                    loadForm.EditTextProgress("Подгрузка всех данных", 45);
                    new Task(() =>
                    {
                        var mainForm = new MainForm(unic);
                        mainForm.Owner = this;
                        this.Invoke(new Action(() =>
                        {
                            mainForm.Show();
                            loadForm.Close();
                            this.Hide();
                        }));
                    }).Start();
                    Task.Delay(1000).Wait();
                    loadForm.EditTextProgress("Взятие всех покупок ...", 65);
                    Task.Delay(1000).Wait();
                    loadForm.EditTextProgress("Открытие формы ...", 75);
                    Task.Delay(3000).Wait();
                    loadForm.EditTextProgress("Загрузка почти завершена ...", 95);
                    Task.Delay(1000).Wait();



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
