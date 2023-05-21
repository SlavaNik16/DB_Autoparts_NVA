using DB_Autoparts_NVA.Colors;
using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using iTextSharp.text.pdf.qrcode;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;

namespace DB_Autoparts_NVA.Forms
{
    public partial class AddProductForm : Form
    {
        public DbContextOptions<ApplicationContext> options;
        private decimal price = 100;
        public AddProductForm()
        {
            InitializeComponent();
            options =DataBaseHelper.Option();
            this.BackColor = ColorsHelp.ColorBackground;
            groupBoxBack.BackColor = ColorsHelp.ColorBackgroundPanelBack;
            ColorsHelp.ButtonSubmit(butAddProduct);
            ColorsHelp.ButtonCancel(butСancel);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtBoxName, "Введите сюда название товара");
            toolTip.SetToolTip(txtBoxPriceOne, "Введите сюда цену товара за 1 шт");
        }

        private void butAddProduct_Click(object sender, EventArgs e)
        {
            var str = decimal.Round(decimal.Parse(txtBoxPriceOne.Text.ToString()),2).ToString().Replace(',','.');
            decimal.TryParse(str, NumberStyles.Number, CultureInfo.InvariantCulture, out price);
            using (var db = new ApplicationContext(options))
            {
                var product = new Product();
                product.title = txtBoxName.Text.ToString();
                product.price = price;
                db.ProductDB.Add(product);
                db.SaveChanges();
                this.Close();
            }
        }

        private void butСancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxPriceOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
      

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            Validates();
        }

        private void txtBoxPriceOne_TextChanged(object sender, EventArgs e)
        {
            Validates();
        } 
        
        public void Validates()
        {
            butAddProduct.Enabled =
                !string.IsNullOrWhiteSpace(txtBoxName.Text.ToString()) &&
                !string.IsNullOrWhiteSpace(txtBoxPriceOne.Text.ToString()) &&
                (decimal.TryParse(txtBoxPriceOne.Text.ToString(),out price) && 
                price > 100m && price < 99999.99m);
        }

    }
}
