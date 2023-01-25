using DuelSysLogic.Managers;
using DuelSysLogic.Models.TournamentModels;

namespace DuelSysLogic.Interfaces
{
    public interface IAssociationRepository
    {
        public void CreateTournament(Tournament newTournament);

        public Tournament GetTournamentById(int tournamentId);

        public List<TournamentShortInfo> GetEightTournamentShortInfoEachTime(int pageNumber);

        public void UpdateTournament(Tournament updatedTournament);

        public void UpdateMedals(Tournament updatedTournament);

        public void DeleteTournament(TournamentShortInfo deletedTournament);

        public List<TournamentShortInfo> GetThreeTournamentShortInfoEachTime(int pageNumber);
    }
}
