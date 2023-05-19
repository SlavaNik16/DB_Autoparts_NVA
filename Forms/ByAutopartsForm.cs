using DB_Autoparts_NVA.Colors;
using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class ByAutopartsForm : Form
    {
        private readonly Autoparts autoparts;
        public DbContextOptions<ApplicationContext> options;
        public List<Product> list = null;
        public ByAutopartsForm()
        {
            InitializeComponent();
            this.BackColor = ColorsHelp.ColorBackground;
            panelHeader.BackColor = ColorsHelp.ColorBackgroundPanelBack;
            ColorsHelp.ButtonSubmit(butSave);
            ColorsHelp.ButtonCancel(butCancel);
            autoparts = new Autoparts();
            autoparts.count = 1;
            options = DataBaseHelper.Option();
            using (var db = new ApplicationContext(options))
            { 
                list = db.ProductDB.ToList();
                list.ForEach(x=> comboProduct.Items.Add(x.title));
                comboProduct.SelectedIndex = 0;
            }
        }
        public Autoparts Autoparts => autoparts;

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProduct.SelectedIndex != -1) {
                autoparts.product = list[comboProduct.SelectedIndex].id_product;
                txtBoxPrice.Text = (list[comboProduct.SelectedIndex].price * numCount.Value).ToString();
           }
        }

        private void numCount_ValueChanged(object sender, EventArgs e)
        {
            autoparts.count = (int)numCount.Value;
            txtBoxPrice.Text = (list[comboProduct.SelectedIndex].price * numCount.Value).ToString();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
