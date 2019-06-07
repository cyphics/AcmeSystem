using AcmeSystem.Business;
using AcmeSystem.Business.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Applicative.Services
{
    public class ClientServices : IClientServices
    {
        IClientRepository _contactRepository;
        public ClientServices(IClientRepository clientRepository)
        {
            _contactRepository = clientRepository;
        }
        public IQueryable<Client> GetAll()
        {
            return _contactRepository.GetAll();
        }
    }
}
