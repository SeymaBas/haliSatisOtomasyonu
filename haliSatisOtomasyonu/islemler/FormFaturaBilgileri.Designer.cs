namespace haliSatisOtomasyonu
{
    partial class FormFaturaBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturaBilgileri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCariKodu = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCariAdi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlFaturaNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTarih = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlToplam = new DevExpress.XtraEditors.LabelControl();
            this.labelControlToplamKDV = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlNet = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlFatura = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrunTanimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButtonKapat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOnizleme = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Bilgileri";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControlCariKodu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControlCariAdi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControlFaturaNo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControlTarih, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControlToplam, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControlToplamKDV, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl13, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControlNet, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Kodu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Cari Adı :";
            // 
            // labelControlCariKodu
            // 
            this.labelControlCariKodu.Location = new System.Drawing.Point(83, 3);
            this.labelControlCariKodu.Name = "labelControlCariKodu";
            this.labelControlCariKodu.Size = new System.Drawing.Size(63, 13);
            this.labelControlCariKodu.TabIndex = 2;
            this.labelControlCariKodu.Text = "labelControl3";
            // 
            // labelControlCariAdi
            // 
            this.labelControlCariAdi.Location = new System.Drawing.Point(83, 42);
            this.labelControlCariAdi.Name = "labelControlCariAdi";
            this.labelControlCariAdi.Size = new System.Drawing.Size(63, 13);
            this.labelControlCariAdi.TabIndex = 3;
            this.labelControlCariAdi.Text = "labelControl4";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(163, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Fatura No :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(163, 42);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Tarih :";
            // 
            // labelControlFaturaNo
            // 
            this.labelControlFaturaNo.Location = new System.Drawing.Point(243, 3);
            this.labelControlFaturaNo.Name = "labelControlFaturaNo";
            this.labelControlFaturaNo.Size = new System.Drawing.Size(63, 13);
            this.labelControlFaturaNo.TabIndex = 6;
            this.labelControlFaturaNo.Text = "labelControl7";
            // 
            // labelControlTarih
            // 
            this.labelControlTarih.Location = new System.Drawing.Point(243, 42);
            this.labelControlTarih.Name = "labelControlTarih";
            this.labelControlTarih.Size = new System.Drawing.Size(63, 13);
            this.labelControlTarih.TabIndex = 7;
            this.labelControlTarih.Text = "labelControl8";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(323, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Toplam :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(323, 42);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(63, 13);
            this.labelControl10.TabIndex = 9;
            this.labelControl10.Text = "Toplam KDV :";
            // 
            // labelControlToplam
            // 
            this.labelControlToplam.Location = new System.Drawing.Point(403, 3);
            this.labelControlToplam.Name = "labelControlToplam";
            this.labelControlToplam.Size = new System.Drawing.Size(69, 13);
            this.labelControlToplam.TabIndex = 10;
            this.labelControlToplam.Text = "labelControl11";
            // 
            // labelControlToplamKDV
            // 
            this.labelControlToplamKDV.Location = new System.Drawing.Point(403, 42);
            this.labelControlToplamKDV.Name = "labelControlToplamKDV";
            this.labelControlToplamKDV.Size = new System.Drawing.Size(69, 13);
            this.labelControlToplamKDV.TabIndex = 11;
            this.labelControlToplamKDV.Text = "labelControl12";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(483, 3);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 13);
            this.labelControl13.TabIndex = 12;
            this.labelControl13.Text = "Net :";
            // 
            // labelControlNet
            // 
            this.labelControlNet.Location = new System.Drawing.Point(563, 3);
            this.labelControlNet.Name = "labelControlNet";
            this.labelControlNet.Size = new System.Drawing.Size(69, 13);
            this.labelControlNet.TabIndex = 13;
            this.labelControlNet.Text = "labelControl14";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlFatura);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış Bilgisi";
            // 
            // gridControlFatura
            // 
            this.gridControlFatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFatura.Location = new System.Drawing.Point(3, 17);
            this.gridControlFatura.MainView = this.gridView1;
            this.gridControlFatura.Name = "gridControlFatura";
            this.gridControlFatura.Size = new System.Drawing.Size(647, 234);
            this.gridControlFatura.TabIndex = 0;
            this.gridControlFatura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUrunKodu,
            this.gridColumnUrunTanimi,
            this.gridColumnBarkod,
            this.gridColumnMiktar,
            this.gridColumnBirimFiyat,
            this.gridColumnAciklama});
            this.gridView1.GridControl = this.gridControlFatura;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnUrunKodu
            // 
            this.gridColumnUrunKodu.Caption = "Ürün Kodu";
            this.gridColumnUrunKodu.Name = "gridColumnUrunKodu";
            this.gridColumnUrunKodu.Visible = true;
            this.gridColumnUrunKodu.VisibleIndex = 0;
            // 
            // gridColumnUrunTanimi
            // 
            this.gridColumnUrunTanimi.Caption = "Ürün Tanımı";
            this.gridColumnUrunTanimi.Name = "gridColumnUrunTanimi";
            this.gridColumnUrunTanimi.Visible = true;
            this.gridColumnUrunTanimi.VisibleIndex = 1;
            // 
            // gridColumnBarkod
            // 
            this.gridColumnBarkod.Caption = "Barkod";
            this.gridColumnBarkod.Name = "gridColumnBarkod";
            this.gridColumnBarkod.Visible = true;
            this.gridColumnBarkod.VisibleIndex = 2;
            // 
            // gridColumnMiktar
            // 
            this.gridColumnMiktar.Caption = "Miktar";
            this.gridColumnMiktar.Name = "gridColumnMiktar";
            this.gridColumnMiktar.Visible = true;
            this.gridColumnMiktar.VisibleIndex = 3;
            // 
            // gridColumnBirimFiyat
            // 
            this.gridColumnBirimFiyat.Caption = "Birim Fiyat";
            this.gridColumnBirimFiyat.Name = "gridColumnBirimFiyat";
            this.gridColumnBirimFiyat.Visible = true;
            this.gridColumnBirimFiyat.VisibleIndex = 4;
            // 
            // gridColumnAciklama
            // 
            this.gridColumnAciklama.Caption = "Açıklama";
            this.gridColumnAciklama.Name = "gridColumnAciklama";
            this.gridColumnAciklama.Visible = true;
            this.gridColumnAciklama.VisibleIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonKapat);
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonYazdir);
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonOnizleme);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(165, 17);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(485, 43);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // simpleButtonKapat
            // 
            this.simpleButtonKapat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKapat.Image")));
            this.simpleButtonKapat.Location = new System.Drawing.Point(392, 3);
            this.simpleButtonKapat.Name = "simpleButtonKapat";
            this.simpleButtonKapat.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonKapat.TabIndex = 2;
            this.simpleButtonKapat.Text = "Kapat";
            this.simpleButtonKapat.Click += new System.EventHandler(this.simpleButtonKapat_Click);
            // 
            // simpleButtonYazdir
            // 
            this.simpleButtonYazdir.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonYazdir.Image")));
            this.simpleButtonYazdir.Location = new System.Drawing.Point(296, 3);
            this.simpleButtonYazdir.Name = "simpleButtonYazdir";
            this.simpleButtonYazdir.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonYazdir.TabIndex = 3;
            this.simpleButtonYazdir.Text = "Yazdır";
            this.simpleButtonYazdir.Click += new System.EventHandler(this.simpleButtonYazdir_Click);
            // 
            // simpleButtonOnizleme
            // 
            this.simpleButtonOnizleme.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonOnizleme.Image")));
            this.simpleButtonOnizleme.Location = new System.Drawing.Point(200, 3);
            this.simpleButtonOnizleme.Name = "simpleButtonOnizleme";
            this.simpleButtonOnizleme.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonOnizleme.TabIndex = 4;
            this.simpleButtonOnizleme.Text = "Önizleme";
            this.simpleButtonOnizleme.Click += new System.EventHandler(this.simpleButtonOnizleme_Click);
            // 
            // FormFaturaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 359);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFaturaBilgileri";
            this.Text = "Fatura Detay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOnizleme;
        private DevExpress.XtraEditors.SimpleButton simpleButtonYazdir;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKapat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControlCariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControlFaturaNo;
        private DevExpress.XtraEditors.LabelControl labelControlTarih;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControlToplam;
        private DevExpress.XtraEditors.LabelControl labelControlToplamKDV;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControlNet;
        private DevExpress.XtraGrid.GridControl gridControlFatura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrunTanimi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAciklama;
    }
}