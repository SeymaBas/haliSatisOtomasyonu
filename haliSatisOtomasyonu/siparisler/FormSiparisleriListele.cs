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

namespace haliSatisOtomasyonu.siparisler
{
    public partial class FormSiparisleriListele : DevExpress.XtraEditors.XtraForm
    {
        public FormSiparisleriListele()
        {
            InitializeComponent();
        }
        YaziciIslemleri yazici = new YaziciIslemleri();

        private void simpleButtonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonExcel_Click(object sender, EventArgs e)
        {
            yazici.VerileriExceleAktar(gridControlSiparisler);

        }

        private void simpleButtonYazdir_Click(object sender, EventArgs e)
        {
            yazici.PrintGrid(gridControlSiparisler);
        }

        private void simpleButtonOnizleme_Click(object sender, EventArgs e)
        {
            yazici.ShowGridPreview(gridControlSiparisler);
        }
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        
        //int subeID = new login.subeID;

        public void satisListele()
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.siparisListele();
            gridControlSiparisler.DataSource = ds.Tables[0];

        }
        private void FormSiparisleriListele_Load(object sender, EventArgs e)
        {
            satisListele();

        }

        private void simpleButtonYenile_Click(object sender, EventArgs e)
        {
            satisListele();
        }
    }
}