using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //will utilize Dictionary data structure
        //member variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get; set; }
        Random rand = new Random();

        //ctor
        public Sweepstakes()
        {
            contestants = new Dictionary<int, Contestant>();
        }

        //member methods

        public Sweepstakes(String sweepstakesName)
        {
            //can use this to set sweepstakes name
        }
        public void RegisterContestant(Contestant contestant)
        {
            Add(contestant.RegistrationNumber, contestant);
            //Will either add to stack or queue here
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.FirstName}");
            Console.WriteLine($"Last Name: {contestant.LastName}");
            Console.WriteLine($"Email: {contestant.EmailAddress}");
            Console.WriteLine($"First Name: {contestant.RegistrationNumber}");
        }
        public Contestant PickWinner()
        {
            int winnerkey = rand.Next(1, contestants.Count + 1);
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
               if (contestant.Key == winnerkey)
                {
                    return contestant.Value;
                }
            }
            return null;
           //Will pick and then return a contestant
        }
    }
}
