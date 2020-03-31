namespace Dorfverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItemTaxRate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditTaxRate = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditItemTaxes = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditTaxes = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barButtonItemAddTribe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDeleteTribe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditTaxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditTaxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barEditItem1,
            this.barEditItemTaxRate,
            this.barEditItemTaxes,
            this.barButtonItemAddTribe,
            this.barButtonItemDeleteTribe});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEditTaxRate,
            this.repositoryItemSpinEditTaxes});
            this.ribbonControl1.Size = new System.Drawing.Size(1589, 199);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = null;
            this.barEditItem1.Id = 3;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barEditItemTaxRate
            // 
            this.barEditItemTaxRate.Caption = "Steuersatz";
            this.barEditItemTaxRate.Edit = this.repositoryItemSpinEditTaxRate;
            this.barEditItemTaxRate.EditValue = new decimal(new int[] {
            2150,
            0,
            0,
            0});
            this.barEditItemTaxRate.EditWidth = 70;
            this.barEditItemTaxRate.Id = 4;
            this.barEditItemTaxRate.Name = "barEditItemTaxRate";
            // 
            // repositoryItemSpinEditTaxRate
            // 
            this.repositoryItemSpinEditTaxRate.AutoHeight = false;
            this.repositoryItemSpinEditTaxRate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditTaxRate.Name = "repositoryItemSpinEditTaxRate";
            // 
            // barEditItemTaxes
            // 
            this.barEditItemTaxes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItemTaxes.Caption = "Steuern    ";
            this.barEditItemTaxes.Edit = this.repositoryItemSpinEditTaxes;
            this.barEditItemTaxes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.barEditItemTaxes.EditWidth = 70;
            this.barEditItemTaxes.Id = 6;
            this.barEditItemTaxes.Name = "barEditItemTaxes";
            // 
            // repositoryItemSpinEditTaxes
            // 
            this.repositoryItemSpinEditTaxes.AutoHeight = false;
            this.repositoryItemSpinEditTaxes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditTaxes.Name = "repositoryItemSpinEditTaxes";
            // 
            // barButtonItemAddTribe
            // 
            this.barButtonItemAddTribe.Caption = "Hinzufügen";
            this.barButtonItemAddTribe.Id = 7;
            this.barButtonItemAddTribe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAddTribe.ImageOptions.Image")));
            this.barButtonItemAddTribe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAddTribe.ImageOptions.LargeImage")));
            this.barButtonItemAddTribe.Name = "barButtonItemAddTribe";
            this.barButtonItemAddTribe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAddTribe_ItemClick);
            // 
            // barButtonItemDeleteTribe
            // 
            this.barButtonItemDeleteTribe.Caption = "Entfehrnen";
            this.barButtonItemDeleteTribe.Id = 8;
            this.barButtonItemDeleteTribe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteTribe.ImageOptions.Image")));
            this.barButtonItemDeleteTribe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDeleteTribe.ImageOptions.LargeImage")));
            this.barButtonItemDeleteTribe.Name = "barButtonItemDeleteTribe";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Steuern";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemTaxRate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemTaxes);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Steuersatz";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Tag = "Tribe";
            this.ribbonPage2.Text = "Stammverwaltung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemAddTribe);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemDeleteTribe);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Tag = "Dwarf";
            this.ribbonPage3.Text = "Zwergverwaltung";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Tag = "Weapon";
            this.ribbonPage4.Text = "Inventarverwaltung";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(0, 205);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1589, 553);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 754);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditTaxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditTaxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItemTaxRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditTaxRate;
        private DevExpress.XtraBars.BarEditItem barEditItemTaxes;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditTaxes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAddTribe;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDeleteTribe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

