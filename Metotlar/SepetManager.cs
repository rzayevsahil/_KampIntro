using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        //parantez içine parametre gönderiyoruz
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            //stokAdedi eklediğimizde programcsde sayfaları teker teker değiştirmek zorunda kalıyoruz
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
