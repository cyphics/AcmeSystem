using AcmeSystem.Business;
using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeSystem.Persistence.MockRepositories
{
    public class ContactRepositoryMock : IContactRepository
    {
        readonly IQueryable<Contact> _contacts = ContactFactory.GetFakeContacts().AsQueryable<Contact>();
            
        public IQueryable<Contact> GetAll()
        {
            return _contacts;
        }
    }
}
