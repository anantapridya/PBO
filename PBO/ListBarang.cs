using System;
using System.Collections.Generic;
using System.Text;

namespace PBO
{
    class ListBarang
    {
        public string Barang(int a)
        {
            string[] NamaBarang = { "Kopi", "Gula", "Teh", "Detergen", "Sabun", "Tepung Terigu", "Mie Instan", "Garam", "Shampo", "Biskuit", "Roti" };
            string barang = Convert.ToString(NamaBarang[a - 1]);
            return barang;
        }
        public int Harga(int a)
        {
            int[] Harga = { 2000, 13000, 5000, 30000, 6000, 20000, 3000, 15000, 25000, 10000, 65000 };
            int harga = Harga[a - 1];
            return harga;
        }

        public void Menu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Kode\t Nama Barang\t");
            Console.WriteLine("1\t Kopi\t\n2\t Gula\t\n3\t Teh\t\n4\t Detergen\t\n5\t Sabun\t\n6\t Tepung Terigu\t\n7\t Mie Instan\t\n8\t Garam\t\n9\t Shampo\t\n10\t Biskuit\t\n11\t Roti");
        }
    }
}
