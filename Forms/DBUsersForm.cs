using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private MainForm mainForm;
        public DBUsersForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            Init();
        }
        public DBUsersForm(Users user) : this()
        {
            mainForm = new MainForm(user);
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
            mainForm.InitAdminDataGrid();
            mainForm.Show();
            this.Close();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
           
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
                    dataGridUsersDB.Rows[i].Cells[1].Style.BackColor = Color.AliceBlue;
                    dataGridUsersDB.Rows[i].Cells[1].Style.ForeColor = Color.Blue;
                }
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
            mainForm.DeleteUser(user);
            ProgressBar.Value = 75;
            textTrip.Text = "Почти закончено!";
            Init();
            textTrip.Text = "Процессс успешно завершено!";
        }


        private void butEdit_Click(object sender, EventArgs e)
        {
            ProgressBar.Value = 10;
            textTrip.Text = "Идет редактирование пользователя";
            var user = (Users)dataGridUsersDB.Rows[dataGridUsersDB.SelectedRows[0].Index].DataBoundItem;
            mainForm.EditUser(user);
            ProgressBar.Value = 75;
            textTrip.Text = "Почти закончено!";
            Init();
            textTrip.Text = "Процессс успешно завершено!";
        }
    }
}
