using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Autoparts_NVA.Models
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public class Users
    {

        /// <summary>
        /// Уникальный номер пользователя
        /// </summary>
        public int user_id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public string gender { get; set; }
        /// <summary>
        /// день рождение
        /// </summary>
        public DateTime birthday { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// права пользователя
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// пароль
        /// </summary>
        public string password { get; set; }
    }
}
