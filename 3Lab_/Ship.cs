using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Lab_
{
    public interface Ship
    {
        /// <summary>
        /// Имя плавучего судна
        /// </summary>
        string name { get; set; }
        /// <summary>
        /// Срок суждбы кораблика
        /// </summary>
        int duration { get; set; }
        /// <summary>
        /// Доставить
        /// </summary>
        void deliver();
        /// <summary>
        /// Получить информацию о плавучем судне
        /// </summary>
        /// <returns></returns>
        string get_info();
    }


    public abstract class Cargo_Ship : Ship
    {
        /// <summary>
        /// Грузоподъёмность кораблика
        /// </summary>
        public int load_capacity;
        /// <summary>
        /// Число доставок
        /// </summary>
        public int deliveries;
        public abstract string name { get; set; }
        public abstract int duration { get; set; }

        public abstract void deliver();
        public abstract string get_info();
    }


    public class Tanker : Cargo_Ship
    {
        public Tanker(string name_, int duration_, int load_capacity_, int deliveries_)
        {
            name = name_;
            duration = duration_;
            load_capacity = load_capacity_;
            deliveries = deliveries_;
        }
        public override string name { get; set; }
        public override int duration { get; set; }


        public override string get_info()
        {
            return "Плавучее судно с названием " + name + " находится на плаву уже " + duration + " лет. " +
                    "Его грузоподъёмность составляет " + load_capacity + " тонн, а количество перевозок достигает " + deliveries;
        }

        public override void deliver()
        {
            deliveries++;
        }
    }



    
}
