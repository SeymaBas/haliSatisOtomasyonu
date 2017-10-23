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
    public partial class FormStokListesi : DevExpress.XtraEditors.XtraForm
    {
        public FormStokListesi()
        {
            InitializeComponent();
        }

        string subeAdi = "Değirmencilik";
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();

        private void stokListele(string subeAdi) {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.subeStokListele(subeAdi);
            gridControlStokListesi.DataSource = ds.Tables[0];
        }

        private void FormStokListesi_Load(object sender, EventArgs e)
        {
            stokListele(subeAdi);
          
        }
    }
}