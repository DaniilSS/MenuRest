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
        public int Cost => Dishes.Select(x => x.Key.Cost * x.Value).Sum();
        public int ID { get => _id; set => _id = value; }
        Dictionary<Dish, int> Dishes = new Dictionary<Dish, int>();
        public Order()
        {
            _id = new Random().Next();
            Dishes = new Dictionary<Dish, int>();
        }

        public void Add(Dish dish)
        {
            if(Dishes.Keys.Contains(dish))
            {
                Dishes[dish]++;                
            }
            else
            {
                Dishes.Add(dish, 1);
            }
        }

        public void RemoveOne(Dish dish)
        {
            if (Dishes.Keys.Contains(dish))
            {
                Dishes[dish]--;
                if(Dishes[dish]<=0)
                    Remove(dish);
            }

        }

        public void Remove(Dish dish)
        {
            if (Dishes.Keys.Contains(dish))
            {
                Dishes.Remove(dish);
            }
        }
    }
}
