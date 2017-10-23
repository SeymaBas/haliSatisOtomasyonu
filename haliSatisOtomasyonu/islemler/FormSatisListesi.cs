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

namespace haliSatisOtomasyonu
{
    public partial class FormSatisListesi : DevExpress.XtraEditors.XtraForm
    {
        public FormSatisListesi()
        {
            InitializeComponent();
        }

        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        public void satisListele(GridControl grid)
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.satisListe();
            grid.DataSource = ds.Tables[0];

        }

        private void FormSatisListesi_Load(object sender, EventArgs e)
        {
            satisListele(gridControlSatislar);

        }

        YaziciIslemleri yazici = new YaziciIslemleri();

        private void simpleButtonOnizleme_Click(object sender, EventArgs e)
        {
            yazici.ShowGridPreview(gridControlSatislar);
        }

        private void simpleButtonYazdir_Click(object sender, EventArgs e)
        {
            yazici.PrintGrid(gridControlSatislar);
        }

        private void simpleButtonExcel_Click(object sender, EventArgs e)
        {
            yazici.VerileriExceleAktar(gridControlSatislar);
        }

        private void simpleButtonYenile_Click(object sender, EventArgs e)
        {
            satisListele(gridControlSatislar);

        }

        private void simpleButtonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}