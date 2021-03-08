using GameSalesAndCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Abstract
{
    interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
