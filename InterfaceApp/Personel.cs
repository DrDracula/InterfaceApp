using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Personel:Kisi
    {
        private int maas;

        public int Maas
        {
            get { return maas; }
            set { maas = value; }
        }
        private departman departman;

        public departman Departman
        {
            get { return departman; }
            set { departman = value; }
        }
        private DateTime iseGiris;

        public DateTime iseGirisTarihi
        {
            get { return iseGiris; }
            set { iseGiris = value; }
        }
        private calismasekli calismasekli;

        public calismasekli Calismasekli
        {
            get { return calismasekli; }
            set { calismasekli = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string ceptelefonu;

        public string CepTelefonu
        {
            get { return ceptelefonu; }
            set { ceptelefonu = value; }
        }


       


    }
    enum departman
    {
        Hizmetli=1,
        Satis=2,
        Muhasebe=3,
        IK=4,
        IT=5,
        Yonetim=6
    }
    enum calismasekli
    { Sozlesmeli=1,
        Kadrolu=2
    }
}
