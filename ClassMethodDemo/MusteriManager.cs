using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("{0} isimli musteri eklendi", musteri.isim + " " + musteri.soyisim);
            MusteriListele(new Musteri[] {musteri});
           
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("{0} isimli musteri silindi", musteri.isim + " " + musteri.soyisim);
            MusteriListele(new Musteri[] { musteri });
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("müşterinin Id'si :"+musteri.Id);
                Console.WriteLine("müşterinin adı :"+musteri.isim);
                Console.WriteLine("müşterinin soyadı :"+musteri.soyisim);
                Console.WriteLine("*********************");
            }
            
        }
    }
}
