using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreLibrary
{
    public class Game
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }

        public Game() { }

        public Game(string team1, int team1Score, string team2, int team2Score)
        {
            Team1 = team1;
            Team2 = team2;
            Team1Score = team1Score;
            Team2Score = team2Score;
        }

        public override string ToString()
        {
            return Team1 + " (" + Team1Score + ")" + " - " + Team2 + " (" + Team2Score + ") ";
        }
    }
}
