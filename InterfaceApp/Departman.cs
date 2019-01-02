using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Departman
    {
        private string departmanAdi;

        public string DepartmanAdi
        {
            get { return departmanAdi; }
            set { departmanAdi = value; }
        }
        private int butce;

        public int Butce
        {
            get { return butce; }
            set { butce = value; }
        }
        ArrayList personeller = new ArrayList();

        public int PersonelEkle(Personel p)
        {
        personeller.Add(p);
            return 1;
        }
        public Personel personelGetir(string tckimlikno)
        {
            Personel bulunan = new Personel();
            foreach (Personel p in personeller)
            {
                if (p.TcKimlikNo == tckimlikno)
                {
                    bulunan = p;
                    break;
                }
            }
            return bulunan;
        }
        public void PersonelleriListele()
        {
            Console.WriteLine("Personellerin Listesi");
            Console.WriteLine("----------------------");
            foreach (Personel p in personeller)
            {
                Console.WriteLine($"TcKimlikNo : {p.TcKimlikNo}");
                Console.WriteLine($"Ad : {p.Ad}");
                Console.WriteLine($"Soyad: {p.Soyad}");
                Console.WriteLine($"Telefon : {p.TelefonNo}");
                Console.WriteLine($"Dogum Yeri : {p.DogumYeri}");
                Console.WriteLine($"Dogum Tarihi : {p.DogumTarihi}");
                Console.WriteLine($"Cinsiyet : {p.Cinsiyet}");
                Console.WriteLine($"Din : {p.Din}");
                Console.WriteLine($"Email : {p.Email}");
            }

        }
        public override string ToString()
        {
            return $"Departman Adi:{DepartmanAdi}\nBütcesi : {Butce}\nPersonel Sayisi : {personeller.Count}";
        }
        public cinsiyet CinsiyetSec(cinsiyet cin)
        {
            Console.WriteLine($"{ cin} personeller");
            Console.WriteLine("-----------------------------");
            foreach (Personel item in personeller)
            {
                if (item.Cinsiyet == cin)
                {
                    Console.WriteLine($"TcKimlikNo : {item.TcKimlikNo}");
                    Console.WriteLine($"Ad : {item.Ad}");
                    Console.WriteLine($"Soyad: {item.Soyad}");
                    Console.WriteLine($"Telefon : {item.TelefonNo}");
                    Console.WriteLine($"Dogum Yeri : {item.DogumYeri}");
                    Console.WriteLine($"Dogum Tarihi : {item.DogumTarihi}");
                    Console.WriteLine($"Cinsiyet : {item.Cinsiyet}");
                    Console.WriteLine($"Din : {item.Din}");
                    Console.WriteLine($"Email : {item.Email}");
                }
            }
            return cin;
                
        }



    }
}
