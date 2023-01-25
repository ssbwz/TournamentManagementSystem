using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Managers;

namespace DuelSysLogic.Interfaces.DAL
{
    public interface ITournamentRepository
    {
        public void AddTeam(Team addedTeam);

        public void RemoveTeam(Team removedTeam);

        public List<Team> GetParticipants();

        public List<Match> GetTwelveMatchesPerPage(int pageNumber);

        public List<Match> GetMatches();

        public void InsertMatches(List<Match> matches);

        public void RegisterResults(Match updatedMatch);

        public Match GetMatchById(int matchId);

    }
}
