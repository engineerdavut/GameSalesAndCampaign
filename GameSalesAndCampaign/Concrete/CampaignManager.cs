using GameSalesAndCampaign.Abstract;
using GameSalesAndCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name +" adli kampanyamiz yuzde "+ campaign.Discount
                + " indirimle " + campaign.CampaignEndTime + " tarihine kadar size sunulmustur.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " adli kampanya silinmistir. ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+ " adli kampanyamiz yuzde "+ campaign.Discount+ " indirimle "
                + campaign.CampaignEndTime + " tarihine kadar uzatilip,guncellenmistir.");
        }
    }
}
