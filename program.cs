//16/09/26

using System;

namespace KerangkaGame
{
    class Karakter
    {
        public int TotalSenjata { get; private set; }
        public int Kekuatan { get; private set; }

        //enskapsulasi
        public string Nama { get; private set; } = string.Empty;
        public int Kesehatan { get; private set; }
        public string Senjata { get; private set; } = string.Empty;

        public Karakter(string nama, int kesehatan, string senjata, int totalSenjata, int kekuatan)
        {
            Nama = nama;
            Kesehatan = kesehatan;
            Senjata = senjata;
            TotalSenjata = totalSenjata;
            Kekuatan = kekuatan;
        }

        public void Serang(Karakter target)
        {
            Console.WriteLine("===> mulai serangan");
            target.TerimaSerangan(Kekuatan);

        }

        public void TerimaSerangan(int serangan)
        {
            Kesehatan = Math.Max(0, Kesehatan - serangan);
            Console.WriteLine($"===> {Nama} menerima serangan, sisa kesehatan {Kesehatan}");
        }


        public void GetData()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Kesehatan: {Kesehatan}");
            Console.WriteLine($"Senjata: {Senjata}");
            Console.WriteLine($"Total senjata: {TotalSenjata}");
            Console.WriteLine($"Kekuatan: {Kekuatan}");
        }
    }

    class MainProgram
    {
        static void Main()
        {
            Karakter player1 = new Karakter("Fiqri", 100, "Doa", 1, 25);
            Karakter enemy = new Karakter("Musuh", 100, "Pedang", 1, 10);

            player1.GetData();
            enemy.GetData();

            player1.Serang(enemy);
            enemy.GetData();
        }
    }
}
