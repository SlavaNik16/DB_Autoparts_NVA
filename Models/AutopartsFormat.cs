using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Autoparts_NVA.Models
{
    public class AutopartsFormat
    {
        public int Parts_id { get; set; }
        ///<summary>
        /// Id пользователя, которому принадлежит продукт
        /// </summary>
        /// <summary>
        /// Id пользователя, которому принадлежит продукт
        /// </summary>  
        public int Id_user { get; set; }
        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string UserSurname { get; set; }
        /// <summary>
        /// Уникальный номер продукта
        /// </summary>
        public string NameProduct { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Общая цена
        /// </summary>
        public string PriceAll { get; set; }
        /// <summary>
        /// Дата покупки
        /// </summary>
        public DateTime DateBy { get; set; }
    }
}
