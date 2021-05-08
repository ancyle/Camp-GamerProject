using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    public class Campaign
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string CampaignName { get; set; }
        public decimal CampaignDiscount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CampaignAfterDiscountPrice { get { return UnitPrice - (UnitPrice*CampaignDiscount/100); } }
    }
}
