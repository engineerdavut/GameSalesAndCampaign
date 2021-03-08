using GameSalesAndCampaign.Abstract;
using GameSalesAndCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name +" adli oyun "+ game.Price+ " satis fiyatiyla oyun veritabanina eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " adli oyun, oyun veritabanindan silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " adli oyun " + game.Price + " satis fiyatiyla oyun veritabanina guncellendi.");
        }
    }
}
