using AcmeSystem.Business.Clients;
using AcmeSystem.Business.Contacts;
using System.Linq;

namespace AcmeSystem.Business
{
    public interface IClientRepository
    {
        IQueryable<Client> GetAll();
        void Update(Client client);
        void Delete(Client client);
        void Create(Client client);
        Client GetById(int id);
        Client GetByName(string name);
    }
}
