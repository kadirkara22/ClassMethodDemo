using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer({
            Ad="kadir",
            Soyad="kara",
            TCKimlikNo="123456789012",
            DogumYili=2000
            });
            TCKimlikNoSorgulama(gamer1.TCKimlikNo);
            
            Gamer gamer2 = new Gamer({
                Ad = "turker",
                Soyad = "can",
                TCKimlikNo = "987654321032",
                DogumYili = 2002
            });
            TCKimlikNoSorgulama(gamer2.TCKimlikNo);
            Gamer gamer3 = new Gamer({
                Ad = "ahmet",
                Soyad = "can",
                TCKimlikNo = "123456789012",
                DogumYili = 1990
            });
            TCKimlikNoSorgulama(gamer3.TCKimlikNo);

            Games games1 = new Games({
            GameName="GTA4",
            Price="100"
            });
            Games games1 = new Games({
                GameName = "pes2020",
                Price = "200"
            });

            Kampanya kampanya1=new Kampanya({
            KampanyaAd="black friday",
            KampanyaIndirim=40,
            });

            Kampanya kampanya2 = new Kampanya({
                KampanyaAd = "black pazar",
                KampanyaIndirim = 20,
            });

            GamerManager gamerManager = new GamerManager();
            gamerManager.GamerAdd(new Gamer {Ad="murat",Soyad="kartal",TCKimlikNo=789456132302,DogumYili=2000 })
            gamerManager.GamerUpdate(gamer1);
            gamerManager.GamerDelete(gamer1);

            GamesManager gamesManager = new GamesManager();
            gamesManager.GameAdd(new Games { GameName= "Counter Strike" ,Price=100 });
            gamesManager.GameUpdate(games1);
            gamesManager.GameDelete(games1);


            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaAdd( new Kampanya {KampanyaAd="Bayram pazarı",KampanyaIndirim=50 } );
            kampanyaManager.KampanyaUpdate(kampanya1);
            kampanyaManager.KampanyaDelete(kampanya1);
            

           
        }
    }
}
