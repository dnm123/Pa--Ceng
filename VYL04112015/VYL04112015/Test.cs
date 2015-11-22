using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL04112015
{
    class Test
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();
            //oduncAlanId == 0 kimseye odunc verilmemis
            Kitap k1 = new Kitap(1, "Denemeler", "Montaigne", "Deneme", 0);
            kutuphane.kitapEkle(k1);
            Kitap k2 = new Kitap(2, "Sefiller", "Victor Hugo", "Roman", 0);
            kutuphane.kitapEkle(k2);
            kutuphane.kitaplariGoruntule();
            Uye u1 = new Uye(1,"Sel.","AKKAŞ");
            Uye u2 = new Uye(2, "Merve","ÖZDEŞ");
            kutuphane.uyeEkle(u1);
            kutuphane.uyeEkle(u2);
            kutuphane.uyeleriGoruntule();
            kutuphane.kitapOduncAl(1, 1);
            kutuphane.oduncAlinanKitaplariGoruntule();
        }
    }
}
