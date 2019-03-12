using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business
{
    public interface IContactRepository
    {
        List<Contact> GetAll();
    }
}
