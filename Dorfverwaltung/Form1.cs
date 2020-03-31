using DevExpress.XtraBars.Ribbon;
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
        private List<Tribe> tribeList = TribeData.setBaseDataset();
        public Form1()
        {
            Initialize();
        }   

        private void Initialize()
        {
            InitializeComponent();

            #region Eventhandler
            barEditItemTaxes.EditValueChanged += BarEditItemTaxes_EditValueChanged;
            barEditItemTaxRate.EditValueChanged += BarEditItemTaxRate_EditValueChanged;
            gridView1.MasterRowExpanded += gridMasterRowExpanded;
            gridView1.CellValueChanged += CellValueChangedEventHandler;
            #endregion

            this.gridControl.DataSource = tribeList;
            SetTaxes();           
        }

        public void AddChanges(BindingSource bindingSource, string name)
        {
            tribeList = DoStuff.AddDataToList(bindingSource, tribeList, name);
            SetTaxes();
            gridControl.RefreshDataSource();
        }

        private void gridMasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            if (!(sender is GridView senderGrid))
                return;

            var detailView = senderGrid.GetDetailView(e.RowHandle, e.RelationIndex);

            System.Diagnostics.Debug.WriteLine($"masterRowExpanden : {e.RowHandle}");
            System.Diagnostics.Debug.WriteLine($"detailGrid : {detailView?.GetType().Name}");

            if (detailView is GridView detailGridView)
            {
                detailGridView.MasterRowExpanded -= gridMasterRowExpanded;
                detailGridView.MasterRowExpanded += gridMasterRowExpanded;

                detailGridView.CellValueChanged -= CellValueChangedEventHandler;
                detailGridView.CellValueChanged += CellValueChangedEventHandler;
            }
        }

        private void CellValueChangedEventHandler(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            SetTaxes();
            System.Diagnostics.Debug.WriteLine($"{e.RowHandle} {e.Column.FieldName} : {e.Value}");
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

        private void barButtonItemAddTribe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = new Tribe("",0,new List<Dwarf>());
            FormAdd addTribeForm = new FormAdd(bindingSource, this, tribeList);
            addTribeForm.ShowDialog();
        }

        private void barButtonItemAddDwarf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = new Dwarf("",0,new List<Weapon>());
            FormAdd addDwarfForm = new FormAdd(bindingSource, this, tribeList);
            addDwarfForm.ShowDialog();
        }

        private void barButtonItemAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = new Weapon();
            FormAdd addDwarfForm = new FormAdd(bindingSource, this, tribeList);
            addDwarfForm.ShowDialog();
        }
    }
}
