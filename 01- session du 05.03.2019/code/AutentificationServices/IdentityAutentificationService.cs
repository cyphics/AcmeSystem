using Metier.Entities;

namespace AutentificationServices
{
    public class IdentityAutentificationService : IAutentificationService
    {
        Token Login(string UserName, string PassWord);
    }
}
