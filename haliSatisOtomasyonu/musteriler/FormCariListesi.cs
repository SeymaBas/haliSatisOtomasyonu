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

namespace haliSatisOtomasyonu.musteriler
{
    public partial class FormCariListesi : DevExpress.XtraEditors.XtraForm
    {
        public FormCariListesi()
        {
            InitializeComponent();
        }
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        public void cariListele(GridControl grid)
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.musteriCek();
            grid.DataSource = ds.Tables[0];

        }
        public void musteriAdiAra(string musteriAdi)
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.musteriAdiAra(musteriAdi);
            gridControlMusteriAdi.DataSource = ds.Tables[0];

        }


        private void simpleButtonMusteriAra_Click(object sender, EventArgs e)
        {
            musteriAdiAra(textEditMusteriAdi.Text);

        }

        private void simpleButtonTumunuListele_Click(object sender, EventArgs e)
        {
            cariListele(gridControlMusteriAdi);
        }
    }
}