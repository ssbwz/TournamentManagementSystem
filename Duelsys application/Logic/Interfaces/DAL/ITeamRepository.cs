
using DuelSysLogic.Models;

namespace DuelSysLogic.Interfaces.DAL
{
    public interface ITeamRepository
    {
        public void AddMember(int newMember);

        public void RemoveMember(int newMember);

        public List<Player> GetMemebers();
    }
}
