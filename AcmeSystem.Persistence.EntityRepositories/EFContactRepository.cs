using AcmeSystem.Business;
using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Persistence.EntityRepositories
{
    public class EFContactRepository : IContactRepository
    {
        AcmeSystemDbContext _context;

        public EFContactRepository(AcmeSystemDbContext context)
        {
            _context = context;
        }

        public void Create(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetAll()
        {
            return _context.Contacts;
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Contact GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
