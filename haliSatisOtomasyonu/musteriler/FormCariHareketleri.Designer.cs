namespace haliSatisOtomasyonu.musteriler
{
    partial class FormCariHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCariHareketleri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonMusteriAra = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControlMusteriAdi = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlFaturalar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButtonIadeGerceklestir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAyrintiGoster = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFaturalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonMusteriAra);
            this.groupControl1.Controls.Add(this.textEditFaturaNo);
            this.groupControl1.Controls.Add(this.labelControlMusteriAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(524, 84);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Fatura Bilgileri";
            // 
            // simpleButtonMusteriAra
            // 
            this.simpleButtonMusteriAra.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonMusteriAra.Image")));
            this.simpleButtonMusteriAra.Location = new System.Drawing.Point(273, 29);
            this.simpleButtonMusteriAra.Name = "simpleButtonMusteriAra";
            this.simpleButtonMusteriAra.Size = new System.Drawing.Size(123, 44);
            this.simpleButtonMusteriAra.TabIndex = 6;
            this.simpleButtonMusteriAra.Text = "Ara";
            this.simpleButtonMusteriAra.Click += new System.EventHandler(this.simpleButtonMusteriAra_Click);
            // 
            // textEditFaturaNo
            // 
            this.textEditFaturaNo.Location = new System.Drawing.Point(107, 41);
            this.textEditFaturaNo.Name = "textEditFaturaNo";
            this.textEditFaturaNo.Size = new System.Drawing.Size(138, 20);
            this.textEditFaturaNo.TabIndex = 5;
            this.textEditFaturaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditFaturaNo_KeyDown);
            // 
            // labelControlMusteriAdi
            // 
            this.labelControlMusteriAdi.Location = new System.Drawing.Point(12, 44);
            this.labelControlMusteriAdi.Name = "labelControlMusteriAdi";
            this.labelControlMusteriAdi.Size = new System.Drawing.Size(89, 13);
            this.labelControlMusteriAdi.TabIndex = 4;
            this.labelControlMusteriAdi.Text = "Fatura Numarası : ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlFaturalar);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 84);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(524, 336);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Hesap Dökümü";
            // 
            // gridControlFaturalar
            // 
            this.gridControlFaturalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFaturalar.Location = new System.Drawing.Point(2, 20);
            this.gridControlFaturalar.MainView = this.gridView1;
            this.gridControlFaturalar.Name = "gridControlFaturalar";
            this.gridControlFaturalar.Size = new System.Drawing.Size(520, 237);
            this.gridControlFaturalar.TabIndex = 1;
            this.gridControlFaturalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlFaturalar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.flowLayoutPanel1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 257);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(520, 77);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "İşlemler";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonIadeGerceklestir);
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonAyrintiGoster);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // simpleButtonIadeGerceklestir
            // 
            this.simpleButtonIadeGerceklestir.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonIadeGerceklestir.Image")));
            this.simpleButtonIadeGerceklestir.Location = new System.Drawing.Point(394, 3);
            this.simpleButtonIadeGerceklestir.Name = "simpleButtonIadeGerceklestir";
            this.simpleButtonIadeGerceklestir.Size = new System.Drawing.Size(119, 44);
            this.simpleButtonIadeGerceklestir.TabIndex = 0;
            this.simpleButtonIadeGerceklestir.Text = "İade\r\n Gerçekleştir";
            this.simpleButtonIadeGerceklestir.Click += new System.EventHandler(this.simpleButtonIadeGerceklestir_Click);
            // 
            // simpleButtonAyrintiGoster
            // 
            this.simpleButtonAyrintiGoster.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAyrintiGoster.Image")));
            this.simpleButtonAyrintiGoster.Location = new System.Drawing.Point(269, 3);
            this.simpleButtonAyrintiGoster.Name = "simpleButtonAyrintiGoster";
            this.simpleButtonAyrintiGoster.Size = new System.Drawing.Size(119, 44);
            this.simpleButtonAyrintiGoster.TabIndex = 1;
            this.simpleButtonAyrintiGoster.Text = "Ayrıntıları \r\nGöster";
            this.simpleButtonAyrintiGoster.Click += new System.EventHandler(this.simpleButtonAyrintiGoster_Click);
            // 
            // FormCariHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 420);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormCariHareketleri";
            this.Text = "Cari Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFaturalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMusteriAra;
        private DevExpress.XtraEditors.TextEdit textEditFaturaNo;
        private DevExpress.XtraEditors.LabelControl labelControlMusteriAdi;
        private DevExpress.XtraGrid.GridControl gridControlFaturalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonIadeGerceklestir;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAyrintiGoster;
    }
}