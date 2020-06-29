using System;
using System.Collections.Generic;
using System.Text;

namespace SweepstakesProject
{
    interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}