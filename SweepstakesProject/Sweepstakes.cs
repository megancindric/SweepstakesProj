using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //member variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get => name; set => name = value; }
        Random rand = new Random();
        int winnerkey;

        //ctor
        public Sweepstakes(String sweepstakesName)
        {
            contestants = new Dictionary<int, Contestant>();
            Name = sweepstakesName;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.FirstName}");
            Console.WriteLine($"Last Name: {contestant.LastName}");
            Console.WriteLine($"Email: {contestant.EmailAddress}");
            Console.WriteLine($"Registration Number: {contestant.RegistrationNumber}");
        }
        public Contestant PickWinner()
        {
            winnerkey = rand.Next(1, contestants.Count + 1);
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
               if (contestant.Key == winnerkey)
               {
                    NotifyWinner();
                    return contestant.Value;
               }
            }
            return null;
        }
        public void NotifyContestants()
        { 

        }

        public void NotifyWinner()
        {
            Console.WriteLine("Congratulations!  You've won the sweepstakes!");
        }

        public void NotifyLoser()
        {
            Console.WriteLine("Sorry - better luck next time!  Thanks for playing!");
        }
        
    }
}
