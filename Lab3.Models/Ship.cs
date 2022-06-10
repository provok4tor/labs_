using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public interface Ship
    {
        /// <summary>
        /// Имя плавучего судна
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Срок суждбы кораблика
        /// </summary>
        int Duration { get; set; }
        /// <summary>
        /// Доставить
        /// </summary>
        void deliver();
        /// <summary>
        /// Получить информацию о плавучем судне
        /// </summary>
        /// <returns></returns>
        string get_info();
        string get_name();
    }
}
