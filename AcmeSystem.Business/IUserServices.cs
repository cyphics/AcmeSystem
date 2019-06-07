using AcmeSystem.Business.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business
{
    public interface IUserServices
    {
        User Validate(string userName, string password);
    }
}
