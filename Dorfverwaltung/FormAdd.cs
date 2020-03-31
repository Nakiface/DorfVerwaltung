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
    public partial class FormAdd : Form
    {
        Form1 form1 = null;
        public FormAdd(BindingSource bindingSource, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            vGridControl1.DataSource = bindingSource;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (vGridControl1.DataSource is BindingSource bindingSource)
                form1.AddChanges(bindingSource);
            this.Close();
        }
    }
}
