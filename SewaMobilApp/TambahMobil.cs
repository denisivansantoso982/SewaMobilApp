using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SewaMobilApp
{
    public partial class TambahMobil : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string imageUrl;

        public TambahMobil()
        {
            InitializeComponent();
        }

        private void TambahMobil_Load(object sender, EventArgs e)
        {
            MuatKelas();
            NumericTahun.Maximum = DateTime.Now.Year;
            NumericHarga.Maximum = 1000000000;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            using ( OpenFileDialog openFileDialog = new OpenFileDialog() )
            {
                if ( openFileDialog.ShowDialog() == DialogResult.OK )
                {
                    imageUrl = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(imageUrl);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if ( ValidationForm() )
                {
                    Koneksi kon = new Koneksi();
                    connection = new SqlConnection(kon.koneksi);
                    connection.Open();
                    Image image = pictureBox.Image;
                    byte[] arr;
                    ImageConverter convert = new ImageConverter();
                    arr = (byte[]) convert.ConvertTo(image, typeof(byte[]));

                    cmd = new SqlCommand("INSERT INTO Mobil VALUES (@No_Pol, @Merk, @Model, @Thn_Buat, @Status_Mobil, @Kelas, @Harga, @Gambar)", connection);
                    cmd.Parameters.AddWithValue("@No_Pol", TxtNoPol.Text);
                    cmd.Parameters.AddWithValue("@Merk", TxtMerk.Text);
                    cmd.Parameters.AddWithValue("@Model", TxtModel.Text);
                    cmd.Parameters.AddWithValue("@Thn_Buat", NumericTahun.Value);
                    cmd.Parameters.AddWithValue("@Status_Mobil", "Bebas");
                    cmd.Parameters.AddWithValue("@Kelas", CBKelas.SelectedValue);
                    cmd.Parameters.AddWithValue("@Harga", NumericHarga.Value);
                    cmd.Parameters.AddWithValue("@Gambar", arr);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Gudang gudang = new Gudang();
                    gudang.loadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Isi form terlebih dahulu!");
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Methods
        private void MuatKelas()
        {
            string[] kelas = { "Sedan", "Minivan", "Hatchback", "SUV", "Sport", "MPV", "Pick-Up", "Bus", "Minibus" };
            CBKelas.DataSource = kelas;
        }

        private bool ValidationForm()
        {
            if (TxtNoPol.Text == "" )
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
            else if ( NumericTahun.Value == 0 )
            {
                NumericTahun.Focus();
                return false;
            }
            else if ( CBKelas.SelectedValue == null )
            {
                CBKelas.Focus();
                return false;
            }
            else if ( NumericHarga.Value == 0 )
            {
                NumericHarga.Focus();
                return false;
            }
            else if ( pictureBox.Image == null )
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}
