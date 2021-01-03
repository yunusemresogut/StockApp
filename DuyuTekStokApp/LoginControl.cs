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
    public partial class LoginControl : Form
    {
        SqlConnection connect = new SqlConnection(ClassConnect.conn);
        public LoginControl()
        {
            InitializeComponent();
            textBoxPW.PasswordChar = '•';
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand cmd = new SqlCommand("SELECT AdminName,AdminPassword FROM Admin WHERE AdminName=@ID and AdminPassword=@PW", connect);
            cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
            cmd.Parameters.AddWithValue("@PW", textBoxPW.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //openChildForm(new AdminPanel());
                AdminPanel form = new AdminPanel();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola girdiniz!");
                textBoxID.Clear();
                textBoxPW.Clear();
                textBoxID.Focus();
            }
            connect.Close();
        }
    }
}
