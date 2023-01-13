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

        public static bool operator ==(Dish left, Dish right) => left.Equals(right);
        public static bool operator !=(Dish left, Dish right) => !left.Equals(right);


        private static bool IsNull(Dish left)
        {
            try
            {
                int i = left._id;
            }
            catch
            {
                return true;
            }
            return false;
        }


        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (this.GetType() != other.GetType())
                return false;
            return this.Equals(other as Dish);
        }

        public bool Equals(Dish other)
        {
            if(Dish.IsNull(other))
                return false;
            if (this.GetType() != other.GetType())
                return false;
            if (string.Compare(this._name, other._name, StringComparison.CurrentCulture) == 0 && this._cost.Equals(other._cost) && this._id.Equals(other._id))
                return true;
            else
                return false;
        }



    }
    public class DishComparer : IEqualityComparer<Dish>
    {
        public bool Equals(Dish x, Dish y)
        {
            return x == y;
        }

        public int GetHashCode(Dish obj)
        {
            return obj.GetHashCode();
        }
    }

}
