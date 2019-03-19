using AcmeSystem.Business;
using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;

namespace AcmeSystem.Persistence.MockRepositories
{
    public class ContactRepositoryMock : IContactRepository
    {
        List<Contact> _contacts = ContactFactory.GetFakeContacts();
        public List<Contact> GetAll()
        {
            return _contacts;
        }
    }
}
