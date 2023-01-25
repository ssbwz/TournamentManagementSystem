using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Managers;

namespace DuelSysLogic.Interfaces
{
    public interface ITournamentSystem
    {
        public List<Match> GenerateSchedule(List<Team> participants);

        public string ToString();

    }
}
