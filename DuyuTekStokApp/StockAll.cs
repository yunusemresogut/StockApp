using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace DuyuTekStokApp
{
    public partial class StockAll : Form
    {
        SqlConnection connect = new SqlConnection(ClassConnect.conn);
        public StockAll()
        {
            InitializeComponent();

        }
        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewAll.DataSource = ds.Tables[0];
        }
        public void changeHeader()
        {
            dataGridViewAll.Columns[0].HeaderText = "Stok Kodu";
            dataGridViewAll.Columns[1].HeaderText = "Stok Cinsi";
            dataGridViewAll.Columns[2].HeaderText = "Barkod Numarası";
            dataGridViewAll.Columns[3].HeaderText = "Birimi";
            dataGridViewAll.Columns[4].HeaderText = "Grubu";
            dataGridViewAll.Columns[5].HeaderText = "Tarih";
            dataGridViewAll.Columns[6].HeaderText = "Açıklama";
            dataGridViewAll.Columns[7].HeaderText = "Sınıfı";
            dataGridViewAll.Columns[8].HeaderText = "Değişim Tarihi";
            dataGridViewAll.Columns[9].HeaderText = "Adeti";
            dataGridViewAll.Columns[10].HeaderText = "Kritik Miktar";
            dataGridViewAll.Columns[11].HeaderText = "Resim";
        }
        
        private void StockAll_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*), SUM(StokAdet) FROM StockCard", connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                labelToplam.Text = dr[0].ToString();
                labelGenel.Text = dr[1].ToString();
            }
            connect.Close();

            VerileriGoster("SELECT StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokTarih, StokAciklama, StokSinif, StokSonTarih, StokAdet, StokKritik, StokResim FROM StockCard ORDER BY StokKodu ASC");
            changeHeader();
        }

        private void dataGridViewAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewAll.SelectedCells[0].RowIndex;
            labelUrun.Text = dataGridViewAll.Rows[secilen].Cells[9].Value?.ToString();
            labelKrit.Text = dataGridViewAll.Rows[secilen].Cells[10].Value.ToString();
            byte[] bytes = (byte[])dataGridViewAll.Rows[secilen].Cells[11].Value;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBoxResim.Image = Image.FromStream(ms);
        }

        /*
        public void ExportToExcel(DataTable tbl)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                var workbook = excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                try
                {
                    var saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = "StokBilgisi";
                    saveFileDialog.DefaultExt = ".xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    }
                    excelApp.Quit();
                    Console.WriteLine("Excel file saved!");
                }
                catch (Exception ex)
                {
                    throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                    + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ExportToExcel: \n" + ex.Message);
            }
        }
        */


        private void btnExcel_Click(object sender, EventArgs e)
        {
            /*
            DataTable table = (DataTable)dataGridViewAll.DataSource;
            ExportToExcel(table);
            */

            
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "StokBilgisi";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage pck = new ExcelPackage(new FileInfo(saveFileDialog.FileName)))
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("StokBilgisi");
                    ws.Cells["A1"].LoadFromDataTable(dataGridViewAll.DataSource as DataTable, true);
                    pck.Save();
                }
            }
            


            /*
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Stok Bilgisi";

            for (int i = 1; i < dataGridViewAll.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dataGridViewAll.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridViewAll.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewAll.Columns.Count; i++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewAll.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "StokBilgisi";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
            */

            /*
            if (dataGridViewAll.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i<dataGridViewAll.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridViewAll.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i<dataGridViewAll.Rows.Count; i++)
                {
                    for (int j = 0; j<dataGridViewAll.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridViewAll.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
            */
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "your header text";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridViewAll, sfd.FileName);
            }
        }
    }
}
