using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuyuTekStokApp
{
    public partial class ClassDefinition : Form
    {
        SqlConnection connect = new SqlConnection(ClassConnect.conn);
        public ClassDefinition()
        {
            InitializeComponent();
        }

        private void listBoxBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ClassConnect.conn);
            connect.Open();
            string sorgu = "SELECT SinifAdi from Siniflar WHERE SinifAdi='" + listBoxSinif.Text + "' ";
            SqlCommand cmd = new SqlCommand(sorgu, connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string birimAdi = dr.GetString(0);

                textBoxSinif.Text = birimAdi;
            }
            connect.Close();
        }

        private void ClassDefinition_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            connect.Open();
            {
                using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT SinifID, SinifAdi FROM Siniflar", connect))
                    da.Fill(table);
            }
            listBoxSinif.DataSource = new BindingSource(table, null);
            listBoxSinif.DisplayMember = "SinifAdi";
            listBoxSinif.ValueMember = "SinifID";
            connect.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Siniflar(SinifAdi) VALUES(@SAdi)", connect);
                cmd.Parameters.AddWithValue("@SAdi", textBoxSinif.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Sınıf eklendi.", "Bilgi");
                retrieve();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen boş alanı doldurunuz.", "Uyarı");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Siniflar SET SinifAdi='" + textBoxSinif.Text + "' WHERE SinifID='" + listBoxSinif.SelectedValue + "'", connect);
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Sınıf güncellendi.", "Bilgi");
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }

        public void retrieve()
        {
            listBoxSinif.DataSource = null;
            listBoxSinif.Items.Clear();
            string sql = "SELECT * FROM Siniflar";
            SqlCommand cmd = new SqlCommand(sql, connect);
            try
            {
                connect.Open();
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    listBoxSinif.Items.Add(row[1].ToString());
                }

                connect.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Sınıfı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Siniflar WHERE SinifID=@ID", connect);
                    cmd.Parameters.AddWithValue("@ID", listBoxSinif.SelectedValue);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Sınıf silindi.", "Bilgi");
                    retrieve();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
            else if(secenek == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi");
            }
                
        }
    }
}
