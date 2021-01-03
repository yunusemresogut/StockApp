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
    public partial class MainPage : Form
    {
        //SqlConnection connect = new SqlConnection(ClassConnect.conn);
        public MainPage()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelOne.Visible = false;
            panelTwo.Visible = false;
            panelThree.Visible = false;
            panelFour.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelOne.Visible == true)
                panelOne.Visible = false;
            if (panelTwo.Visible == true)
                panelTwo.Visible = false;
            if (panelThree.Visible == true)
                panelThree.Visible = false;
            if (panelFour.Visible == true)
                panelFour.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOne);
        }

        private void btnStokKart_Click(object sender, EventArgs e)
        {
            openChildForm(new StockCard());
            //code

            hideSubMenu();
        }

        private void btnStokTum_Click(object sender, EventArgs e)
        {
            openChildForm(new StockAll());
            //code

            hideSubMenu();
        }

        private void btnStokHarek_Click(object sender, EventArgs e)
        {
            openChildForm(new StockMovements());
            //code

            hideSubMenu();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTwo);
        }

        private void btnYonet_Click(object sender, EventArgs e)
        {
            openChildForm(new LoginControl());
            //code

            hideSubMenu();
        }

        private void btnEk_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThree);
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
            //code

            hideSubMenu();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel");
            //code

            hideSubMenu();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword");
            //code

            hideSubMenu();
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFour);
        }

        private void btnTanim_Click(object sender, EventArgs e)
        {
            //code

            hideSubMenu();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            //code

            hideSubMenu();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            /*
            if (bunifuiOSSwitch1.Value==true)
            {
                this.BackColor = Color.FromArgb(11, 7, 17);
            }
            else
            {
                this.BackColor = Color.White;
            }
            */
        }

        private void btnSinif_Click(object sender, EventArgs e)
        {
            openChildForm(new ClassDefinition());
            hideSubMenu();
        }
    }
}
