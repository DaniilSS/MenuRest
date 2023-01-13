using ClassLibraryMenu;
using KURS.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS
{
    public class MenuManager
    {
        Menu _menu;
        internal void WriteToGrid(CTRLMenuListForm data)
        {
            data.Rows.Clear();
            _menu.Dishes.AsParallel().ForAll(x => data.Rows.Add(x.ID, x.Name, x.Cost));
        }
        public bool WriteToFile(string path)
        {
            try
            {
                File.WriteAllLines(path, _menu.GetStrMenu());
            }
            catch
            {
                return false;
            }
            return true;
        }
        
        public bool ReadFromFile(string path)
        {
            try
            {
                _menu = new Menu(File.ReadAllLines(path));
            }
            catch
            {
                return false;
            }
            return true;
        }


        public int AddNewDish(string name, int cost)
        {
            return _menu.Add(name, cost);
        }
    }
}
