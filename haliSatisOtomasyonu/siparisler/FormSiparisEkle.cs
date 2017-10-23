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
    public partial class FormSiparisEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormSiparisEkle()
        {
            InitializeComponent();
        }
         haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();

      

         public void siparisEkle(string urunBarkodu,int siaprisAdeti,int subeID)
         {
             ws.siparisEkle(urunBarkodu,siaprisAdeti,subeID);
         }
        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            int siparisAdeti=int.Parse(textEditSiparisAdeti.Text);
            int subeKodu = int.Parse(textEditSubeKodu.Text);

            try
            {
                siparisEkle(textEditUrunBarkodu.Text, siparisAdeti, subeKodu);
                XtraMessageBox.Show("Siparis başarıyle iletilmiştir", "Sipariş gönderildi", MessageBoxButtons.OK);

            }
            catch
            {
                XtraMessageBox.Show("Siparis gönderilemedi", "İşlem Başarısız", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }

        private void simpleButtonVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}