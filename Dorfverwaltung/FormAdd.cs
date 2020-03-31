using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Dorfverwaltung
{
    public partial class FormAdd : Form
    {
        Form1 form1 = null;
        public FormAdd(BindingSource bindingSource, Form1 form1, List<Tribe> tribeList)
        {
            InitializeComponent();
            this.form1 = form1;
            vGridControl1.DataSource = bindingSource;
            if (bindingSource.DataSource is Tribe)
                checkedListBoxControl1.Visible = false;
            if (bindingSource.DataSource is Dwarf)
                checkedListBoxControl1.DataSource = DoStuff.FindAllTribeNames(tribeList);
            if (bindingSource.DataSource is Weapon)
                checkedListBoxControl1.DataSource = DoStuff.FindAllDwarfNames(tribeList);           
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (vGridControl1.DataSource is BindingSource bindingSource)
            {
                if (checkedListBoxControl1.CheckedItemsCount != 0)
                    form1.AddChanges(bindingSource, checkedListBoxControl1.CheckedItems[0].ToString());
                else
                    form1.AddChanges(bindingSource, "");
            }              
            this.Close();
        }
    }
}
