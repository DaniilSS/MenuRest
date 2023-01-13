using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMenu
{
    internal class Dish
    {
        string _name;
        int _cost;

        public Dish(string[] dishParams)
        {
            _name = dishParams[0];
            _cost = Convert.ToInt32(dishParams[1]);
        }
    }
}
