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
            _context.SaveChanges();
        }

        public void Delete(Compte compte)
        {
            _context.Remove(compte);
            _context.SaveChanges();
        }

        public IQueryable<Compte> GetAll()
        {
            return _context.Comptes;
        }

        public Compte GetById(int id)
        {
            return _context.Comptes.FirstOrDefault(x => x.Id == id);
        }

        public Compte GetByName(string name)
        {
            var list = GetAll();
            foreach (Compte compte in list)
            {
                if (compte.Nom == name)
                    return compte;
            }
            return null;
        }

        public void Update(Compte compte)
        {

            var storedCompte = GetById(compte.Id);
            storedCompte.Nom = compte.Nom;
            storedCompte.DateModification = DateTime.Today;
            _context.SaveChanges();
        }
    }
}
