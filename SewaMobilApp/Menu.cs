using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewaMobilApp
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            muatNama();
        }

        private void muatNama()
        {
            labelTitle.Text = "Selamat Datang " + Karyawan.Nama;
        }
    }
}
