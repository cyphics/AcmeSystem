using System;

namespace Metier
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }

    }
}
