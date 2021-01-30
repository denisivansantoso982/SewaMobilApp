using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace SewaMobilApp
{
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection connect;
        SqlDataReader sdr;

        public Login()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBox.Checked )
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi kon = new Koneksi();
                connect = new SqlConnection(kon.koneksi);
                connect.Open();
                if ( textBoxPassword.Text == "" || textBoxUsername.Text == "" )
                {
                    MessageBox.Show("Form Harus di Isi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM Karyawan WHERE Username= '" + textBoxUsername.Text +  "' AND Password= '" + textBoxPassword.Text + "'", connect);
                    sdr = cmd.ExecuteReader();
                    sdr.Read();
                    if ( sdr.HasRows )
                    {
                        Karyawan.Id_Karyawan = Convert.ToInt32(sdr["Id_Karyawan"]);
                        Karyawan.Nama = sdr["Nama"].ToString();
                        Karyawan.No_Telp = sdr["No_Telp"].ToString();
                        Karyawan.Tgl_Lahir = Convert.ToDateTime(sdr["Tgl_lahir"]);
                        Karyawan.Jk = sdr["Jk"].ToString();
                        Karyawan.Username = sdr["Username"].ToString();
                        Karyawan.Password = sdr["Password"].ToString();
                        Karyawan.Posisi = sdr["Posisi"].ToString();

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Gagal! Coba Lagi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char)Keys.Enter )
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char) Keys.Enter )
            {
                btnLogin_Click(sender, null);
            }
        }
    }
}
