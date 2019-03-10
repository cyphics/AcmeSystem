using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    public interface IAutentificationService
    {
        void Login(string UserName, string PassWord);
    }
}
