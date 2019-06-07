using AcmeSystem.Business;
using AcmeSystem.Business.Clients;
using AcmeSystem.Business.Contacts;
using System;
using System.Linq;

namespace AcmeSystem.Persistence.MockRepositories
{
    public class ClientRepositoryMock : IClientRepository
    {
        readonly IQueryable<Client> _clients = ClientFactory.GetFakeClients().AsQueryable<Client>();

        public void Create(Client contact)
        {
            throw new NotImplementedException();
        }

        public void Delete(Client contact)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Client> GetAll()
        {
            return _clients;
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Client GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Client contact)
        {
            throw new NotImplementedException();
        }

        Client IClientRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
