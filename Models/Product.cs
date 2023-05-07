using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Autoparts_NVA.Models
{
    public class Product
    {

        /// <summary>
        /// id продукта
        /// </summary>
        public int id_product { get; set; }

        /// <summary>
        /// название
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// деньги за 1 шт
        /// </summary>
        public decimal price { get; set; }

    }
}
