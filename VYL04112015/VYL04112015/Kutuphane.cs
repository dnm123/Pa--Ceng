using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL04112015
{
    class Kutuphane
    {
        Node<Uye> uyeHead;
        Node<Kitap> kitapHead;

        public void kitapEkle(Kitap k)
        {
            if(kitapHead==null)
                kitapHead = new Node < Kitap > (k);
            else
            {
                Node<Kitap> iterator = kitapHead;
                while(iterator.Next != null)
                    iterator = iterator.Next;
                iterator.Next = new Node<Kitap>(k);
            }
        }
        public void kitaplariGoruntule()
        {
            Console.WriteLine("ISBN\tAd\t\tYazar\t\tTur\tOduncAlan");
            Node<Kitap> iterator = kitapHead;
            while (iterator!= null)
            {
                Console.WriteLine(iterator.Value.goruntule());
                iterator = iterator.Next;
            }
            
        }
        public void uyeEkle(Uye u)
        {
            if (uyeHead == null)
                uyeHead = new Node<Uye>(u);
            else
            {
                Node<Uye> iterator = uyeHead;
                while (iterator.Next!=null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = new Node<Uye>(u);
            }
        }
        public void uyeleriGoruntule()
        {
            Console.WriteLine("Id\tAd\tSoyad");
            Node<Uye> iterator = uyeHead;
            while (iterator != null)
            {
                Console.WriteLine(iterator.Value.goruntule());
                iterator = iterator.Next;
            }

        }
        public void kitapOduncAl(int Isbn,int uyeId)//uyeId,Isbn gecerli varsay
        {
            Node<Kitap> iterator = kitapHead;
            while (iterator!=null)
            {
                if (iterator.Value.Isbn == Isbn)
                {
                    if (iterator.Value.OduncAlanId == 0)
                    {
                        iterator.Value.OduncAlanId = uyeId;
                        Console.WriteLine(iterator.Value.Ad+" kitabi odunc alindi!");
                        break;
                    }
                    else
                        Console.WriteLine(iterator.Value.Ad + " kitabi daha onceden odunc alinmis!");
                }
                iterator = iterator.Next;
            }
            if(iterator==null)
                Console.WriteLine("Kitap bulunamadi");

        }

        public void oduncAlinanKitaplariGoruntule()
        {
            Console.WriteLine("\n######Odunc Alinanlar######");
            Console.WriteLine("ISBN\tAd\t\tYazar\t\tTur\tOduncAlan");

            Node<Kitap> iterator = kitapHead;
            while (iterator != null)
            {
                if(iterator.Value.OduncAlanId != 0)
                    Console.WriteLine(iterator.Value.goruntule());
                iterator = iterator.Next;
            }

        }

    }
}
