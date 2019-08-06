using AcmeSystem.Business.Comptes;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeSystem.Business
{
    public interface ICompteServices
    {
        IQueryable<Compte> GetAll();
        void Create(Compte compte);
        void Edit(Compte compte);
        void Delete(Compte compte);
        Compte FindById(int id);
        Compte FindByName(string name);
    }
}
