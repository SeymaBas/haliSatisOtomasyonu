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

namespace haliSatisOtomasyonu.stok
{
    public partial class FormStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public FormStokHareketleri()
        {
            InitializeComponent();
        }
        YaziciIslemleri yazici = new YaziciIslemleri();
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();

        private void stokHareketi(string barcode) {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.stokHareketiAra(barcode);
            gridControlStokHareketListele.DataSource = ds.Tables[0];
        }

        private void simpleButtonAra_Click(object sender, EventArgs e)
        {
            stokHareketi(textEditBarkod.Text);

        }

        private void simpleButtonYazdir_Click(object sender, EventArgs e)
        {
            yazici.PrintGrid(gridControlStokHareketListele);
        }

        private void simpleButtonOnizleme_Click(object sender, EventArgs e)
        {
            yazici.ShowGridPreview(gridControlStokHareketListele);
        }

        private void simpleButtonExcel_Click(object sender, EventArgs e)
        {
            yazici.VerileriExceleAktar(gridControlStokHareketListele);
        }

        private void simpleButtonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonTemizle_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            textEditBarkod.Text = "";
        }

        
    }
}