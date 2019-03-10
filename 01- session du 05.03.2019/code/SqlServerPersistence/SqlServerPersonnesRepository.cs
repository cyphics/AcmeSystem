using Metier;
using System;
using System.Collections.Generic;

namespace SqlServerPersistence
{
    public class SqlServerPersonnesRepository : IPersonnePersistence
    {
        List<Personne> _personnes = new List<Personne>();

        public SqlServerPersonnesRepository()
        {
            _personnes.Add(new Personne { Nom = "Einstein SqlServer", Prenom = "Albert" });
            _personnes.Add(new Personne { Nom = "Newton SqlServer", Prenom = "Isac" });
            _personnes.Add(new Personne { Nom = "Monroe SqlServer", Prenom = "Marilyn" });
        }

        public List<Personne> GetAll()
        {
            return _personnes;
        }
    }
}
