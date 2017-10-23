namespace haliSatisOtomasyonu
{
    partial class FormTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransfer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControlGonderilenAmbar = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButtonVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlOkutulanBarkodlar = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOkutulanBarkodlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.comboBoxEdit1);
            this.groupBox1.Controls.Add(this.labelControlGonderilenAmbar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkod Bilgisi";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(252, 20);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(150, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(114, 20);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(132, 20);
            this.comboBoxEdit1.TabIndex = 1;
            // 
            // labelControlGonderilenAmbar
            // 
            this.labelControlGonderilenAmbar.Location = new System.Drawing.Point(13, 21);
            this.labelControlGonderilenAmbar.Name = "labelControlGonderilenAmbar";
            this.labelControlGonderilenAmbar.Size = new System.Drawing.Size(95, 13);
            this.labelControlGonderilenAmbar.TabIndex = 0;
            this.labelControlGonderilenAmbar.Text = "Gönderilen Ambar : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButtonVazgec);
            this.groupBox3.Controls.Add(this.simpleButtonSil);
            this.groupBox3.Controls.Add(this.simpleButtonKaydet);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // simpleButtonVazgec
            // 
            this.simpleButtonVazgec.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButtonVazgec.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonVazgec.Image")));
            this.simpleButtonVazgec.Location = new System.Drawing.Point(519, 17);
            this.simpleButtonVazgec.Name = "simpleButtonVazgec";
            this.simpleButtonVazgec.Size = new System.Drawing.Size(95, 31);
            this.simpleButtonVazgec.TabIndex = 2;
            this.simpleButtonVazgec.Text = "Vazgeç";
            // 
            // simpleButtonSil
            // 
            this.simpleButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSil.Image")));
            this.simpleButtonSil.Location = new System.Drawing.Point(100, 13);
            this.simpleButtonSil.Name = "simpleButtonSil";
            this.simpleButtonSil.Size = new System.Drawing.Size(95, 30);
            this.simpleButtonSil.TabIndex = 1;
            this.simpleButtonSil.Text = "Sil";
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(7, 12);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(95, 30);
            this.simpleButtonKaydet.TabIndex = 0;
            this.simpleButtonKaydet.Text = "Kaydet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlOkutulanBarkodlar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Okutulan Barkodlar";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlOkutulanBarkodlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlOkutulanBarkodlar
            // 
            this.gridControlOkutulanBarkodlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOkutulanBarkodlar.Location = new System.Drawing.Point(3, 17);
            this.gridControlOkutulanBarkodlar.MainView = this.gridView1;
            this.gridControlOkutulanBarkodlar.Name = "gridControlOkutulanBarkodlar";
            this.gridControlOkutulanBarkodlar.Size = new System.Drawing.Size(611, 315);
            this.gridControlOkutulanBarkodlar.TabIndex = 0;
            this.gridControlOkutulanBarkodlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.GridControl = this.gridControlOkutulanBarkodlar;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransfer";
            this.Text = "Transfer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOkutulanBarkodlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonVazgec;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSil;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControlGonderilenAmbar;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControlOkutulanBarkodlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
    }
}