using System;
using System.Collections.Generic;
using System.Text;

namespace SweepstakesProject
{
    public class Contestant
    {
        //member variables
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        //ctor
        public Contestant()
        {
           string[] contestantData = UserInterface.GetContestantInfo().Split(",");
            FirstName = contestantData[0];
            LastName = contestantData[1];
            EmailAddress = contestantData[2];
        }
        //member methods
    }
}
