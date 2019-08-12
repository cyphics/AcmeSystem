using AcmeSystem.Business;
using AcmeSystem.Business.Comptes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Applicative.Services
{
    public class CompteServices : ICompteServices
    {
        ICompteRepository _repo;
        public CompteServices(ICompteRepository repo)
        {
            _repo = repo;
        }

        public void Create(Compte compte)
        {
            _repo.Create(compte);
        }

        public void Delete(Compte compte)
        {
            _repo.Delete(compte);
        }

        public Compte FindById(int id)
        {
            var list = GetAll();
            foreach (Compte compte in list)
            {
                if (compte.Id == id)
                    return compte;
            }
            return null;
        }

        public Compte FindByName(string name)
        {
            return _repo.GetByName(name);
        }

        public IQueryable<Compte> GetAll()
        {
            return _repo.GetAll();
        }

        public void Edit(Compte compte)
        {
            _repo.Update(compte);
        }

        public void Save()
        {
            
        }
    }
}
