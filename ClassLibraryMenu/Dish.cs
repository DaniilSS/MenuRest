using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMenu
{
    public class Dish
    {
        int _id;
        string _name;
        int _cost;
        public int ID=>_id;
        public string Name => _name;
        public int Cost => _cost;
        public Dish(string[] dishParams)
        {
            _id = Convert.ToInt32(dishParams[0]);
            _name = dishParams[1];
            _cost = Convert.ToInt32(dishParams[2]);
        }

        internal string GetStr()
        {
            return $"{_id};{_name};{_cost}";
        }
    }
}
