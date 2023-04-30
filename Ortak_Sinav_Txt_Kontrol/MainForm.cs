using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TulparUI.Controls;

namespace Ortak_Sinav_Txt_Kontrol
{
    public partial class MainForm : TulparForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string InnerTrim(string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        }

        public void ControlTxttoExcel(string Path)
        {
            ListSinav.Items.Clear();
            //Soru
            List<string> list = new List<string>();

            //txt satır satır list listesine ekliyor.
            FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            string[] lines = list.ToArray();
            string ln;

            //tzt satır sayısı
            int Count = lines.Length;

            try
            {
                for (int i = 0; i < Count; i++)
                {
                    ln = lines[i];

                    if (ln.Length != 0)
                    {
                        string Ad = ln.Substring(0, 14);
                        string Soyad = ln.Substring(14, 14);
                        string TCNo = ln.Substring(28, 11);
                        string OkulNo = ln.Substring(39, 8);
                        string DersKodu = ln.Substring(47, 3);
                        string OkulKodu = ln.Substring(50, 4);
                        string OkulTur = ln.Substring(54, 1);
                        string Cinsiyet = ln.Substring(55, 1);
                        string CevapTur = ln.Substring(56, 1);
                        string AdayCevapAnahtari = ln.Substring(57, 20);

                        ListViewItem ListSinavItem = new ListViewItem(Ad);
                        ListSinavItem.SubItems.Add(Soyad);
                        ListSinavItem.SubItems.Add(TCNo);
                        ListSinavItem.SubItems.Add(AdayCevapAnahtari);
                        ListSinav.Items.Add(ListSinavItem);
                    }
                    else
                    {
                        ListViewItem ListSinavItem = new ListViewItem(" ");
                        ListSinavItem.SubItems.Add(" ");
                        ListSinavItem.SubItems.Add(" ");
                        ListSinavItem.SubItems.Add(" ");
                        ListSinav.Items.Add(ListSinavItem);
                    }
                }
                TxtToExcelSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportExcel(string Path)
        {
            object misvalue = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = true,
                StandardFont = "Times New Roman",
                StandardFontSize = 12,
            };
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            ws.Cells[1, 1] = "Ad";
            ws.Cells[1, 2] = "Soyad";
            ws.Cells[1, 3] = "TC no";
            ws.Cells[1, 4] = "Öğrenci Cevap Anahtarı";
            //ws.Cells[1, 5] = "Ders Kodu";
            //ws.Cells[1, 6] = "Okul Kodu";
            //ws.Cells[1, 7] = "Okul Tur";
            //ws.Cells[1, 8] = "Cinsiyet";
            //ws.Cells[1, 9] = "Cevap Tur";
            //ws.Cells[1, 10] = "Öğrenci Cevap Anahtarı";


            int i2 = 2;
            foreach (ListViewItem lvi in ListSinav.Items)
            {
                int i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    Microsoft.Office.Interop.Excel.Range range = ws.UsedRange;
                    Microsoft.Office.Interop.Excel.Range cell = range.Cells[i2, i];
                    Microsoft.Office.Interop.Excel.Borders border = cell.Borders;
                    border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    //border.Weight = 2d;
                    i++;
                }
                i2++;
            }

            wb.SaveAs(Path);
            // StatusLog.StatusText(ErrorCode.Sistem, "Kayıt Başarılı!");
            ListSinav.Items.Clear();

            //System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "txt_to_excel.xlsx"
        }

        private void TxtToExcelSave()
        {
            SaveDocx.Filter = "Excel|*.xlsx";
            SaveDocx.FileName = "Txt to Excel";

            //if (!Globals.IsDebugEnagble)
            //    SaveDocx.InitialDirectory = @"\\172.16.12.47\idari Br\YAZIŞMALAR  AĞUSTOS 2020";


            switch (SaveDocx.ShowDialog())
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    ExportExcel(SaveDocx.FileName);
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }


