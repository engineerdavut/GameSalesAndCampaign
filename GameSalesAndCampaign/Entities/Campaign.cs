using GameSalesAndCampaign.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Entities
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public string Name { get; set; }

        public DateTime CampaignEndTime { get; set; }
        //Oyuna özel kampanya olabilir.
    }
}
