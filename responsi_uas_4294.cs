using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    // Deklarasi Class Penjualan dengan Acces Modifier Public
    public class Penjualan
    {
        // Property Nota yang menampung tipe data String dengan Acces Modifier Public
        public string Nota { get; set; }

        // Property Tanggal yang menampung tipe data String dengan Acces Modifier Public
        public string Tanggal { get; set; }

        // Property Costumer yang menampung tipe data String dengan Acces Modifier Public
        public string Costumer { get; set; }

        // Property Jenis yang menampung tipe data String dengan Acces Modifier Public
        public string Jenis { get; set; }

        // Property Total yang menampung tipe data Double dengan Acces Modifier Public
        public double Total { get; set; }
    }
}
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {    // Memberikan judul Console
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            // Perulangan menggunakan While
            while (true)
            {
                // Memanggil Fungsi TampilMenu
                TampilMenu();
                // mencetak kalimat "Nomor menu [1..4]"
                Console.Write("\nNomor Menu [1..4]: ");

                // menyimpan input yang dimasukkan user ke variable nomorMenu
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                // Percabangan menggunakan switch case
                switch (nomorMenu)
                {
                    // Jika nomerMenu bernilai 1 maka akan meenjalankan fungsi berikut
                    case 1:
                        
                        // Menjalankan fungsi TambahPenjualan
                        TambahPenjualan();

                        // Keluar dari switch case
                        break;

                    // Jika nomerMenu bernilai 2 maka akan meenjalankan fungsi berikut
                    case 2:

                        // Menjalankan fungsi HapusPenjualan
                        HapusPenjualan();

                        // Keluar dari switch case
                        break;

                    // Jika nomerMenu bernilai 3 maka akan meenjalankan fungsi berikut
                    case 3:

                        // Menjalankan fungsi TampilPenjualan
                        TampilPenjualan();

                        // Keluar dari switch case
                        break;

                    // Jika nomerMenu bernilai 3 maka akan meenjalankan fungsi berikut
                    case 4: // keluar dari program
                        return;
                    default:
                        break;
                }
            }
        }

        // Deklarasi Fungsi TampilMenu
        static void TampilMenu()
        {
            // Membersihkan Layar Console 
            Console.Clear();

            // Memberikan judul Console
            Console.Title = "Responsi Pemrograman";

            // Menampilkan kalimat " Pilih Menu :"
            Console.Write(" Pilih Menu :");

            // untuk pindah baris
            Console.WriteLine();

            // Menampilkan kalimat "1.Tambah Data Penjualan"
            Console.Write("1.Tambah Data Penjualan");

            // untuk pindah baris
            Console.WriteLine();

            // Menampilkan kalimat "2.Hapus Data Penjualan"
            Console.Write("2.Hapus Data Penjualan");

           // untuk pindah baris
            Console.WriteLine();

            // Menampilkan kalimat "3.Tampilkan Penjualan"
            Console.Write("3.Tampilkan Penjualan");

            // untuk pindah baris
            Console.WriteLine();

            // Menampilkan kalimat "4.Keluar"
            Console.Write("4.Keluar");

           // untuk pindah baris
            Console.WriteLine();
        }

        // Deklarasi Fungsi TambahPenjualan
        static void TambahPenjualan()
        {
            // Membersihkan layar Console
            Console.Clear();

            // Menampilkan kalimat "4.Keluar"
            Console.WriteLine("Tambah Penjualan");

            // Menampilkan kalimat "Nota : "
            Console.Write("Nota : ");

            // menyimpan input yang dimasukkan user ke variable nota
            string nota = Console.ReadLine();

            // Menampilkan kalimat "Tanggal : "
            Console.Write("Tanggal : ");

            // menyimpan input yang dimasukkan user ke variable tanggal
            string tanggal = Console.ReadLine();

            // Menampilkan kalimat "Costumer : "
            Console.Write("Costumer : ");

            // menyimpan input yang dimasukkan user ke variable costumer 
            string costumer = Console.ReadLine();

            // Menampilkan kalimat "Jenis [T/K] : "
            Console.Write("Jenis [T/K] : ");

            // menyimpan input yang dimasukkan user ke variable jenis 
            string jenis = Console.ReadLine();

            // Pengkondisian jika niali variable jenis sama dengan string T maka eksekusi blok berikut
            if (jenis == "T")
            {

                // Assigment variable jenis dengan Tunai
                jenis = "Tunai";
            }

            // Jika bukan maka esekusi blok berikut
            else
            {

                // Assigment nilai variable jenis dengan Kredit
                jenis = "Kredit";
            }

            // Menampilkan kalimat "Total Nota : "
            Console.Write("Total Nota : ");

            // menyimpan input yang dimasukkan user ke variable total
            double total = Convert.ToDouble(Console.ReadLine());

            // Menambahkan element List
            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Costumer = costumer, Jenis = jenis, Total = total });

            // Menampilkan kalimat "Tekan ENTER untuk kembali ke menu"
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            
            // Membaca Key yang diinputkan user untuk melanjutkan program
            Console.ReadKey();
        }

        // Deklarasi fungsi HapusPenjualan
        static void HapusPenjualan()
        {
            // Membersihkan layar console
            Console.Clear();

            // Menampilkan kalimat "Hapus Data Penjualan"
            Console.WriteLine("Hapus Data Penjualan");
            
            // Menampilkan kalimat "Nota : "
            Console.WriteLine("Nota : ");

            // menyimpan input yang dimasukkan user ke variable hapus
            string hapus = Console.ReadLine();

            // deklarasi variable x dengan tipe data integer yang mempunyai value 0
            int x = 0;

            // Mengakses semua element daftarPenjualan menggunakan foreach
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                // Cek apakah hapus sama dengan objek penjualan
                if (hapus == penjualan.Nota)
                {
                    // Menghapus list pada index x
                    daftarPenjualan.RemoveAt(x);

                    // Menampilkan kalimat "Data Penjualan Berhasil Dihapus"
                    Console.WriteLine("Data Penjualan Berhasil Dihapus");

                    // Keluar dari perulangan foreach
                    break;

                }

                // Incerment value dari variable X
                x++;

                // Menampilkan kalimat "Nota tidak ditemukan"
                Console.WriteLine("Nota tidak ditemukan");
            }

            // Menampilkan kalimat "Tekan ENTER untuk kembali ke menu"
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");

            // Membaca Key yang diinputkan user untuk melanjutkan program
            Console.ReadKey();
        }

        // Deklarasi fungsi TampilPenjualan
        static void TampilPenjualan()
        {
            // Membersihkan layar Console
            Console.Clear();

            // Menampilkan kalimat "Data Penjualan"
            Console.WriteLine("Data Penjualan");

            // Deklarasi variable no dengan tipe data Integer yang mempunyai value 1
            int no = 1;

            // Mengakses semua element daftarPenjualan menggunakan foreach
            foreach (Penjualan penjualan in daftarPenjualan)
            {

                // Menampilkan sebuah string dengan pindah baris
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Jenis, penjualan.Total);
                
                // Incerment nilai variable no
                no++;
            }

            // Menampilkan kalimat "Tekan enter untuk kembali ke menu"
            Console.WriteLine("\nTekan enter untuk kembali ke menu");

            // Membaca Key yang diinputkan user untuk melanjutkan program
            Console.ReadKey();
        }
    }
}
