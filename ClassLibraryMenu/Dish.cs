using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMenu
{
    public class Dish:IEquatable<Dish>
    {
        int _id=0;
        string _name="";
        int _cost=0;
        public int ID=>_id;
        public string Name => _name;
        public int Cost => _cost;
        public Dish(string[] dishParams)
        {
            _id = Convert.ToInt32(dishParams[0]);
            _name = dishParams[1];
            _cost = Convert.ToInt32(dishParams[2]);
        }

        public Dish(int count, string name, int cost)
        {
            _id=count;
            _name = name;
            _cost = cost;
        }
        public Dish()
        {
        }

        public string GetStr()
        {
            return $"{_id};{_name};{_cost}";
        }


        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (this.GetType() != other.GetType())
                return false;
            if (string.Compare(this._name, ((Dish)other)._name, StringComparison.CurrentCulture) == 0 && this._cost.Equals(((Dish)other)._cost) && this._id.Equals(((Dish)other)._id))
                return true;
            else
                return false;
        }

        public bool Equals(Dish other)
        {
            if(other == null)
                return false;
            if (this.GetType() != other.GetType())
                return false;
            if (string.Compare(this._name, other._name, StringComparison.CurrentCulture) == 0 && this._cost.Equals(other._cost) && this._id.Equals(other._id))
                return true;
            else
                return false;
        }

    }
}
