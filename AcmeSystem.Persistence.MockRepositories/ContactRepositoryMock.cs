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
            return _contacts;
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
