using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
   public class Gamer
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TCKimlikNo { get; set; }
        public DateTime DogumYili { get; set; }
    }
}
