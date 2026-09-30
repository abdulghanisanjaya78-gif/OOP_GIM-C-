using System;

namespace KerangkaGame
{
    class Karakter
    {
        public int TotalSenjata { get; private set; }
        public int Kekuatan { get; private set; }

        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }

        public Karakter(string nama, int kesehatan, int senjata)
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void Serang(Karakter target)
        {  
            Console.WriteLine("===> mulai serangan");
            target.TerimaSerangan(this.senjata);

        }

        public void TerimaSerangan(int Serangan) 
        {
            this.kesehatan -= Serangan;
            Console.WriteLine($"===> {this.nama} menerima serangan, sisa kesehatan {this.kesehatan}");
        }

        public void Healing()
        {
            this.kesehatan += 20;
            Console.WriteLine($"===> {this.nama} melakukan healing, kesehatan menjadi {this.kesehatan}");
        }

        public void getData()
        {
            Console.WriteLine($"Karakter {nama}, KesehatanMu{kesehatan}, Senjata{senjata} ");
        }
    }
        class MainProgram
        {
            static void Main(string[] args)
            {
                Karakter player1 = new Karakter("Zaqi", 100, 10); 
                Karakter musuh = new Karakter("Musuh", 80, 8);
                player1.getData();
                musuh.getData();

                player1.Serang(musuh);
                musuh.Serang(player1);  
                Console.WriteLine($"sembuhkan {player1.nama}? (y/n)");
                string pilihan = Console.ReadLine();

                if (pilihan == "y")
                {
                    player1.Healing();
                }
                else if (pilihan == "n")
                {
                    Console.WriteLine("tidak disembuhkan!");
                }
                else
                {
                    Console.WriteLine("Pilihan tidak ada");
                }

                player1.getData();
        }
            }
}
