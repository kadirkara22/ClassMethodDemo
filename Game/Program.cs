using Game.Entities
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yapmak istediğiniz işlemi seçiniz");



            Console.WriteLine("lütfen TC kimlik numaranızı giriniz");
            string TCKimlikNo = Console.ReadLine();
            Console.WriteLine("lütfen adınızı giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("lütfen Soyisminizi giriniz");
            string soyisim = Console.ReadLine();
            Console.WriteLine("lütfen doğum yılınızı giriniz");
            string dogumyili = Console.ReadLine();
            Gamer gamer = new Gamer(new Gamer
            {
                Ad=isim,
                Soyad=soyisim,
                TCKimlikNo=TCKimlikNo,
                DogumYili=dogumyili
            });
            GamerDataBase gmDatabase = new GamerDataBase();
           
        }
    }
}
