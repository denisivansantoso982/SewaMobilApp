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
    public partial class TambahKaryawan : Form
    {
        SqlConnection connection;
        SqlCommand command;

        public TambahKaryawan()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            dateTimePicker.MaxDate = DateTime.Now.Date;
            string[] jk = { "pria", "wanita" };
            comboBoxJK.DataSource = jk;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi kon = new Koneksi();
                connection = new SqlConnection(kon.koneksi);
                connection.Open();

                if (validation())
                {
                    command = new SqlCommand("INSERT INTO Karyawan VALUES(FLOOR(CONCAT(19, FLOOR(RAND()*100000000) + 20)), @nama, @no_telp, @tgl, @jk, @username, @password, 'petugas')", connection);
                    command.Parameters.AddWithValue("@nama", textBoxNama.Text);
                    command.Parameters.AddWithValue("@no_telp", textBoxTelepon.Text);
                    command.Parameters.AddWithValue("@tgl", dateTimePicker.Value);
                    command.Parameters.AddWithValue("@jk", comboBoxJK.SelectedValue);
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } else
                {
                    MessageBox.Show("Form harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                connection.Close();
            } catch ( Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxPassword.Checked )
            {
                textBoxPassword.UseSystemPasswordChar = false;
            } else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char) Keys.Space);
        }

        private void textBoxTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private bool validation()
        {
            if ( textBoxNama.TextLength < 1 )
            {
                return false;
            } else if ( textBoxTelepon.TextLength < 1 )
            {
                return false;
            } else if (dateTimePicker.Value == null)
            {
                return false;
            } else if (comboBoxJK.SelectedValue == null)
            {
                return false;
            } else if (textBoxUsername.TextLength < 1)
            {
                return false;
            } else if (textBoxPassword.TextLength < 1)
            {
                return false;
            }

            return true;
        }
    }
}
