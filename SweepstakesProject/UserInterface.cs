using System;
using System.Collections.Generic;
using System.Dynamic;
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

        public static string GetManagerInput()
        {
            string managerInput;
            Console.WriteLine("Press 1 for Stack\nPress 2 for Queue");
            managerInput = Console.ReadLine();
            return managerInput;
        }

        public static string GetSweepstakesName()
        {
            string sweepstakesName;
                Console.WriteLine("Please enter the name of your sweepstakes");
            sweepstakesName = Console.ReadLine();
            return sweepstakesName;
        }
    }
}
