using DuelSysLogic.Exceptions;
using DuelSysLogic.Managers;
using DuelSysLogic.Models.Sports;

namespace DuelSys_Logic.Models.TournamentModels
{
    public class Match
    {

        public Match(Team? teamAway, Team? teamHome)
        {
            this.TeamAway = teamAway;
            this.TeamHome = teamHome;
        }

        public Match(int id, Team teamAway, int? scoreTeamAway, Team teamHome, int? scoreHomeAway, Sport sportType)
        {
            this.Id = id;
            this.TeamAway = teamAway;
            this.TeamHome = teamHome;
            this.SportType = sportType;
            this.ScoreTeamAway = scoreTeamAway;
            this.ScoreTeamHome = scoreHomeAway;
        }


        public Sport SportType { get; private set; }

        public int Id { get; private set; }

        public Team? Winner
        {
            get
            {
                if (ScoreTeamAway == null && ScoreTeamHome == null)
                {
                    throw new NoScoresSettledException("There are no socres to get the winner");
                }
                return SportType.GetWinner(this);
            }
        }

        public Team? TeamAway { get; set; }

        public Team? TeamHome { get; set; }

        public int? ScoreTeamAway { get; set; }

        public int? ScoreTeamHome { get; set; }

        public string MatchResult
        {
            get
            {
                if (ScoreTeamAway == null && ScoreTeamHome == null)
                {
                    return "N/A";
                }
                return $"{ScoreTeamAway} - {ScoreTeamHome}";
            }
        }
    }
}
