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
    public partial class ExportUserForm : Form
    {
        private List<String> list = new List<String>() { "Excel", "PDf", "Word" };
        public DbContextOptions<ApplicationContext> options;
        public ExportUserForm()
        {
            InitializeComponent();
        }
        public ExportUserForm(Users user) : this()
        {
            options = DataBaseHelper.Option();
            labelFIO.Text = $"{user.surname} {user.name}";
            labelPhone.Text = user.phone.ToString();
            FullComboType();
            using (var db = new ApplicationContext(options))
            {
                var tovar = db.AutopartDB.Where(x => x.id_user == user.user_id).ToList();
                var format = tovar.Select(x => new
                {
                    x.parts_id, 
                    NameProduct = db.ProductDB.Find(x.product).title,
                    x.count, 
                    priceAll = x.count * db.ProductDB.Find(x.product).price,
                    x.dateBy 
                }
                ).ToList();

                dataGridProductExport.DataSource = format;
            }
        }
        private void FullComboType()
        {
            foreach(var text in list)
            {
                comboBoxTypeExport.Items.Add(text);
            }
                
        }
    }
}
