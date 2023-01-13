using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMenu
{
    public class Order
    {
        int _id;
        public int ID { get => _id; set => _id = value; }
        Dictionary<Dish, int> Dishes = new Dictionary<Dish, int>();
    }
}
