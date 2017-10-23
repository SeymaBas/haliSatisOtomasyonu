namespace haliSatisOtomasyonu.islemler
{
    partial class FormUrunSat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunSat));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunBarkodu = new DevExpress.XtraEditors.TextEdit();
            this.textEditMusteriKodu = new DevExpress.XtraEditors.TextEdit();
            this.textEditSubeKodu = new DevExpress.XtraEditors.TextEdit();
            this.textEditUrunMiktari = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButtonSiparisiTamamla = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonFaturayiGoster = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunBarkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMusteriKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubeKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunMiktari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Barkodu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Müşteri Kodu : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Şube Kodu : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 199);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Ürün Miktarı :";
            // 
            // textEditUrunBarkodu
            // 
            this.textEditUrunBarkodu.Location = new System.Drawing.Point(117, 42);
            this.textEditUrunBarkodu.Name = "textEditUrunBarkodu";
            this.textEditUrunBarkodu.Size = new System.Drawing.Size(219, 20);
            this.textEditUrunBarkodu.TabIndex = 4;
            // 
            // textEditMusteriKodu
            // 
            this.textEditMusteriKodu.Location = new System.Drawing.Point(117, 94);
            this.textEditMusteriKodu.Name = "textEditMusteriKodu";
            this.textEditMusteriKodu.Size = new System.Drawing.Size(219, 20);
            this.textEditMusteriKodu.TabIndex = 5;
            // 
            // textEditSubeKodu
            // 
            this.textEditSubeKodu.Location = new System.Drawing.Point(117, 146);
            this.textEditSubeKodu.Name = "textEditSubeKodu";
            this.textEditSubeKodu.Size = new System.Drawing.Size(219, 20);
            this.textEditSubeKodu.TabIndex = 6;
            // 
            // textEditUrunMiktari
            // 
            this.textEditUrunMiktari.Location = new System.Drawing.Point(117, 196);
            this.textEditUrunMiktari.Name = "textEditUrunMiktari";
            this.textEditUrunMiktari.Size = new System.Drawing.Size(219, 20);
            this.textEditUrunMiktari.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditMusteriKodu);
            this.groupControl1.Controls.Add(this.textEditUrunMiktari);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEditSubeKodu);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEditUrunBarkodu);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(450, 466);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Ürün Bilgilerini Giriniz...";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.flowLayoutPanel1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 384);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(450, 82);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "İşlemler";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonFaturayiGoster);
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonSiparisiTamamla);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // simpleButtonSiparisiTamamla
            // 
            this.simpleButtonSiparisiTamamla.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSiparisiTamamla.Image")));
            this.simpleButtonSiparisiTamamla.Location = new System.Drawing.Point(203, 3);
            this.simpleButtonSiparisiTamamla.Name = "simpleButtonSiparisiTamamla";
            this.simpleButtonSiparisiTamamla.Size = new System.Drawing.Size(117, 44);
            this.simpleButtonSiparisiTamamla.TabIndex = 7;
            this.simpleButtonSiparisiTamamla.Text = "Satışı Tamamla";
            this.simpleButtonSiparisiTamamla.Click += new System.EventHandler(this.simpleButtonSiparisiTamamla_Click);
            // 
            // simpleButtonFaturayiGoster
            // 
            this.simpleButtonFaturayiGoster.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonFaturayiGoster.Image")));
            this.simpleButtonFaturayiGoster.Location = new System.Drawing.Point(326, 3);
            this.simpleButtonFaturayiGoster.Name = "simpleButtonFaturayiGoster";
            this.simpleButtonFaturayiGoster.Size = new System.Drawing.Size(117, 44);
            this.simpleButtonFaturayiGoster.TabIndex = 8;
            this.simpleButtonFaturayiGoster.Text = "Faturayı \r\nGöster";
            this.simpleButtonFaturayiGoster.Click += new System.EventHandler(this.simpleButtonFaturayiGoster_Click);
            // 
            // FormUrunSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 466);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormUrunSat";
            this.Text = "FormUrunSat";
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunBarkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMusteriKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSubeKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunMiktari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditUrunBarkodu;
        private DevExpress.XtraEditors.TextEdit textEditMusteriKodu;
        private DevExpress.XtraEditors.TextEdit textEditSubeKodu;
        private DevExpress.XtraEditors.TextEdit textEditUrunMiktari;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSiparisiTamamla;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFaturayiGoster;
    }
}