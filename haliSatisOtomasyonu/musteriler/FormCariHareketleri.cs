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
using haliSatisOtomasyonu.islemler;

namespace haliSatisOtomasyonu.musteriler
{
    public partial class FormCariHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public FormCariHareketleri()
        {
            InitializeComponent();
        }
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        public void faturaAra(string faturaNo)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.faturaAra(faturaNo);
            gridControlFaturalar.DataSource = ds.Tables[0];

        }
        public void ayrintiliFaturaAra(string faturaNo)
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.ayrintiliFaturaAra(faturaNo);
            gridControlFaturalar.DataSource = ds.Tables[0];

        }

        private void simpleButtonMusteriAra_Click(object sender, EventArgs e)
        {
            faturaAra(textEditFaturaNo.Text);

        }
        private void textEditFaturaNo_KeyDown(object sender, KeyEventArgs e)
        {
            faturaAra(textEditFaturaNo.Text);
        }
        private void simpleButtonAyrintiGoster_Click(object sender, EventArgs e)
        {
            ayrintiliFaturaAra(textEditFaturaNo.Text);

        }

        private void simpleButtonIadeGerceklestir_Click(object sender, EventArgs e)
        {
            FormUrunIade iadeForm = new FormUrunIade();
            iadeForm.Show();
        }

       
    }
}