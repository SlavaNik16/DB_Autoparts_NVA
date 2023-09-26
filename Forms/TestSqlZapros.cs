using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Autoparts_NVA.DB;
using DB_Autoparts_NVA.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ApplicationContext = DB_Autoparts_NVA.DB.ApplicationContext;
namespace DB_Autoparts_NVA.Forms
{
    public partial class TestSqlZapros : Form
    {
        public DbContextOptions<ApplicationContext> options;
        public TestSqlZapros()
        {
            InitializeComponent();
            options = DataBaseHelper.Option();

            using (var db = new ApplicationContext(options))
            {
                string query =
                    "Select Max(Autoparts.count * Product.price) from Autoparts, Product where Autoparts.product = Product.id_product";
                string query2 =
                    "Select top 1 Users.user_id, Users.surname, Users.name, Users.gender, Max(Autoparts.count * Product.price) as Summa " +
                    "from Users, Autoparts, Product " +
                    "where Autoparts.product = Product.id_product and Users.user_id = Autoparts.id_user " +
                    "Group by Users.user_id,Users.surname, Users.name, Users.gender order by Summa desc";
                SqlConnection connection = new SqlConnection(DataBaseHelper.GetConnectionString());
                connection.Open();

                SqlCommand command = new SqlCommand(query2, connection);
                SqlDataReader reader = command.ExecuteReader();

                var list = new List<UserMagnat>();
                while (reader.Read())
                {
                    var userMagnat = new UserMagnat()
                    {
                        Id = int.Parse(reader[0].ToString()),
                        Surname = reader[1].ToString(),
                        Name = reader[2].ToString(),
                        Gender = reader[3].ToString(),
                        Summa = decimal.Parse(reader[4].ToString()),
                    };
                    list.Add(userMagnat);
                    dataGridViewZapros.DataSource = list;
                }
                var tovarsList = db.AutopartDB.OrderByDescending(x => x.parts_id).ToList();
                var forma = tovarsList.Select(i => new UserMagnat()
                {
                    Id = i.id_user,
                    Surname = db.UserDB.Find(i.id_user).surname,
                    Name = db.UserDB.Find(i.id_user).name,
                    Gender = db.UserDB.Find(i.id_user).gender,
                    Summa = db.AutopartDB.Max(l => i.count * db.ProductDB.Find(i.product).price),
                }).OrderByDescending(s => s.Summa).ToList();
                var list2 = new List<UserMagnat>() { forma[0] } ;
                dataGridViewZapros.DataSource = list2;



                dataGridViewZapros2.DataSource = db.ProductDB.Select(i => new ProductCount()
                {
                    Id = i.id_product,
                    Price = i.price,
                    Title = i.title,
                    Counts = db.AutopartDB.Where(h => h.product == i.id_product).Count(),
                    CountsAll = db.AutopartDB.Where(h => h.product == i.id_product).Sum(y=>y.count),
                }).ToList();
            }

        }
    }
}
