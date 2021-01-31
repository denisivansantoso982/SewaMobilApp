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
    public partial class MenuKaryawan : UserControl
    {
        SqlConnection connection;
        DataTable dt;
        //SqlDataReader sdr;
        SqlDataAdapter sda;
        SqlCommand command;
        int id;

        public MenuKaryawan()
        {
            InitializeComponent();
            loadData();
            textBoxCari.Text = "";
        }

        public void loadData()
        {
            try
            {
                Koneksi kon = new Koneksi();
                connection = new SqlConnection(kon.koneksi);

                command = new SqlCommand("SELECT * FROM Karyawan WHERE Posisi != 'Owner'", connection);
                sda = new SqlDataAdapter(command);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridKaryawan.DataSource = dt;

                dataGridKaryawan.Columns[0].HeaderText = "ID";
                dataGridKaryawan.Columns[2].HeaderText = "No. Telepon";
                dataGridKaryawan.Columns[3].HeaderText = "Tanggal Lahir";
                dataGridKaryawan.Columns[4].HeaderText = "Jenis Kelamin";

                dataGridKaryawan.Columns[5].Visible = false;
                dataGridKaryawan.Columns[6].Visible = false;

                dataGridKaryawan.Columns[3].DefaultCellStyle.Format = "dddd, dd MMMMM yyyy";

                dataGridKaryawan.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridKaryawan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridKaryawan.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridKaryawan.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridKaryawan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridKaryawan.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                btnUbah.Visible = false;
                btnHapus.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            textBoxCari.Text = "";
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadData();
                DataView dataView = new DataView(dt);
                dataView.RowFilter = String.Format("Id_Karyawan LIKE %{0}% OR Nama LIKE '%{0}%' OR No_Telp LIKE '%{0}%'", textBoxCari.Text.ToString());
                dataGridKaryawan.DataSource = dataView;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Koneksi kon = new Koneksi();
                    connection = new SqlConnection(kon.koneksi);
                    command = new SqlCommand("DELETE FROM Karyawan WHERE Id_Karyawan = @id_karyawan", connection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id_karyawan", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    loadData();
                } else
                { }
            } catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridKaryawan.SelectedRows[0].Cells[0].Value);
                btnUbah.Visible = true;
                btnHapus.Visible = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
