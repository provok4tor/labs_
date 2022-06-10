using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Liner : Cargo_Ship
    {
        public int cabins { get; set; }
        public int cabin_capacity { get; set; } = 3;//ну предположим, что все кабины трёхместные


        public override string get_info()
        {
            return base.get_info() + " с " + cabins * cabin_capacity + " пассажирами на борту на борту.";
        }

        public override void deliver()
        {
            base.deliver();
        }

        public string info()
        {
            return get_info();
        }

        public int deliver_cost(int kilometers)
        {
            return  kilometers * 1000 / (cabins * cabin_capacity / 2);
        }

        public double passangers_per_year()
        {
            return cabins * cabin_capacity * base.deliveries_per_year();
        }

        public void set_cabins()
        {
            cabins = Convert.ToInt32(get_capacity() * 1000 / (3 * 80)); //возьмём средний вес людей за 80
        }
    }
}
