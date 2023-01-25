using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Managers;

namespace DuelSysLogic.Models.TournamentModels
{
    public partial class Tournament
    {
        private ITournamentRepository repository;

        public bool IsDone
        {
            get
            {
                List<Match> matches = GetAllMatches();

                if (matches == null) 
                {
                    return false;
                }
                foreach (Match match in matches)
                {
                    if (match.MatchResult == "N/A" && match.TeamAway != null && match.TeamHome != null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        
        public List<Match> GetTwelveMatchesPerPage(int pageNumber)
        {
            return repository.GetTwelveMatchesPerPage(pageNumber);
        }

        public List<Match> GetAllMatches()
        {
            return repository.GetMatches();
        }

        public void InsertMatches(List<Match> matches)
        {
            repository.InsertMatches(matches);
        }

        public void RegisterResults(Match selectedMatch)
        {
            repository.RegisterResults(selectedMatch);
        }

        public Match GetSelectedMatch(int matchId)
        {
            return repository.GetMatchById(matchId);
        }

        public void AddTeam(Team addedTeam)
        {
            repository.AddTeam(addedTeam);
        }

        public void RemoveTeam(Team removedTeam)
        {
            repository.RemoveTeam(removedTeam);
        }

        public List<Team> GetParticipants()
        {
            return repository.GetParticipants();
        }
    }
}
