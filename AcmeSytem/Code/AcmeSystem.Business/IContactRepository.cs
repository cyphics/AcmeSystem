using AcmeSystem.Business.Contacts;
using System.Linq;

namespace AcmeSystem.Business
{
    public interface IContactRepository
    {
        IQueryable<Contact> GetAll();
        void Update(Contact contact);
        void Delete(Contact contact);
        void Create(Contact contact);
        Contact GetById(int id);
        Contact GetByName(string name);
    }
}
