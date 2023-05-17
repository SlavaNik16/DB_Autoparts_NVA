using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class DBUsersForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        private Users usersMy = null;

        private bool exit = false;
        public DBUsersForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            Init();
        }
        public DBUsersForm(Users user) : this()
        {
            usersMy =user;
        }
        public void Init()
        {
            listBox.SelectedIndex = 0;
            using (var db = new ApplicationContext(options))
            {
                comboGender.DataSource = db.UserDB.OrderBy(x => x.gender).Select(x => x.gender).Distinct().ToList();
                comboBirthday.DataSource = db.UserDB.OrderBy(x => x.birthday).Select(x => x.birthday).Distinct().ToList();
                dataGridUsersDB.DataSource = db.UserDB.OrderBy(x => x.user_id).ToList();
            }
            ProgressBar.Value = 0;
           
        }
        private void butClose_Click(object sender, EventArgs e)
        {
            this.textTrip.Text = "Процесс закрытие формы ...";
            this.ProgressBar.Value = 75;
            if (MessageBox.Show("Вы уверены что хотите выйти!", "Приложение",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.textTrip.Text = "Процесс закрытие формы отменен";
                ProgressBar.Value = 0;
                return;
            }
            exit = true;
            if (usersMy == null) {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                var loadForm = new LoadForm();
                loadForm.Show();
                loadForm.EditTextProgress("Закрытие формы", 45);
                new Task(() =>
                {
                    var mainForm = new MainForm(usersMy);
                    this.Invoke(new Action(() =>
                    {
                        mainForm.Show();
                        loadForm.Close();
                        this.Close();
                    }));
                }).Start();
                Task.Delay(1000).Wait();
                loadForm.EditTextProgress("Открытие главной формы ...", 65);
                Task.Delay(1000).Wait();
                loadForm.EditTextProgress("Обновление данных ...", 75);
                Task.Delay(3000).Wait();
                loadForm.EditTextProgress("Загрузка почти завершена ...", 95);
                Task.Delay(1000).Wait();
            }

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            var isSearch = false;

            for (int i = 0; i < dataGridUsersDB.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridUsersDB.RowCount; j++)
                {
                    dataGridUsersDB[i, j].Style.BackColor = Color.White;
                    dataGridUsersDB[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridUsersDB.RowCount; i++)
            {
                if (dataGridUsersDB.Rows[i].Cells[1].Value.ToString().Contains(searchBox.Text))
                {
                    isSearch = true;
                    dataGridUsersDB.Rows[i].Cells[1].Style.BackColor = Color.AliceBlue;
                    dataGridUsersDB.Rows[i].Cells[1].Style.ForeColor = Color.Blue;
                }
            }
            if (!isSearch)
            {
                MessageBox.Show("Ничего не найдено!");
            }
        }

        private void butFiltr_Click(object sender, EventArgs e)
        {
            if (comboGender.Enabled || comboBirthday.Enabled)
            {
                var filtr = MainForm.FiltrPhoneAndGender(options,
                    (DateTime)comboBirthday.SelectedItem,
                    comboGender.SelectedItem.ToString(),
                    comboBirthday.Enabled,
                    comboGender.Enabled);
                dataGridUsersDB.DataSource = filtr;
            }
        }
           

        private void butSort_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                string colName = "";
                if(listBox.SelectedIndex >= 3)
                {
                    colName = dataGridUsersDB.Columns[listBox.SelectedIndex+1].DataPropertyName;
                }
                else
                {
                    colName = dataGridUsersDB.Columns[listBox.SelectedIndex].DataPropertyName;
                }
                
                if (radioOrder.Checked)
                    dataGridUsersDB.DataSource = MainForm.SortUsersOrderBy(options, colName);
                else
                    dataGridUsersDB.DataSource = MainForm.SortUsersOrderByDescending(options, colName);
            }
        }

        private void checkBoxGender_CheckedChanged(object sender, EventArgs e)
        {
            comboGender.Enabled = checkBoxGender.Checked;
        }

        private void checkBoxPhone_CheckedChanged(object sender, EventArgs e)
        {
            comboBirthday.Enabled = checkBoxPhone.Checked;
        }

        private void butViewAll_Click(object sender, EventArgs e)
        {
           Init();
        }

        private void dataGridUsersDB_SelectionChanged(object sender, EventArgs e)
        {
            menuExport.Enabled = dataGridUsersDB.SelectedRows.Count > 0;

            butEdit.Enabled =
            butDelete.Enabled =
                dataGridUsersDB.SelectedRows.Count > 0 && usersMy != null;

        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            var user = (Users)dataGridUsersDB.Rows[dataGridUsersDB.SelectedRows[0].Index].DataBoundItem;
            var exportForm = new ExportUserForm(user);
            this.Visible = false;
            if (exportForm.ShowDialog() == DialogResult.Yes)
            {
                this.Visible = true;
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 10;
            textTrip.Text = "Идет удаление пользователя";
            var user = (Users)dataGridUsersDB.Rows[dataGridUsersDB.SelectedRows[0].Index].DataBoundItem;
            if (user.status == "Admin")
            {
                MessageBox.Show("Вы не можете заблокировать другого Админа или себя!");
                return;
            }
            if (MessageBox.Show($"Вы действительно хотите заблокировать пользователя с \n\rId: {user.user_id}" +
                $"\n\rФамилия,Имя: {user.surname},{user.name}\n\rТелефон: {user.phone}",
               "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainForm.RemoveUsersDB(options, user.user_id);
                ProgressBar.Value = 75;
                textTrip.Text = "Почти закончено!";
                Init();
                textTrip.Text = "Процессс успешно завершено!";
            }
        }


        private void butEdit_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 10;
            textTrip.Text = "Идет редактирование пользователя";
            var user = (Users)dataGridUsersDB.Rows[dataGridUsersDB.SelectedRows[0].Index].DataBoundItem;
            if (user.status == "Admin" && user.user_id != usersMy.user_id)
            {
                MessageBox.Show("Вы не можете редактировать другого Админа!");
                return;
            }
            var usersForm = new UsersForm(user);
            if (usersForm.ShowDialog() == DialogResult.OK)
            {
                MainForm.UpdateUsersDB(options, usersForm.Users);
                ProgressBar.Value = 75;
                textTrip.Text = "Почти закончено!";
                Init();
                textTrip.Text = "Процессс успешно завершено!";
                ProgressBar.Value = 0;
            }      
        }

        private void DBUsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!exit)Application.Exit();
        }
    }
}
