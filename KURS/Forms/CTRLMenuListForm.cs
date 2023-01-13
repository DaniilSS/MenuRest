
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KURS.Enums.MyEnums;
using ClassLibraryMenu;

namespace KURS.Forms
{
    public partial class CTRLMenuListForm : DataGridView
    {
        eTypeCtrl _type;
        MenuManager _manager;
        public CTRLMenuListForm()
        {
            InitializeComponent();

        }
        public CTRLMenuListForm(eTypeCtrl type,MenuManager menuManager)
        {
            InitializeComponent();
            _type = type;
            _manager = menuManager;
            InitColumn(1, "ID", "ID",true);
            InitColumn(200,"ColName", "Название блюда");
            InitColumn(300,"ColCost", "Цена");
            _manager.WriteToGrid(this);
        }

        public void InitColumn(int width, string name, string header,bool visible =false)
        {
            this.Columns.Add(name, header);
            this.Columns[name].Width = width;
            this.Columns[name].Visible = visible;
        }
    }
}
