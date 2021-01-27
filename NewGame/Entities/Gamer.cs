using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
  public  class Gamer
    {
        public static int sayac = 1;
        private int _id;
        public int Id {
            get 
            {
                return _id;
            } 
          private  set
            {
                _id = sayac;
                sayac++;
            }
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TCKimlikNo { get; set; }
        public DateTime DogumYili { get; set; }
    }
}
