using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4405
{
    class Karyawan
    {
        // constructor default
        public Karyawan()
        {

        }
        // overload constructor 
        public Karyawan(string nik, string nama, int gajiperbulan)
        {
            NIK = nik;
            NAMA = nama;
            Gajiperbulan = gajiperbulan;
        }

        // properties
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int Gajiperbulan { get; set; }
    }
}