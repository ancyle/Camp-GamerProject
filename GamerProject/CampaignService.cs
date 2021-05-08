using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class CampaignService : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign \"{0}\" insert success. Game is {1} New Price is {2}",campaign.CampaignName,campaign.GameName,campaign.CampaignAfterDiscountPrice);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign \"{0}\" delete success.", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign \"{0}\" update success. Game is {1} New Price is {1}", campaign.CampaignName,campaign.GameName, campaign.CampaignAfterDiscountPrice);
        }
    }
}
