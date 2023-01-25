using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Exceptions.TouranmentsSystems;
using DuelSysLogic.Models.Tournament;

namespace DuelSysLogic.Managers.TournamentManager
{
    public class TiesHandler
    {
        public static List<Team> GetTopThree(List<Match> matches)
        {
            if(matches == null || matches.Count == 0) 
            {
                throw new HandleTiesException("Matches list can't be empty or null");
            }
            List<Tie> winners = new List<Tie>();
            List<Tie> winnerTeamsTies = new List<Tie>();


            for (int i = 0; i < matches.Count; i++)
            {
                if (matches[i].MatchResult != "N/A")
                {
                    Tie tieAway = new Tie(matches[i].TeamAway);

                    winners.Add(matches[i].Winner != null ? new(matches[i].Winner) : null); 

                    if (!containTeam(tieAway.Team.Id))
                    {
                        winnerTeamsTies.Add(tieAway);
                    }

                    Tie tiehome = new Tie(matches[i].TeamHome);

                    if (!containTeam(tiehome.Team.Id))
                    {
                        winnerTeamsTies.Add(tiehome);
                    }
                }
            }


            for (int j = 0; j < winnerTeamsTies.Count; j++)
            {
                foreach (Match match in matches)
                {

                    if (match.MatchResult != "N/A")
                    {
                        if (winnerTeamsTies[j].Team.Id == match.TeamHome.Id)
                        {
                            winnerTeamsTies[j].TotalPoints += (int)match.ScoreTeamHome;
                        }
                        else if (winnerTeamsTies[j].Team.Id == match.TeamAway.Id)
                        {
                            winnerTeamsTies[j].TotalPoints += (int)match.ScoreTeamAway;
                        }
                    }

                }
            }

            foreach (Tie team in winnerTeamsTies)
            {
                for (int i = 0; i < winners.Count; i++)
                {
                    if (team.Team.Id == winners[i].Team.Id)
                    {
                        team.WinCount++;
                    }
                }
            }

            for (int i = 0; i < winnerTeamsTies.Count; i++)
            {
                for (int j = 0; j < winnerTeamsTies.Count; j++)
                {
                    if (winnerTeamsTies[j].TotalPoints == winnerTeamsTies[i].TotalPoints && j != i)
                    {
                        throw new HandleTiesException("System couldn't determine the top winners.");
                    }
                }
            }

            winnerTeamsTies = winnerTeamsTies.OrderBy(o => o.TotalPoints).ToList();

            winnerTeamsTies = winnerTeamsTies.OrderBy(o => o.WinCount).Reverse().ToList();

            List<Team> teams = new List<Team>();

            teams.AddRange(winnerTeamsTies.Select(t => t.Team));

            return teams.Take(3).ToList();


            bool containTeam(int teamId)
            {
                foreach (Tie tie in winnerTeamsTies)
                {
                    if (tie.Team.Id == teamId)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

    }
}
