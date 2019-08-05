using AcmeSystem.Business;
using AcmeSystem.Business.Comptes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Applicative.Services
{
    class CompteService : ICompteService
    {
        ICompteRepository _repo;
        public CompteService(ICompteRepository repo)
        {
            _repo = repo;
        }
        public IQueryable<Compte> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
