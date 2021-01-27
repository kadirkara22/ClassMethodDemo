using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
   public class KampanyaManager
    {
        public void KampanyaAdd(Kampanya kampanya)
        {
            Console.WriteLine("{0} {1} adlı yeni kampanya eklendi", kampanya.KampanyaAd);
        }
        public void KampanyaDelete(Kampanya kampanya)
        {
            Console.WriteLine("{0} {1} adlı kampanya silindi", kampanya.KampanyaAd);
        }
        public void KampanyaUpdate(Kampanya kampanya)
        {
            Console.WriteLine("{0} {1} adlı kampanya güncellendi", kampanya.KampanyaAd);
        }
    }
}
