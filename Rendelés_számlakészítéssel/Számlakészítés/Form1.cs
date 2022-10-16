using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;
using Microsoft.Office.Interop.Excel;

namespace Számlakészítés
{
    public partial class Form1 : Form
    {
        private Word.Application word;
        private Excel.Application excel;
        List<Termek> termekek = new List<Termek>();
        List<Tetel> tetelek = new List<Tetel>();
        double fizetendo = 0;
        Termek t;
        string nev, cim;

        public Form1()
        {
            InitializeComponent();
            Beolvas();
            TablabaIr();
            GC.Collect();
        }

        private void TablabaIr() //a form betöltésekor feltöltjük a Termékek táblát
        {
            foreach (Termek t in termekek)
            {
                DataGridViewRow row = (DataGridViewRow)dgvTermekek.Rows[0].Clone();
                row.Cells[0].Value =t.Azonosito;
                row.Cells[1].Value = t.Megnevezes;
                row.Cells[2].Value = t.Kat;
                row.Cells[3].Value = t.Netto + "Ft";
                row.Cells[4].Value = Convert.ToInt32(t.Afa) + "%";

                if (t is gTermek)
                {
                    gTermek gt = t as gTermek;
                    row.Cells[5].Value = gt.Tartam+ "év";
                }
                dgvTermekek.Rows.Add(row);
            }
        }



        private void Beolvas() //a form betöltésekor beolvassuk az adatokat a termekek.txt fájlból
        {
            if (File.Exists("termekek.txt"))
            {
                StreamReader r = new StreamReader("termekek.txt");
                while (!r.EndOfStream)
                {
                    Termek t;
                    gTermek gt;
                    string[] s = r.ReadLine().Split('\t');
                    if (s.Length == 5)
                    {
                        t = new Termek(s[0], s[1], (Kategoria)Enum.Parse(typeof(Kategoria), s[2]), 
                            Convert.ToInt32(s[3]), (Afa)Enum.Parse(typeof(Afa), s[4]));
                        termekek.Add(t);
                    }
                    else
                    {
                        gt = new gTermek(s[0], s[1], (Kategoria)Enum.Parse(typeof(Kategoria), s[2]),
                            Convert.ToInt32(s[3]), (Afa)Enum.Parse(typeof(Afa), s[4]),
                            Convert.ToInt32(s[5]));
                        termekek.Add(gt);
                    }
                }
                r.Close();
            }
        }

        private void dgvTermekek_SelectionChanged(object sender, EventArgs e) 
            //a kiválasztott termék adataival feltöltjük a textboxokat, 
            //és kiszámoljuk a nettó és bruttó éréket
        {
            t = termekek[dgvTermekek.CurrentCell.RowIndex];
            tbNev.Text = t.Megnevezes;
            tbAr.Text = t.Netto.ToString();
            tbAfa.Text = Convert.ToInt32(t.Afa).ToString();
            Ujraszamol();
        }

        private void nudMennyiseg_ValueChanged(object sender, EventArgs e)
        //mennyiség váltás hatására is kiszámoljuk a nettó és bruttó éréket
        {
            Ujraszamol();
        }

        private void Ujraszamol()
        //kiszámoljuk a nettó és bruttó éréket
        {
            double Netto = Convert.ToDouble(tbAr.Text) * Convert.ToDouble(nudMennyiseg.Value);
            tbNetto.Text = Netto.ToString();
            tbBrutto.Text = (Netto *(1 + Convert.ToDouble(tbAfa.Text)/ 100.0)).ToString();
        }

        private void btnRendel_Click(object sender, EventArgs e)
            //a Rendel gomb megnyitja a vevő adatok megadására szolgáló formot
            //elindítja a word-beli exportálást, azaz a számlaképet elkészíti
            //az excel táblát aktualizálja
        {          
            VevoForm vevoForm = new VevoForm();
            vevoForm.ShowDialog();
            if (vevoForm.textBox1.Text != "") nev = vevoForm.textBox1.Text;
            else nev = "No name";
            cim = vevoForm.textBox2.Text;

            ExportToWord(dgvRendeles, nev, cim);

            Osszesit();

            dgvRendeles.Rows.Clear();
            dgvRendeles.Refresh();

            tetelek.Clear();
        }

