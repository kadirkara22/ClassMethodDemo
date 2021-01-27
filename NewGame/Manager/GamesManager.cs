using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    public class GamesManager
    {
        public void GameAdd(Games game)
        {
            Console.WriteLine("{0} {1} adlı yeni oyun eklendi", game.GameName);
        }
        public void GameDelete(Games game)
        {
            Console.WriteLine("{0} {1} adlı oyun silindi", game.GameName);
        }
        public void GameUpdate(Games game)
        {
            Console.WriteLine("{0} {1} adlı oyun güncellendi", game.GameName);
        }
    }
}
