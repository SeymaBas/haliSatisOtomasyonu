﻿namespace haliSatisOtomasyonu.siparisler
{
    partial class FormSiparisleriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparisleriListele));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSiparisler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButtonOnizleme = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonYenile = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlSiparisler);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(644, 475);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sipariş Detayları";
            // 
            // gridControlSiparisler
            // 
            this.gridControlSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSiparisler.Location = new System.Drawing.Point(2, 23);
            this.gridControlSiparisler.MainView = this.gridView1;
            this.gridControlSiparisler.Name = "gridControlSiparisler";
            this.gridControlSiparisler.Size = new System.Drawing.Size(640, 450);
            this.gridControlSiparisler.TabIndex = 0;
            this.gridControlSiparisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlSiparisler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.flowLayoutPanel2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 409);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(644, 66);
            this.groupControl2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonOnizleme);
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonYazdir);
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonExcel);
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonYenile);
            this.flowLayoutPanel2.Controls.Add(this.simpleButtonKapat);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(157, 23);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(485, 41);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // simpleButtonOnizleme
            // 
            this.simpleButtonOnizleme.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonOnizleme.Image")));
            this.simpleButtonOnizleme.Location = new System.Drawing.Point(3, 3);
            this.simpleButtonOnizleme.Name = "simpleButtonOnizleme";
            this.simpleButtonOnizleme.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonOnizleme.TabIndex = 4;
            this.simpleButtonOnizleme.Text = "Önizleme";
            this.simpleButtonOnizleme.Click += new System.EventHandler(this.simpleButtonOnizleme_Click);
            // 
            // simpleButtonYazdir
            // 
            this.simpleButtonYazdir.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonYazdir.Image")));
            this.simpleButtonYazdir.Location = new System.Drawing.Point(99, 3);
            this.simpleButtonYazdir.Name = "simpleButtonYazdir";
            this.simpleButtonYazdir.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonYazdir.TabIndex = 3;
            this.simpleButtonYazdir.Text = "Yazdır";
            this.simpleButtonYazdir.Click += new System.EventHandler(this.simpleButtonYazdir_Click);
            // 
            // simpleButtonExcel
            // 
            this.simpleButtonExcel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonExcel.Image")));
            this.simpleButtonExcel.Location = new System.Drawing.Point(195, 3);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonExcel.TabIndex = 0;
            this.simpleButtonExcel.Text = "Excel";
            this.simpleButtonExcel.Click += new System.EventHandler(this.simpleButtonExcel_Click);
            // 
            // simpleButtonYenile
            // 
            this.simpleButtonYenile.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonYenile.Image")));
            this.simpleButtonYenile.Location = new System.Drawing.Point(291, 3);
            this.simpleButtonYenile.Name = "simpleButtonYenile";
            this.simpleButtonYenile.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonYenile.TabIndex = 1;
            this.simpleButtonYenile.Text = "Yenile";
            this.simpleButtonYenile.Click += new System.EventHandler(this.simpleButtonYenile_Click);
            // 
            // simpleButtonKapat
            // 
            this.simpleButtonKapat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKapat.Image")));
            this.simpleButtonKapat.Location = new System.Drawing.Point(387, 3);
            this.simpleButtonKapat.Name = "simpleButtonKapat";
            this.simpleButtonKapat.Size = new System.Drawing.Size(90, 34);
            this.simpleButtonKapat.TabIndex = 2;
            this.simpleButtonKapat.Text = "Kapat";
            this.simpleButtonKapat.Click += new System.EventHandler(this.simpleButtonKapat_Click);
            // 
            // FormSiparisleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 475);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormSiparisleriListele";
            this.Text = "FormSiparisleriListele";
            this.Load += new System.EventHandler(this.FormSiparisleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOnizleme;
        private DevExpress.XtraEditors.SimpleButton simpleButtonYazdir;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonYenile;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKapat;
        private DevExpress.XtraGrid.GridControl gridControlSiparisler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}