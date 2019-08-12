using AcmeSystem.Business;
using AcmeSystem.Business.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Applicative.Services
{
    public class UserServices : IUserServices
    {
        IUserRepository _repository;
        public UserServices(IUserRepository repository)
        {
            _repository = repository;
        }
        public User Validate(string userName, string password)
        {
            User user = _repository.FindByUserName(userName);

            if(user == null || user.PassWord != password)
                return null;

            return user;         
        }
    }
}
