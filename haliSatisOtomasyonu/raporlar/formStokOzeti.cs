using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraPivotGrid;
using DevExpress.LookAndFeel;
using System.IO;
namespace haliSatisOtomasyonu
{
    public partial class formStokOzeti : DevExpress.XtraEditors.XtraForm
    {
        public formStokOzeti()
        {
            InitializeComponent();
        }
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        public void satisListele(GridControl grid) {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.satisListe();
            grid.DataSource = ds.Tables[0];
        
        }

        private void xtraTabControlStokOzeti_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageListe) {
                satisListele(gridControlListe);

            }
        }

        private void formStokOzeti_Load(object sender, EventArgs e){
            /*System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.satisListe();
            // Assign the data source to the PivotGrid control.
            pivotGridControlOzetTablo.DataSource = ds.Tables[0];

            // Create a row Pivot Grid Control field bound to the DurumKodu datasource field.
            PivotGridField fieldDurumKodu = new PivotGridField("DurumKodu", PivotArea.RowArea);

            // Create a row Pivot Grid Control field bound to the Sales Person datasource field.
            PivotGridField fieldRenk = new PivotGridField("Renk", PivotArea.RowArea);
            fieldRenk.Caption = "Renk";

            // Create a column Pivot Grid Control field bound to the OrderDate datasource field.
            PivotGridField fieldMalzemeKodu = new PivotGridField("MalzemeKodu", PivotArea.ColumnArea);
            fieldMalzemeKodu.Caption = "Malzeme Kodu";

            // Create a column Pivot Grid Control field bound to the CategoryName datasource field.
            PivotGridField fieldMalzemeAdi = new PivotGridField("MalzemeAdi", PivotArea.ColumnArea);
            fieldMalzemeAdi.Caption = "Malzeme Adı";

            // Create a filter Pivot Grid Control field bound to the ProductName datasource field.
            PivotGridField fieldKenar = new PivotGridField("Kenar", PivotArea.FilterArea);
            fieldKenar.Caption = "Kenar";

            // Create a column Pivot Grid Control field bound to the CategoryName datasource field.
            PivotGridField fieldM2 = new PivotGridField("M2", PivotArea.ColumnArea);
            fieldM2.Caption = "M2";

            // Create a filter Pivot Grid Control field bound to the ProductName datasource field.
            PivotGridField fieldAdet = new PivotGridField("Adet", PivotArea.FilterArea);
            fieldAdet.Caption = "Adet";

            // Add the fields to the control's field collection.         
            pivotGridControlOzetTablo.Fields.AddRange(new PivotGridField[] {fieldM2, fieldAdet, 
  fieldDurumKodu, fieldRenk, fieldMalzemeKodu, fieldMalzemeAdi,fieldKenar});

            // Arrange the row fields within the Row Header Area.
            fieldM2.AreaIndex = 0;
            fieldAdet.AreaIndex = 1;

            // Arrange the column fields within the Column Header Area.
            fieldDurumKodu.AreaIndex = 0;
            fieldRenk.AreaIndex = 1;
            fieldMalzemeKodu.AreaIndex = 2;
            fieldMalzemeAdi.AreaIndex = 3;
            fieldKenar.AreaIndex = 4;*/

        }

        private void simpleButtonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonYenile_Click(object sender, EventArgs e)
        {
            satisListele(gridControlListe);

        }

        YaziciIslemleri yazici = new YaziciIslemleri();

        private void simpleButtonExcel_Click(object sender, EventArgs e)
        {
            yazici.VerileriExceleAktar(gridControlListe);
        }
       
        private void simpleButtonYazdir_Click(object sender, EventArgs e)
        {
            yazici.PrintGrid(gridControlListe);
        }
       
        private void simpleButtonOnizleme_Click(object sender, EventArgs e)
        {
            yazici.ShowGridPreview(gridControlListe);
        }

        private void simpleButtonOnizleme1_Click(object sender, EventArgs e)
        {
           // ShowGridPreview(pivotGridControlOzetTablo);
            
        }

        private void simpleButtonKapat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonYazdir1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonExcel1_Click(object sender, EventArgs e)
        {
           // VerileriExceleAktar(pivotGridControlOzetTablo);

        }

        private void simpleButtonYenile1_Click(object sender, EventArgs e)
        {

        }

        
    }
}