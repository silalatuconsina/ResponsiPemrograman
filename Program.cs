using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog_4405
{
    public class Program
    {
        static List<Mahasiswa> list = new List<Mahasiswa>();
        static Mahasiswa mhs = new Mahasiswa();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa(list);
                        break;

                    case 3:
                        return;

                    default:
                        break;
                }
            }
        }
        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar\n");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            mhs = new Mahasiswa();
            Console.WriteLine("Tambah data Mahasiswa\n");
            Console.Write("NIM   : ");
            mhs.Nim = Console.ReadLine();
            Console.Write("Nama   : ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelain [L/P]   : ");
            mhs.Gender = Console.ReadLine() == "L" ? "Laki-laki" : "Perempuan";
            Console.Write("IPK   : ");
            mhs.Ipk = (float)Convert.ToDouble(Console.ReadLine());
            list.Add(mhs);

            //Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa(List<Mahasiswa> list)
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;
            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0}.{1},{2},{3},{4}", no, mhs.Nim, mhs.Nama, mhs.Gender, mhs.Ipk);
                no++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
