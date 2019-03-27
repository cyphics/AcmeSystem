using AcmeSystem.Business.Contacts;
using AcmeSystem.Business.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Business
{
    public interface IContactRepository
    {
        IQueryable<Contact> GetAll();
        void Update(Contact contact);
        void Delete(Contact contact);
        void Create(Contact contact);
        Contact GetById(int id);
        Contact GetByName(string name);
    }
}
