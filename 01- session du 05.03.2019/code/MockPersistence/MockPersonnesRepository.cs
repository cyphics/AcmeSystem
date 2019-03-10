using Metier;
using System;
using System.Collections.Generic;

namespace MockPersistence
{
    public class MockPersonnesRepository : IPersonnePersistence
    {
        List<Personne> _personnes = new List<Personne>();

        public MockPersonnesRepository()
        {
            _personnes.Add(new Personne { Nom = "Einstein Mock", Prenom = "Albert" });
            _personnes.Add(new Personne { Nom = "Newton Mock", Prenom = "Isac" });
            _personnes.Add(new Personne { Nom = "Monroe Mock", Prenom = "Marilyn" });
        }

        public List<Personne> GetAll()
        {
            return _personnes;
        }
    }
}
