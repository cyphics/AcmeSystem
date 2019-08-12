using System;
using System.Collections.Generic;
using System.Text;

namespace AcmeSystem.Business.Users
{
    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public override string ToString()
        {
            return Prenom;
        }
    }
}
