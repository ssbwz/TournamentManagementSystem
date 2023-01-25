using DuelSysLogic.Interfaces;
using DuelSysLogic.Models.TournamentModels;

namespace DuelSysLogic.Managers
{
    public partial class Association
    {
        public IAssociationRepository repository;

        public void CreateTournament(Tournament newTournament)
        {
            repository.CreateTournament(newTournament);
        }

        public Tournament GetTournamentById(int tournamentId)
        {
            return repository.GetTournamentById(tournamentId);
        }

        public List<TournamentShortInfo> GetEightTournamentShortInfoEachTime(int pageNumber)
        {
            return repository.GetEightTournamentShortInfoEachTime(pageNumber);
        }
        
        public List<TournamentShortInfo> GetThreeTournamentShortInfoEachTime(int pageNumber)
        {
            return repository.GetThreeTournamentShortInfoEachTime(pageNumber);
        }

        public void UpdateTournament(Tournament updatedTournament)
        {
            repository.UpdateTournament(updatedTournament);
        }

        public void UpdateMedals(Tournament updatedTournament)
        {
            repository.UpdateMedals(updatedTournament);
        }

        public void DeleteTournament(TournamentShortInfo deletedTournament)
        {
            repository.DeleteTournament(deletedTournament);
        }

    }
}
