using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorfverwaltung
{
    public partial class FormRemove : Form
    {
        public Form1 form1 { get; set; }
        private Object context { get; set; }
        private List<Tribe> tribeList { get; set; }

        public FormRemove(Object context, Form1 form1, List<Tribe> tribeList)
        {
            InitializeComponent();
            this.form1 = form1;
            this.context = context;
            this.tribeList = tribeList;
            if (context is Tribe tribe)
                checkedListBoxControlRemove.DataSource = DoStuff.FindAllTribeNames(tribeList);
            if (context is Dwarf dwarf)
                checkedListBoxControlRemove.DataSource = DoStuff.FindAllDwarfNames(tribeList);
            if (context is Weapon weapon)
                checkedListBoxControlRemove.DataSource = DoStuff.FindAllWeaponsWithDwarfName(DoStuff.FindAllDwarfs(tribeList));
        }

        private void simpleButtonRemove_Click(object sender, EventArgs e)
        {
            if (context is Tribe tribe)
                form1.RemoveChanges(tribe, getSelectedString());
            if (context is Dwarf dwarf)
                form1.RemoveChanges(dwarf, getSelectedString());
            if (context is Weapon weapon)
                form1.RemoveChanges(weapon, getSelectedString());
            this.Close();
        }

        private string getSelectedString()
        {
            if (checkedListBoxControlRemove.CheckedItemsCount != 0)
                return checkedListBoxControlRemove.CheckedItems[0].ToString();
            else
                return null;
        }
    }
}
