using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Models;

namespace DuelSysLogic.Managers
{
    public partial class Team
    {
        private ITeamRepository reposistory;

        public void AddMember(int newMember) 
        {
            reposistory.AddMember(newMember);
        }

        public void RemoveMember(int memberId) 
        {
            reposistory.RemoveMember(memberId);
        }

        public List<Player> GetMemebers() 
        {
            return reposistory.GetMemebers();
        }
    }
}
