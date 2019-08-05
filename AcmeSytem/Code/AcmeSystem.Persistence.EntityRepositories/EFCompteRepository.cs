using AcmeSystem.Business;
using AcmeSystem.Business.Comptes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Persistence.EntityRepositories
{
    class EFCompteRepository : ICompteRepository
    {
        AcmeSystemDbContext _context;

        public EFCompteRepository(AcmeSystemDbContext context)
        {
            _context = context;
        }

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
            return _context.Comptes;
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
