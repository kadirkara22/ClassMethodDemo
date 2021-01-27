using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
  public  class Kampanya
    {
        public static int sayac = 1;
        private int _kampanyaid;
        public int KampanyaId
        {
            get
            {
                return _kampanyaid;
            }
            private set
            {
                _kampanyaid = sayac;
                sayac++;
            }
        }
        public string KampanyaAd { get; set; }
        public string KampanyaIndirim { get; set; }
    }
}
