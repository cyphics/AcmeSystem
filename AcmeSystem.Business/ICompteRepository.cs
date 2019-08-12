using AcmeSystem.Business.Comptes;
using System.Linq;

namespace AcmeSystem.Business
{
    public interface ICompteRepository
    {
        IQueryable<Compte> GetAll();
        void Update(Compte compte);
        void Delete(Compte compte);
        void Create(Compte compte);
        Compte GetById(int id);
        Compte GetByName(string name);
    }
}
