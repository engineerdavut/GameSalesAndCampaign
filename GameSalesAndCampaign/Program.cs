using GameSalesAndCampaign.Adapters;
using GameSalesAndCampaign.Concrete;
using GameSalesAndCampaign.Entities;
using System;

namespace GameSalesAndCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer = new Gamer()
            {
                FirstName = "Davut",
                NationalityId = "86454653",
                DateOfBirth = new DateTime(1961, 07, 26),
                LastName = "istanbul",
                Id = 1
            };
            Gamer gamer2 = new Gamer()
            {
                FirstName = "gül",
                NationalityId = "346464678",
                DateOfBirth = new DateTime(1978, 07, 26),
                LastName = "İstanbul",
                Id = 2
            };
            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);
            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer2);

            Game game = new Game()
            {
                Id = 1,
                Name = "GTA 6",
                Description = "Guzel oyun" +
                "Helikopter gorevi var.",
                Price = 200
            };
            Game game2 = new Game()
            {
                Id = 2,
                Name = "PES",
                Description = "Futbol oyunu" +
                "Kariyer modu geldi.",
                Price = 300
            };
            GameManager gameManager = new GameManager();

            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);
            gameManager.Add(game2);
            gameManager.Update(game2);
            gameManager.Delete(game2);

            Campaign campaign = new Campaign() {
                Id = 1,
                Discount = 80,
                Name = "Summer Discount",
                CampaignEndTime = new DateTime(2021, 09, 26)
            };
            Campaign campaign2 = new Campaign()
            {
                Id = 1,
                Discount = 80,
                Name = "Winter Discount",
                CampaignEndTime = new DateTime(2021, 03, 26)
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign2);

            SaleManager salesManager = new SaleManager();
            salesManager.Sale(gamer, game);
            salesManager.CampaignSale(gamer, game, campaign);
            salesManager.Sale(gamer2, game2);
            salesManager.CampaignSale(gamer2, game2, campaign2);
        }
    }
}
