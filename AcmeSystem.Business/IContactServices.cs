using AcmeSystem.Business.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Business
{
    public interface IContactServices
    {
        IQueryable<Contact> GetAll();
    }
}
