using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Tanker : Cargo_Ship
    {
        public int barrels { get; set; } //Минимальное число бочек
        public int volume_of_one_barrel { get; set; } = 217; //Стандартный объём бочки

        public override string get_info()
        {
            return base.get_info() + ". На борту при максимальной загрузке находятся " + barrels + " бочек с топливом по " + volume_of_one_barrel + " литров каждая.";
        }

        public override void deliver()
        {
            base.deliver();
        }

        public double barrels_per_year()
        {
            return barrels * volume_of_one_barrel * base.deliveries_per_year();
        }

        public void set_barrels()
        {
            barrels = Convert.ToInt32(Math.Floor(get_capacity() * 1000 / (volume_of_one_barrel * 0.76))); //0.76 плотность какого-то там бензина, поэтому пусть будет так
        }
    }
}
