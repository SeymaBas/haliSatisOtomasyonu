namespace haliSatisOtomasyonu.stok
{
    partial class FormStokAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStokAra));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageArama = new DevExpress.XtraTab.XtraTabPage();
            this.labelControlBilgi = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAra = new DevExpress.XtraEditors.SimpleButton();
            this.textEditBarkod = new DevExpress.XtraEditors.TextEdit();
            this.textEditUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControlBarkod = new DevExpress.XtraEditors.LabelControl();
            this.labelControlStokAdi = new DevExpress.XtraEditors.LabelControl();
            this.gridControlUrunListelemeEkrani = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunListelemeEkrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlUrunListelemeEkrani);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(700, 425);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageArama;
            this.xtraTabControl1.Size = new System.Drawing.Size(229, 425);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageArama});
            // 
            // xtraTabPageArama
            // 
            this.xtraTabPageArama.Controls.Add(this.labelControlBilgi);
            this.xtraTabPageArama.Controls.Add(this.simpleButtonTemizle);
            this.xtraTabPageArama.Controls.Add(this.simpleButtonAra);
            this.xtraTabPageArama.Controls.Add(this.textEditBarkod);
            this.xtraTabPageArama.Controls.Add(this.textEditUrunAdi);
            this.xtraTabPageArama.Controls.Add(this.labelControlBarkod);
            this.xtraTabPageArama.Controls.Add(this.labelControlStokAdi);
            this.xtraTabPageArama.Name = "xtraTabPageArama";
            this.xtraTabPageArama.Size = new System.Drawing.Size(223, 397);
            this.xtraTabPageArama.Text = "Arama";
            // 
            // labelControlBilgi
            // 
            this.labelControlBilgi.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlBilgi.LineVisible = true;
            this.labelControlBilgi.Location = new System.Drawing.Point(12, 18);
            this.labelControlBilgi.Name = "labelControlBilgi";
            this.labelControlBilgi.Size = new System.Drawing.Size(215, 36);
            this.labelControlBilgi.TabIndex = 8;
            this.labelControlBilgi.Text = "Ürünün barkodunu veya \r\nadını girerek arama yapabilirsiniz...";
            // 
            // simpleButtonTemizle
            // 
            this.simpleButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonTemizle.Image")));
            this.simpleButtonTemizle.Location = new System.Drawing.Point(111, 216);
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
            this.simpleButtonAra.Location = new System.Drawing.Point(12, 216);
            this.simpleButtonAra.Name = "simpleButtonAra";
            this.simpleButtonAra.Size = new System.Drawing.Size(93, 46);
            this.simpleButtonAra.TabIndex = 6;
            this.simpleButtonAra.Text = "Ara";
            this.simpleButtonAra.Click += new System.EventHandler(this.simpleButtonAra_Click);
            // 
            // textEditBarkod
            // 
            this.textEditBarkod.Location = new System.Drawing.Point(12, 178);
            this.textEditBarkod.Name = "textEditBarkod";
            this.textEditBarkod.Size = new System.Drawing.Size(200, 20);
            this.textEditBarkod.TabIndex = 5;
            // 
            // textEditUrunAdi
            // 
            this.textEditUrunAdi.Location = new System.Drawing.Point(11, 105);
            this.textEditUrunAdi.Name = "textEditUrunAdi";
            this.textEditUrunAdi.Size = new System.Drawing.Size(200, 20);
            this.textEditUrunAdi.TabIndex = 4;
            // 
            // labelControlBarkod
            // 
            this.labelControlBarkod.Location = new System.Drawing.Point(12, 148);
            this.labelControlBarkod.Name = "labelControlBarkod";
            this.labelControlBarkod.Size = new System.Drawing.Size(40, 13);
            this.labelControlBarkod.TabIndex = 2;
            this.labelControlBarkod.Text = "Barkod :";
            // 
            // labelControlStokAdi
            // 
            this.labelControlStokAdi.Location = new System.Drawing.Point(12, 86);
            this.labelControlStokAdi.Name = "labelControlStokAdi";
            this.labelControlStokAdi.Size = new System.Drawing.Size(48, 13);
            this.labelControlStokAdi.TabIndex = 1;
            this.labelControlStokAdi.Text = "Ürün Adı :";
            // 
            // gridControlUrunListelemeEkrani
            // 
            this.gridControlUrunListelemeEkrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunListelemeEkrani.Location = new System.Drawing.Point(0, 0);
            this.gridControlUrunListelemeEkrani.MainView = this.gridView1;
            this.gridControlUrunListelemeEkrani.Name = "gridControlUrunListelemeEkrani";
            this.gridControlUrunListelemeEkrani.Size = new System.Drawing.Size(466, 425);
            this.gridControlUrunListelemeEkrani.TabIndex = 0;
            this.gridControlUrunListelemeEkrani.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlUrunListelemeEkrani;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FormStokAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 425);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormStokAra";
            this.Text = "Stoklarda Ara";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageArama.ResumeLayout(false);
            this.xtraTabPageArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunListelemeEkrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageArama;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTemizle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAra;
        private DevExpress.XtraEditors.TextEdit textEditBarkod;
        private DevExpress.XtraEditors.TextEdit textEditUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControlBarkod;
        private DevExpress.XtraEditors.LabelControl labelControlStokAdi;
        private DevExpress.XtraGrid.GridControl gridControlUrunListelemeEkrani;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControlBilgi;

    }
}