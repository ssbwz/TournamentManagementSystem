using DuelSysLogic.Interfaces.DAL;

namespace DuelSysLogic.Managers
{
    public class TeamsManager
    {
        private ITeamsRepository repository;

        public TeamsManager(ITeamsRepository repository)
        {
            this.repository = repository;
        }

        public void CreateTeam(Team newTeam)
        {
            repository.CreateTeam(newTeam);
        }

        public Team GetTeam(int teamId)
        {
            return repository.GetTeam(teamId);
        }

        public List<Team> GetTeams() 
        {
            return repository.GetTeams();
        }
    }
}
