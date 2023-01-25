
using DuelSysLogic.Interfaces.DAL;

namespace DuelSysLogic.Managers
{
    public partial class Team
    {
        public Team(string name) 
        {
            this.Name = name;
        }

        public Team(int id, string name, ITeamRepository reposistory) 
        {
            this.Id = id;
            this.Name = name;
            this.reposistory = reposistory;
        }

        public Team(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; private set; }

        public string Name { get; set; }
    }
}
