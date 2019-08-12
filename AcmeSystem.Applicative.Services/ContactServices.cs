using AcmeSystem.Business;
using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeSystem.Applicative.Services
{
    public class ContactServices : IContactServices
    {
        IContactRepository _contactRepository;
        public ContactServices(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IQueryable<Contact> GetAll()
        {
            return _contactRepository.GetAll();
        }
    }
}
