using GameSalesAndCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game);   //normal satis
        void CampaignSale(Gamer gamer, Game game, Campaign campaign); //kampanyali satis 
    }
}
