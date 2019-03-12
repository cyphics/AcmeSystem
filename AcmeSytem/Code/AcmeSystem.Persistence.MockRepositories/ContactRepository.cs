using AcmeSystem.Business;
using System;
using System.Collections.Generic;

namespace AcmeSystem.Persistence.MockRepositories
{
    public class ContactRepository : IContactRepository
    {
        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
