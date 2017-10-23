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

namespace haliSatisOtomasyonu
{
    public partial class FormCariHesap : DevExpress.XtraEditors.XtraForm
    {
        public FormCariHesap()
        {
            InitializeComponent();
        }

        private void simpleButtonVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();

        public void cariHesapOlustur() {
            ws.musteriEkle(textEditAdSoyadUnvan.Text.ToString(), comboBoxEditUlke.Text.ToString(), buttonEditSehir.Text.ToString(), buttonEditIlce.Text.ToString(), buttonEditSemt.Text.ToString(),
                textEditPostaKodu.Text.ToString(), buttonUlke2.Text.ToString(), buttonEditSehir2.Text.ToString(), buttonEditIlce2.Text.ToString(), buttonEditSemt2.Text.ToString(),
                textEditPostaKodu2.Text.ToString(), textEditTelNo.Text.ToString(), textEditTelNo2.Text.ToString(), textEditTCKimlikVergiNo.Text.ToString(), textEditVergiDaresi.Text.ToString());
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            
            try {
                cariHesapOlustur();
                XtraMessageBox.Show("Kayıt Başarıyla Eklendi", "İşlem Başarılı", MessageBoxButtons.OK);
                
            }
            catch {
                XtraMessageBox.Show("Kayıt Eklenemedi", "İşlem Başarısız", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }
    }
}