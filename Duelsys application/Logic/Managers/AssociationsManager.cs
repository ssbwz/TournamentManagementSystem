using DuelSysLogic.Interfaces;

namespace DuelSysLogic.Managers
{
    public class AssociationsManager
    {
        IAssociationsRepository repository;

        public AssociationsManager(IAssociationsRepository repository)
        {
            this.repository = repository;
        }

        public void CreateAssociation(Association newAssocaition) 
        {
            repository.CreateAssociation(newAssocaition);
        }

        public Association GetAssociation(int assocationId) 
        {
           return repository.GetAssociationById(assocationId);
        }

        public List<Association> GetEightAssociationEachTime(int group) 
        {
            return repository.GetEightAssociationEachTime(group);
        }

        public List<Association> GetAllAssociations()
        {
            return repository.GetAllAssociations();
        }
    }
}
