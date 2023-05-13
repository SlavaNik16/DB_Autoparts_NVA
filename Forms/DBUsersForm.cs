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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class DBUsersForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        public DBUsersForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
            listBox.SelectedIndex = 0;
            using (var db = new ApplicationContext(options))
            {
                comboGender.DataSource = db.UserDB.OrderBy(x=>x.gender).Select(x=>x.gender).Distinct().ToList();
                comboBirthday.DataSource = db.UserDB.OrderBy(x => x.birthday).Select(x=>x.birthday).Distinct().ToList();
            }
             dataGridUsersDB.DataSource = GetAllUsers();
            
        }
        private List<Users> GetAllUsers()
        {
            return MainForm.ReadUserAll(options);
        }
        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
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
                switch (listBox.SelectedIndex)
                {
                    case 0:
                        colName = columnIdDataGridViewTextBoxColumn.DataPropertyName;
                        break;
                    case 1:
                        colName = columnSurnameDataGridViewTextBoxColumn.DataPropertyName;
                        break;
                    case 2:
                        colName = columnNameDataGridViewTextBoxColumn.DataPropertyName;
                        break;
                    case 3:
                        colName = columnBirthdayDataGridViewTextBoxColumn.DataPropertyName;
                        break;
                    case 4:
                        colName = сolumnEmailDataGridViewTextBoxColumn.DataPropertyName;
                        break;
                    case 5:
                        colName = columnPhoneDataGridViewTextBoxColumn.DataPropertyName;
                        break;
                    case 6:
                        colName = columnStatusDataGridViewTextBoxColumn.DataPropertyName;
                        break;
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
            dataGridUsersDB.DataSource = GetAllUsers();
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

            var mainForm = new MainForm();
            var user = (Users)dataGridUsersDB.Rows[dataGridUsersDB.SelectedRows[0].Index].DataBoundItem;
            mainForm.DeleteUser(user);
        }
    }
}
