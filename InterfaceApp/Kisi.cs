using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Kisi : IKimlik
    {
        private cinsiyet cinsiyet;
        public cinsiyet Cinsiyet { get { return cinsiyet; } set { cinsiyet = value; } }
        private din din;
        public din Din { get { return din; } set { din = value; } }
        private string tckimlik;
        public string TcKimlikNo { get { return tckimlik; } set { tckimlik = value; } }
        private string dogumyeri;
        public string DogumYeri { get { return dogumyeri; } set { dogumyeri = value; } }
        private DateTime dogumtarihi;
        public DateTime DogumTarihi { get { return dogumtarihi; } set { dogumtarihi = value; } }
        private string adi;
        public string Ad { get { return adi; } set { adi = value; } }
        private string soyad;
        public string Soyad { get { return soyad; } set { soyad = value; } }
        private string babaadi;
        public string BabaAdi { get { return babaadi; } set { babaadi = value; } }

        private string telefonNo;

        public string TelefonNo
        {
            get { return telefonNo; }
            set { telefonNo = value; }
        }


        public string FullName()
        {
            return Ad + " " + Soyad;
        }
        
    }
    

}
