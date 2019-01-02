using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeData;

namespace InterfaceApp
{
    class Program
    {
        static Personel p;
        static Departman dep;
        static void Main(string[] args)
        {
            
            DataEKle();
            dep.CinsiyetSec(cinsiyet.Erkek);
            dep.PersonelleriListele();
            Console.WriteLine(dep.ToString());
            Console.ReadLine();
        }

      

        private static void DataEKle()
        {
            p = new Personel();
            p.Ad = "Ali";
            p.Soyad = "Yilmaz";
            p.TcKimlikNo = "123456789";
            p.TelefonNo = "2125486978";
            p.DogumTarihi = new DateTime(1990, 10, 9);
            p.DogumYeri = "Silivri";
            p.Cinsiyet = cinsiyet.Erkek;
            p.Din = din.Para;

            dep = new Departman();
            dep.Butce = 10000;
            dep.DepartmanAdi = "IT";
            dep.PersonelEkle(p);

            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.TelefonNo = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Bayan;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "123456789";

            dep.PersonelEkle(p);
            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.TelefonNo = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Bayan;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "1235423789";

            dep.PersonelEkle(p);
            p = new Personel();
            p.Ad = FakeData.NameData.GetFirstName();
            p.Soyad = FakeData.NameData.GetSurname();
            p.BabaAdi = FakeData.NameData.GetCompanyName();
            p.TelefonNo = FakeData.PhoneNumberData.GetPhoneNumber();
            p.DogumTarihi = FakeData.DateTimeData.GetDatetime();
            p.DogumYeri = FakeData.PlaceData.GetCity();
            p.Cinsiyet = cinsiyet.Bayan;
            p.Din = din.Hristiyan;
            p.Email = FakeData.NetworkData.GetEmail();
            p.TcKimlikNo = "1234563429";

            dep.PersonelEkle(p);



        }
        
    }
}
