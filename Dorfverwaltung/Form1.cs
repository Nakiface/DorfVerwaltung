using DevExpress.XtraGrid.Views.Grid;
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
    public partial class Form1 : Form
    {
        List<Tribe> tribeList = TribeData.setBaseDataset();
        public Form1()
        {
            Initialize();

            #region Eventhandler
            barEditItemTaxes.EditValueChanged += BarEditItemTaxes_EditValueChanged;
            barEditItemTaxRate.EditValueChanged += BarEditItemTaxRate_EditValueChanged;          
            #endregion
        }

        private void Initialize()
        {
            InitializeComponent();
            this.gridControl.DataSource = tribeList;
            SetTaxes();           
        }

        #region Taxes
        private void BarEditItemTaxRate_EditValueChanged(object sender, EventArgs e)
        {
            SetTaxes();
        }

        private void BarEditItemTaxes_EditValueChanged(object sender, EventArgs e)
        {
            SetTaxRate();
        }

        private void SetTaxRate()
        {
            var force = tribeList.Aggregate(0, (a, tribe) => a + tribe.Macht);
            var taxes = Convert.ToDecimal(barEditItemTaxes.EditValue);
            barEditItemTaxRate.EditValue = taxes / force;
        }

        private void SetTaxes()
        {
            var force = tribeList.Aggregate(0, (a, tribe) => a + tribe.Macht);
            var taxRate = Convert.ToDecimal(barEditItemTaxRate.EditValue);
            barEditItemTaxes.EditValue = force * taxRate;
        }
        #endregion

    }
}
