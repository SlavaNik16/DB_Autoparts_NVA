using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Autoparts_NVA.Models
{
    public class Autoparts
    {
        /// <summary>
        /// Уникальный номер продукта
        /// </summary>
        public int parts_id { get; set; }
        /// <summary>
        /// Id пользователя, которому принадлежит продукт
        /// </summary>
        public int id_user { get; set; }
        /// <summary>
        /// Вид продукта
        /// </summary>
        public int product { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// Дата покупки
        /// </summary>
        public DateTime dateBy { get; set; }
    }
}
