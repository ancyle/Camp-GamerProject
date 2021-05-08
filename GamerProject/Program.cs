using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamerService gamerService = new GamerService();
            Gamer gamer = new Gamer();
            //Begin
            Console.WriteLine("Welcome, there is no user to continue. Please follow instructions.");
            //Get user infos, validate Identity
            do
            {
                gamer.Id = 1;
                Console.WriteLine("Enter your NAME:");
                gamer.FirstName = Console.ReadLine();
                Console.WriteLine("Enter your Surname:");
                gamer.LastName = Console.ReadLine();
                Console.WriteLine("Enter your (dd/mm/yyyy)Birth Date:");
                gamer.DateBirth = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter your (11 numeric characters)TC:");
                gamer.TcNo = Console.ReadLine();
                gamerService.Validate(gamer);
            }
            //Loop
            while (!gamerService.Validate(gamer));
            //Gamer Service methods
            gamerService.Add(gamer);
            gamerService.Delete(gamer);
            gamerService.Update(gamer);
            //Campaign details BASICLY we have no game Get game in here
            Campaign campaign = new Campaign();
            Console.WriteLine("To add a new campaign please follow instructions.");
            Console.WriteLine("Campaign Name:");
            campaign.CampaignName = Console.ReadLine();
            Console.WriteLine("Game Name:");
            campaign.GameName = Console.ReadLine();
            Console.WriteLine("Campaign Original Price:");
            campaign.UnitPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Campaign Discount:");
            campaign.CampaignDiscount = Convert.ToDecimal(Console.ReadLine());
            campaign.Id = 1;
            //Campaign methods BASICLY we have no game 
            ICampaignService campaignService = new CampaignService();
            campaignService.Add(campaign);
            campaignService.Update(campaign);
            campaignService.Delete(campaign);
            //Run Buy button method here.
            ISellService sellService = new SellService();
            sellService.Buy(gamer,campaign);
            //Wait for key...
            Console.ReadKey(true);
            //End
        }
    }
}
