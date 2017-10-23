namespace haliSatisOtomasyonu.stok
{
    partial class FormStokListesi
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
            this.groupControlGenelStokBilgileri = new DevExpress.XtraEditors.GroupControl();
            this.gridControlStokListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGenelStokBilgileri)).BeginInit();
            this.groupControlGenelStokBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlGenelStokBilgileri
            // 
            this.groupControlGenelStokBilgileri.Controls.Add(this.gridControlStokListesi);
            this.groupControlGenelStokBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlGenelStokBilgileri.Location = new System.Drawing.Point(0, 0);
            this.groupControlGenelStokBilgileri.Name = "groupControlGenelStokBilgileri";
            this.groupControlGenelStokBilgileri.Size = new System.Drawing.Size(749, 448);
            this.groupControlGenelStokBilgileri.TabIndex = 1;
            this.groupControlGenelStokBilgileri.Text = "Genel Stok Bilgileri";
            // 
            // gridControlStokListesi
            // 
            this.gridControlStokListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStokListesi.Location = new System.Drawing.Point(2, 20);
            this.gridControlStokListesi.MainView = this.gridView1;
            this.gridControlStokListesi.Name = "gridControlStokListesi";
            this.gridControlStokListesi.Size = new System.Drawing.Size(745, 426);
            this.gridControlStokListesi.TabIndex = 0;
            this.gridControlStokListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlStokListesi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FormStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 448);
            this.Controls.Add(this.groupControlGenelStokBilgileri);
            this.Name = "FormStokListesi";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.FormStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGenelStokBilgileri)).EndInit();
            this.groupControlGenelStokBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlGenelStokBilgileri;
        private DevExpress.XtraGrid.GridControl gridControlStokListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}