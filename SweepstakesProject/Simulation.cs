using System;
using System.Collections.Generic;
using System.Text;

namespace SweepstakesProject
{
    class Simulation
    {
        ISweepstakesManager _manager;
        public void CreateMarketingFirmWithManager()
        {
            string userInput = UserInterface.GetManagerInput();
            switch (userInput)
            {
                case "1":
                    _manager = new SweepstakesStackManager();
                    break;
                case "2":
                    _manager = new SweepstakesQueueManager();
                    break;
                default:
                    CreateMarketingFirmWithManager();
                    break;
            }
            MarketingFirm marketingFirm = new MarketingFirm(_manager);
        }
    }
}
