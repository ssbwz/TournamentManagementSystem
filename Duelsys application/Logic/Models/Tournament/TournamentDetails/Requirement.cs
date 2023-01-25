
namespace DuelSysLogic.Models.Tournament.TournamentDetails
{
    public class Requirement
    {
        public Requirement(int minPlayer,int maxPlayer) 
        {
            this.MinPlayers = minPlayer;
            this.MaxPlayers = maxPlayer;
        }

        public int MinPlayers{ get; set; }

        public int MaxPlayers { get; set; }
    }
}
