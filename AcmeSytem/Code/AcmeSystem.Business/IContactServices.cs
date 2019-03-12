using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business
{
    public interface IContactServices
    {
        List<Contact> GetAll();
    }
}
