using DB_Autoparts_NVA.Colors;
using DB_Autoparts_NVA.DB;
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
            this.dataGridUsersDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            options = DataBaseHelper.Option();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(searchBox,"Введите сюда критерий поиска товара по фамилии"); 
        }
        public DBUsersForm(Users user) : this()
        {
            usersMy = user;
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
            DialogResult = DialogResult.Retry;

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
                if (listBox.SelectedIndex >= 3)
                {
                    colName = dataGridUsersDB.Columns[listBox.SelectedIndex + 1].DataPropertyName;
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
            menuExport.Enabled =
            butEdit.Enabled =
            butDelete.Enabled =
                    dataGridUsersDB.SelectedRows.Count > 0;

        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            textTrip.Text = "Подготовка пользователя к экспорту";
            ProgressBar.Value = 20;

           var thead = new Thread(() =>
            {
                var user = (Users)dataGridUsersDB.Rows[dataGridUsersDB.SelectedRows[0].Index].DataBoundItem;
                var expForm = new ExportUserForm(user);
                if (expForm.ShowDialog() == DialogResult.Yes)
                {
                    this.Invoke(new Action(() =>
                    {
                        textTrip.Text = "Действие";
                        ProgressBar.Value = 0;
                    }));
                }
            });
            thead.SetApartmentState(ApartmentState.STA);
            thead.Start();
            Task.Delay(1000).Wait();
            textTrip.Text = "Открытие окна";
            ProgressBar.Value = 70;
            Task.Delay(1000).Wait();

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
            if (!exit) Application.Exit();
        }

        private void DBUsersForm_Load(object sender, EventArgs e)
        {
            this.dataGridUsersDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsersDB.EnableHeadersVisualStyles = false;
            this.BackColor = ColorsHelp.ColorBackground;
            dataGridUsersDB.BackgroundColor = ColorsHelp.ColorBackground;
            statusStrip.BackColor = ColorsHelp.ColorBackgroundPanelBack;
            menuStrip.BackColor = ColorsHelp.ColorBackground;
            ColorsHelp.ButtonSubmit(butFiltr);
            ColorsHelp.ButtonSubmit(butSearch);
            ColorsHelp.ButtonSubmit(butSort);
            ColorsHelp.ButtonSubmit(butViewAll);
            ColorsHelp.ButtonCancel(butClose);
            Init();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            butSearch.Enabled =
              !string.IsNullOrWhiteSpace(searchBox.Text);
        }
    }
}
