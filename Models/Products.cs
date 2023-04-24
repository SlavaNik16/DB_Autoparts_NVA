using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Autoparts_NVA.Models
{
    public class Products
    {

        /// <summary>
        /// id продукта
        /// </summary>
        public string id_products { get; set; }

        /// <summary>
        /// название
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// деньги за 1 шт
        /// </summary>
        public double price { get; set; }

    }
}
