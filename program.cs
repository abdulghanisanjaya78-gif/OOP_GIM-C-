//16/09/26

using System;
using System.Collections.Generic;

namespace KerangkaGame
{
    class Karakter
    {
        public int TotalSenjata { get; private set; }
        public int Kekuatan { get; private set; }

        //enskapsulasi
        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }

        public Karakter(string nama, int kesehatan, int senjata) //Membuat constructor
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


        

         
        //public void setData(string nama, string kesehatan, string senjata, int totalSenjata, int kekuatan)
        //{
        //    this.nama = nama;
        //    this.kesehatan = kesehatan;
        //    this.senjata = senjata;
        //    this.totalSenjata = totalSenjata;
        //    this.kekuatan = kekuatan;
        //}


        //public void getData()
        //{
        //    Console.WriteLine(nama);
        //    Console.WriteLine(kesehatan);
        //    Console.WriteLine(senjata);
        //    Console.WriteLine(totalSenjata);
        //    Console.WriteLine(kekuatan);
        //}
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
                Karakter musuh = new Karakter("Musuh", 80, 8); //membuat objek
                //player1.nama = ("Fiqri Aqias");
                //player1.kesehatan = ("Sehat");
                //player1.senjata = ("Demon Sword");
                player1.getData();
                musuh.getData();

                player1.Serang(musuh);
                musuh.Serang(player1);  
                player1.Healing();
                player1.getData();
                //List<Karakter> daftarMC = new List<Karakter>(); //array penyimpan data

                //Karakter player1 = new Karakter();
                //player1.setData("Fiqri", "Kesehatan: Inni Bin Sehaati Alhamdulillah", "Senjata: Karambit", 2, 100);
                ////player1.getData();

                //Karakter player2 = new Karakter();
                //player2.setData("Aqias", "Kesehatan: Inni Amrod", "Senjata: Tangan Kosong", 0, 50);
                ////player2.getData();

                //List<Karakter> daftarMusuh = new List<Karakter>();
                //Karakter enemy = new Karakter();
                //enemy.setData("Musuh: Alucard", "Kekebalan Tubuh", "Senjata: Demon Sword", 1, 99);
                //enemy.getData();

                //Karakter enemy2 = new Karakter();
                //enemy2.setData("Musuh: Dracula", "Kerentanan Tubuh", "Senjata: Drows Nomed", 2, 1);
                //enemy2.getData();

                //daftarMC.Add(player1);
                //daftarMC.Add(player2);

                ////menampilkan data dari array, foreach
                //foreach(Karakter player in daftarMC)
                //{
                //    player.getData();
        }
            }
}
