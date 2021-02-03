using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewaMobilApp
{
    public class Karyawan
    {
        public static int Id_Karyawan { get; set; }
        public static string Nama { get; set; }
        public static string No_Telp { get; set; }
        public static DateTime Tgl_Lahir { get; set; }
        public static string Jk { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Posisi { get; set; }
    }

    public class Mobil {
        public static string no_pol { get; set; }
        public static string merk { get; set; }
        public static string model { get; set; }
        public static int tahun_buat { get; set; }
        public static string status_mobil {get;set;}
        public static string kelas { get; set; }
        public static int harga { get; set; }
        public static byte[] gambar { get; set; }
    }

    public class DataKaryawan
    {
        public static int Id { get; set; }
        public static string Nama { get; set; }
        public static string No_telp { get; set; }
        public static DateTime Tgl_lahir { get; set; }
        public static string Jk { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Posisi { get; set; }
    }
}
