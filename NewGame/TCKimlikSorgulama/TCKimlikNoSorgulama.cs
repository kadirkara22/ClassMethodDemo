using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame.TCKimlikSorgulama
{
   public class TCKimlikNoSorgulama
    {
        public static void TCKimlikNoDogrulama()
        {
            TCKimlikNoDogrulama.KPSPublic kps = new TCKimlikNoDogrulama.KPSPublic();
            bool kontrol = kps.TCKimlikNoDogrula(long.Parse(TCKimlikNo), isim.ToUpper(), soyisim.ToUpper(), int.Parse(dogumyili));

            if (kontrol)
            {
                Console.WriteLine("Bilgileriniz doğrulandı");
            }
            else
            {
                Console.WriteLine("Bilgileriniz doğrulamadı");
            }

            
        }
    }
}
