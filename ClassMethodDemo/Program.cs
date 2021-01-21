using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.Id = 1;
            musteri1.isim = "kadir";
            musteri1.soyisim = "kara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.isim = "sezer";
            musteri2.soyisim = "kara";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriEkle(new Musteri {Id=3,isim="turker",soyisim="can"});
            musteriManager.MusteriSil(musteri1);

        }
    }
}
