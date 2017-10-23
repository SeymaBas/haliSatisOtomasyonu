namespace haliSatisOtomasyonu.siparisler
{
    partial class FormSiparisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisEkle));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButtonVazgeç = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSubeKodu = new DevExpress.XtraEditors.TextEdit();
            this.textEditUrunBarkodu = new DevExpress.XtraEditors.TextEdit();
            this.textEditSiparisAdeti = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubeKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunBarkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSiparisAdeti.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.flowLayoutPanel1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 321);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(381, 69);
            this.groupControl2.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditSiparisAdeti);
            this.groupControl1.Controls.Add(this.textEditUrunBarkodu);
            this.groupControl1.Controls.Add(this.textEditSubeKodu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(381, 321);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Sipariş detaylarını giriniz...";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonVazgeç);
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonKaydet);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // simpleButtonVazgeç
            // 
            this.simpleButtonVazgeç.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonVazgeç.Image")));
            this.simpleButtonVazgeç.Location = new System.Drawing.Point(259, 3);
            this.simpleButtonVazgeç.Name = "simpleButtonVazgeç";
            this.simpleButtonVazgeç.Size = new System.Drawing.Size(115, 39);
            this.simpleButtonVazgeç.TabIndex = 3;
            this.simpleButtonVazgeç.Text = "Vazgeç";
            this.simpleButtonVazgeç.Click += new System.EventHandler(this.simpleButtonVazgeç_Click);
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(138, 3);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(115, 39);
            this.simpleButtonKaydet.TabIndex = 2;
            this.simpleButtonKaydet.Text = "Kaydet";
            this.simpleButtonKaydet.Click += new System.EventHandler(this.simpleButtonKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Şube Kodu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ürün Barkodu :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Sipariş Adeti :";
            // 
            // textEditSubeKodu
            // 
            this.textEditSubeKodu.Location = new System.Drawing.Point(114, 49);
            this.textEditSubeKodu.Name = "textEditSubeKodu";
            this.textEditSubeKodu.Size = new System.Drawing.Size(221, 20);
            this.textEditSubeKodu.TabIndex = 3;
            // 
            // textEditUrunBarkodu
            // 
            this.textEditUrunBarkodu.Location = new System.Drawing.Point(114, 101);
            this.textEditUrunBarkodu.Name = "textEditUrunBarkodu";
            this.textEditUrunBarkodu.Size = new System.Drawing.Size(221, 20);
            this.textEditUrunBarkodu.TabIndex = 4;
            // 
            // textEditSiparisAdeti
            // 
            this.textEditSiparisAdeti.Location = new System.Drawing.Point(114, 155);
            this.textEditSiparisAdeti.Name = "textEditSiparisAdeti";
            this.textEditSiparisAdeti.Size = new System.Drawing.Size(221, 20);
            this.textEditSiparisAdeti.TabIndex = 5;
            // 
            // FormSiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 390);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "FormSiparisEkle";
            this.Text = "Sipariş Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubeKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunBarkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSiparisAdeti.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonVazgeç;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEditSiparisAdeti;
        private DevExpress.XtraEditors.TextEdit textEditUrunBarkodu;
        private DevExpress.XtraEditors.TextEdit textEditSubeKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}