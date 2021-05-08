using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
   public class SellService:ISellService
    {
        public void Buy(Gamer gamer,Campaign campaign)
        {
            Console.WriteLine("Congratulations.\nYou have bought {0}, \nUsing campaign {1}, \nPrice is {2}",campaign.GameName,campaign.CampaignName,campaign.CampaignAfterDiscountPrice);
        }
    }
}
