using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Polymorphsim__Abstraction___Collection_2685
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap     = new KaryawanTetap();
            karyawanTetap.Nik               = "19.11.2698";
            karyawanTetap.Nama              = "Rifai Aslam";
            karyawanTetap.GajiBulanan       = 4000000;

            KaryawanHarian karyawanHarian   = new KaryawanHarian();
            karyawanHarian.Nik              = "123-321-345";
            karyawanHarian.Nama             = "Rifai";
            karyawanHarian.JumlahJamKerja   = 8;
            karyawanHarian.UpahPerJam       = 13000;

            Sales sales                     = new Sales();
            sales.Nik                       = "123-333-347";
            sales.Nama                      = "Aslam";
            sales.JumlahPenjualan           = 30;
            sales.Komisi                    = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
