using System;
using System.Collections.Generic;
using System.Text;

namespace SweepstakesProject
{
    class MarketingFirm
    {
        //member variables
        public ISweepstakesManager _manager;
        //ctor
        public MarketingFirm(ISweepstakesManager _manager)
        {

        }
        
        //member methods
       
        public void CreateSweepstake()
        {
            Sweepstakes newSweepstakes = new Sweepstakes();
            _manager.InsertSweepstakes(newSweepstakes);
        }
    }
}
