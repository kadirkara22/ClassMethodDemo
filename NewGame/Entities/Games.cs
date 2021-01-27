using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
   public class Games
    {
        public static int sayac = 1;
        private int _gameid;
        public int GameId
        {
            get
            {
                return _gameid;
            }
            private set
            {
                _gameid = sayac;
                sayac++;
            }
        }
        public string GameName { get; set; }
        public double Price { get; set; }
    }
}
