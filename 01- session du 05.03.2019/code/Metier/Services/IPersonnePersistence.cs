using System;
using System.Collections.Generic;
using System.Text;

namespace Metier
{
    public interface IPersonnePersistence
    {
        List<Personne> GetAll(); 
    }
}
