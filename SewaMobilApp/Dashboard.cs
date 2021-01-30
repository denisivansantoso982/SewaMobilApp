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

namespace SewaMobilApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            timer.Start();
            muatAwal();
        }

        private void muatAwal()
        {
            menuGudang.Hide();
            menuKaryawan.Hide();
            menuUser.Show();

            if ( Karyawan.Posisi == "owner" || Karyawan.Posisi == "Owner" )
            {
                btnKaryawan.Visible = true;
                btnKaryawan.Enabled = true;
            }
            else
            {
                btnKaryawan.Visible = false;
                btnKaryawan.Enabled = false;
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {

        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {

        }

        public void btnGudang_Click(object sender, EventArgs e)
        {
            label1.Text = "Gudang";
            menuGudang.Show();
            menuUser.Hide();
            menuKaryawan.Hide();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {

        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            label1.Text = "Karyawan";
            menuKaryawan.Show();
            menuGudang.Hide();
            menuUser.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (msg == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
                timer.Stop();
            } 
            else if (msg == DialogResult.No)
            {

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            label1.Text = "Dashboard";
            menuUser.Show();
            menuKaryawan.Hide();
            menuGudang.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy   hh:mm:ss tt");
        }
    }
}
