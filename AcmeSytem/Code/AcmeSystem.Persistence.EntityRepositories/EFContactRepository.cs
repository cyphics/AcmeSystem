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
        public IQueryable<Contact> GetAll()
        {
            return _context.Contacts;
        }
    }
}
