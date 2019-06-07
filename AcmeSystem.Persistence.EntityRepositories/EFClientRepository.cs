using AcmeSystem.Business;
using AcmeSystem.Business.Clients;
using System;
using System.Linq;

namespace AcmeSystem.Persistence.EntityRepositories
{
    public class EFClientRepository : IClientRepository
    {
        AcmeSystemDbContext _context;

        public EFClientRepository(AcmeSystemDbContext context)
        {
            _context = context;
        }

        public void Create(Client client)
        {
            throw new NotImplementedException();
        }

        public void Delete(Client client)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Client> GetAll()
        {
            return _context.Clients;
        }

        public Client GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Client client)
        {
            throw new NotImplementedException();
        }

        Client IClientRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
