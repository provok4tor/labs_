using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public abstract class Cargo_Ship : Ship
    {
        private int _load_capacity;
        private int _deliveries;
        private string _name;
        private int _duration;




        public int Load_capacity
        {
            get => _load_capacity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Грузоподъёмность меньше 0");

                _load_capacity = value;
            }
        }
        public int Deliveries
        {
            get => _deliveries;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Число доставок меньше 0");

                _deliveries = value;
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                    throw new ArgumentException("Пустое имя");

                _name = value;
            }
        }
        public int Duration
        {
            get => _duration;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательный срок службы");

                _duration = value;
            }
        }


        public virtual void deliver()
        {
            _deliveries++;
        }
        public virtual string get_info()
        {
            return "Плавучее судно с названием " + _name + " находится на плаву уже " + _duration + " лет. " +
                   "Его грузоподъёмность составляет " + _load_capacity + " тонн, а количество перевозок достигает " + _deliveries;
        }

        public virtual string get_name()
        {
            return _name;
        }

        public virtual int get_capacity()
        {
            return _load_capacity;
        }

        public double deliveries_per_year()
        {
            return Deliveries / Duration;
        }
    }
}