        private void Osszesit()
            //excel tábla aktualizálása
        {
            if (File.Exists(@"c:\Users\bajaki\Source\Repos\Számlakészítés jó\Számlakészítés\bin\Debug\Rendelesek.xls"))
                //figyeljünk, hogy a megfelelő útvonal legyen megadva
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(@"c:\Users\bajaki\Source\Repos\Számlakészítés jó\Számlakészítés\bin\Debug\Rendelesek.xls");
                object misValue = System.Reflection.Missing.Value;
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                
                UjSorok(xlWorkSheet);
                
                xlWorkBook.Save();
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
                //fel kell szabadítani az excel munkafüzet objektumait, hogy újból megnyitható legyen
            }

            else
            {
                Excel.Application xlApp = new Excel.Application();
                object misValue = System.Reflection.Missing.Value;

                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                //fejlécek, szöveges adatok kitöltése
                xlWorkSheet.Cells[2, 1].EntireRow.Font.Bold = true;
                xlWorkSheet.Cells[3, 1].EntireRow.Font.Bold = true;
                xlWorkSheet.Cells[5, 1].EntireRow.Font.Bold = true;
                xlWorkSheet.Cells[5, 1] = "Vevő neve";
                xlWorkSheet.Cells[5, 2] = "Vevő címe";
                xlWorkSheet.Cells[5, 3] = "Dátum";
                xlWorkSheet.Cells[5, 4] = "Áru neve";
                xlWorkSheet.Cells[5, 5] = "Nettó ár";
                xlWorkSheet.Cells[5, 6] = "Áfa kulcs";
                xlWorkSheet.Cells[5, 7] = "Mennyiség";
                xlWorkSheet.Cells[5, 8] = "Nettó érték";
                xlWorkSheet.Cells[5, 9] = "Bruttó érték";
                

                xlWorkSheet.Cells[2, 1] = "Nettó összesen";
                xlWorkSheet.Cells[3, 1] = "Bruttó összesen";
                

                UjSorok(xlWorkSheet);//a rendelés sorainak hozzáadására szolgáló metódus meghívása

                xlWorkBook.SaveAs(@"c:\Users\bajaki\Source\Repos\Számlakészítés jó\Számlakészítés\bin\Debug\Rendelesek.xls", Excel.XlFileFormat.xlWorkbookNormal,
                    misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive,
                    misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }

        private void UjSorok(Worksheet sheet) //a rendelés sorainak hozzáadására szolgáló metódus
        {
            double net = 0;
            double gross = 0;
            foreach (DataGridViewRow row in dgvRendeles.Rows)
            {
                //adatok feltöltése a táblába
                sheet.Rows["6"].Insert();
                sheet.Cells[6, 1] = nev;
                sheet.Cells[6, 2] = cim;
                sheet.Cells[6, 3] = DateTime.Today.ToShortDateString();
                sheet.Cells[6, 1].EntireRow.Font.Bold = false;
                for (int i = 0; i < 6; i++)
                {
                    sheet.Cells[6, i + 4] = row.Cells[i].Value.ToString();
                    if (i == 4)
                    {
                        string m="",m2;
                        if (!(sheet.Cells[2, 3].Text ==""))
                        {
                            m = ((Microsoft.Office.Interop.Excel.Range)sheet.Cells.Cells[2, 3]).Text;
                            m = m.Remove(m.Length - 2);
                            net = Convert.ToDouble(m);
                        }
                        
                        m2 = ((Microsoft.Office.Interop.Excel.Range)sheet.Cells.Cells[6, 8]).Text;
                        net += Convert.ToDouble(m2.Remove(m2.Length - 2));                      
                        
                        sheet.Cells[2, 3] = net+"Ft";
                    }
                    if (i == 5)
                    {
                        string m = "", m2;
                        if (!(sheet.Cells[3, 3].Text ==""))
                        {
                            m = ((Microsoft.Office.Interop.Excel.Range)sheet.Cells.Cells[3, 3]).Text;
                            m = m.Remove(m.Length - 2);
                            gross = Convert.ToDouble(m);
                        }
                        
                        m2 = ((Microsoft.Office.Interop.Excel.Range)sheet.Cells.Cells[6, 9]).Text;
                        gross += Convert.ToDouble(m2.Remove(m2.Length - 2));

                        sheet.Cells[3, 3]=gross + "Ft";
                    }
                }
            }
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
            //az új tétel hozzáadása a rendeléshez
        {
            if (nudMennyiseg.Value > 0)
            {
                Tetel te = new Tetel(t, Convert.ToDouble(nudMennyiseg.Value));

                dgvRendeles.Rows.Add(te.T.Megnevezes, te.T.Netto + "Ft",
                    Convert.ToInt32(te.T.Afa) + "%", te.Mennyiseg, 
                    te.NE().ToString() + "Ft", te.BE().ToString() + "Ft");

                tetelek.Add(te);

                FizetendoSzamol();

                Torol();
            }
            else
            {
                MessageBox.Show("A mennyiség 0!");
            }
        }

        private void FizetendoSzamol() //a fizetendő összeg újraszámolása tétel hozzáadásakor, módosításakor, törlésekor
        {
            fizetendo = 0;

            foreach (Tetel te in tetelek)
            {
                    fizetendo += te.T.Netto * te.Mennyiseg
                        * (1 + Convert.ToDouble(te.T.Afa) / 100);                                  
            }
            tbFizetendo.Text = fizetendo.ToString();
        }

        private void Torol() //termék adatok törlése textboxokból rendelésután
        {
            tbNev.Text = "";
            nudMennyiseg.Value = 0;
            tbNetto.Text = "";
            tbBrutto.Text = "";
        }

        private void btnTorol_Click(object sender, EventArgs e)
            //tétel törlése a rendelésből
        {
            MessageBox.Show(dgvRendeles.CurrentCell.RowIndex.ToString());
            MessageBox.Show(tetelek[Convert.ToInt32(dgvRendeles.CurrentCell.RowIndex)].ToString()); ;
            tetelek.RemoveAt(dgvRendeles.CurrentCell.RowIndex);
            dgvRendeles.Rows.RemoveAt(dgvRendeles.CurrentCell.RowIndex);
            MessageBox.Show(tetelek.Count.ToString());
            FizetendoSzamol(); //újra kell számolni a fizetendőt
        }
 
        private void btnModosit_Click(object sender, EventArgs e)
            //módosításkor a mennisége változtatására szolgáló vezérlők megjelenése/eltüntetése
        {
            nudUjMennyiseg.Visible = !nudUjMennyiseg.Visible;
            btnOk.Visible = !btnOk.Visible;
        }

        private void btnOk_Click(object sender, EventArgs e)
            //tétel módosításkor a mennyiség változás jóváhagyása
        {
            tetelek[dgvRendeles.CurrentCell.RowIndex].Mennyiseg=
                Convert.ToDouble(nudUjMennyiseg.Value);
            dgvRendeles.CurrentRow.Cells[3].Value= nudUjMennyiseg.Value;
            dgvRendeles.CurrentRow.Cells[4].Value = 
                tetelek[dgvRendeles.CurrentCell.RowIndex].NE().ToString() + "Ft";
            dgvRendeles.CurrentRow.Cells[5].Value = 
                tetelek[dgvRendeles.CurrentCell.RowIndex].BE().ToString() + "Ft";
            nudUjMennyiseg.Value = 0;
            nudUjMennyiseg.Visible = !nudUjMennyiseg.Visible;
            btnOk.Visible = !btnOk.Visible;
            FizetendoSzamol(); //újra kell számolni a fizetendőt
        }

        public void ExportToWord(DataGridView dgv, string nev, string cim)
            //wordbe exportáljuk a számla készítéshez szükséges adatokat
        {
            Word.Application word = null;
            Word.Document doc = null;
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
            try
            {
                word = new Word.Application();
                word.Visible = true;
                doc = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba!");
            }
            finally
            {
            }
            if (word != null && doc != null)
            {
                Word.Selection selection = word.Selection; //https://www.c-sharpcorner.com/forums/ending-a-word-table

                //bekezdésenként külön kell megadni a beállításokat
                Word.Paragraph oPara0;
                oPara0 = doc.Content.Paragraphs.Add(ref oMissing);
                oPara0.Range.Font.Bold = 1;
                oPara0.Range.Font.Size = 16;
                oPara0.Range.Text="Számla";
                oPara0.Range.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oPara0.Format.SpaceAfter = 6;
                oPara0.Range.InsertParagraphAfter();

                Word.Paragraph oPara01;
                oPara01 = doc.Content.Paragraphs.Add(ref oMissing);
                oPara01.Range.Font.Bold = 0;
                oPara01.Range.Font.Size = 12;
                oPara01.Range.Text = DateTime.Now.ToString();
                oPara01.Range.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oPara01.Format.SpaceAfter = 6;
                oPara01.Range.InsertParagraphAfter();

                Word.Paragraph oPara1;
                oPara1 = doc.Content.Paragraphs.Add(ref oMissing);               
                oPara1.Range.Font.Bold = 1;
                oPara1.Range.Font.Size = 12;
                oPara1.Range.Text = "Vevő adatai";
                oPara1.Range.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oPara1.Range.InsertParagraphAfter();

                Word.Paragraph oPara2;
                oPara2 = doc.Content.Paragraphs.Add(ref oMissing);
                oPara2.Range.Font.Bold = 0;
                oPara2.Range.Font.Size = 12;
                oPara2.Range.Text = "A vevő neve: " + nev + "\nA vevő címe: " + cim;
                oPara2.Range.InsertParagraphAfter();

                Word.Paragraph oPara3;
                oPara3 = doc.Content.Paragraphs.Add(ref oMissing);
                oPara3.Range.Font.Bold = 1;
                oPara3.Range.Text="\nTételek: \n";

                Word.Table newTable;
                Word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                newTable = doc.Tables.Add(wrdRng, 1, dgv.Columns.Count , ref oMissing, ref oMissing);
                newTable.AllowAutoFit = true;

                //tételadatok fejléc
                foreach (DataGridViewCell cell in dgv.Rows[0].Cells)
                {
                    newTable.Cell(newTable.Rows.Count, cell.ColumnIndex+1).Range.Text = dgv.Columns[cell.ColumnIndex].HeaderText;
                    
                    newTable.Cell(newTable.Rows.Count, cell.ColumnIndex + 1).Range.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    newTable.Cell(newTable.Rows.Count, 1).Range.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphLeft;

                }

                newTable.Rows.Add();
                newTable.Range.Font.Bold = 0;
                newTable.Rows[1].Range.Font.Bold = 1;
                newTable.Rows[1].Range.Font.Italic = 1;
                newTable.Columns[1].Width = 110;

                //tételadatok feltöltése
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex+1).Range.Text = 
                            cell.Value.ToString();
                        newTable.Cell(newTable.Rows.Count, cell.ColumnIndex + 1).Range.ParagraphFormat.Alignment =
                            Word.WdParagraphAlignment.wdAlignParagraphCenter; 
                        newTable.Cell(newTable.Rows.Count, 1).Range.ParagraphFormat.Alignment =
                            Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    }
                    newTable.Rows.Add();
                }

                Word.Paragraph oPara4;
                object oRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara4 = doc.Content.Paragraphs.Add(ref oRng);
                oPara0.Range.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphRight;
                oPara4.Range.Font.Name = "Times New Roman";
                oPara4.Range.Font.Animation = Word.WdAnimation.wdAnimationBlinkingBackground;
                oPara4.Range.Font.Bold = 1;
                oPara4.Range.Text=("Fizetendő: " + fizetendo + "Ft"); 
            }

        }

        private void összesRendelésToolStripMenuItem_Click(object sender, EventArgs e)
            //összes rendelés gomb hatására megnyitjuk az excelt
        {
            if (File.Exists(@"c:\Users\bajaki\Source\Repos\Számlakészítés jó\Számlakészítés\bin\Debug\Rendelesek.xls"))
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook workb = xlApp.Workbooks.Open(@"c:\Users\bajaki\Source\Repos\Számlakészítés jó\Számlakészítés\bin\Debug\Rendelesek.xls");
                xlApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Nincs megjeleníthető adat!");
            }
        }
    }
}
