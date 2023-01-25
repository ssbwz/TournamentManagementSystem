using DuelSysLogic.Managers;

namespace DuelSysLogic.Interfaces.DAL
{
    public interface ITeamsRepository
    {
        public void CreateTeam(Team newTeam);

        public Team GetTeam(int teamId);

        public List<Team> GetTeams();  

    }
}
