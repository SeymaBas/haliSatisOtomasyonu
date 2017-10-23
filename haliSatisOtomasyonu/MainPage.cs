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
using haliSatisOtomasyonu.kasa;
using haliSatisOtomasyonu.stok;
using haliSatisOtomasyonu.musteriler;
using haliSatisOtomasyonu.islemler;
using haliSatisOtomasyonu.siparisler;

namespace haliSatisOtomasyonu
{
    public partial class MainPage : DevExpress.XtraEditors.XtraForm
    {
        public MainPage()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItemTema, true, true);
        }
        //butonlara basınca yeni form açılması için gerekli fonk.
        public void FormAc(Form AcilacakForm)
        {
            AcilacakForm.MdiParent = this;
            AcilacakForm.Show();
        }

        private void BarBtnItmUrunSatisSihirbazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormUrunSat());
        }

        private void BarBtnItmStokOzeti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new formStokOzeti());
        }

        private void barBtnItmTransfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormTransfer());
        }

        private void barBtnItmSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormSatisListesi());
        }


        private void barBtnItmMalKabul_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormMalKabul());
        }

        private void barBtnItmBarkod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormBarkod());
        }

        private void barBtnItmBarkodRezerve_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormBarkodRezerve());
        }

        private void barBtnItmGunSonu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormGunSonu());
        }

     

        private void barButtonItemKasaAcilisKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.FormAc(new KasaAcilisKarti());

        }

        private void barButtonItemKasaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new KasaListesi());

        }

        private void barButtonItemKasaDevirIslemKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new KasaDevirIslemKarti());
        }

        private void barButtonItemKasaTahsilatOdeme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new KasaTahsilatOdeme());
        }

       

        private void barButtonItemStokListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormStokListesi());
        }

 

        private void barButtonItemStokHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormStokHareketleri());
        }

        private void barButtonItemCariAcilisKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormCariHesap());
        }

        private void barButtonItemStokAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormStokAra());
        }

        private void barButtonItemCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormCariListesi());

        }

        private void barButtonItemCariHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormCariHareketleri());
        }

        private void barBtnItmDegisimIadesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormUrunIade());
        }

        private void barButtonItemSiparisEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormSiparisEkle());
        }

        private void barButtonItemSiparisListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.FormAc(new FormSiparisleriListele());
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = XtraMessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış tuşuna bastınız...", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
            else if (x == DialogResult.No)
            {
                e.Cancel = true; // Hayır tıklandığında iptal edilecek
            }
            
            }
    }

}