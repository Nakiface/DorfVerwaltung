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
        List<Tribe> tribeList = TribeData.setBaseDataset();
        public Form1()
        {
            Initialize();

            #region Eventhandler
            barEditItemTaxes.EditValueChanged += BarEditItemTaxes_EditValueChanged;
            barEditItemTaxRate.EditValueChanged += BarEditItemTaxRate_EditValueChanged;
            //gridView1.CellValueChanged += GridView1_CellValueChanged;
            //gridView1.CellValueChanging += GridView1_CellValueChanging;
            //gridView1.ColumnWidthChanged += GridView1_ColumnWidthChanged;



            gridView1.MasterRowExpanded += gridMasterRowExpanded;
            gridView1.CellValueChanged += CellValueChangedEventHandler;
            gridView1.SelectionChanged += SelectionChangedEventHandler;
            gridView1.FocusedRowChanged += FocusedRowChangedEventHandler;

            #endregion
        }

        private void FocusedRowChangedEventHandler(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!(sender is GridView senderGrid))
                return;

            var item = senderGrid.GetFocusedDataRow();
            if (item == null)
                return;


            var itemTypeName = item.GetType().Name;
            foreach (RibbonPage page in ribbonControl1.Pages)
            {
                if (page.Tag?.ToString().Equals(itemTypeName) == true)
                {
                    ribbonControl1.SelectedPage = page;
                    return;
                }
            }
        }

        private void SelectionChangedEventHandler(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
           
            
        }

        private void gridMasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            if (!(sender is GridView senderGrid))
                return;

            var detailView = senderGrid.GetDetailView(e.RowHandle, e.RelationIndex);

            System.Diagnostics.Debug.WriteLine($"masterRowExpanden : {e.RowHandle}");
            System.Diagnostics.Debug.WriteLine($"detailGrid : {detailView?.GetType().Name}");




            if(detailView is GridView detailGridView)
            {
                detailGridView.SelectionChanged -= SelectionChangedEventHandler;
                detailGridView.SelectionChanged += SelectionChangedEventHandler;

                detailGridView.FocusedRowChanged -= FocusedRowChangedEventHandler;
                detailGridView.FocusedRowChanged += FocusedRowChangedEventHandler;

                detailGridView.MasterRowExpanded -= gridMasterRowExpanded;
                detailGridView.MasterRowExpanded += gridMasterRowExpanded;

                detailGridView.CellValueChanged -= CellValueChangedEventHandler;
                detailGridView.CellValueChanged += CellValueChangedEventHandler;
            }
        }

        //private void GridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        //{
        //    Console.WriteLine();
        //}

        //private void GridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    Console.WriteLine();
        //}

        private void CellValueChangedEventHandler(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"{e.RowHandle} {e.Column.FieldName} : {e.Value}");
        }

        private void Initialize()
        {
            InitializeComponent();
            
            this.gridControl.DataSource = tribeList;
            //gridView1.chang
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
