using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        Mahasiswa mhs = new Mahasiswa();


        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

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
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
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
            Console.WriteLine("\n1. Tambah Mahasiwa\n2. Hapus Mahasiswa\n3. Tampil Mahasiswa\n4.Keluar dari program");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mhs = new Mahasiswa();
            Console.WriteLine("Tambah Data Mahasiswa\n");
            Console.Write("NIM : ");
            mhs.Nim = Console.ReadLine();
            Console.Write("Nama : ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            mhs.jeniskelamin = Console.ReadLine();
            if (mhs.jeniskelamin == "L")
            {
                mhs.jeniskelamin = "Laki-Laki";
            }
            else if (mhs.jeniskelamin == "P")
            {
                mhs.jeniskelamin = "Perempuan";
            }
            Console.Write("IPK : ");
            mhs.IPK = double.Parse(Console.ReadLine());

            daftarMahasiswa.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();


            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM : ");
            string nim = Console.ReadLine();

            Mahasiswa delete = daftarMahasiswa.SingleOrDefault(x => x.Nim == nim);
            if (daftarMahasiswa.Contains(delete) == true)
            {
                daftarMahasiswa.Remove(delete);
                Console.WriteLine("Data Mahasiswa Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("NIM Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("No.  Nim     Nama     Jenis Kelamin      IPK");
            Console.WriteLine("============================");
            int num = 0;
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                Console.WriteLine($"{num++}   {mhs.Nim}   {mhs.Nama}     {mhs.jeniskelamin}         {mhs.IPK}");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
