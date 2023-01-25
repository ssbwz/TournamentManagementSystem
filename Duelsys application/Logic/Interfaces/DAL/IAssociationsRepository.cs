using DuelSysLogic.Managers;

namespace DuelSysLogic.Interfaces
{
    public interface IAssociationsRepository
    {
        public void CreateAssociation(Association newAssocation);

        public Association GetAssociationById(int assocationId);

        public List<Association> GetEightAssociationEachTime(int pageNumber);

        public List<Association> GetAllAssociations();
    }
}
