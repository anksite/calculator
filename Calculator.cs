using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih operasi hitung:");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\nMenu yang anda pilih (1-4): ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1 | pilih == 2 | pilih == 3 | pilih == 4)
            {
                Console.Write("\nInput nilai a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input nilai b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                switch (pilih)
                {
                    case 1: tambah(a, b); break;
                    case 2: kurang(a, b); break;
                    case 3: kali(a, b); break;
                    case 4: bagi(a, b); break;
                }
            }
            else
            {
                Console.WriteLine("\nMenu yang anda pilih tidak tersedia!");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static void tambah(double a, double b)
        {
            Console.WriteLine("Hasil penambahan {0} + {1} = {2}", a, b, a + b);
        }

        static void kurang(double a, double b)
        {
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, a - b);
        }

        static void kali(double a, double b)
        {
            Console.WriteLine("Hasil perkalian {0} X {1} = {2}", a, b, a * b);
        }

        static void bagi(double a, double b)
        {
            Console.WriteLine("Hasil pembagian {0} : {1} = {2}", a, b, a / b);
        }
    }
}
