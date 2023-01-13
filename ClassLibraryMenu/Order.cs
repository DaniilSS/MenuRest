using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMenu
{
    public class Order
    {
        DishComparer comparer = new DishComparer();
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
            Dish tdish = Dishes.Keys.Where(x => x == dish).FirstOrDefault();
            if (Dishes.Keys.Contains(dish,comparer))
            {
                Dishes[tdish]++;
            }
            else
            {
                Dishes.Add(dish, 1);
            }
        }

        public void RemoveOne(Dish dish)
        {
            Dish tdish = Dishes.Keys.Where(x => x == dish).FirstOrDefault();
            if (!(tdish is null))
                if (Dishes.Keys.Contains(tdish))
                {
                    Dishes[tdish]--;
                    if (Dishes[tdish] <= 0)
                        Remove(tdish);
                }

        }

        public void Remove(Dish dish)
        {
            Dish tdish = Dishes.Keys.Where(x => x == dish).FirstOrDefault();
            if (!(tdish is null))
                if (Dishes.Keys.Contains(tdish))
                {
                    Dishes.Remove(tdish);
                }
        }
    }
}
