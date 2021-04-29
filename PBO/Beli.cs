using System;
using System.Collections.Generic;
using System.Text;

namespace PBO
{
    class Beli : ListBarang
    {
        ListBarang A = new ListBarang();
        public void hitung()
        {
            int[] Bayar = new int[1000];
            string choice;
            int total = 0;
            string[] Item = new string[10000];
            int[] pcs = new int[0];
            int[] kode = new int[0];
            do
            {
                Array.Resize(ref kode, kode.Length + 1);
                Array.Resize(ref pcs, pcs.Length + 1);
                Console.Write("Kode Barang      : ");
                kode[kode.GetUpperBound(0)] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Jumlah Barang    : ");
                pcs[pcs.GetUpperBound(0)] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Apakah Ada Input Lagi (Y/T): ");
                choice = Console.ReadLine();
            }
            while (choice == "Y" || choice == "y");
            for (int i = 0; i < kode.Length; i++)
            {
                int a = kode[i];
                Item[i] = A.Barang(a);
                Bayar[i] = A.Harga(kode[i]) * pcs[i];
            }
            for (int i = 0; i < kode.Length; i++)
            {
                total = total + Bayar[i];
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\t============================\t");
            Console.WriteLine("\t     TOKO SERBA MURAH\t\t");
            Console.WriteLine("\t============================\t");
            DateTime Date = DateTime.Now;
            Console.WriteLine("");
            Console.WriteLine("Hari,Tanggal :" + Date.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine("");
            Console.WriteLine("Nama Item\t\t Jumlah\t\t Total\t\t");
            for (int i = 0; i < kode.Length; i++)
            {
                Console.WriteLine("{0}\t\t {1}\t\t {2}\t\t", Item[i], pcs[i], Bayar[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("TOTAL BELANJA        : {0}", total);
            Console.Write("UANG YANG DIBAYAR    : ");
            int pembayaran = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KEMBALIAN            : {0}", pembayaran - total);
            Console.WriteLine("");
            System.Environment.Exit(0);
        }
    }
}
