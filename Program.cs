using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Data Penjualan");
            Console.WriteLine("2. Hapus Data Penjualana");
            Console.WriteLine("3. Tampilkan Data Penjualan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine("");
            
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Console.WriteLine("");
            Console.Write(" Nota : ");
            string nota = Console.ReadLine();
            Console.Write(" Tanggal : ");
            int tanggal = int.Parse(Console.ReadLine());
            Console.WriteLine("Customer : ");
            string customer = Console.ReadLine();
            Console.Write(" Total Nota : ");
            double totalNota = Double.Parse(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Costumers = customer, TotalNota = totalNota });
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Console.Clear();
            Console.WriteLine(" Hapus Data Penjualan");
            Console.WriteLine("");
            Console.Write(" Masukan Nota yang ingin dihapus : ");
            string Delete = Console.ReadLine();
            int H = 0;
            bool Data = false;

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (Delete == penjualan.Nota)
                {
                    daftarPenjualan.RemoveAt(H);
                    Data = true;
                    break;
                }
                H++;
            }
            if (Data == false)
            {
                Console.WriteLine("");
                Console.WriteLine(" Maaf data tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.Clear();
            Console.WriteLine(" Menampilkan data Penjualan ");
            Console.WriteLine("");
            int No = 1;
            bool Data = false;
            foreach ( Penjualan penjualan in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3} ,{4},{5}",
                No, penjualan.Nota,penjualan.Costumers, penjualan.Tanggal, penjualan.Jenis, penjualan.TotalNota);
                Data = true;
                No++;
            }
            if (Data == false)
            {
                Console.WriteLine("");
                Console.WriteLine(" Maaf data Kosong ");

            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
