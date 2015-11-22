using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL04112015
{
    class Kitap
    {
        int isbn,oduncAlanId;
        string ad,yazar,tur;

        public int Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public int OduncAlanId
        {
            get
            {
                return oduncAlanId;
            }

            set
            {
                oduncAlanId = value;
            }
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Yazar
        {
            get
            {
                return yazar;
            }

            set
            {
                yazar = value;
            }
        }

        public string Tur
        {
            get
            {
                return tur;
            }

            set
            {
                tur = value;
            }
        }
        public Kitap(int isbn, string ad, string yazar,
            string tur, int oduncAlanId)
        {
            Isbn = isbn;
            Ad = ad;
            Yazar = yazar;
            Tur = tur;
            OduncAlanId = oduncAlanId;
        }
        public string goruntule()
        {
            return Isbn + "\t" + ad + "\t" + yazar + "\t" + tur + "\t" + oduncAlanId;
        }
    }
}
