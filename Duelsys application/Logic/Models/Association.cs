using DuelSysLogic.Interfaces;

namespace DuelSysLogic.Managers
{
    public partial class Association
    {
        public Association(string name)
        {
            this.Name = name;
        }

        public Association(int id, string name,IAssociationRepository associationRepository)
        {
            this.Id = id;
            this.Name = name;
            this.repository = associationRepository;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
