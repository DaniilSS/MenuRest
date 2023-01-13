﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryMenu
{
    public class Menu
    {
        List<Dish> _dishes = new List<Dish> { };
        public List<Dish> Dishes { get=>_dishes; }

        public Menu(string[] menu)
        {
            _dishes = ReadFromFile(menu);
        }

        private List<Dish> ReadFromFile(string[] menu)
        {
            return menu.Select(x => new Dish(x.Split(';'))).ToList();            
        }

        public string[] GetStrMenu()
        {
            return _dishes.Select(x => x.GetStr()).ToArray();
        }
        public int Add(string name,int cost)
        {
            _dishes.Add(new Dish(_dishes.Count+1, name, cost));
            return _dishes.Last().ID;
        }
    }
}
