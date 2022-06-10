using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Logger : Cargo_Ship
    {
        public int logs { get; set; }
        public int log_weight { get; set; } = 319;


        public override string get_info()
        {
            return base.get_info() + " с " + logs + " бревнами по " + log_weight + " кг на борту.";
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
            return logs * log_weight * kilometers / 2;
        }

        public double kg_per_year()
        {
            return logs * log_weight * base.deliveries_per_year();
        }

        public void set_logs()
        {
            logs = Convert.ToInt32(get_capacity() * 1000 / (319)); //319 это вес бревна лиственницы
        }
    }
}
