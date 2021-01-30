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
        SqlDataReader sdr;
        SqlDataAdapter sda;
        SqlCommand command;

        public MenuKaryawan()
        {
            InitializeComponent();
            loadData();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
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
    }
}
