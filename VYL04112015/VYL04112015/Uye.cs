using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL04112015
{
    class Uye
    {
        int id;
        string ad, soyad;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public Uye(int id, string ad, string soyad)
        {
            this.Id = id;
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public string goruntule()
        {
            return id + "\t" + ad + "\t" + soyad;
        }
        
    }
}
