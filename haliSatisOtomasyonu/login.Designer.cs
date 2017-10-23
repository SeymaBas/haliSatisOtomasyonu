namespace haliSatisOtomasyonu
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.simpleButtonCevrimDisi = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCikisYap = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.textEditLokasyon = new DevExpress.XtraEditors.TextEdit();
            this.textEditSifre = new DevExpress.XtraEditors.TextEdit();
            this.textEditKullaniciKodu = new DevExpress.XtraEditors.TextEdit();
            this.textEditKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBoxGiris = new System.Windows.Forms.GroupBox();
            this.radioButtonFabrika = new System.Windows.Forms.RadioButton();
            this.radioButtonMagaza = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLokasyon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciAdi.Properties)).BeginInit();
            this.groupBoxGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonCevrimDisi
            // 
            this.simpleButtonCevrimDisi.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCevrimDisi.Image")));
            this.simpleButtonCevrimDisi.Location = new System.Drawing.Point(241, 178);
            this.simpleButtonCevrimDisi.Name = "simpleButtonCevrimDisi";
            this.simpleButtonCevrimDisi.Size = new System.Drawing.Size(100, 38);
            this.simpleButtonCevrimDisi.TabIndex = 24;
            this.simpleButtonCevrimDisi.Text = "Çevrim Dışı";
            // 
            // simpleButtonCikisYap
            // 
            this.simpleButtonCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCikisYap.Image")));
            this.simpleButtonCikisYap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButtonCikisYap.Location = new System.Drawing.Point(135, 178);
            this.simpleButtonCikisYap.Name = "simpleButtonCikisYap";
            this.simpleButtonCikisYap.Size = new System.Drawing.Size(100, 38);
            this.simpleButtonCikisYap.TabIndex = 23;
            this.simpleButtonCikisYap.Text = "Çıkış Yap";
            this.simpleButtonCikisYap.Click += new System.EventHandler(this.simpleButtonCikisYap_Click);
            // 
            // simpleButtonGirisYap
            // 
            this.simpleButtonGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGirisYap.Image")));
            this.simpleButtonGirisYap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButtonGirisYap.Location = new System.Drawing.Point(29, 178);
            this.simpleButtonGirisYap.Name = "simpleButtonGirisYap";
            this.simpleButtonGirisYap.Size = new System.Drawing.Size(100, 38);
            this.simpleButtonGirisYap.TabIndex = 22;
            this.simpleButtonGirisYap.Text = "Giriş Yap";
            this.simpleButtonGirisYap.Click += new System.EventHandler(this.simpleButtonGirisYap_Click);
            // 
            // textEditLokasyon
            // 
            this.textEditLokasyon.Location = new System.Drawing.Point(118, 120);
            this.textEditLokasyon.Name = "textEditLokasyon";
            this.textEditLokasyon.Size = new System.Drawing.Size(206, 20);
            this.textEditLokasyon.TabIndex = 21;
            // 
            // textEditSifre
            // 
            this.textEditSifre.Location = new System.Drawing.Point(118, 93);
            this.textEditSifre.Name = "textEditSifre";
            this.textEditSifre.Properties.PasswordChar = '*';
            this.textEditSifre.Size = new System.Drawing.Size(206, 20);
            this.textEditSifre.TabIndex = 20;
            this.textEditSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditSifre_KeyDown);
            // 
            // textEditKullaniciKodu
            // 
            this.textEditKullaniciKodu.Location = new System.Drawing.Point(118, 66);
            this.textEditKullaniciKodu.Name = "textEditKullaniciKodu";
            this.textEditKullaniciKodu.Size = new System.Drawing.Size(206, 20);
            this.textEditKullaniciKodu.TabIndex = 19;
            // 
            // textEditKullaniciAdi
            // 
            this.textEditKullaniciAdi.Location = new System.Drawing.Point(118, 36);
            this.textEditKullaniciAdi.Name = "textEditKullaniciAdi";
            this.textEditKullaniciAdi.Size = new System.Drawing.Size(206, 20);
            this.textEditKullaniciAdi.TabIndex = 18;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Lokasyon";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Şifre";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Kullanıcı Kodu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Kullanıcı Adı";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "London Liquid Sky";
            // 
            // groupBoxGiris
            // 
            this.groupBoxGiris.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGiris.Controls.Add(this.radioButtonFabrika);
            this.groupBoxGiris.Controls.Add(this.radioButtonMagaza);
            this.groupBoxGiris.Controls.Add(this.textEditSifre);
            this.groupBoxGiris.Controls.Add(this.labelControl1);
            this.groupBoxGiris.Controls.Add(this.labelControl2);
            this.groupBoxGiris.Controls.Add(this.labelControl3);
            this.groupBoxGiris.Controls.Add(this.textEditLokasyon);
            this.groupBoxGiris.Controls.Add(this.labelControl4);
            this.groupBoxGiris.Controls.Add(this.textEditKullaniciAdi);
            this.groupBoxGiris.Controls.Add(this.textEditKullaniciKodu);
            this.groupBoxGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGiris.Location = new System.Drawing.Point(0, 0);
            this.groupBoxGiris.Name = "groupBoxGiris";
            this.groupBoxGiris.Size = new System.Drawing.Size(347, 172);
            this.groupBoxGiris.TabIndex = 25;
            this.groupBoxGiris.TabStop = false;
            this.groupBoxGiris.Text = "Giriş";
            // 
            // radioButtonFabrika
            // 
            this.radioButtonFabrika.AutoSize = true;
            this.radioButtonFabrika.BackColor = System.Drawing.Color.White;
            this.radioButtonFabrika.Location = new System.Drawing.Point(197, 121);
            this.radioButtonFabrika.Name = "radioButtonFabrika";
            this.radioButtonFabrika.Size = new System.Drawing.Size(60, 17);
            this.radioButtonFabrika.TabIndex = 23;
            this.radioButtonFabrika.Text = "Fabrika";
            this.radioButtonFabrika.UseVisualStyleBackColor = false;
            // 
            // radioButtonMagaza
            // 
            this.radioButtonMagaza.AutoSize = true;
            this.radioButtonMagaza.BackColor = System.Drawing.Color.White;
            this.radioButtonMagaza.Checked = true;
            this.radioButtonMagaza.Location = new System.Drawing.Point(129, 121);
            this.radioButtonMagaza.Name = "radioButtonMagaza";
            this.radioButtonMagaza.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMagaza.TabIndex = 22;
            this.radioButtonMagaza.TabStop = true;
            this.radioButtonMagaza.Text = "Mağaza";
            this.radioButtonMagaza.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(347, 228);
            this.Controls.Add(this.groupBoxGiris);
            this.Controls.Add(this.simpleButtonCevrimDisi);
            this.Controls.Add(this.simpleButtonCikisYap);
            this.Controls.Add(this.simpleButtonGirisYap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(363, 267);
            this.Name = "login";
            this.Text = "Hoşgeldiniz...";
            ((System.ComponentModel.ISupportInitialize)(this.textEditLokasyon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKullaniciAdi.Properties)).EndInit();
            this.groupBoxGiris.ResumeLayout(false);
            this.groupBoxGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonCevrimDisi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCikisYap;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGirisYap;
        private DevExpress.XtraEditors.TextEdit textEditLokasyon;
        private DevExpress.XtraEditors.TextEdit textEditSifre;
        private DevExpress.XtraEditors.TextEdit textEditKullaniciKodu;
        private DevExpress.XtraEditors.TextEdit textEditKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBoxGiris;
        private System.Windows.Forms.RadioButton radioButtonFabrika;
        private System.Windows.Forms.RadioButton radioButtonMagaza;
    }
}