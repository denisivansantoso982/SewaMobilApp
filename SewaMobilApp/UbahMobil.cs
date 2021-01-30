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
using System.IO;

namespace SewaMobilApp
{
    public partial class UbahMobil : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string imageUrl;

        public UbahMobil()
        {
            InitializeComponent();
        }

        private void UbahMobil_Load(object sender, EventArgs e)
        {
            numericHarga.Maximum = 100000000;
            numericTahun.Maximum = DateTime.Now.Year;
            loadData();
        }

        private void loadData()
        {
            string[] dataKelas = { "Sedan", "Minivan", "Hatchback", "SUV", "Sport", "MPV", "Pick-Up", "Bus", "Minibus" };
            CBKelas.DataSource = dataKelas;

            TxtNoPol.Text = Mobil.no_pol;
            TxtMerk.Text = Mobil.merk;
            TxtModel.Text = Mobil.model;
            CBKelas.SelectedItem = Mobil.kelas;
            numericTahun.Value = Mobil.tahun_buat;
            numericHarga.Value = Mobil.harga;

            MemoryStream memoryStream = new MemoryStream(Mobil.gambar);
            pictureBox.Image = Image.FromStream(memoryStream);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(imageUrl);
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationForm())
                {
                    Image image = pictureBox.Image;
                    byte[] foto;
                    ImageConverter imageConverter = new ImageConverter();
                    foto = (byte[]) imageConverter.ConvertTo(image, typeof(byte[]));

                    Koneksi kon = new Koneksi();
                    connection = new SqlConnection(kon.koneksi);

                    connection.Open();

                    command = new SqlCommand("UPDATE Mobil SET Merk=@merk, Model=@model, Thn_Buat=@tahun_buat, Kelas=@kelas, Harga=@harga, Gambar=@foto WHERE No_Pol = @nopol", connection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nopol", TxtNoPol.Text);
                    command.Parameters.AddWithValue("@merk", TxtMerk.Text);
                    command.Parameters.AddWithValue("@model", TxtModel.Text);
                    command.Parameters.AddWithValue("@tahun_buat", numericTahun.Value);
                    command.Parameters.AddWithValue("@kelas", CBKelas.SelectedItem);
                    command.Parameters.AddWithValue("@harga", numericHarga.Value);
                    command.Parameters.AddWithValue("@foto", foto);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Diubah!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();

                    this.Close();
                } else
                {
                    MessageBox.Show("Isi form terlebih dahulu!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private bool ValidationForm()
        {
            if ( TxtNoPol.Text == "" )
            {
                TxtNoPol.Focus();
                return false;
            }
            else if ( TxtMerk.Text == "" )
            {
                TxtMerk.Focus();
                return false;
            }
            else if ( TxtModel.Text == "" )
            {
                TxtModel.Focus();
                return false;
            }
            else if ( numericTahun.Value == 0 )
            {
                numericTahun.Focus();
                return false;
            }
            else if ( CBKelas.SelectedValue == null )
            {
                CBKelas.Focus();
                return false;
            }
            else if ( numericHarga.Value == 0 )
            {
                numericHarga.Focus();
                return false;
            }
            else if ( pictureBox.Image == null )
            {
                return false;
            }

            return true;
        }
    }
}
