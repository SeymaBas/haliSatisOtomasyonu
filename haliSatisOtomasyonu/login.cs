using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace haliSatisOtomasyonu
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
           // DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItemThema, true, true);
        }
        haliSistemiWS.Service1SoapClient ws = new haliSistemiWS.Service1SoapClient();
        public static int subeID;

        void kullaniciGiris()
        {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.kullaniciGiris(textEditKullaniciAdi.Text,textEditKullaniciKodu.Text, textEditSifre.Text);
            SplashScreenManager.ShowForm(this,typeof(WaitFormLoading),true,true,false);
            SplashScreenManager.Default.SetWaitFormCaption("Veri tabanına bağlanıyor");
            for (int i = 0; i < 300;i++ ) {
                Thread.Sleep(10);
            }
           
            if (ds.Tables[0].Rows.Count == 0)
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Kullanıcı adınız veya şifreniz hatalı lütfen tekrar deneyin...");
               
            }
            else
            {

                Int32 subeID = Convert.ToInt32(ds.Tables[0].Rows[0]["subeID"].ToString());
                SplashScreenManager.CloseForm();
                login formKapat = new login();
                formKapat.Close();
                MainPage formAc = new MainPage();
                formAc.Show();
                this.Hide();

            }
        }

        private void simpleButtonGirisYap_Click(object sender, EventArgs e)
        {
            kullaniciGiris();
        }

       

        private void textEditSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                kullaniciGiris();
            }

        }

        private void simpleButtonCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}