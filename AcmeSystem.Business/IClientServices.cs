using AcmeSystem.Business.Clients;
using System.Linq;

namespace AcmeSystem.Business
{
    public interface IClientServices
    {
        IQueryable<Client> GetAll();
    }
}
