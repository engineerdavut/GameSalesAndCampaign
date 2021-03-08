using GameSalesAndCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
