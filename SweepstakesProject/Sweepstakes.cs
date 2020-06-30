using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

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
                    return contestant.Value;
               }
            }
            return null;
        }
        public void NotifyContestants(Contestant winnerContestant)
        {
            MailboxAddress duckAddress = new MailboxAddress("Brent & Megan", "bigduckenergy@duckduckgo.com");
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {  
                var message = new MimeMessage();
                message.From.Add(duckAddress);
                message.To.Add(new MailboxAddress(contestant.Value.FirstName, contestant.Value.EmailAddress));
                if(contestant.Value == winnerContestant)
                {
                    message.Subject = $"Congratulations, you're the lucky winner!";
                    message.Body = new TextPart("plain") { Text = @$"CONGRATS {contestant.Value.FirstName},
                
                Wow you won our sweepstakes and the grand prize of a millon dollars and a yacht!  Lucky you!  Just reply to this email and we'll send you your yacht via USPS in 3-5 business days!

                    Thanks so much for playing!
                        ~~BigDuckEnergy" };
                }
                else
                {
                    message.Subject = "Thanks for playing!";
                    message.Body = new TextPart("plain") {Text = @$"Hey there {contestant.Value.FirstName},
                
                Thanks so much for playing our sweepstakes, but unfortunately you were not the winner.We hope you'll try again!

                    Warm Regards,
                        ~~BigDuckEnergy"};


                    using (var client = new SmtpClient())
                    {
                        client.Connect("smpt.gmail.com", 465, true);
                        client.Authenticate ("bigduckenergy", "themightyducks1");

                        client.Send(message);
                        client.Disconnect(true);
                    }
                }
            }
        }
    }
}
