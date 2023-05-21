
using DB_Autoparts_NVA.Colors;
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
        private Users userMy;
        private const int COLUMN_PRICE = 2;
        private bool exit = false;
        public DBProductsForm()
        {
            InitializeComponent();
            this.dataGridProductDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            options = DataBaseHelper.Option();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(searchBox, "Введите сюда критерий поиска товара по фамилии");
        }
        public void Init()
        {
            listBox.SelectedIndex = 0;
            using (var db = new ApplicationContext(options))
            {
                var list = MainForm.FormatDataGridAdmin(options);
                dataGridProductDB.DataSource = list;
                comboTovar.DataSource = db.AutopartDB.Select(x =>
                                        db.ProductDB.FirstOrDefault(f => f.id_product == x.product).title).Distinct().ToList();

            }

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            var isSearch = false;
            for (int i = 0; i < dataGridProductDB.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridProductDB.RowCount; j++)
                {
                    dataGridProductDB[i, j].Style.BackColor = Color.FromArgb(255, 255, 251, 217);
                    dataGridProductDB[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridProductDB.RowCount; i++)
            {
                if (dataGridProductDB.Rows[i].Cells[COLUMN_PRICE].Value.ToString().Contains(searchBox.Text))
                {
                    isSearch = true;
                    dataGridProductDB.Rows[i].Cells[COLUMN_PRICE].Style.BackColor = Color.AliceBlue;
                    dataGridProductDB.Rows[i].Cells[COLUMN_PRICE].Style.ForeColor = Color.Blue;
                }
            }
            if (!isSearch)
            {
                MessageBox.Show("Ничего не найдено!");
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




        private void butClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти!", "Приложение",
                  MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            exit = true;
            DialogResult = DialogResult.Cancel;
        }
        private void DBProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exit) Application.Exit();
        }

        private void DBProductsForm_Load(object sender, EventArgs e)
        {
            this.dataGridProductDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductDB.EnableHeadersVisualStyles = false;
            this.BackColor = ColorsHelp.ColorBackground;
            dataGridProductDB.BackgroundColor = ColorsHelp.ColorBackground;
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
