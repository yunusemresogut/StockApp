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
    public partial class AdminPanel : Form
    {
        SqlConnection connect = new SqlConnection(ClassConnect.conn);
        public AdminPanel()
        {
            InitializeComponent();
        }
        public void changeHeader()
        {
            dataGridViewAdmin.Columns[0].HeaderText = "Kullanıcı Adı";
            dataGridViewAdmin.Columns[1].HeaderText = "Şifre";
        }

        bool status;
        public void sameData()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT AdminName FROM Admin WHERE AdminName=@ID", connect);
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
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
        public void VerileriGoster(string Veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(Veriler, connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewAdmin.DataSource = ds.Tables[0];
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            VerileriGoster("SELECT AdminName, AdminPassword FROM Admin ORDER BY AdminName");
            changeHeader();
        }

        private void groupBoxAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewAdmin.SelectedCells[0].RowIndex;
            textBoxID.Text = dataGridViewAdmin.Rows[secilen].Cells[0].Value.ToString();
            textBoxPW.Text = dataGridViewAdmin.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sameData();
            if (status == true)
            {
                try
                {
                    if (textBoxID.Text == string.Empty && textBoxPW.Text == string.Empty)
                    {
                        MessageBox.Show("Kullanıcı Adı ve Şifre boş geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Admin(AdminName, AdminPassword) VALUES(@Name,@Password) ", connect);
                        cmd.Parameters.AddWithValue("@Name", textBoxID.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxPW.Text);
                        cmd.ExecuteNonQuery();
                        VerileriGoster("SELECT AdminName, AdminPassword FROM Admin ORDER BY AdminName");
                        connect.Close();
                        MessageBox.Show("Yeni kullanıcı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Aynı isimle yeni bir kullanıcı oluşturamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            textBoxID.Clear();
            textBoxPW.Clear();
            textBoxID.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // En az bir yönetici kaydı olduğunda bu işlemi gerçekleştirme fonksiyonu eklenecek
            try
            {
                if (textBoxID.Text == string.Empty && textBoxPW.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen bir kullanıcı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult secenek = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (secenek == DialogResult.Yes)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Admin WHERE AdminName=@Name", connect);
                        cmd.Parameters.AddWithValue("@Name", textBoxID.Text);
                        cmd.ExecuteNonQuery();
                        VerileriGoster("SELECT AdminName, AdminPassword FROM Admin ORDER BY AdminName");
                        connect.Close();
                        MessageBox.Show("Kullanıcı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Clear();
                        textBoxPW.Clear();
                        textBoxID.Focus();
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
