namespace haliSatisOtomasyonu.stok
{
    partial class FormStokHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStokHareketleri));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageArama = new DevExpress.XtraTab.XtraTabPage();
            this.labelControlBilgi = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAra = new DevExpress.XtraEditors.SimpleButton();
            this.textEditBarkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControlBarkod = new DevExpress.XtraEditors.LabelControl();
            this.gridControlStokHareketListele = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButtonOnizleme = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokHareketListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlStokHareketListele);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(655, 425);
            this.splitContainerControl1.SplitterPosition = 221;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageArama;
            this.xtraTabControl1.Size = new System.Drawing.Size(221, 425);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageArama});
            // 
            // xtraTabPageArama
            // 
            this.xtraTabPageArama.Controls.Add(this.labelControlBilgi);
            this.xtraTabPageArama.Controls.Add(this.simpleButtonTemizle);
            this.xtraTabPageArama.Controls.Add(this.simpleButtonAra);
            this.xtraTabPageArama.Controls.Add(this.textEditBarkod);
            this.xtraTabPageArama.Controls.Add(this.labelControlBarkod);
            this.xtraTabPageArama.Name = "xtraTabPageArama";
            this.xtraTabPageArama.Size = new System.Drawing.Size(215, 397);
            this.xtraTabPageArama.Text = "Arama";
            // 
            // labelControlBilgi
            // 
            this.labelControlBilgi.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBilgi.LineVisible = true;
            this.labelControlBilgi.Location = new System.Drawing.Point(12, 24);
            this.labelControlBilgi.Name = "labelControlBilgi";
            this.labelControlBilgi.Size = new System.Drawing.Size(195, 36);
            this.labelControlBilgi.TabIndex = 8;
            this.labelControlBilgi.Text = "Durumunu öğrenmek istediğiniz \r\nürünün barkodunu okutunuz...";
            // 
            // simpleButtonTemizle
            // 
            this.simpleButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonTemizle.Image")));
            this.simpleButtonTemizle.Location = new System.Drawing.Point(114, 143);
            this.simpleButtonTemizle.Name = "simpleButtonTemizle";
            this.simpleButtonTemizle.Size = new System.Drawing.Size(93, 46);
            this.simpleButtonTemizle.TabIndex = 7;
            this.simpleButtonTemizle.Text = "Temizle";
            this.simpleButtonTemizle.Click += new System.EventHandler(this.simpleButtonTemizle_Click);
            // 
            // simpleButtonAra
            // 
            this.simpleButtonAra.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAra.Image")));
            this.simpleButtonAra.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButtonAra.Location = new System.Drawing.Point(15, 143);
            this.simpleButtonAra.Name = "simpleButtonAra";
            this.simpleButtonAra.Size = new System.Drawing.Size(93, 46);
            this.simpleButtonAra.TabIndex = 6;
            this.simpleButtonAra.Text = "Ara";
            this.simpleButtonAra.Click += new System.EventHandler(this.simpleButtonAra_Click);
            // 
            // textEditBarkod
            // 
            this.textEditBarkod.Location = new System.Drawing.Point(15, 105);
            this.textEditBarkod.Name = "textEditBarkod";
            this.textEditBarkod.Size = new System.Drawing.Size(200, 20);
            this.textEditBarkod.TabIndex = 5;
            // 
            // labelControlBarkod
            // 
            this.labelControlBarkod.Location = new System.Drawing.Point(15, 75);
            this.labelControlBarkod.Name = "labelControlBarkod";
            this.labelControlBarkod.Size = new System.Drawing.Size(40, 13);
            this.labelControlBarkod.TabIndex = 2;
            this.labelControlBarkod.Text = "Barkod :";
            // 
            // gridControlStokHareketListele
            // 
            this.gridControlStokHareketListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStokHareketListele.Location = new System.Drawing.Point(0, 0);
            this.gridControlStokHareketListele.MainView = this.gridView1;
            this.gridControlStokHareketListele.Name = "gridControlStokHareketListele";
            this.gridControlStokHareketListele.Size = new System.Drawing.Size(429, 425);
            this.gridControlStokHareketListele.TabIndex = 0;
            this.gridControlStokHareketListele.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlStokHareketListele;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonKapat);
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonExcel);
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonOnizleme);
            this.flowLayoutPanel1.Controls.Add(this.simpleButtonYazdir);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(423, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // simpleButtonOnizleme
            // 
            this.simpleButtonOnizleme.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonOnizleme.Image")));
            this.simpleButtonOnizleme.Location = new System.Drawing.Point(138, 3);
            this.simpleButtonOnizleme.Name = "simpleButtonOnizleme";
            this.simpleButtonOnizleme.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonOnizleme.TabIndex = 8;
            this.simpleButtonOnizleme.Text = "Önizleme";
            this.simpleButtonOnizleme.Click += new System.EventHandler(this.simpleButtonOnizleme_Click);
            // 
            // simpleButtonYazdir
            // 
            this.simpleButtonYazdir.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonYazdir.Image")));
            this.simpleButtonYazdir.Location = new System.Drawing.Point(42, 3);
            this.simpleButtonYazdir.Name = "simpleButtonYazdir";
            this.simpleButtonYazdir.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonYazdir.TabIndex = 7;
            this.simpleButtonYazdir.Text = "Yazdır";
            this.simpleButtonYazdir.Click += new System.EventHandler(this.simpleButtonYazdir_Click);
            // 
            // simpleButtonExcel
            // 
            this.simpleButtonExcel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonExcel.Image")));
            this.simpleButtonExcel.Location = new System.Drawing.Point(234, 3);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonExcel.TabIndex = 5;
            this.simpleButtonExcel.Text = "Excel";
            this.simpleButtonExcel.Click += new System.EventHandler(this.simpleButtonExcel_Click);
            // 
            // simpleButtonKapat
            // 
            this.simpleButtonKapat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKapat.Image")));
            this.simpleButtonKapat.Location = new System.Drawing.Point(330, 3);
            this.simpleButtonKapat.Name = "simpleButtonKapat";
            this.simpleButtonKapat.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonKapat.TabIndex = 6;
            this.simpleButtonKapat.Text = "Kapat";
            this.simpleButtonKapat.Click += new System.EventHandler(this.simpleButtonKapat_Click);
            // 
            // FormStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 425);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormStokHareketleri";
            this.Text = "Stok Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageArama.ResumeLayout(false);
            this.xtraTabPageArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokHareketListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageArama;
        private DevExpress.XtraEditors.LabelControl labelControlBilgi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTemizle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAra;
        private DevExpress.XtraEditors.TextEdit textEditBarkod;
        private DevExpress.XtraEditors.LabelControl labelControlBarkod;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControlStokHareketListele;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKapat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOnizleme;
        private DevExpress.XtraEditors.SimpleButton simpleButtonYazdir;

    }
}