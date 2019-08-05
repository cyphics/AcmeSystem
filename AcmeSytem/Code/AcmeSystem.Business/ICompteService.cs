using AcmeSystem.Business.Comptes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmeSystem.Business
{
    public interface ICompteService
    {
        IQueryable<Compte> GetAll();
    }
}
