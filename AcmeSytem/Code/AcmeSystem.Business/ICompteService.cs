using AcmeSystem.Business.Comptes;
using System.Linq;

namespace AcmeSystem.Business
{
    public interface ICompteServices
    {
        IQueryable<Compte> GetAll();
    }
}
