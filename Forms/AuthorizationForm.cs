﻿using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class AuthorizationForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        private Stopwatch stopwatch;
        public AuthorizationForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            progressBarLoad.Value = 0;
            stopwatch = new Stopwatch();
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
                progressBarLoad.Value = 45;
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
                    progressBarLoad.Value = 0;
                }
            }

        }

        private async void butEnter_Click(object sender, EventArgs e)
        {
            progressBarLoad.Value = 0;
            using (var db = new ApplicationContext(options))
            {
                var enterUser = new EnterUserForm();
                if (enterUser.ShowDialog() == DialogResult.OK)
                {

                    progressBarLoad.Value = 75;
                    var hesh = getHashSha256(enterUser.Users.password);


                    var unic = db.UserDB.Where(x => x.phone.StartsWith(enterUser.Users.phone)).FirstOrDefault(x => x.password == hesh);


                    if (unic == null)
                    {

                        MessageBox.Show("Пользователь не найден!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        progressBarLoad.Value = 0;
                        return;
                    }


                    progressBarLoad.Value = 100;

                    var mainForm = new MainForm(unic);
                    var loadForm = new LoadForm();
                        loadForm.Show(); 
                        loadForm.BeginInvoke((MethodInvoker)delegate ()
                        {
                            loadForm.EditTextProgress("Создаем экземпляр формы", 10); 
                          
                        });   
                    mainForm.Owner = this;
                    this.Hide();
                    mainForm.Show();
                    //stopwatch.Start();
                    //stopwatch.Stop();
                    //MessageBox.Show($"{stopwatch.ElapsedMilliseconds}"); 

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
