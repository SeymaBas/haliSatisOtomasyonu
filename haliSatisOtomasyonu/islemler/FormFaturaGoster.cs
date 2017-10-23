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

namespace haliSatisOtomasyonu.islemler
{
    public partial class FormFaturaGoster : DevExpress.XtraEditors.XtraForm
    {
        public FormFaturaGoster()
        {
            InitializeComponent();
        }

        YaziciIslemleri yazici = new YaziciIslemleri();
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        public void faturaGoster(GridControl grid)
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.faturaGoster();
            grid.DataSource = ds.Tables[0];

        }

        private void simpleButtonKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void simpleButtonYenile_Click(object sender, EventArgs e)
        {
            faturaGoster(gridControlFaturaDokumu);
        }

        private void simpleButtonExcel_Click(object sender, EventArgs e)
        {
            yazici.VerileriExceleAktar(gridControlFaturaDokumu);

        }

        private void simpleButtonYazdir_Click(object sender, EventArgs e)
        {
            yazici.PrintGrid(gridControlFaturaDokumu);
        }

        private void simpleButtonOnizleme_Click(object sender, EventArgs e)
        {
            yazici.ShowGridPreview(gridControlFaturaDokumu);
        }

        private void FormFaturaGoster_Load(object sender, EventArgs e)
        {
            faturaGoster(gridControlFaturaDokumu);
        }
    }
}