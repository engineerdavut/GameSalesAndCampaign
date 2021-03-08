using GameSalesAndCampaign.Abstract;
using GameSalesAndCampaign.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesAndCampaign.Concrete
{
    class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Yeni üye " + gamer.FirstName + " hosgeldiniz. Kaydiniz tamamlanmistir.");
            }
            else
            {
                throw new Exception("Boyle bir kisi yok.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+ " adli üyenin hesabi silinmistir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " hesabiniz guncellenmistir.");
        }
    }
}
