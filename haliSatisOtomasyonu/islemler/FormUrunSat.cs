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

namespace haliSatisOtomasyonu.islemler
{
    public partial class FormUrunSat : DevExpress.XtraEditors.XtraForm
    {
        public FormUrunSat()
        {
            InitializeComponent();
        }

         haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
         void satisYap(string urunBarkod,int musteriID,int subeID,int urunMiktari)
         {
             ws.satisYap(urunBarkod,musteriID,subeID,urunMiktari);
         
         }

        private void simpleButtonSiparisiTamamla_Click(object sender, EventArgs e)
        {
            
            int musteriKodu = int.Parse(textEditMusteriKodu.Text.ToString());
            int subeKodu = int.Parse(textEditSubeKodu.Text.ToString());
            int urunMiktari = int.Parse(textEditUrunMiktari.Text.ToString());
            try
            {

                satisYap(textEditUrunBarkodu.Text, musteriKodu, subeKodu, urunMiktari);
                XtraMessageBox.Show("Ürün Satış İşlemi Gerçekleşmiştir", "Faturanız oluşturuluyor...", MessageBoxButtons.OK);
                FormFaturaGoster fatura = new FormFaturaGoster();
                fatura.Show();

            }
            catch
            {
                XtraMessageBox.Show("Ürün satış işlemi gerçekleştirilemedi", "İşlem Başarısız", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            

        }

        private void simpleButtonFaturayiGoster_Click(object sender, EventArgs e)
        {
            FormFaturaGoster fatura = new FormFaturaGoster();
            fatura.Show();
        }
    }
}