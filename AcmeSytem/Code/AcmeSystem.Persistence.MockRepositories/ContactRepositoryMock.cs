using AcmeSystem.Business;
using System;
using System.Collections.Generic;

namespace AcmeSystem.Persistence.MockRepositories
{
    public class ContactRepositoryMock : IContactRepository
    {
        List<Contact> _contacts = new List<Contact>()
        {
            new Contact(){Nom="Einsten", Prenom="Albert"},
            new Contact(){Nom="Newton", Prenom="Isaac"}
        };
        public List<Contact> GetAll()
        {
            return _contacts;
        }
    }
}
