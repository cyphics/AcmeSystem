using AcmeSystem.Business;
using AcmeSystem.Business.Comptes;
using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeSystem.Persistence.MockRepositories
{
    public class CompteRepositoryMock : ICompteRepository
    {
        readonly IQueryable<Compte> _comptes = CompteFactory.GetFakeComptes().AsQueryable<Compte>();

        public void Create(Compte compte)
        {
            throw new NotImplementedException();
        }

        public void Delete(Compte compte)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Compte> GetAll()
        {
            return _comptes;
        }

        public Compte GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Compte GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Compte compte)
        {
            throw new NotImplementedException();
        }
    }
}
