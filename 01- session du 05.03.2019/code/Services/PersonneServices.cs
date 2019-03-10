using Metier;
using System;
using System.Collections.Generic;

namespace Services
{
    public class PersonneServices : IPersonneServices
    {
        IPersonnePersistence _personnePersistence;
        public PersonneServices(IPersonnePersistence personnePersistence)
        {
            _personnePersistence = personnePersistence;
        }
        public List<Personne> GetAllPersonnes()
        {
            return _personnePersistence.GetAll();
        }
    }
}
