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
    public partial class FormFaturaBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public FormFaturaBilgileri()
        {
            InitializeComponent();
        }

        private void simpleButtonKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        YaziciIslemleri yazici = new YaziciIslemleri();

        private void simpleButtonYazdir_Click(object sender, EventArgs e)
        {
            yazici.PrintGrid(gridControlFatura);
        }

        private void simpleButtonOnizleme_Click(object sender, EventArgs e)
        {
            yazici.ShowGridPreview(gridControlFatura);
        }
    }
}