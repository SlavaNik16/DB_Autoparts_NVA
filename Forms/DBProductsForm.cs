
using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class DBProductsForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        private MainForm mainForm;
        private const int COLUMN_PRICE = 2;
        public DBProductsForm()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();
        }
        public DBProductsForm(Users user) : this()
        {
            mainForm = new MainForm(user);
            Init();
        }
        public void Init()
        {
            listBox.SelectedIndex = 0;
            using (var db = new ApplicationContext(options))
            {
                var list = MainForm.FormatDataGridAdmin(options);
                dataGridProductDB.DataSource = list;
                comboTovar.DataSource = db.AutopartDB.Select(x =>
                                        db.ProductDB.FirstOrDefault(f=>f.id_product == x.product).title).Distinct().ToList();
               
            }

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridProductDB.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridProductDB.RowCount; j++)
                {
                    dataGridProductDB[i, j].Style.BackColor = Color.FromArgb(255,255, 251, 217);
                    dataGridProductDB[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridProductDB.RowCount; i++)
            {
                if (dataGridProductDB.Rows[i].Cells[COLUMN_PRICE].Value.ToString().Contains(searchBox.Text))
                {
                    dataGridProductDB.Rows[i].Cells[COLUMN_PRICE].Style.BackColor = Color.AliceBlue;
                    dataGridProductDB.Rows[i].Cells[COLUMN_PRICE].Style.ForeColor = Color.Blue;
                }
            }
        }

        private void butFiltr_Click(object sender, EventArgs e)
        {
            dataGridProductDB.DataSource = MainForm.FiltrProductTitle(options, comboTovar.SelectedItem.ToString());
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                string colName = "";
                if (listBox.SelectedIndex >= 1)
                {
                    colName = dataGridProductDB.Columns[listBox.SelectedIndex + 1].DataPropertyName;
                }
                else
                {
                    colName = dataGridProductDB.Columns[listBox.SelectedIndex].DataPropertyName;
                }

                if (radioOrder.Checked)
                    dataGridProductDB.DataSource = MainForm.SortProductOrderBy(options, colName);
                else
                    dataGridProductDB.DataSource = MainForm.SortProductOrderByDescending(options, colName);
            }
        }

        private void butViewAll_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void DBProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.InitAdminDataGrid();
            mainForm.Show();
        }

        private void butClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void DBProductsForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            progressBar.Value = 75;
            if (MessageBox.Show("Вы уверены что хотите выйти!", "Приложение",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mainForm.InitAdminDataGrid();
                mainForm.Show();
                e.Cancel = true;
            }
            e.Cancel = false;
            progressBar.Value = 0;
        }
    }
}
