using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class Player
    {
        private static int UserIDseed = 1234567890;

        private List<Game> allGames = new List<Game>();
        public string UserName { get; set; }

        public decimal Rating
        {
            get
            {
                decimal rating = 1;
                foreach (var item in allGames)
                {
                    rating += item.Points;
                    if(rating < 1)
                    {
                        rating = 1;
                    }

                }
                return rating;

            }
        }
        public string ID { get; set; }
        
        

        public void WinGame(string opponentname, int Rating, DateTime Date)
        {
            var game = new Game(Rating, opponentname, Date);
            allGames.Add(game);
        }

        public void LoseGame(string opponentname, int Rating,DateTime Date)
        {
            var game = new Game(-Rating, opponentname, Date);
            allGames.Add(game);
        }

        public string GetStats()
        {
            var report = new System.Text.StringBuilder();
            decimal rating = 1;
            report.AppendLine("Date\tPoints\tRatings\t\topponent");
            foreach (var item in allGames)
            {
                rating += item.Points;
                if (rating < 1)
                {
                    rating = 1;
                }
                report.AppendLine($"{item.Date.ToShortTimeString()}\t{item.Points}\t{rating}\t\t{item.opponent}");               
            }
            return report.ToString();
        }

        public Player(string player, decimal firststore)
        {
            
            this.ID = UserIDseed.ToString();
            UserIDseed++;
            this.UserName = player;
            
        }
        
    }

    public class Game
    {
        public DateTime Date { get; }
        public int Points { get; }
        public string opponent { get; }
        public Game(int points,string opponent, DateTime date)
        {
            this.Points = points;
            this.Date = date;
            this.opponent = opponent;

        }
    }
}

