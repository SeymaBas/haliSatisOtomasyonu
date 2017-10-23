namespace haliSatisOtomasyonu.musteriler
{
    partial class FormCariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCariListesi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonTumunuListele = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMusteriAra = new DevExpress.XtraEditors.SimpleButton();
            this.textEditMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControlMusteriAdi = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMusteriAdi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMusteriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonTumunuListele);
            this.groupControl1.Controls.Add(this.simpleButtonMusteriAra);
            this.groupControl1.Controls.Add(this.textEditMusteriAdi);
            this.groupControl1.Controls.Add(this.labelControlMusteriAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(565, 86);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Müşteri Bilgileri";
            // 
            // simpleButtonTumunuListele
            // 
            this.simpleButtonTumunuListele.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonTumunuListele.Image")));
            this.simpleButtonTumunuListele.Location = new System.Drawing.Point(379, 28);
            this.simpleButtonTumunuListele.Name = "simpleButtonTumunuListele";
            this.simpleButtonTumunuListele.Size = new System.Drawing.Size(123, 44);
            this.simpleButtonTumunuListele.TabIndex = 3;
            this.simpleButtonTumunuListele.Text = "Tümünü Listele";
            this.simpleButtonTumunuListele.Click += new System.EventHandler(this.simpleButtonTumunuListele_Click);
            // 
            // simpleButtonMusteriAra
            // 
            this.simpleButtonMusteriAra.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonMusteriAra.Image")));
            this.simpleButtonMusteriAra.Location = new System.Drawing.Point(250, 28);
            this.simpleButtonMusteriAra.Name = "simpleButtonMusteriAra";
            this.simpleButtonMusteriAra.Size = new System.Drawing.Size(123, 44);
            this.simpleButtonMusteriAra.TabIndex = 2;
            this.simpleButtonMusteriAra.Text = "Ara";
            this.simpleButtonMusteriAra.Click += new System.EventHandler(this.simpleButtonMusteriAra_Click);
            // 
            // textEditMusteriAdi
            // 
            this.textEditMusteriAdi.Location = new System.Drawing.Point(105, 40);
            this.textEditMusteriAdi.Name = "textEditMusteriAdi";
            this.textEditMusteriAdi.Size = new System.Drawing.Size(138, 20);
            this.textEditMusteriAdi.TabIndex = 1;
            // 
            // labelControlMusteriAdi
            // 
            this.labelControlMusteriAdi.Location = new System.Drawing.Point(21, 43);
            this.labelControlMusteriAdi.Name = "labelControlMusteriAdi";
            this.labelControlMusteriAdi.Size = new System.Drawing.Size(63, 13);
            this.labelControlMusteriAdi.TabIndex = 0;
            this.labelControlMusteriAdi.Text = "Müşteri Adı : ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlMusteriAdi);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 86);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(565, 315);
            this.groupControl2.TabIndex = 1;
            // 
            // gridControlMusteriAdi
            // 
            this.gridControlMusteriAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMusteriAdi.Location = new System.Drawing.Point(2, 23);
            this.gridControlMusteriAdi.MainView = this.gridView1;
            this.gridControlMusteriAdi.Name = "gridControlMusteriAdi";
            this.gridControlMusteriAdi.Size = new System.Drawing.Size(561, 290);
            this.gridControlMusteriAdi.TabIndex = 0;
            this.gridControlMusteriAdi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlMusteriAdi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FormCariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 401);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormCariListesi";
            this.Text = "Cari Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMusteriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteriAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTumunuListele;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMusteriAra;
        private DevExpress.XtraEditors.TextEdit textEditMusteriAdi;
        private DevExpress.XtraEditors.LabelControl labelControlMusteriAdi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlMusteriAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}