using AcmeSystem.Business.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User FindByUserName(string userName);
    }
}
