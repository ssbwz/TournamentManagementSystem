

using DuelSysLogic.Managers;

namespace DuelSysLogic.Models.Tournament
{
    public class Tie
    {
        public Tie(Team team) 
        {
            this.Team = team;
        }
        public Team Team { get; private set; }

        public int WinCount { get; set; }

        public int TotalPoints { get; set; }

    }
}
