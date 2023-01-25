using DuelSys_Logic.Models.TournamentModels;
using DuelSysLogic.Managers;

namespace DuelSysLogic.Models.Sports
{
    public abstract class Sport
    {

        protected abstract bool IsScoreValide(int? teamAway, int? teamHome);

        public abstract Team GetWinner(Match match);

        public abstract string ToString();

    }
}
