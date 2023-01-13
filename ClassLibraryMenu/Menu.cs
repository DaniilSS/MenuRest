using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibraryMenu
{
    public class Menu
    {
        List<Dish> _dishes = new List<Dish> { };
        public List<Dish> Dishes { get=>_dishes; }

        public Menu(string filePath)
        {
            _dishes = ReadFromFile(filePath);
        }

        private List<Dish> ReadFromFile(string filePath)
        {
            List<string> dishes = File.ReadAllLines(filePath).ToList();
            return dishes.Select(x => new Dish(x.Split(';'))).ToList();            
        }
        public string[] GetStrMenu()
        {
            return _dishes.Select(x => x.GetStr()).ToArray();
        }
    }
}
