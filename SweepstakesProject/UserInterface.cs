using System;
using System.Collections.Generic;
using System.Text;

namespace SweepstakesProject
{
   public static class UserInterface
    {
        //Will be used to assign Contestant object firstName, lastName, emailAddress, registrationNumber

        //ctor

        //member methods
        public static string GetContestantInfo()
        {
            string contestantInfo;
            Console.WriteLine("Enter the following Contestant information:");
            Console.Write("First Name: ");
            contestantInfo = Console.ReadLine();
            Console.Write("Last Name: ");
            contestantInfo += "," + Console.ReadLine();
            Console.Write("Email Address: ");
            contestantInfo += "," + Console.ReadLine();
            return contestantInfo;
        }
    }
}
