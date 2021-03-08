using GameSalesAndCampaign.Abstract;
using GameSalesAndCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Concrete
{
    class SaleManager : ISaleService
    {
        int discountedPrice;
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            discountedPrice = game.Price - ((game.Price * campaign.Discount) / 100);
            Console.WriteLine(gamer.FirstName + " adli kullanici " + campaign.Name
                + " adli kampanyadan yararlanarak " + game.Name + " adli oyunu yuzde "
                + campaign.Discount + " indirimle "+ discountedPrice + " fiyata almistir.");

        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+ " adli kullanici "
                + game.Name + " adli oyunu " + game.Price + " fiyatiyla satin almistir. ");
        }
    }
}
