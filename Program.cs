using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4405
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            // memberi nilai property
            karyawan1.NIK = "21114424";
            karyawan1.NAMA = "Muqsid";
            karyawan1.Gajiperbulan = 3000000;

            // validasi gaji karyawan1
            if (karyawan1.Gajiperbulan < 0)
            {
                karyawan1.Gajiperbulan = 0;
            }

            // membuat objek Karyawan 2
            Karyawan karyawan2 = new Karyawan();

            // memberi nilai property 2
            karyawan2.NIK = "21114405";
            karyawan2.NAMA = "Sitiqalam";
            karyawan2.Gajiperbulan = 2000000;

            // validasi gaji karyawan1
            if (karyawan2.Gajiperbulan < 0)
            {
                karyawan2.Gajiperbulan = 0;
            }

            // mengambil nilai dengan property
            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("1. {0} {1}\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.Gajiperbulan);
            Console.WriteLine("2. {0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.Gajiperbulan);
            Console.WriteLine("\n");

            Console.WriteLine("Asyiiiiik kenaikan gaji 10%!! ");
            Console.WriteLine("\n");

            Console.WriteLine("No Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("1. {0} {1}\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.Gajiperbulan + (karyawan1.Gajiperbulan * 0.1));
            Console.WriteLine("2. {0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.Gajiperbulan + (karyawan2.Gajiperbulan * 0.1));

            Console.ReadKey();
        }
    }
}