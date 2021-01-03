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
    public partial class StockCard : Form
    {
        //SqlConnection connect = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|StockControl.mdf; Integrated Security = True");
        SqlConnection connect = new SqlConnection(ClassConnect.conn);
        string imageUrl = null;
        public StockCard()
        {
            InitializeComponent();
            this.ActiveControl = textBoxKod;
            textBoxKod.Focus();
        }

        public void changeHeader()
        {
            dataGridViewStok.Columns[0].HeaderText = "Stok Kodu";
            dataGridViewStok.Columns[1].HeaderText = "Stok Cinsi";
            dataGridViewStok.Columns[2].HeaderText = "Barkod Numarası";
            dataGridViewStok.Columns[3].HeaderText = "Birimi";
            dataGridViewStok.Columns[4].HeaderText = "Grubu";
            dataGridViewStok.Columns[5].HeaderText = "Kritik Miktar";
            dataGridViewStok.Columns[6].HeaderText = "Tarih";
            dataGridViewStok.Columns[7].HeaderText = "Açıklama";
            dataGridViewStok.Columns[8].HeaderText = "Resim";
        }

        bool status;
        bool status2;
        public void sameData()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT StokKodu FROM StockCard WHERE StokKodu=@SKod", connect);
            cmd.Parameters.AddWithValue("@SKod", textBoxKod.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                status = false;
            }
            else
            {
                status = true;
            }
            connect.Close();
        }
        public void sameData2()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT StokBarkod FROM StockCard WHERE StokBarkod=@SBarkod", connect);
            cmd.Parameters.AddWithValue("@SBarkod", textBoxBarkod.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                status2 = false;
            }
            else
            {
                status2 = true;
            }
            connect.Close();
        }
        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewStok.DataSource = ds.Tables[0];
        }
        private void StockCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockControlDataSet1.Gruplar' table. You can move, or remove it, as needed.
            this.gruplarTableAdapter.Fill(this.stockControlDataSet1.Gruplar);
            // TODO: This line of code loads data into the 'stockControlDataSet1.Birimler' table. You can move, or remove it, as needed.
            this.birimlerTableAdapter.Fill(this.stockControlDataSet1.Birimler);
            // TODO: This line of code loads data into the 'stockControlDataSet1.Gruplar' table. You can move, or remove it, as needed.
            //this.gruplarTableAdapter1.Fill(this.stockControlDataSet1.Gruplar);
            // TODO: This line of code loads data into the 'stockControlDataSet1.Birimler' table. You can move, or remove it, as needed.
            //this.birimlerTableAdapter1.Fill(this.stockControlDataSet1.Birimler);
            // TODO: This line of code loads data into the 'stockControlDataSet.Gruplar' table. You can move, or remove it, as needed.
            //this.gruplarTableAdapter.Fill(this.stockControlDataSet.Gruplar);
            // TODO: This line of code loads data into the 'stockControlDataSet.Birimler' table. You can move, or remove it, as needed.
            //this.birimlerTableAdapter.Fill(this.stockControlDataSet.Birimler);
            // TODO: This line of code loads data into the 'stockControlDataSet.StockCard' table. You can move, or remove it, as needed.
            //this.stockCardTableAdapter.Fill(this.stockControlDataSet.StockCard);
            VerileriGoster("SELECT StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokKritik, StokTarih, StokAciklama, StokResim FROM StockCard ORDER BY StokKodu ASC");
            changeHeader();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sameData();
            sameData2();
            Image img = pictureBoxResim.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            if (status == true && status2 == true)
            {
                try
                {
                    if (textBoxKod.Text == string.Empty && textBoxCins.Text == string.Empty && textBoxBarkod.Text == string.Empty)
                    {
                        MessageBox.Show("Stok Kodu, Stok Cinsi ve Barkod Numarası boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT StokKodu FROM StockCard WHERE StokKodu='" + textBoxKod + "' ", connect);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        connect.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO StockCard(StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokKritik, StokTarih, StokAciklama, StokResim) " +
                            "VALUES(@SKod,@SCins, @SBarkod, @SBirim, @SGrup, @SKritik, @STarih, @SAciklama, @SResim) ", connect);
                        cmd.Parameters.AddWithValue("@SKod", textBoxKod.Text);
                        cmd.Parameters.AddWithValue("@SCins", textBoxCins.Text);
                        cmd.Parameters.AddWithValue("@SBarkod", textBoxBarkod.Text);
                        cmd.Parameters.AddWithValue("@SBirim", comboBoxBirim.Text);
                        cmd.Parameters.AddWithValue("@SGrup", comboBoxGrup.Text);
                        cmd.Parameters.AddWithValue("@SKritik", maskedTextBoxKrit.Text);
                        cmd.Parameters.AddWithValue("@STarih", dateTimeTarih.Text);
                        cmd.Parameters.AddWithValue("@SAciklama", richTextAciklama.Text);
                        cmd.Parameters.AddWithValue("@SResim", arr);
                        int sonuc = cmd.ExecuteNonQuery();

                        /*
                        if (sonuc == -1)
                        {
                            MessageBox.Show("Bu ürün daha önce stoklarımıza eklenmiştir. Aynı ürünü birden fazla kez ekleyemezsiniz.", "Hata");
                        }
                        else
                        {
                            MessageBox.Show("Yeni stok bilgisi eklendi.", "Bilgi");
                        }
                        */

                        VerileriGoster("SELECT StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokKritik, StokTarih, StokAciklama, StokResim FROM StockCard ORDER BY StokKodu ASC");
                        connect.Close();
                        MessageBox.Show("Yeni stok bilgisi eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
 
            }
            else
            {
                MessageBox.Show("Bu ürün daha önce stoklarımıza eklenmiştir. Aynı ürünü birden fazla kez ekleyemezsiniz. \n\n(Stok Kodu ve Barkod Numarası dikkate alınır.)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                textBoxKod.Clear();
                textBoxCins.Clear();
                textBoxBarkod.Clear();
                comboBoxBirim.Text = null;
                comboBoxGrup.Text = null;
                maskedTextBoxKrit.Clear();
                dateTimeTarih.Text = null;
                richTextAciklama.Clear();
                pictureBoxResim.Image = null;
                textBoxKod.Focus();
        }

        private void dataGridViewStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewStok.SelectedCells[0].RowIndex;
            textBoxKod.Text = dataGridViewStok.Rows[secilen].Cells[0].Value?.ToString();
            textBoxCins.Text = dataGridViewStok.Rows[secilen].Cells[1].Value.ToString();
            textBoxBarkod.Text = dataGridViewStok.Rows[secilen].Cells[2].Value.ToString();
            comboBoxBirim.Text = dataGridViewStok.Rows[secilen].Cells[3].Value.ToString();
            comboBoxGrup.Text = dataGridViewStok.Rows[secilen].Cells[4].Value.ToString();
            maskedTextBoxKrit.Text = dataGridViewStok.Rows[secilen].Cells[5].Value.ToString();
            dateTimeTarih.Text = dataGridViewStok.Rows[secilen].Cells[6].Value.ToString();
            richTextAciklama.Text = dataGridViewStok.Rows[secilen].Cells[7].Value.ToString();
            byte[] bytes = (byte[])dataGridViewStok.Rows[secilen].Cells[8].Value;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBoxResim.Image = Image.FromStream(ms);
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pictureBoxResim.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void listBoxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxKod.Text == string.Empty && textBoxBarkod.Text == string.Empty && textBoxCins.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen bir ürün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult secenek = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (secenek == DialogResult.Yes)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM StockCard WHERE StokKodu=@SKod", connect);
                        cmd.Parameters.AddWithValue("@SKod", textBoxKod.Text);
                        cmd.ExecuteNonQuery();
                        VerileriGoster("SELECT StokKodu, StokCinsi, StokBarkod, StokBirim, StokGrup, StokKritik, StokTarih, StokAciklama, StokResim FROM StockCard ORDER BY StokKodu ASC");
                        connect.Close();
                        MessageBox.Show("Stok silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxKod.Clear();
                        textBoxCins.Clear();
                        textBoxBarkod.Clear();
                        comboBoxBirim.Text = null;
                        comboBoxGrup.Text = null;
                        maskedTextBoxKrit.Clear();
                        dateTimeTarih.Text = null;
                        richTextAciklama.Text = null;
                        pictureBoxResim.Image = null;
                        textBoxKod.Focus();
                    }
                    else if (secenek == DialogResult.No)
                    {
                        MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDuzen_Click(object sender, EventArgs e)
        {

        }

        private void panelStok_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxKod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxCins.Focus();
            }
        }

        private void textBoxCins_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxBarkod.Focus();
            }
        }

        private void textBoxBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxBirim.Focus();
            }
        }

        private void comboBoxBirim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxGrup.Focus();
            }
        }

        private void comboBoxGrup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBoxKrit.Focus();
            }
        }

        private void dateTimeTarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextAciklama.Focus();
            }
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBoxKrit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimeTarih.Focus();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sorgu = "SELECT * FROM StockCard WHERE StokCinsi Like '" + textBoxCins.Text + "%'";
            SqlDataAdapter dp = new SqlDataAdapter(sorgu, connect);
            DataSet ds = new DataSet();
            dp.Fill(ds, "StockCard");
            this.dataGridViewStok.DataSource = ds.Tables[0];
            connect.Close();
        }
    }
}


