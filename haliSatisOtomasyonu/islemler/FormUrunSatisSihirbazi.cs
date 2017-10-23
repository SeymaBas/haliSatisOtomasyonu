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
using DevExpress.XtraGrid.Views.Grid;

namespace haliSatisOtomasyonu
{
    public partial class FormUrunSatisSihirbazi : DevExpress.XtraEditors.XtraForm
    {

        public FormUrunSatisSihirbazi()
        {
            InitializeComponent();
        }

        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        void urunBilgisi()
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.barcodeBilgisi(textBoxBarkod.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                XtraMessageBox.Show("Böyle bir ürün bulunamadı...");
            }
            else
            {
                gridControlSatisBilgisi.DataSource = ds.Tables[0];



            }

            textBoxBarkod.Text = "";
            textBoxBarkod.Focus();
        }

        private void textBoxBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                urunBilgisi();
            }
        }

        private void FormUrunSatisSihirbazi_Load(object sender, EventArgs e)
        {

            xtraTabPageCariBilgisi.PageEnabled = false;
            xtraTabPageOdemeBilgileri.PageEnabled = false;
            xtraTabPageFaturaOdemeBilgileri.PageEnabled = false;
        }

        private void simpleButtonIleri_Click(object sender, EventArgs e)
        {
            xtraTabPageCariBilgisi.PageEnabled = true;
            xtraTabControlUrunSatis.SelectedTabPage = xtraTabPageCariBilgisi;
            xtraTabPageBarkodUrunBilgileri.PageEnabled = false;
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.musteriCek();
            gridControlCariBilgisi.DataSource = ds.Tables[0];

        }

        private void simpleButtonIleri2_Click(object sender, EventArgs e)
        {
            xtraTabPageOdemeBilgileri.PageEnabled = true;
            xtraTabControlUrunSatis.SelectedTabPage = xtraTabPageOdemeBilgileri;
            xtraTabPageCariBilgisi.PageEnabled = false;

        }

        private void simpleButtonYeniKayit_Click(object sender, EventArgs e)
        {
            FormCariHesap formCari = new FormCariHesap();
            formCari.Show();
        }

        private void simpleButtonDegistir_Click(object sender, EventArgs e)
        {

            int[] selRows = ((GridView)gridControlCariBilgisi.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlCariBilgisi.MainView).GetRow(selRows[0]));

            FormCariHesap formCari = new FormCariHesap();


        }

        private void simpleButtonGeri_Click(object sender, EventArgs e)
        {
            xtraTabPageBarkodUrunBilgileri.PageEnabled = true;
            xtraTabControlUrunSatis.SelectedTabPage = xtraTabPageBarkodUrunBilgileri;
            xtraTabPageCariBilgisi.PageEnabled = false;

        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            if (gridView1 == null || gridView1.SelectedRowsCount == 0) return;
            DataRow[] rows = new DataRow[gridView1.SelectedRowsCount];
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                rows[i] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i]);
            gridView1.BeginSort();
            try
            {
                foreach (DataRow row in rows)
                    row.Delete();

            }
            finally
            {
                gridView1.EndSort();
            }

        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //CTRL+ Delete tuşuna basınca barkodu okutulan seçili ürünü siler
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Onayla", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }


        public DataRow veriler { get; set; }

        private void simpleButtonYenile_Click(object sender, EventArgs e)
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.musteriCek();
            gridControlCariBilgisi.DataSource = ds.Tables[0];

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            /*if (gridControlCariBilgisi.SelectedCells.Count > 0)
            {
                int selectedrowindex = gridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = gridControlCariBilgisi.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["you have to mention you cell  corresponding column name"].Value);


            }*/
        }


    }
}
  
 