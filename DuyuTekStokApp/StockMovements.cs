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

namespace DuyuTekStokApp
{
    public partial class StockMovements : Form
    {
        SqlConnection connect = new SqlConnection(ClassConnect.conn);
        public StockMovements()
        {
            InitializeComponent();
        }
        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, connect);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewStok.DataSource = ds.Tables[0];
        }
        public void VerileriGoster2(string Veriler2)
        {
            
            SqlDataAdapter da2 = new SqlDataAdapter(Veriler2, connect);
            DataSet ds2 = new DataSet();
            try
            {
                da2.Fill(ds2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewMove.DataSource = ds2.Tables[0];
        }
        public void changeHeader()
        {
            dataGridViewStok.Columns[0].HeaderText = "Stok Kodu";
            dataGridViewStok.Columns[1].HeaderText = "Stok Cinsi";
            dataGridViewStok.Columns[2].HeaderText = "Barkod Numarası";
            dataGridViewStok.Columns[3].HeaderText = "Birimi";
            dataGridViewStok.Columns[4].HeaderText = "Grubu";
            dataGridViewStok.Columns[5].HeaderText = "Tarih";
            dataGridViewStok.Columns[6].HeaderText = "Açıklama";
            dataGridViewStok.Columns[7].HeaderText = "Resim";

            dataGridViewMove.Columns[0].HeaderText = "Stok Kodu";
            dataGridViewMove.Columns[1].HeaderText = "Stok Cinsi";
            dataGridViewMove.Columns[2].HeaderText = "Barkod Numarası";
            dataGridViewMove.Columns[3].HeaderText = "Birimi";
            dataGridViewMove.Columns[4].HeaderText = "Grubu";
            dataGridViewMove.Columns[5].HeaderText = "Tarih";
            dataGridViewMove.Columns[6].HeaderText = "Açıklama";
            dataGridViewMove.Columns[7].HeaderText = "Sınıfı";
            dataGridViewMove.Columns[8].HeaderText = "Değişim Tarihi";
            dataGridViewMove.Columns[9].HeaderText = "Adeti";
            dataGridViewMove.Columns[10].HeaderText = "Resim";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockMovements_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockControlDataSet1.Siniflar' table. You can move, or remove it, as needed.
            this.siniflarTableAdapter.Fill(this.stockControlDataSet1.Siniflar);
            // TODO: This line of code loads data into the 'stockControlDataSet1.Siniflar' table. You can move, or remove it, as needed.
            //this.siniflarTableAdapter1.Fill(this.stockControlDataSet1.Siniflar);
            // TODO: This line of code loads data into the 'stockControlDataSet.Siniflar' table. You can move, or remove it, as needed.
            //this.siniflarTableAdapter.Fill(this.stockControlDataSet.Siniflar);
            VerileriGoster("SELECT StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokTarih, StokAciklama, StokResim FROM StockCard ORDER BY StokKodu ASC");


            VerileriGoster2("SELECT StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokTarih, StokAciklama, StokSinif, StokSonTarih, StokAdet, StokResim FROM StockCard ORDER BY StokKodu ASC");
            changeHeader();
        }

        private void dataGridViewMove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewMove.SelectedCells[0].RowIndex;
            textBoxKod.Text = dataGridViewMove.Rows[secilen].Cells[0].Value?.ToString();
            textBoxCins.Text = dataGridViewMove.Rows[secilen].Cells[1].Value.ToString();
            textBoxBarkod.Text = dataGridViewMove.Rows[secilen].Cells[2].Value.ToString();
            textBoxBirim.Text = dataGridViewMove.Rows[secilen].Cells[3].Value.ToString();
            textBoxGrup.Text = dataGridViewMove.Rows[secilen].Cells[4].Value.ToString();
            dateTimeTarih.Text = dataGridViewMove.Rows[secilen].Cells[5].Value.ToString();
            richTextAciklama.Text = dataGridViewMove.Rows[secilen].Cells[6].Value.ToString();
            comboBoxSinif.Text = dataGridViewMove.Rows[secilen].Cells[7].Value.ToString();
            dateTimePickerGuncel.Text = dataGridViewMove.Rows[secilen].Cells[8].Value.ToString();
            textBoxMevcut.Text = dataGridViewMove.Rows[secilen].Cells[9].Value.ToString();
            byte[] bytes = (byte[])dataGridViewMove.Rows[secilen].Cells[10].Value;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBoxResim.Image = Image.FromStream(ms);
        }

        private void listBoxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxKod.Text == string.Empty && textBoxBarkod.Text == string.Empty && textBoxAdetS.Text == string.Empty && dateTimePickerGuncel.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen bir ürün seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE StokCard SET StokSinif='" + comboBoxSinif.Text + "', StokSonTarih='" + dateTimePickerGuncel.Text + "', StokAdet='" + textBoxAdetS.Text + "' WHERE StokKodu='" + textBoxKod.Text + "' ", connect);
                    cmd.ExecuteNonQuery();
                    VerileriGoster2("SELECT StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokTarih, StokAciklama, StokSinif, StokSonTarih, StokAdet, StokResim FROM StockCard ORDER BY StokKodu ASC");
                    connect.Close();
                    MessageBox.Show("Stok bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewStok.SelectedCells[0].RowIndex;
            textBoxKod.Text = dataGridViewStok.Rows[secilen].Cells[0].Value?.ToString();
            textBoxCins.Text = dataGridViewStok.Rows[secilen].Cells[1].Value.ToString();
            textBoxBarkod.Text = dataGridViewStok.Rows[secilen].Cells[2].Value.ToString();
            textBoxBirim.Text = dataGridViewStok.Rows[secilen].Cells[3].Value.ToString();
            textBoxGrup.Text = dataGridViewStok.Rows[secilen].Cells[4].Value.ToString();
            dateTimeTarih.Text = dataGridViewStok.Rows[secilen].Cells[5].Value.ToString();
            richTextAciklama.Text = dataGridViewStok.Rows[secilen].Cells[6].Value.ToString();
            byte[] bytes = (byte[])dataGridViewStok.Rows[secilen].Cells[7].Value;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBoxResim.Image = Image.FromStream(ms);
        }

        private void textBoxAdetS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxMevcut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
