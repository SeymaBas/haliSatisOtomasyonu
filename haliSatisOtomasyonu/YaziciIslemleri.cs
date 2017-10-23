using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haliSatisOtomasyonu
{
   public class YaziciIslemleri
    {
        public void VerileriExceleAktar(GridControl gridControl)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {

                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "Dosya Açılamadı" + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "Dosya kaydedilemedi" + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
        public void PrintGrid(GridControl grid)
        {
            // Yazıcı kontrolü
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("Yazıcı bulunamadı...", "Error");
                return;
            }

            // Yazdir
            grid.Print();
        }

       
        public void ShowGridPreview(GridControl grid)
        {

            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("'DevExpress.XtraPrinting' kütüphanesi bulunamadı", "Error");
                return;
            }


            grid.ShowPrintPreview();
        }
    }
}
