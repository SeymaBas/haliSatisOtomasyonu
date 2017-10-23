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
    public partial class FormStokAra : DevExpress.XtraEditors.XtraForm
    {
        public FormStokAra()
        {
            InitializeComponent();
        }
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        void urunAdiAra()
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.stoklardaUrunAdiAra(textEditUrunAdi.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                XtraMessageBox.Show("Böyle bir ürün bulunamadı...");
            }
            else
            {
                gridControlUrunListelemeEkrani.DataSource = ds.Tables[0];


            }
        }
        void urunBarkodAra()
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.stoklardaBarkodAra(textEditBarkod.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                XtraMessageBox.Show("Böyle bir ürün bulunamadı...");
            }
            else
            {
                gridControlUrunListelemeEkrani.DataSource = ds.Tables[0];


            }
        }


        private void simpleButtonAra_Click(object sender, EventArgs e)
        {
            if (textEditUrunAdi.Text != "") {
                urunAdiAra();
            
            }
            else if (textEditBarkod.Text != "") {
                urunBarkodAra();
            
            }
            else if (textEditUrunAdi.Text == "" && textEditBarkod.Text == null) {

                XtraMessageBox.Show("Ürün aramak için barkod ya da ürün adı kısmını doldurmalısınız!");
            }
        }

        private void simpleButtonTemizle_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            textEditUrunAdi.Text = "";
            textEditBarkod.Text = "";
        }
    }
}