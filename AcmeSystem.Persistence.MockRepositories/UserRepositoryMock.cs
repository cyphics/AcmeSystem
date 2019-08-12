using AcmeSystem.Business;
using AcmeSystem.Business.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AcmeSystem.Persistence.MockRepositories
{
    public class UserRepositoryMock : IUserRepository
    {
        IList<User> _users;

        public UserRepositoryMock()
        {
            _users = new List<User>() {
                new Employe(){Prenom ="Filomena", Nom="Gomez", PassWord="12345", UserName="FiGo"},
                new Administrateur() { Prenom = "Hans", Nom = "Schwendimann", PassWord = "12345", UserName = "Hws" }
                };
        }

        public User FindByUserName(string userName)
        {
            return _users.
                Where(u => u.UserName == userName).FirstOrDefault();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}