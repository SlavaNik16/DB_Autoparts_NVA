using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Autoparts_NVA.Models
{
    public class Keys
    {

        /// <summary>
        /// id ключа 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// специальный ключ
        /// </summary>
        public string keys { get; set; }
    }
}
