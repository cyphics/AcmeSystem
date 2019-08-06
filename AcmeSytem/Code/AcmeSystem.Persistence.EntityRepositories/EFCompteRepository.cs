using AcmeSystem.Business;
using AcmeSystem.Business.Comptes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Persistence.EntityRepositories
{
    public class EFCompteRepository : ICompteRepository
    {
        AcmeSystemDbContext _context;

        public EFCompteRepository(AcmeSystemDbContext context)
        {
            _context = context;
        }

        public void Create(Compte compte)
        {
            _context.Add(compte);
            _context.SaveChangesAsync();
        }

        public void Delete(Compte compte)
        {
            _context.Remove(compte);
            _context.SaveChangesAsync();
        }

        public IQueryable<Compte> GetAll()
        {
            return _context.Comptes;
        }

        public Compte GetById(int id)
        {
            //var list = GetAll();
            //foreach(Compte compte in list)
            //{
            //    if (compte.Id == id)
            //        return compte;
            //}
            return null;
        }

        public Compte GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Compte compte)
        {
            
        }
    }
}
