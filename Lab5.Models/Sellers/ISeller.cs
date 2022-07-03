using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models.Sellers
{
    public interface ISeller
    {
        //Что продаёт
        List<int> ProductsIndexes { get; }
    }
}
