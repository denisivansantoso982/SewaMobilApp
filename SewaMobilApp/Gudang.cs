using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SewaMobilApp
{
    public partial class Gudang : UserControl
    {
        SqlConnection connect;
        SqlDataReader sdr;
        DataTable dt;
        SqlCommand cmd;
        SqlDataAdapter sda;
        string nopol;

        public Gudang()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            try
            {
                Koneksi kon = new Koneksi();
                connect = new SqlConnection(kon.koneksi);
                cmd = new SqlCommand("SELECT No_Pol, Merk, Model, Thn_Buat, Status_Mobil, Kelas, Harga, Gambar FROM Mobil", connect);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridGudang.DataSource = dt;
                dataGridGudang.Columns[0].HeaderText = "No. Polisi";
                dataGridGudang.Columns[3].HeaderText = "Tahun Buat";
                dataGridGudang.Columns[4].HeaderText = "Status";

                dataGridGudang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridGudang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridGudang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridGudang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridGudang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridGudang.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dataGridGudang.Columns[6].Visible = false;
                dataGridGudang.Columns[7].Visible = false;

                btnUbah.Visible = false;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridGudang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridGudang.Rows[e.RowIndex];
                labelHarga.Text = selectedRow.Cells[6].Value.ToString();
                var value = dataGridGudang.SelectedRows[0].Cells["Gambar"].Value;
                nopol = Convert.ToString(selectedRow.Cells[0].Value);
                btnUbah.Visible = true;
                if ( value != DBNull.Value )
                {
                    byte[] foto = (byte[]) value;
                    MemoryStream stream = new MemoryStream(foto);
                    pictureBox.Image = Image.FromStream(stream);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TambahMobil tambahMobil = new TambahMobil();
            tambahMobil.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Konfirmasi", "Apakah anda yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( dialogResult == DialogResult.Yes )
                {
                    Koneksi koneksi = new Koneksi();
                    connect = new SqlConnection(koneksi.koneksi);
                    SqlCommand command = new SqlCommand("DELETE FROM Mobil WHERE No_Pol = @nopol", connect);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nopol", nopol);

                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();

                    loadData();
                } else if (dialogResult == DialogResult.Cancel)
                {}
            } catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi kon = new Koneksi();
                connect = new SqlConnection(kon.koneksi);

                connect.Open();

                cmd = new SqlCommand("SELECT * FROM Mobil WHERE No_Pol = '" + nopol + "'", connect);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                if ( sdr.HasRows )
                {
                    Mobil.no_pol = sdr["No_Pol"].ToString();
                    Mobil.merk = sdr["Merk"].ToString();
                    Mobil.model = sdr["Model"].ToString();
                    Mobil.tahun_buat = Convert.ToInt32(sdr["Thn_Buat"]);
                    Mobil.status_mobil = sdr["Status_Mobil"].ToString();
                    Mobil.kelas = sdr["Kelas"].ToString();
                    Mobil.harga = Convert.ToInt32(sdr["Harga"]);
                    Mobil.gambar = (byte[]) sdr["Gambar"];

                    UbahMobil ubahMobil = new UbahMobil();
                    ubahMobil.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Terjadi Kesalahan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                connect.Close();
            }
            catch ( Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadData();
                DataView dataView = new DataView(dt);
                dataView.RowFilter = String.Format("No_Pol LIKE '%{0}%' OR Merk LIKE '%{0}%' OR Model LIKE '%{0}%' OR Kelas LIKE '%{0}%'", textBoxCari.Text);
                dataGridGudang.DataSource = dataView;
            } catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            labelHarga.Text = "-";
        }
    }
}
