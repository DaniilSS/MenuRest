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
    }
}