        public void ControlTxt(string Path)
        {
            //Soru
            int SoruSayisi = 20;
            List<string> list = new List<string>();
            List<string> TCNoList = new List<string>();
            List<string> OkulNoList = new List<string>();

            //txt satır satır list listesine ekliyor.
            FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            string[] lines = list.ToArray();
            string ln;

            //tzt satır sayısı
            int Count = lines.Length;

            try
            {
                for (int i = 0; i < Count; i++)
                {
                    int BosSayisi = 0;
                    int Ciftisaret = 0;
                    int SatirSay = (i + 1);

                    ln = lines[i];

                    if (ln == string.Empty)
                    {
                        MainMultiLineTextBox.AppendText(string.Format("{0}. satır boş.\n", SatirSay.ToString()));
                        MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                    }

                    if (ln.Length != 0)
                    {
                        string Ad = ln.Substring(0, 14);
                        string Soyad = ln.Substring(14, 14);
                        string TCNo = ln.Substring(28, 11);
                        string OkulNo = ln.Substring(39, 8);
                        string DersKodu = ln.Substring(47, 3);
                        string OkulKodu = ln.Substring(50, 4);
                        string OkulTur = ln.Substring(54, 1);
                        string Cinsiyet = ln.Substring(55, 1);
                        string CevapTur = ln.Substring(56, 1);
                        string AdayCevapAnahtari = ln.Substring(57, 20);

                        string AdayCevap1 = ln.Substring(57, 1);
                        string AdayCevap2 = ln.Substring(58, 1);
                        string AdayCevap3 = ln.Substring(59, 1);
                        string AdayCevap4 = ln.Substring(60, 1);
                        string AdayCevap5 = ln.Substring(61, 1);
                        string AdayCevap6 = ln.Substring(62, 1);
                        string AdayCevap7 = ln.Substring(63, 1);
                        string AdayCevap8 = ln.Substring(64, 1);
                        string AdayCevap9 = ln.Substring(65, 1);
                        string AdayCevap10 = ln.Substring(66, 1);
                        string AdayCevap11 = ln.Substring(67, 1);
                        string AdayCevap12 = ln.Substring(68, 1);
                        string AdayCevap13 = ln.Substring(69, 1);
                        string AdayCevap14 = ln.Substring(70, 1);
                        string AdayCevap15 = ln.Substring(71, 1);
                        string AdayCevap16 = ln.Substring(72, 1);
                        string AdayCevap17 = ln.Substring(73, 1);
                        string AdayCevap18 = ln.Substring(74, 1);
                        string AdayCevap19 = ln.Substring(75, 1);
                        string AdayCevap20 = ln.Substring(76, 1);

                        string[] Cevap = new string[] { AdayCevap1, AdayCevap2, AdayCevap3, AdayCevap4, AdayCevap5, AdayCevap6, AdayCevap7, AdayCevap8, AdayCevap9, AdayCevap10, AdayCevap11, AdayCevap12, AdayCevap13, AdayCevap14, AdayCevap15, AdayCevap16, AdayCevap17, AdayCevap18, AdayCevap19, AdayCevap20 };

                        int AdayCevapUzunluk = InnerTrim(AdayCevapAnahtari).Length;
                        int TCNoUzunluk = InnerTrim(TCNo).Length;

                        if (TCNo == "           ")
                        {
                            MainMultiLineTextBox.AppendText(SatirSay.ToString() + ".Satır | Ad: " + Ad + " | Soyad: " + Soyad + " " + TCNo + " TC No kodlamamış olabilir!!\n");
                            MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }
                        else if (TCNoUzunluk != 11)
                        {
                            MainMultiLineTextBox.AppendText(SatirSay.ToString() + ".Satır | Ad: " + Ad + " | Soyad: " + Soyad + " " + TCNo + " TC No eksik kodlamış olabilir!!\n");
                            MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }
                        else if (TCNo.IndexOf("*") != -1)
                        {
                            MainMultiLineTextBox.AppendText(SatirSay.ToString() + ".Satır | Ad: " + Ad + " | Soyad: " + Soyad + " " + TCNo + " TC No eksik ve çift kodlama yapılmış olabilir!!\n");
                            MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }


                        if (CevapTur != " ")
                        {
                            MainMultiLineTextBox.AppendText(SatirSay.ToString() + " .Satırda cevap anahtarında kayma olabilir!!\n");
                            MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }

                        if (TCNoList.Contains(TCNo) && OkulNoList.Contains(OkulNo))
                        {
                            MainMultiLineTextBox.AppendText(SatirSay.ToString() + ".Satır | Ad: " + Ad + " | Soyad: " + Soyad + " " + TCNo + " TC No iki sefer okutulmuş olabilir!!\n");
                            MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }

                        TCNoList.Add(TCNo);
                        OkulNoList.Add(OkulNo);

                        for (int a = 0; a < SoruSayisi; a++)
                        {
                            if (Cevap[a] == " ")
                            {
                                BosSayisi += 1;
                            }
                            else if (Cevap[a] == "*")
                            {
                                Ciftisaret += 1;
                            }
                        }
                        string BSayi = BosSayisi.ToString();

                        if (BosSayisi >= 1)
                        {
                            MainMultiLineTextBox.AppendText(SatirSay.ToString() + ". Satır |Ad: " + Ad + " |Soyad: " + Soyad + " |TC No: " + TCNo + " |Öğrenci No: " + OkulNo + " |Cevap: " + AdayCevapAnahtari + " |Cevap Uzunluğu " + AdayCevapUzunluk.ToString() + " |Boş Sayısı: " + BSayi + "| Çift işaretleme " + Ciftisaret.ToString() + "\n"); ;
                            MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }
                        else if (Ciftisaret >= 1)
                        {
                            MainMultiLineTextBox.AppendText(SatirSay.ToString() + ". Satır |Ad: " + Ad + " |Soyad: " + Soyad + " |TC No: " + TCNo + " |Öğrenci No: " + OkulNo + " |Cevap: " + AdayCevapAnahtari + " |Cevap Uzunluğu " + AdayCevapUzunluk.ToString() + " |Boş Sayısı: " + BSayi + "| Çift işaretleme " + Ciftisaret.ToString() + "\n"); ;
                            MainMultiLineTextBox.AppendText("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }
                    }
                }
                MainMultiLineTextBox.AppendText("\nKontrol Tamamlandı! Toplam Satır Sayısı: " + Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTxtSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFile.Filter = "Txt Belgesi|*.txt";

                switch (OpenFile.ShowDialog())
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        MainMultiLineTextBox.Clear();
                        ControlTxt(OpenFile.FileName);
                        break;
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void BtxtToExcel_Click_2(object sender, EventArgs e)
        {
            try
            {
                OpenFile.Filter = "Txt Belgesi|*.txt";

                switch (OpenFile.ShowDialog())
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        ControlTxttoExcel(OpenFile.FileName);
                        break;
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
