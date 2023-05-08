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
            autoparts = new Autoparts();
            autoparts.count = 1;
            options = DataBaseHelper.Option();
            using (var db = new ApplicationContext(options))
            {
                list = db.ProductDB.ToList();
                if (list != null)
                {
                    FullComboBoxProduct(list);
                }
            }
        }
        public Autoparts Autoparts => autoparts;
        private void FullComboBoxProduct(List<Product> list)
        {
            foreach (var product in list)
            {
                comboProduct.Items.Add(product.title);
            }
            comboProduct.SelectedIndex = 0;
        }

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
    }
}
