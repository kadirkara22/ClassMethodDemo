using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
  public  class GamerManager
    {
        public void GamerAdd(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adlı yeni oyuncu eklendi",gamer.Ad,gamer.Soyad);
        }
        public void GamerDelete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adlı oyuncu silindi", gamer.Ad, gamer.Soyad);
        }
        public void GamerUpdate(Gamer gamer)
        {
            Console.WriteLine("{0} {1} adlı oyuncu güncellendi", gamer.Ad, gamer.Soyad);
        }
    }
}
